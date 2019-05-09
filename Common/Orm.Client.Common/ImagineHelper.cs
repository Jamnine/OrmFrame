using Microsoft.Win32;
using System; 
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text; 
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading; 

namespace Orm.Client.Common
{
    public class ImagineHelper
    {
        /// <summary>
        /// 直接打开图片预览
        /// </summary>
        public static void OpenImageDialog(object parameter)
        {
            if (parameter != null)
            {
                var image = parameter as System.Windows.Controls.Image;
                if (image != null && image.Source != null)
                {
                    var window = new Window
                    {
                        Width = 800,
                        Height = 600,
                        WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen,
                        Content = new System.Windows.Controls.Border()
                        {
                            Child = new Image
                            {
                                Source = image.Source
                            }
                        },
                        Topmost = true,
                    };

                    string Pathstr = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    window.ShowInTaskbar = false;
                    window.ShowDialog();
                }
            }
        }

        /// <summary>
        /// 打开插入图片框
        /// </summary>
        private static int i = 0;
        public static string UpPhoto(object parameter)
        {
            i++;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += (s, e1) => { timer.IsEnabled = false; i = 0; };
            timer.IsEnabled = true;
            string fileName = string.Empty;
            if (i % 2 == 0)
            {
                return fileName;
            }
            else
            {
                object arr = parameter as object;
                //创建＂打开文件＂对话框
                Microsoft.Win32.OpenFileDialog dlg = new OpenFileDialog();
                //设置文件类型过滤
                dlg.Filter = "图片|*.jpg;*.png;*.jpeg";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    fileName = dlg.FileName;
                    FileInfo file = new FileInfo(fileName);
                    if ((file.Length / 1024) > 512)
                    {
                        //Orm.Client.Base.FrmMessageRemind.Show("图片不能大于512KB");
                        return string.Empty;
                    }
                    var xPhoto = new BitmapImage(new Uri(fileName));
                    if (arr is Image)
                    {
                        ((Image)arr).Source = xPhoto;
                        ((Image)arr).Stretch = System.Windows.Media.Stretch.Fill;
                    }
                }
                return fileName;
            }
        }

        /// <summary>
        /// 通过路径获得BitmapImage图片
        /// </summary>
        /// <param name="fileName">图片路径</param>
        /// <returns></returns>
        public static BitmapImage GetBitmapImageFromPath(string fileName)
        {
            System.IO.MemoryStream ms = null;
            var data = System.IO.File.ReadAllBytes(fileName);
            ms = new System.IO.MemoryStream(data);
            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.StreamSource = ms;
            bmp.EndInit();
            return bmp;
        }

