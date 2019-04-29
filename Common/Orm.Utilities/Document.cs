using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Orm.Utilities
{
    /// <summary>
    /// Summary description for Document.
    /// </summary>
    public class Document
    {
        StringBuilder sb;
        public Document()
        {
            sb = new StringBuilder();
        }


        /// <summary>
        /// 基本路径
        /// </summary>
        private string _baseFolder;

        public string BaseFolder
        {
            set { _baseFolder = value; }
            get { return _baseFolder; }
        }

        /// <summary>
        /// 内容
        /// </summary>
        private StringBuilder _content;

        public StringBuilder Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="encoding"></param>
        public void Create(string fileName, string encoding)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            Encoding e = Encoding.GetEncoding(encoding);
            StreamWriter file = new StreamWriter(fileName, false, e);
            try
            {
                file.Write(this.Content);
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
                file.Close();
            }

        }

        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="append">是否追加</param>
        public void Create(string fileName, bool append)
        {
            StreamWriter file = new StreamWriter(fileName, append);
            file.Write(this.Content);
            file.Close();
        }

        /// <summary>
        /// 将指定的URL写入文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileName"></param>
        /// <param name="encoding"></param>
        /// <param name="bufferSize"></param>
        /// <returns></returns>
        public string Create(string url, string fileName, string encoding, int bufferSize)
        {
            Encoding e = Encoding.GetEncoding(encoding);
            StreamWriter writer = new StreamWriter(fileName, false, e, bufferSize);
            Stream stream;

            try
            {
                System.Uri objUri = new Uri(url);
                System.Net.WebRequest objRequest = System.Net.WebRequest.Create(objUri);
                System.Net.WebResponse objResponse = objRequest.GetResponse();
                stream = objResponse.GetResponseStream();
                objResponse.Close();
                int len = 4096;
                byte[] read = new byte[len];
                int bytes = stream.Read(read, 0, len);

                while (bytes > 0)
                {
                    writer.Write(e.GetString(read, 0, bytes));
                    bytes = stream.Read(read, 0, len);
                }
                stream.Flush();
                stream.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                writer.Flush();
                writer.Close();

            }
            return "OK";

        }
        /// <summary>
        /// 从URL取得文件
        /// </summary>
        /// <param name="url">指定的URL</param>
        /// <param name="fileName">文件名</param>
        /// <param name="encoding">编码</param>
        public string Create(string url, string fileName, string encoding)
        {
            Encoding e = Encoding.GetEncoding(encoding.ToLower());
            StreamWriter writer = new StreamWriter(fileName, false, e);
            Stream stream;

            try
            {
                System.Uri objUri = new Uri(url);
                System.Net.WebRequest objRequest = System.Net.WebRequest.Create(objUri);
                System.Net.WebResponse objResponse = objRequest.GetResponse();
                stream = objResponse.GetResponseStream();

                System.IO.StreamReader reader = new StreamReader(stream, e);

                writer.Write(reader.ReadToEnd());
                stream.Flush();
                stream.Close();
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
                writer.Flush();
                writer.Close();
            }
            return "OK";
        }
        /// <summary>
        /// 从Url读取数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public StringBuilder ReadUrl(string url, string encoding)
        {
            Encoding e = Encoding.GetEncoding(encoding.ToLower());

            Stream stream;
            string temp = string.Empty;
            try
            {
                System.Uri objUri = new Uri(url);
                System.Net.WebRequest objRequest = System.Net.WebRequest.Create(objUri);
                System.Net.WebResponse objResponse = objRequest.GetResponse();
                stream = objResponse.GetResponseStream();

                System.IO.StreamReader reader = new StreamReader(stream, e);

                temp = reader.ReadToEnd();
                stream.Flush();
                stream.Close();

            }
            catch (System.Exception ex)
            {
                throw (ex);
            }

            return new StringBuilder(temp);
        }

        public string Read(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return string.Empty;
            }
            Encoding e = Encoding.GetEncoding("gb2312");
            System.IO.StreamReader file = new StreamReader(fileName, e);
            string str = file.ReadToEnd();
            file.Close();
            return str;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public void CreateHTML(string fileName)
        {
            this.Create(fileName, "gb2312");
        }

        /// <summary>
        /// 取得随机文件全名
        /// </summary>
        /// <returns>SHTML文件名</returns>
        public string GetFullRndName()
        {
            return this.GetFullPath() + this.GetRandName() + ".shtml";
        }
        /// <summary>
        /// 取得全路径
        /// </summary>
        /// <returns></returns>

        public string GetFullPath()
        {
            string str = this.BaseFolder + this.GetDayFolderName() + "\\";
            if (!Directory.Exists(str)) Directory.CreateDirectory(str);
            return str;
        }

        public string GetRandName()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            string temp = (rnd.NextDouble() * 100000000000).ToString();
            temp = temp.Substring(0, 4);
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + temp;
        }
        public string GetDayFolderName()
        {
            string strFolder = DateTime.Today.ToString("yyyyMMdd");
            return strFolder;
        }
        public string GetMonthFoldName()
        {
            return DateTime.Today.ToString("yyyy-MM");
        }
        public long GetTimeNumer(DateTime time)
        {
            return long.Parse(time.Hour.ToString() + formatNum(time.Minute, 2) + formatNum(time.Second, 2) + formatNum(time.Millisecond, 3));
        }
        private string formatNum(int num, int len)
        {
            string temp = num.ToString();
            for (int i = 0; i < len - num.ToString().Length; i++)
            {
                temp = "0" + temp;
            }
            return temp;
        }
        /// <summary>
        /// 保存日志
        /// </summary>
        /// <param name="logTxt"></param>
        /// <param name="filePath"></param>
        public void SaveLog(string logTxt, string filePath)
        {
            try
            {
                this.Content = new StringBuilder(logTxt);
                this.Create(filePath, true);
                this.Content = new StringBuilder(string.Empty);
            }
            catch
            {

            }
        }
        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="sourceFileName">源文件</param>
        /// <param name="targetName">目标文件</param>
        public void Copy(string sourceFileName, string targetName)
        {
            File.Copy(sourceFileName, targetName, true);
        }

        /// <summary>
        /// 从指定内容中提取
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="rex">正则表达式</param>
        /// <returns></returns>
        public ArrayList GetParts(string content, string rex)
        {
            ArrayList list = new ArrayList();

            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(rex, System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Match m = r.Match(content);
            for (m = r.Match(content); m.Success; m = m.NextMatch())
            {
                list.Add(m.Groups[1].Value);
            }
            return list;
        }

        /// <summary>
        /// 按正则表达式替换
        /// </summary>
        /// <param name="input">输入字符</param>
        /// <param name="findRegEx">查找表达式</param>
        /// <param name="replaceEx">替换表达式</param>
        /// <returns>处理后的字符</returns>
        public static string Replace(string input, string findRegEx, string replaceEx)
        {
            return System.Text.RegularExpressions.Regex.Replace(input, findRegEx, replaceEx, System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// 静态方法:将指定文件夹下面的所有内容copy到目标文件夹下面
        /// </summary>
        /// <param name="srcPath">源文件夹</param>
        /// <param name="aimPath">目标文件夹</param>
        public static void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                // 判断目标目录是否存在如果不存在则新建之
                if (!Directory.Exists(aimPath)) Directory.CreateDirectory(aimPath);
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果指向copy目标文件下面的文件而不包含目录可使用下面的方法
                // string[] fileList = Directory.GetFiles(srcPath);
                string[] fileList = Directory.GetFileSystemEntries(srcPath);
                // 遍历所有的文件和目录
                //Utilities.Information.ShowMsgBox(srcPath+"服务器到工作站" + aimPath);
                foreach (string file in fileList)
                {
                    if (file.IndexOf("Utilities.") > 0 || file.IndexOf("AutoUpdate.") > 0 || file.IndexOf("HIS3.") > 0 || file.Trim() == "His2.exe" || file.Trim() == "His2.pdb")
                    {
                        Utilities.Document.currentCount++;
                        continue;
                    }
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    //Utilities.Information.ShowMsgBox("正在复制文件：" + file);
                    if (Directory.Exists(file))
                    {
                        CopyDir(file, aimPath + Path.GetFileName(file));
                    }
                    // 否则直接Copy文件
                    else
                    {
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                        Utilities.Document.currentCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        ///  当前已经复制文件个数
        /// </summary>
        private static int currentCount = 0;

        public static int CurrentCount
        {
            get { return Document.currentCount; }
        }
        /// <summary>
        /// 文件总个数
        /// </summary>
        private static int count = 0;

        public static int Count
        {
            get { return Document.count; }
        }
        /// <summary>
        /// 获取目录总文件个数
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static void GetAllFiles(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Utilities.Document.count += dir.GetFiles().Length;
            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                //GetAllFiles(di);
            }
        }

        /// <summary>
        /// 静态方法:将指定文件夹下面的所有内容Detele
        /// </summary>
        /// <param name="aimPath"></param>
        public static void DeleteDir(string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果指向Delete目标文件下面的文件而不包含目录可使用下面的方法
                // string[] fileList = Directory.GetFiles(aimPath);
                string[] fileList = Directory.GetFileSystemEntries(aimPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Delete该目录下面的文件
                    if (Directory.Exists(file))
                    {

                        DeleteDir(aimPath + Path.GetFileName(file));
                    }
                    // 否则直接Delete文件
                    else
                    {
                        File.Delete(aimPath + Path.GetFileName(file));
                    }
                }
                //删除文件夹

                System.IO.Directory.Delete(aimPath, true);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 取得文件的扩展名
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetExtention(string file)
        {
            int start = file.LastIndexOf(".");
            if (start < 0) return string.Empty;
            string ext = file.Substring(start, file.Length - start);
            return ext;
        }

        /// <summary>
        /// 取得文件的扩展名
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static bool IsExistFile(string path, string fileName)
        {
            foreach (string f in Directory.GetFiles(path, fileName))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 二进制数组Byte[]生成文件
        /// </summary>
        /// <param name="FileFullPath">要生成的文件全路径</param>
        /// <param name="StreamByte">要生成文件的二进制 Byte 数组</param>
        /// <returns>bool 是否生成成功</returns>
        public static bool ByteStreamToFile(string FileFullPath, byte[] StreamByte)
        {
            try
            {
                if (File.Exists(FileFullPath) == true)  //判断要创建的文件是否存在，若存在则先删除
                {
                    File.Delete(FileFullPath);
                }
                FileStream FS = new FileStream(FileFullPath, FileMode.OpenOrCreate);  //创建文件流(打开或创建的方式)
                FS.Write(StreamByte, 0, StreamByte.Length);  //把文件流写到文件中
                FS.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除文件夹及子文件夹
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteFolder(string dir)
        {
            if (Directory.Exists(dir)) //如果存在这个文件夹删除之 
            {
                foreach (string d in Directory.GetFileSystemEntries(dir))
                {
                    if (File.Exists(d))
                    {
                        File.Delete(d); //直接删除其中的文件 
                    }
                    else
                    {
                        DeleteFolder(d); //递归删除子文件夹 
                    }
                }
                Directory.Delete(dir); //删除已空文件夹 
            }
        }
    }
}
