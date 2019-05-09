using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq; 
using System.Text.RegularExpressions;
using System.Threading; 
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using Orm.Client.Common;
using Orm.Config; 
using Orm.Model.Custom; 

namespace Orm.ViewModel.OuPatient
{
    /// <summary>
    /// 病人详情文件处理类
    /// </summary>
    public class FileProcessingClass
    {
        /// <summary>
        /// 下载病人图片
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        public void DownLoadMedia(string url, string path)
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                if (!File.Exists(path))
                {
                    webClient.DownloadFile(url, path);
                }
            }
        }
        /// <summary>
        /// 文件大小
        /// </summary>
        /// <param name="Size">大小</param>
        /// <returns></returns>
        public string CountSize(long Size)
        {
            string m_strSize = string.Empty;
            long FactSize = 0;
            FactSize = Size;
            if (FactSize < 1024.00)
            {
                m_strSize = FactSize.ToString("F2") + " B";
            }
            else if (FactSize >= 1024.00 && FactSize < 1048576)
            {
                m_strSize = (FactSize / 1024.00).ToString("F2") + " KB";
            }
            else if (FactSize >= 1048576 && FactSize < 1073741824)
            {
                m_strSize = (FactSize / 1024.00 / 1024.00).ToString("F2") + " MB";
            }
            else if (FactSize >= 1073741824)
            {
                m_strSize = (FactSize / 1024.00 / 1024.00 / 1024.00).ToString("F2") + " GB";
            }
            return m_strSize;
        }
        /// <summary>
        /// 计算文件夹/文件的大小
        /// </summary>
        /// <param name="sourcePath">文件路径</param>
        /// <returns></returns>
        public long ComputingFolderOrFileSize(string sourcePath, ref int count)
        {
            long totalBytes = 0;
            count++;//计算
            if (Directory.Exists(sourcePath))
            {
                DirectoryInfo sourceDirInfo = new DirectoryInfo(sourcePath);
                DirectoryInfo[] dirArray = sourceDirInfo.GetDirectories();
                FileInfo[] fileArray = sourceDirInfo.GetFiles();
                foreach (FileInfo FileInfo in fileArray)
                {
                    totalBytes += FileInfo.Length;
                    count++;//计算
                }
                foreach (DirectoryInfo directoryInfo in dirArray)
                {
                    totalBytes += ComputingFolderOrFileSize(directoryInfo.FullName, ref count);
                }
            }
            else if (File.Exists(sourcePath))
            {
                var fInfo = new FileInfo(sourcePath);
                if (!fInfo.Attributes.ToString().Equals("Hidden,Temporary"))
                {
                    totalBytes += fInfo.Length;
                }
            }
            return totalBytes;
        }
      
        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="sourcePath">源路径</param>
        /// <param name="destPath">目标路径</param>
        /// <param name="action">动作</param>
        /// <param name="canCoverAction">判断是否覆盖文件</param>
        /// <param name="logInfoForXmlAction">xml操作的日志信息</param>
        /// <param name="canCancelAction">是否取消操作</param>
        public void CopyFile(string sourcePath, string destPath, Action<long, string, long> action = null, Func<string, bool> canCoverAction = null, Func<bool> canCancelAction = null)
        {
            if (canCancelAction != null && canCancelAction())//判断取消操作
            {
                return;
            }

            FileInfo fInfo = null;
            try
            {
                fInfo = new FileInfo(sourcePath);
                if (fInfo.Attributes.ToString().Equals("Hidden,Temporary"))//系统文件可见排除临时文件，隐藏文件 主要是显示所有文件
                {
                    return;
                }

                if (canCoverAction != null && File.Exists(destPath) && !canCoverAction(destPath))
                {
                    action(0, fInfo.Name, fInfo.Length);
                    return;
                }
            }
            catch (Exception ex)
            {
                //Orm.Client.Base.BaseForm.FrmShowError.Show(ex, "文件读取失败！", "系统提示！");
                //return;
                throw ex;
            }

            Stream readStream = null;
            Stream writeStream = null;
            try
            {
                readStream = fInfo.OpenRead();
                writeStream = File.Create(destPath);

                long fileLength = fInfo.Length;
                /// 每次读取的字节数
                int readBytes = 100 * 1024;
                byte[] buffer = new byte[readBytes];
                //读取数
                int readNumber = 0;

                while (true)
                {
                    if (canCancelAction != null && canCancelAction())//判断取消操作
                    {
                        break;//只能跳出循环
                    }
                    //设定线程优先级

                    //读写文件
                    readNumber = readStream.Read(buffer, 0, buffer.Length);
                    if (readNumber == 0)
                    {
                        break;
                    }
                    writeStream.Write(buffer, 0, readNumber);
                    writeStream.Flush();
                    if (action != null)
                    {
                        action(buffer.Length, fInfo.Name, 0);//处理一些额外的内容，比如 取消复制操作、反馈复制的文件进度等等
                        Thread.Sleep(1);
                        //删除文件
                        //fInfo.Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                //Orm.Client.Base.BaseForm.FrmShowError.Show(ex, string.Format("复制文件过程中出现干扰，导致复制 {0} 文件失败！", fInfo.Name), "系统友情提示！");
                throw ex;
            }
            finally
            {
                if (readStream != null)
                {
                    readStream.Close();
                }
                if (writeStream != null)
                {
                    writeStream.Close();
                }
            }
        }

        /// <summary>
        /// 复制目录
        /// </summary>
        /// <param name="sourceDirectory"></param>
        /// <param name="destDirectory"></param>
        public void CopyDirectory(string sourceDirectory, string destDirectory, Action<long, string, long> action = null, Func<string, bool> canCoverAction = null, Func<bool> canCancelAction = null)
        {
            if (canCancelAction != null && canCancelAction())
            {
                return;
            }
            if (!Directory.Exists(destDirectory))
            {
                Directory.CreateDirectory(destDirectory);
            }
            DirectoryInfo sourceDirInfo = new DirectoryInfo(sourceDirectory);
            //拷贝文件
            FileInfo[] fileArray = sourceDirInfo.GetFiles();
            foreach (FileInfo fileInfo in fileArray)
            {
                CopyFile(fileInfo.FullName, string.Format("{0}\\{1}", destDirectory, fileInfo.Name), action, canCoverAction, canCancelAction);
            }

            //循环子文件夹
            DirectoryInfo[] directoryArray = sourceDirInfo.GetDirectories();
            foreach (DirectoryInfo directory in directoryArray)
            {
                CopyDirectory(directory.FullName, string.Format("{0}\\{1}", destDirectory, directory.Name), action, canCoverAction, canCancelAction);
            }
        }

        /// <summary>
        /// 确认文件是否被占用
        /// </summary>
        /// <param name="addressPath"></param>
        /// <returns>True 为被占用</returns>
        private bool ConfirmedFileIsOccupied(string addressPath)
        {
            bool isUse = false;
            if (!string.IsNullOrWhiteSpace(addressPath) && File.Exists(addressPath))
            {
                FileStream fileStream = null;
                try
                {
                    fileStream = new FileStream(addressPath, FileMode.Open, FileAccess.Read, FileShare.None);
                }
                catch (Exception)
                {
                    isUse = true;
                }
                finally
                {
                    if (fileStream != null)
                    {
                        fileStream.Close();
                    }
                }
            }
            if (isUse)//文件正在使用
            {
                bool isDetermine = (Orm.Toolkit.MessageBox.Show("重要文件正在被占用中，无法使用！是否强制解除文件占用？", "系统提示", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes);
                if (isDetermine)
                {
                    isUse = false;
                    try
                    {
                        Process toolProcess = new Process();
                        toolProcess.StartInfo.FileName = "handle.exe";
                        toolProcess.StartInfo.Arguments = addressPath + "/accepteula";
                        toolProcess.StartInfo.UseShellExecute = false;
                        toolProcess.StartInfo.RedirectStandardOutput = true;
                        toolProcess.Start();
                        toolProcess.WaitForExit();
                        string outputTool = toolProcess.StandardOutput.ReadToEnd();
                        string matchPattern = @"(?<=\s+pid:\s+)\b(\d+)\b(?=\s+)";
                        foreach (Match match in Regex.Matches(outputTool, matchPattern))
                        {
                            Process.GetProcessById(int.Parse(match.Value)).Kill();
                        }
                    }
                    catch (Exception)
                    {
                        isUse = true;
                        Orm.Toolkit.MessageBox.Show("解除占用失败！", "系统友情提示");
                    }
                }
            }
            return isUse;
        }
        /// <summary>
        /// 获取XML
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public XDocument GetXml(string xmlPath)
        {
            XDocument xDocument = null;
            if (File.Exists(xmlPath))
            {
                if (!this.ConfirmedFileIsOccupied(xmlPath))
                {
                    try
                    {
                        xDocument = XDocument.Load(xmlPath);
                    }
                    catch (Exception)
                    {
                        File.Delete(xmlPath);//删除文件
                    }
                }
            }
            return xDocument;
        }

        /// <summary>
        /// 清理xml节点
        /// </summary>
        /// <param name="patId"></param>
        /// <param name="serverPath"></param>
        /// <param name="localPath"></param>
        public bool ClearRecordsForXml(string  patId, string serverPath, string localPath)
        {
            bool flag = false;
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "ConfigFiles\\PatientReportDownloadRecords.xml";
            XDocument xDocument = this.GetXml(filePath);
            if (xDocument != null && xDocument.Root != null)
            {
                if (patId  != string.Empty && !string.IsNullOrEmpty(localPath) && !string.IsNullOrEmpty(serverPath))
                {
                    IEnumerable<XElement> nodes = from element in xDocument.Elements("ReportFile").Elements("Doctor" + UserProfiles.UserCode).Elements("Patient" + patId.ToString())
                                                  where element.Attribute("ServerPath").Value == serverPath && element.Attribute("LocalPath").Value == localPath
                                                  select element;
                    if (nodes.Count() > 0)
                    {
                        nodes.Remove();
                        xDocument.Save(filePath, SaveOptions.None);
                        flag = true;
                    }
                }
            }
            return flag;
        }
        /// <summary>
        /// 写入xml
        /// </summary>
        /// <param name="patId"></param>
        public bool WriteRecordsIntoXml(string  patId, string serverPath, string localPath)
        {
            bool flag = false;
            if (patId != string.Empty)
            {
                XDocument xDocument = null;
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "ConfigFiles";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                    xDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));//GB2312
                    flag = true;
                }
                else
                {
                    if (!File.Exists(filePath + "\\PatientReportDownloadRecords.xml"))
                    {
                        xDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));//GB2312
                        flag = true;
                    }
                    else
                    {
                        xDocument = this.GetXml(filePath + "\\PatientReportDownloadRecords.xml");
                        flag = true;
                    }
                }
                if (flag)
                {
                    SaveRecordsIntoXml(patId, serverPath, localPath, ref flag, ref xDocument, filePath);
                }
                else
                {
                    flag = WriteRecordsIntoXml(patId, serverPath, localPath);
                }
            }
            return flag;
        }
        /// <summary>
        /// 保存记录信息xml文件
        /// </summary>
        /// <param name="patId">病人id</param>
        /// <param name="serverPath">服务器路径</param>
        /// <param name="localPath">本地路径</param>
        /// <param name="flag">信号</param>
        /// <param name="xDocument">xml文档</param>
        /// <param name="filePath">文件路径</param>
        private void SaveRecordsIntoXml(string patId, string serverPath, string localPath, ref bool flag, ref XDocument xDocument, string filePath)
        {
            if (xDocument == null)
            { return; }
            if (xDocument.Descendants("ReportFile").Count() <= 0)
            { xDocument.Add(new XElement("ReportFile")); }
            if (xDocument.Elements("ReportFile").Descendants("Doctor" + UserProfiles.UserCode).Count() <= 0)
            { xDocument.Element("ReportFile").Add(new XElement("Doctor" + UserProfiles.UserCode)); }
            IEnumerable<XElement> elements = from element in xDocument.Elements("ReportFile").Elements("Doctor" + UserProfiles.UserCode).Elements("Patient" + patId.ToString())
                                             where element.Attribute("ServerPath").Value.Equals(serverPath) && element.Attribute("LocalPath").Value.Equals(localPath)
                                             select element;
            if (elements.Count() == 1)
            {
                flag = true;
            }
            else if (elements.Count() <= 0)
            {
                xDocument.Element("ReportFile").Element("Doctor" + UserProfiles.UserCode).Add(new XElement("Patient" + patId.ToString(), new XAttribute("ServerPath", serverPath), new XAttribute("LocalPath", localPath)));
                xDocument.Save(filePath + "\\PatientReportDownloadRecords.xml", SaveOptions.None);
                flag = true;
            }
            else
            {
                if (this.ClearRecordsForXml(patId, serverPath, localPath))
                {
                    xDocument = this.GetXml(filePath + "\\PatientReportDownloadRecords.xml");
                    if (xDocument != null)
                    {
                        xDocument.Element("ReportFile").Element("Doctor" + UserProfiles.UserCode).Add(new XElement("Patient" + patId.ToString(), new XAttribute("ServerPath", serverPath), new XAttribute("LocalPath", localPath)));
                        xDocument.Save(filePath + "\\PatientReportDownloadRecords.xml", SaveOptions.None);
                        flag = true;
                    }
                }
            }
        }
        /// <summary>
        /// 设置文件模板
        /// </summary>
        /// <param name="info">文件信息</param>
        /// <param name="status">状态</param>
        /// <param name="isLocalFile">是否本地文件</param>
        /// <param name="fileLink">下载地址</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public FileTempate SetFileInfo(FileInfo info, int status, bool isLocalFile, string fileLink, ICommand btnDownloadFileClickCommand, ICommand openFileCommand, ICommand openRootDirectoryCommand, ICommand resetDownloadFileCommand, ICommand deleteFileCommand, ICommand deleteServerFileCommand, ICommand upLoadFileCommand, string filePath = "")
        {
            FileTempate ftInfo = new FileTempate();
            ftInfo.Name = info.Name;
            ftInfo.CreationTime = info.CreationTime;
            ftInfo.LastWriteTime = info.LastWriteTime;
            ftInfo.FileSize = this.CountSize(info.Length);
            ftInfo.Status = status;
            ftInfo.IsLocalFile = isLocalFile;
            ftInfo.FileLink = fileLink;
            ftInfo.FilePath = filePath;
            ftInfo.CommandList = this.GetCommandList(status, isLocalFile, btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand);
            return ftInfo;
        }
        /// <summary>
        /// 设置文件模板
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="lastWriteTime">最后修改时间</param>
        /// <param name="length">长度</param>
        /// <param name="status">状态</param>
        /// <param name="isLocalFile">是否是本地文件</param>
        /// <param name="fileLink">下载地址</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public FileTempate SetFileInfo(string name, DateTime creationTime, DateTime lastWriteTime, long length, int status, bool isLocalFile, string fileLink, ICommand btnDownloadFileClickCommand, ICommand openFileCommand, ICommand openRootDirectoryCommand, ICommand resetDownloadFileCommand, ICommand deleteFileCommand, ICommand deleteServerFileCommand, ICommand upLoadFileCommand,string filePath = "")
        {
            FileTempate ftInfo = new FileTempate();
            ftInfo.Name = name;
            ftInfo.CreationTime = creationTime;
            ftInfo.LastWriteTime = lastWriteTime;
            ftInfo.FileSize = this.CountSize(length);
            ftInfo.Status = status;
            ftInfo.IsLocalFile = isLocalFile;
            ftInfo.FileLink = fileLink;
            ftInfo.FilePath = filePath;
            ftInfo.CommandList = this.GetCommandList(status, isLocalFile, btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand);
            return ftInfo;
        }

        /// <summary>
        /// 获取命令列表
        /// </summary>
        /// <param name="fileStatus">文件状态</param>
        /// <param name="isLocalFile">是否是本地文件</param>
        /// <returns></returns>
        public List<CommandInfo> GetCommandList(int fileStatus, bool isLocalFile, ICommand btnDownloadFileClickCommand, ICommand openFileCommand, ICommand openRootDirectoryCommand, ICommand resetDownloadFileCommand, ICommand deleteFileCommand, ICommand deleteServerFileCommand, ICommand upLoadFileCommand)
        {
            List<CommandInfo> commandInfoList = new List<CommandInfo>();
            commandInfoList.Add(new CommandInfo() { CmdName = "下载", Command = btnDownloadFileClickCommand, IsCmdEditable = (fileStatus == 0 && !isLocalFile) });
            commandInfoList.Add(new CommandInfo() { CmdName = "打开", Command = openFileCommand, IsCmdEditable = fileStatus == 1 });
            commandInfoList.Add(new CommandInfo() { CmdName = "打开文件位置", Command = openRootDirectoryCommand, IsCmdEditable = fileStatus == 1 });
            commandInfoList.Add(new CommandInfo() { CmdName = "重新下载", Command = resetDownloadFileCommand, IsCmdEditable = (fileStatus == 1 && !isLocalFile) });
            commandInfoList.Add(new CommandInfo() { CmdName = "删除", Command = deleteFileCommand, IsCmdEditable = fileStatus == 1 });
            commandInfoList.Add(new CommandInfo() { CmdName = "删除服务器文件", Command = deleteServerFileCommand, IsCmdEditable = !isLocalFile }); 
            commandInfoList.Add(new CommandInfo() { CmdName = "上传至服务器", Command = upLoadFileCommand, IsCmdEditable = fileStatus == 1 });
            return commandInfoList;
        }
        /// <summary>
        /// 整理文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="serverPath">服务器路径</param>
        private void ArrangeFile(ref ObservableCollection<FileTempate> fileTempateObservableCollection, ICommand btnDownloadFileClickCommand, ICommand openFileCommand, ICommand openRootDirectoryCommand, ICommand resetDownloadFileCommand, ICommand deleteFileCommand, ICommand deleteServerFileCommand, ICommand upLoadFileCommand,string filePath,  string serverPath = "")
        {
            try
            {
                if (File.Exists(filePath))
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    if (fileTempateObservableCollection.Any(t => t.Name == fileInfo.Name && t.LastWriteTime < fileInfo.LastWriteTime))
                    {
                        FileTempate fileTempate = fileTempateObservableCollection.First(t => t.Name == fileInfo.Name);
                        fileTempate.Status = 1;
                        fileTempate.CreationTime = fileInfo.CreationTime;
                        fileTempate.LastWriteTime = fileInfo.LastWriteTime;
                        fileTempate.FileSize = this.CountSize(fileInfo.Length);
                        fileTempate.FilePath = fileInfo.DirectoryName;
                        fileTempate.CommandList = this.GetCommandList(1, string.IsNullOrWhiteSpace(serverPath), btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand);
                    }
                    else
                    {
                        fileTempateObservableCollection.Add(SetFileInfo(fileInfo, 1, string.IsNullOrWhiteSpace(serverPath), serverPath, btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand, fileInfo.DirectoryName));
                    }
                }
                else if (Directory.Exists(filePath))
                {
                    List<FileInfo> fileInfoList = FileHelper.GetFileList(filePath);
                    foreach (FileInfo fileInfo in fileInfoList)
                    {
                        this.ArrangeFile(ref fileTempateObservableCollection, btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand,fileInfo.DirectoryName + "\\" + fileInfo.Name, serverPath);
                    }
                }
            }
            catch (Exception ex)
            {
                //Orm.Client.Base.BaseForm.FrmShowError.Show(ex);
                throw ex;
            }
        }
        ///// <summary>
        ///// 删除文件
        ///// </summary>
        ///// <param name="parameter"></param>
        //private void DeleteFileExecute(object parameter,ref bool isShowDownloads,ref ObservableCollection<FileTempate> fileTempateObservableCollection, ICommand btnDownloadFileClickCommand, ICommand openFileCommand, ICommand openRootDirectoryCommand, ICommand resetDownloadFileCommand, ICommand deleteFileCommand, ICommand deleteServerFileCommand, ICommand upLoadFileCommand,int patientId,ref ObservableCollection<Orm.Toolkit.DownloadItem> downloadItems)
        //{
        //    if (parameter is FileTempate)
        //    {
        //        FileTempate fileTempate = parameter as FileTempate;
        //        if (!string.IsNullOrWhiteSpace(fileTempate.FilePath) && !string.IsNullOrWhiteSpace(fileTempate.Name))
        //        {
        //            string path = fileTempate.FilePath + "\\" + fileTempate.Name;
        //            FileInfo fileInfo = new FileInfo(path);
        //            if (fileInfo.Exists)
        //            {
        //                fileInfo.Delete();
        //                if (fileTempate.IsLocalFile)
        //                {
        //                    if (isShowDownloads)
        //                    {
        //                        isShowDownloads = false;
        //                    }
        //                    fileTempateObservableCollection.Remove(fileTempate);
        //                }
        //                else
        //                {
        //                    fileTempate.Status = 0;
        //                    fileTempate.FilePath = string.Empty;
        //                    fileTempate.CommandList = this.GetCommandList(0, false, btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand);
        //                }
        //            }
        //            else
        //            {
        //                if (isShowDownloads)
        //                {
        //                    isShowDownloads = false;
        //                }
        //                fileTempateObservableCollection.Remove(fileTempate);
        //            }
        //        }
        //        else
        //        {
        //            if (isShowDownloads)
        //            {
        //                isShowDownloads = false;
        //            }
        //            fileTempateObservableCollection.Remove(fileTempate);
        //        }
        //        DeleteDownloadItem(fileTempate.FileLink, fileTempate.Name,patientId,ref isShowDownloads,ref downloadItems);
        //    }
        //    else
        //    {
        //        if (isShowDownloads)
        //        {
        //            isShowDownloads = false;
        //        }
        //    }
        //}
        ///// <summary>
        ///// 删除下载的项目
        ///// </summary>
        ///// <param name="filePath">文件路径</param>
        ///// <param name="serverPath">服务器路径</param>
        //private void DeleteDownloadItem(string serverPath, string fileName,int patientId, ref bool isShowDownloads, ref ObservableCollection<Orm.Toolkit.DownloadItem> downloadItems)
        //{
        //    if (!string.IsNullOrWhiteSpace(serverPath) && !string.IsNullOrWhiteSpace(fileName) && downloadItems.Any(t => t.URL == serverPath + "\\" + fileName && t.IsComplete || t.IsCanceled))
        //    {
        //        if (!isShowDownloads)
        //        {
        //            isShowDownloads = true;
        //        }
        //        Global.CacheDownloadItems.Remove(Global.CacheDownloadItems.Find(t => t.Key == patientId && t.Value.URL == serverPath + "\\" + fileName));
        //        Orm.Toolkit.DownloadItem downloadItem = downloadItems.First(t => t.URL == serverPath + "\\" + fileName);
        //        downloadItems.Remove(downloadItem);
        //    }
        //}
        ///// <summary>
        ///// 设置命令按钮菜单
        ///// </summary>
        ///// <param name="canDownload"></param>
        ///// <param name="canOpen"></param>
        ///// <returns></returns>
        //private List<CommandInfo> SetMenuCommands(bool canDownload, bool canOpen)
        //{
        //    List<CommandInfo> commandInfoList = new List<CommandInfo>();
        //    commandInfoList.Add(new CommandInfo() { CmdName = "下载", Command = this.BtnDownloadFileClickCommand, IsCmdEditable = canDownload });
        //    commandInfoList.Add(new CommandInfo() { CmdName = "打开", Command = this.OpenFileCommand, IsCmdEditable = canOpen });
        //    commandInfoList.Add(new CommandInfo() { CmdName = "打开文件位置", Command = this.OpenRootDirectoryCommand, IsCmdEditable = canOpen });
        //    commandInfoList.Add(new CommandInfo() { CmdName = "重新下载", Command = this.ResetDownloadFileCommand, IsCmdEditable = canDownload });
        //    commandInfoList.Add(new CommandInfo() { CmdName = "删除", Command = this.DeleteFileCommand, IsCmdEditable = canOpen });
        //    return commandInfoList;
        //}
        ///// <summary>
        ///// 设置菜单命令
        ///// </summary>
        ///// <param name="parameter"></param>
        //private void GetMenuCommands(object parameter)
        //{
        //    if (parameter is IList)
        //    {
        //        IList tempList = parameter as IList;
        //        List<FileTempate> fileList = new List<FileTempate>();
        //        foreach (FileTempate fileTempate in tempList)
        //        {
        //            fileList.Add(fileTempate as FileTempate);
        //        }
        //        if (fileList.Count == 1)
        //        {
        //            this.MenuCommandList = this.GetCommandList(fileList.First().Status, fileList.First().IsLocalFile);
        //        }
        //        else if (fileList.Count > 1)
        //        {
        //            List<FileTempate> localFiles = fileList.FindAll(t => t.IsLocalFile && t.Status == 1);
        //            List<FileTempate> DownloadedFiles = fileList.FindAll(t => !t.IsLocalFile && t.Status == 1);
        //            List<FileTempate> serverFiles = fileList.FindAll(t => !t.IsLocalFile && t.Status == 0);
        //            if (localFiles.Count > 0 && serverFiles.Count > 0)
        //            {
        //                this.MenuCommandList = this.SetMenuCommands(true, true);
        //            }
        //            else if (localFiles.Count > 0 && serverFiles.Count <= 0)
        //            {
        //                this.MenuCommandList = this.GetCommandList(1, true);
        //            }
        //            else if (localFiles.Count <= 0 && serverFiles.Count > 0)
        //            {
        //                this.MenuCommandList = this.GetCommandList(0, false);
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// 异步下载文件操作
        ///// </summary>
        ///// <param name="Url">用户资源路径</param>
        ///// <param name="Path">文件夹路径</param>
        ///// <param name="CancelAction">取消动作</param>
        ///// <param name="DownloadProgressAction">下载进度</param>
        ///// <param name="CompleteAction">完成动作</param>
        //private void AsyncTaskDownFileToStream(string Url, string Path, Func<bool> CancelAction, Func<bool> PauseAction, Action<int, long, long> DownloadProgressAction, Action<bool, string> CompleteAction,int patientId,string patientName,bool isShowDownloads, ObservableCollection<FileTempate> fileTempateObservableCollection, ObservableCollection<Orm.Toolkit.DownloadItem> downloadItems, KeyValuePair<string, bool> busyMessagePair, ICommand btnDownloadFileClickCommand, ICommand openFileCommand, ICommand openRootDirectoryCommand, ICommand resetDownloadFileCommand, ICommand deleteFileCommand, ICommand deleteServerFileCommand, ICommand upLoadFileCommand)
        //{
        //    DispatcherHelper.Initialize();
        //    Task task = Task.Factory.StartNew(() =>
        //    {
        //        long seekBytes = 0;
        //        int ProgressPercentage = 0;
        //        long TotalBytesToReceive = 0;
        //        long BytesReceived = 0;
        //        bool Cancelled = false;
        //        Stream wtdStream = null;//下载数据临时文件
        //        string tdPath = string.Format("{0}.td", Path);
        //        try
        //        {
        //            StringBuilder dirBuilder = new StringBuilder();
        //            string[] strArray = Path.Split('\\');
        //            for (int i = 0; i < strArray.Length - 1; i++)
        //            {
        //                if (i == 0)
        //                {
        //                    dirBuilder.Append(strArray[i]);
        //                }
        //                else
        //                {
        //                    dirBuilder.Append(string.Format("\\{0}", strArray[i]));
        //                }
        //                if (!System.IO.Directory.Exists(dirBuilder.ToString()))
        //                {
        //                    Directory.CreateDirectory(dirBuilder.ToString());
        //                }
        //            }
        //            byte[] tempBuffer = null;
        //            if (File.Exists(tdPath))
        //            {
        //                tempBuffer = File.ReadAllBytes(tdPath);
        //            }
        //            wtdStream = File.Create(tdPath);
        //            if (tempBuffer != null)
        //            {
        //                //写入数据
        //                wtdStream.Write(tempBuffer, 0, tempBuffer.Length);
        //                wtdStream.Flush();
        //                seekBytes = tempBuffer.Length;
        //            }
        //            ICommonServices commonServices = Orm.Config.Service.CommonServices;
        //            Orm.Model.Parameter.ReturnDownloadResponse returnDownloadResponse;
        //            while (true)
        //            {
        //                if (CancelAction != null)
        //                {
        //                    Cancelled = CancelAction();
        //                }
        //                if (Cancelled)
        //                {
        //                    if (CompleteAction != null)
        //                    {
        //                        CompleteAction(Cancelled, tdPath);
        //                        if (wtdStream != null)
        //                        {
        //                            wtdStream.Close();
        //                        }
        //                        if (File.Exists(tdPath))
        //                        {
        //                            File.Delete(tdPath);
        //                        }
        //                        DispatcherHelper.CheckBeginInvokeOnUI(() =>
        //                        {
        //                            var fi = new FileInfo(Url);
        //                            DeleteDownloadItem(fi.DirectoryName, fi.Name, patientId,isShowDownloads,downloadItems);
        //                        });
        //                        this.ClearRecordsForXml(patientId, Url, Path);
        //                    }
        //                    break;
        //                }
        //                if (PauseAction != null && PauseAction())
        //                {
        //                    continue;
        //                }
        //                returnDownloadResponse = commonServices.DownFileToStream(Url, seekBytes, 1024 * 10);
        //                if (returnDownloadResponse == null)
        //                {
        //                    continue;
        //                }
        //                if (returnDownloadResponse != null && returnDownloadResponse.IsComplete)
        //                {
        //                    if (CompleteAction != null)
        //                    {
        //                        if (wtdStream != null)
        //                        {
        //                            wtdStream.Close();
        //                        }
        //                        if (File.Exists(Path))
        //                        {
        //                            File.Delete(Path);
        //                        }
        //                        File.Move(tdPath, Path);

        //                        //去掉文件临时文件标识后缀 删除配置文件
        //                        CompleteAction(Cancelled, Path);
        //                        DispatcherHelper.CheckBeginInvokeOnUI(() =>
        //                        {
        //                            GetFileList(patientId, patientName,busyMessagePair, fileTempateObservableCollection, downloadItems, btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand);
        //                        });
        //                        this.ClearRecordsForXml(patientId, Url, Path);
        //                    }
        //                    break;
        //                }
        //                //写入数据
        //                wtdStream.Write(returnDownloadResponse.ReadBuffer, 0, returnDownloadResponse.ReadNumber);
        //                wtdStream.Flush();
        //                seekBytes = returnDownloadResponse.BytesReceived;
        //                System.Threading.Thread.Sleep(30);
        //                if (returnDownloadResponse.TotalBytesToReceive > 0 && seekBytes <= returnDownloadResponse.TotalBytesToReceive)
        //                {
        //                    ProgressPercentage = Convert.ToInt32(seekBytes * 100 / returnDownloadResponse.TotalBytesToReceive);
        //                    TotalBytesToReceive = returnDownloadResponse.TotalBytesToReceive;
        //                    BytesReceived = returnDownloadResponse.BytesReceived;
        //                }
        //                if (DownloadProgressAction != null)
        //                {
        //                    DispatcherHelper.CheckBeginInvokeOnUI((int p, long t, long b) =>
        //                    {
        //                        DownloadProgressAction(p, t, b);
        //                    }, ProgressPercentage, TotalBytesToReceive, BytesReceived);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Orm.Client.Base.BaseForm.FrmShowError.Show(ex, "下载文件出错！", "系统友情提示");
        //        }
        //        finally
        //        {
        //            if (wtdStream != null)
        //            {
        //                wtdStream.Close();
        //            }
        //        }
        //    });
        //}
        ///// <summary>
        ///// 获取文件列表
        ///// </summary>
        ///// <param name="patID">病人id</param>
        ///// <param name="patName">病人名称</param>
        //private void GetFileList(int patID, string patName, KeyValuePair<string, bool> busyMessagePair, ObservableCollection<FileTempate> fileTempateObservableCollection, ObservableCollection<Orm.Toolkit.DownloadItem> downloadItems, ICommand btnDownloadFileClickCommand, ICommand openFileCommand, ICommand openRootDirectoryCommand, ICommand resetDownloadFileCommand, ICommand deleteFileCommand, ICommand deleteServerFileCommand, ICommand upLoadFileCommand)
        //{
        //    busyMessagePair = new KeyValuePair<string, bool>("正在检取服务器端公共资料，请稍后...", true);
        //    DispatcherHelper.Initialize();
        //    Task task = Task.Factory.StartNew(() =>
        //    {
        //        try
        //        {
        //            //获取病人文件信息列表
        //            ReturnValue returnValue = Orm.Config.Service.CommonServices.GetFileInfoListByPatID(patID);
        //            ObservableCollection<FileTempate> fileTempateList = new ObservableCollection<FileTempate>();
        //            PMFileReturnValue pmFileReturnValue = new PMFileReturnValue();
        //            ///取文件列表
        //            List<FileInfo> fileInfoList = Orm.Client.Common.FileHelper.GetFileList(this._patientFile + "\\" + patID.ToString() + "\\ReportFile");
        //            if (returnValue.ErrorCode == 0 && returnValue.Returns != null)
        //            {
        //                if (returnValue.Returns is PMFileReturnValue)
        //                {
        //                    pmFileReturnValue = returnValue.Returns as PMFileReturnValue;
        //                }
        //                else
        //                {
        //                    Dictionary<string, object> dictionary = new ZhongXin.Tool.SerializerReverse().Json<Dictionary<string, object>>(returnValue.Returns.ToString());
        //                    if (dictionary["FileList"] != null)
        //                    {
        //                        pmFileReturnValue.FileList = new ZhongXin.Tool.SerializerReverse().Json<List<FileInfoEx>>(new ZhongXin.Tool.Serializer().Json(dictionary["FileList"]));
        //                    }
        //                }
        //                List<FileInfoEx> serverList = pmFileReturnValue.FileList;
        //                foreach (FileInfoEx fileInfoEx in serverList)
        //                {
        //                    if (!fileInfoList.Any(t => t.Name == fileInfoEx.Name))
        //                    {
        //                        fileTempateList.Add(SetFileInfo(fileInfoEx.Name, fileInfoEx.CreationTime, fileInfoEx.LastWriteTime, fileInfoEx.Length, 0, false,fileInfoEx.DirectoryName,btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand));
        //                    }
        //                    else
        //                    {
        //                        FileInfo fileInfo = fileInfoList.Find(t => t.Name == fileInfoEx.Name);
        //                        fileTempateList.Add(SetFileInfo(fileInfo, 1, false, fileInfoEx.DirectoryName, btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand, fileInfo.DirectoryName));
        //                    }
        //                }
        //            }
        //            foreach (FileInfo fileInfo in fileInfoList)
        //            {
        //                if (!fileTempateList.Any(t => t.Name == fileInfo.Name))
        //                {
        //                    fileTempateList.Add(SetFileInfo(fileInfo, 1, true, string.Empty, btnDownloadFileClickCommand, openFileCommand, openRootDirectoryCommand, resetDownloadFileCommand, deleteFileCommand, deleteServerFileCommand, upLoadFileCommand, fileInfo.DirectoryName));
        //                }
        //            }
        //            if (fileTempateList.Count > 0)
        //            {
        //                fileTempateList = fileTempateList.OrderByDescending(t => t.CreationTime).ToObservableCollection();
        //            }
        //            DispatcherHelper.CheckBeginInvokeOnUI((string ErrorMsg, ObservableCollection<FileTempate> TempList) =>
        //            {
        //                fileTempateObservableCollection = TempList;
        //                if (!string.IsNullOrWhiteSpace(ErrorMsg))
        //                {
        //                    Orm.Client.Base.BaseForm.FrmShowError.Show(ErrorMsg);
        //                }
        //                if (this.IsOpenForm)
        //                {
        //                    List<KeyValuePair<int, Orm.Toolkit.DownloadItem>> templist = Global.CacheDownloadItems.FindAll(t => t.Key == patID);
        //                    foreach (KeyValuePair<int, Orm.Toolkit.DownloadItem> item in templist)
        //                    {
        //                        downloadItems.Add(item.Value);
        //                    }
        //                    CheckAndDownCurDocPatReports(patID, patName);
        //                    this.IsOpenForm = false;
        //                }
        //            }, returnValue.ErrorMsg, fileTempateList);
        //        }
        //        catch (Exception ex)
        //        {
        //            Orm.Client.Base.BaseForm.FrmShowError.Show(ex);
        //        }
        //        finally
        //        {
        //            DispatcherHelper.CheckBeginInvokeOnUI(() =>
        //            {
        //                busyMessagePair = new KeyValuePair<string, bool>(string.Empty, false);
        //            });
        //        }
        //    });
        //}
        ///// <summary>
        ///// 检查下载
        ///// </summary>
        ///// <param name="patId">患者ID</param>
        ///// <param name="patName">患者姓名</param>
        //private void CheckAndDownCurDocPatReports(int patId, string patName,ObservableCollection<Orm.Toolkit.DownloadItem> downloadItems, ref bool isShowDownloads)
        //{
        //    XDocument xDocument = this.GetXml(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigFiles\\PatientReportDownloadRecords.xml");
        //    if (xDocument == null)
        //    { return; }
        //    IEnumerable<XElement> elements = from element in xDocument.Elements("ReportFile").Elements("Doctor" + UserProfiles.UserCode).Elements("Patient" + patId.ToString()) select element;
        //    if (elements.Count() <= 0)
        //    { return; }
        //    bool flag = true;
        //    foreach (XElement xElement in elements)
        //    {
        //        if (downloadItems.Any(t => t.IsDownloading && t.URL == xElement.Attribute("ServerPath").Value))
        //        {
        //            flag = false;
        //            break;
        //        }
        //    }
        //    if (flag)
        //    {
        //        if (Orm.Client.Base.FrmMessageBox.ShowDialog(string.Format("是否进行上次【{0}】患者的报告下载任务？", patName), "系统提示") == true)
        //        {
        //            List<KeyValuePair<string, string>> tempList = new List<KeyValuePair<string, string>>();
        //            foreach (XElement xElement in elements)
        //            {
        //                tempList.Add(new KeyValuePair<string, string>(xElement.Attribute("ServerPath").Value, xElement.Attribute("LocalPath").Value));
        //            }
        //            this.DownFileServer(patId, tempList, downloadItems, ref isShowDownloads);
        //        }
        //    }
        //}
        ///// <summary>
        ///// 下载文件服务
        ///// </summary>
        ///// <param name="serverPathTolocalPath">服务器路径</param>
        //private void DownFileServer(int patientId, List<KeyValuePair<string, string>> serverPathTolocalPath, KeyValuePair<string, bool> busyMessagePair, ObservableCollection<Orm.Toolkit.DownloadItem> downloadItems,ref bool isShowDownloads)
        //{
        //    if (serverPathTolocalPath != null && serverPathTolocalPath.Count > 0)
        //    {
        //        busyMessagePair = new KeyValuePair<string, bool>("正在处理下载信息，请稍后...", true);
        //        DispatcherHelper.Initialize();
        //        bool isTrue = false;
        //        Task task = Task.Factory.StartNew(() =>
        //        {
        //            try
        //            {
        //                foreach (KeyValuePair<string, string> keyValuePairitem in serverPathTolocalPath)
        //                {
        //                    if (this.WriteRecordsIntoXml(patientId, keyValuePairitem.Key, keyValuePairitem.Value))
        //                    {
        //                        Orm.Toolkit.DownloadItem downloadItem = null;
        //                        Action removeAction = new Action(() =>
        //                        {
        //                            if (downloadItems.SingleOrDefault(d => d == downloadItem) != null)
        //                            {
        //                                Global.CacheDownloadItems.Remove(Global.CacheDownloadItems.Find(t => t.Key == patientId && t.Value == downloadItem));
        //                                downloadItems.Remove(downloadItems.SingleOrDefault(d => d == downloadItem));
        //                            }
        //                            this.ClearRecordsForXml(patientId, keyValuePairitem.Key, keyValuePairitem.Value);
        //                        });
        //                        downloadItem = new Orm.Toolkit.DownloadItem(keyValuePairitem.Key, keyValuePairitem.Value, AsyncTaskDownFileToStream, removeAction);
        //                        DispatcherHelper.CheckBeginInvokeOnUI((DownLoadItem, Item) =>
        //                        {
        //                            if (!downloadItems.Any(t => t == DownLoadItem))
        //                            {
        //                                Global.CacheDownloadItems.Add(new KeyValuePair<int, Orm.Toolkit.DownloadItem>(patientId, DownLoadItem));
        //                                downloadItems.Add(DownLoadItem);
        //                                DownLoadItem.Start();
        //                            }
        //                            else
        //                            {
        //                                var info = downloadItems.First(t => t == DownLoadItem);
        //                                if (!info.IsDownloading)
        //                                {
        //                                    info.GoOnStart();
        //                                }
        //                            }
        //                        }, downloadItem, keyValuePairitem);
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Orm.Client.Base.BaseForm.FrmShowError.Show(ex);
        //            }
        //            finally
        //            {
        //                DispatcherHelper.CheckBeginInvokeOnUI(() =>
        //                {
        //                    busyMessagePair = new KeyValuePair<string, bool>(string.Empty, false);
        //                    if (!isShowDownloads)
        //                    {
        //                        isShowDownloads = true;
        //                    }
        //                });
        //            }
        //        });
        //    }
        //    else
        //    {
        //        if (!this.IsShowDownloads)
        //        { this.IsShowDownloads = true; }
        //    }
        //}

        #region 全局变量
        /// <summary>
        /// 是否打开着窗体（true 取出下载缓存）
        /// </summary>
        private bool IsOpenForm = true;
        /// <summary>
        /// 上传的病人文件
        /// </summary>
        private string _patientFile = AppDomain.CurrentDomain.BaseDirectory + "PatientFile";
        /// <summary>
        /// 取消文件复制
        /// </summary>
        private Action _copyFileCancelAction = null;
        #endregion
        #region 属性
     
        #endregion
    }
}