        /// <summary>
        /// 打开
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool ProcessStartInfoByPath(string path)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(path);
            startInfo.Arguments = path;
            startInfo.CreateNoWindow = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process = Process.Start(startInfo);
            process.WaitForExit();
            if (process.ExitCode != 0)
                return false;
            else
                return true;
        }

        //public static List<EmrTemplate> LstFilesEmrTemplate = new List<EmrTemplate>();
        /// <summary>
        /// 递归rootPath所有文件
        /// 配合LstFilesEmrTemplate一起用
        /// </summary>
        /// <param name="rootPath"></param>
        //public static void GetAllDirectoriesUnlimited(string rootPath)
        //{
        //    string[] subPaths = System.IO.Directory.GetDirectories(rootPath);//得到所有子目录
        //    foreach (string path in subPaths)
        //    {
        //        GetAllDirectoriesUnlimited(path);
        //        //对每一个字目录做与根目录相同的操作：即找到子目录并将当前目录的文件名存入List
        //    }
        //    string[] files = System.IO.Directory.GetFiles(rootPath);
        //    foreach (string file in files)
        //    {
        //        //var xx = Path.GetDirectoryName(file);
        //        var tmp = new Model.EmrTemplate();
        //        var start = file.LastIndexOf("\\") + 1;
        //        var end = file.LastIndexOf(".");
        //        tmp.FileName = file.Substring(start, file.Length - start);
        //        tmp.Path = file;
        //        LstFilesEmrTemplate.Add(tmp);
        //        //将当前目录中的所有文件全名存入文件List
        //    }
        //}

        /// <summary>
        /// 获取所在路径的文件名称
        /// </summary>
        /// <param name="fileName">文件带路径</param>
        /// <param name="isWithSuffix">是否带后缀名</param>
        /// <returns></returns>
        public static string GetFileNameByPath(string fileName, bool isWithSuffix)
        {
            var filename = string.Empty;
            var start = fileName.LastIndexOf("\\") + 1;
            var end = fileName.LastIndexOf(".");
            if (isWithSuffix)
                fileName = fileName.Substring(start, fileName.Length - start);
            else
                fileName = fileName.Substring(start, end - start);

            return fileName;
        }

        /// <summary>
        /// 清空字符中间的所有空格
        /// </summary>
        /// <param name="stringx">带有空格的字符</param>
        /// <returns></returns>
        public static string StringToTrimMiddle(string stringx)
        {
            stringx = stringx.Trim();
            var index = stringx.IndexOf(" ");
            if (index != -1)
            {
                var stringsub = stringx.Substring(0, index);
                var tmp = stringsub + stringx.Substring(index + 1, stringx.Length - (index + 1));
                if (tmp.IndexOf(" ") != -1)
                    stringx = StringToTrimMiddle(tmp);
                else
                    stringx = tmp;
            }
            return stringx;
        }

        #region 压缩图片算法处理 2015-11-16 11：20 添加

        /// <summary>
        /// 压缩图片处理
        /// </summary>
        /// <param name="bytes">图片字节</param>
        /// <param name="quality">质量 取值 0-100之间，数值越大质量越高</param>
        /// <returns>图片流</returns>
        public Stream CompressionImageToStream(Byte[] bytes, long quality = 0L)
        {
            using (System.IO.MemoryStream stream = new MemoryStream(bytes))
            {
                return new System.IO.MemoryStream(CompressionImageProcessing(stream, quality));
            }
        }

        public Byte[] CompressionImageToByte(Byte[] bytes, long quality = 0L)
        {
            using (System.IO.MemoryStream stream = new MemoryStream(bytes))
            {
                return CompressionImageProcessing(stream, quality);
            }
        }

        /// <summary>
        /// 压缩图片处理
        /// </summary>
        /// <param name="stream">图片流</param>
        /// <param name="quality">质量 取值 0-100之间，数值越大质量越高</param>
        public Byte[] CompressionImageProcessing(Stream stream, long quality = 0L)
        {
            using (System.Drawing.Image img = System.Drawing.Image.FromStream(stream))
            {
                using (System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(img))
                {
                    System.Drawing.Imaging.ImageCodecInfo codecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders().FirstOrDefault(e => e.FormatID == img.RawFormat.Guid);
                    System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
                    System.Drawing.Imaging.EncoderParameters encoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
                    System.Drawing.Imaging.EncoderParameter encoderParameter = new System.Drawing.Imaging.EncoderParameter(encoder, quality);

                    encoderParameters.Param[0] = encoderParameter;
                    using (System.IO.MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, codecInfo, encoderParameters);
                        encoderParameters.Dispose();
                        encoderParameter.Dispose();
                        return ms.ToArray();
                    }
                }
            }
        }

        #endregion

        private void GetWebContent()
        {
            try
            {
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData("http://bbs.csdn.net/topics/391056287?page=1"); //从指定网站下载数据
                string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            
                string pageHtml2 = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                Console.WriteLine(pageHtml);//在控制台输入获取的内容
                using (StreamWriter sw = new StreamWriter("c:\\test\\ouput.html"))//将获取的内容写入文本
                {
                    sw.Write(pageHtml);
                }
                Console.ReadLine(); //让控制台暂停,否则一闪而过了             
            }
            catch (WebException webEx)
            {
                Console.WriteLine(webEx.Message.ToString());
            }
        }

        private string GetWebContent(string Url)
        {
            var strResult = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url); //声明一个HttpWebRequest请求
                request.Timeout = 30000; //设置连接超时时间
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                Encoding encoding = Encoding.GetEncoding("UTF-8");
                StreamReader streamReader = new StreamReader(streamReceive, encoding);
                strResult = streamReader.ReadToEnd();
                var yes = strResult.Contains("没说明白");
            }
            catch { }
            return strResult;
        }

        /// <summary>
        /// 获取Excel数据成DataTable
        /// </summary>
        /// <param name="hasTitle"></param>
        /// <returns></returns>
        //public DataTable GetDataFromExcelByCom(bool hasTitle = false)
        //{
        //    System.Windows.Forms.OpenFileDialog openFile = new System.Windows.Forms.OpenFileDialog();
        //    openFile.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
        //    openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    openFile.Multiselect = false;
        //    if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return null;
        //    var excelFilePath = openFile.FileName;

        //    Excel.Application app = new Excel.Application();
        //    Excel.Sheets sheets;
        //    object oMissiong = System.Reflection.Missing.Value;
        //    Excel.Workbook workbook = null;
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        if (app == null) return null;
        //        workbook = app.Workbooks.Open(excelFilePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
        //            oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
        //        sheets = workbook.Worksheets;

        //        //将数据读入到DataTable中
        //        Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);//读取第一张表  
        //        if (worksheet == null) return null;

        //        int iRowCount = worksheet.UsedRange.Rows.Count;
        //        int iColCount = worksheet.UsedRange.Columns.Count;
        //        //生成列头
        //        for (int i = 0; i < iColCount; i++)
        //        {
        //            var name = "column" + i;
        //            if (hasTitle)
        //            {
        //                var txt = ((Excel.Range)worksheet.Cells[1, i + 1]).Text.ToString();
        //                if (!string.IsNullOrWhiteSpace(txt)) name = txt;
        //            }
        //            while (dt.Columns.Contains(name)) name = name + "_1";//重复行名称会报错。
        //            dt.Columns.Add(new DataColumn(name, typeof(string)));
        //        }
        //        //生成行数据
        //        Excel.Range range;
        //        int rowIdx = hasTitle ? 2 : 1;
        //        for (int iRow = rowIdx; iRow <= iRowCount; iRow++)
        //        {
        //            DataRow dr = dt.NewRow();
        //            for (int iCol = 1; iCol <= iColCount; iCol++)
        //            {
        //                range = (Excel.Range)worksheet.Cells[iRow, iCol];
        //                dr[iCol - 1] = (range.Value2 == null) ? "" : range.Text.ToString();
        //            }
        //            dt.Rows.Add(dr);
        //        }
        //        return dt;
        //    }
        //    catch { return null; }
        //    finally
        //    {
        //        workbook.Close(false, oMissiong, oMissiong);
        //        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
        //        workbook = null;
        //        app.Workbooks.Close();
        //        app.Quit();
        //        System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        //        app = null;
        //    }
        //}
    }
}
