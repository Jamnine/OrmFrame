using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Orm.Model;

namespace Orm.Client.Common
{
    /// <summary>
    /// 文件操作类
    /// Add By Ben 2014-12-16
    /// </summary>
    public class FileHelper
    {

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="directory">路径</param>
        public static void DeleteFiles(string directory)
        {
            if (Directory.Exists(directory))
            {
                var files = Directory.GetFiles(directory);
                for (int i = 0; i < files.Length; i++)
                {
                    File.Delete(files[i]);
                }
            }
            else
            {
                Directory.CreateDirectory(directory);
            }
        }

        /// <summary>
        /// 文件转换为二进制流数组
        /// </summary>
        /// <param name="fileName">完整文件名</param>
        /// <returns></returns>
        public static byte[] FileContentToByteArray(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                byte[] buffur = new byte[fs.Length];
                fs.Read(buffur, 0, (int)fs.Length);

                return buffur;
            }
            catch 
            {
                return null;
            }
            finally
            {
                if (fs != null)
                {
                    //关闭资源  
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// 二进制流数组转换为BitmapImage
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        public static BitmapImage ByteArrayToBitmapImage(byte[] byteArray)
        {
            if (byteArray == null) return null;
            BitmapImage bmp = null;
            try
            {
                bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = new MemoryStream(byteArray);
                bmp.EndInit();
            }
            catch
            {
                bmp = null;
            }

            return bmp;
        }
        /// <summary>
        /// Bitmap转换为BitmapImage
        /// </summary>
        public static BitmapImage BitmapToBitmapImage(Bitmap bitmap)
        {
            Bitmap bitmapSource = new Bitmap(bitmap.Width, bitmap.Height);
            int i, j;
            for (i = 0; i < bitmap.Width; i++)
                for (j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);
                    bitmapSource.SetPixel(i, j, newColor);
                }
            MemoryStream ms = new MemoryStream();
            bitmapSource.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(ms.ToArray());
            bitmapImage.EndInit();
            return bitmapImage;
        }

        /// <summary>
        /// BitmapImage 转换成二进制流
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static byte[] BitmapImageToByteArray(BitmapImage bmp)
        {
            byte[] bytearray = null;
            try
            {
                Stream smarket = bmp.StreamSource;
                if (smarket != null && smarket.Length > 0)
                {
                    //很重要，因为position经常位于stream的末尾，导致下面读取到的长度为0。
                    smarket.Position = 0;
                    using (BinaryReader br = new BinaryReader(smarket))
                    {
                        bytearray = br.ReadBytes((int)smarket.Length);
                    }
                }
            }
            catch
            {
                //other exception handling
            }

            return bytearray;
        }

        /// <summary>
        /// 保存图片文件
        /// </summary>
        /// <param name="imgSource"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static void SaveImageFile(BitmapSource imgSource, string fileName)
        { 
            PngBitmapEncoder bbe = new PngBitmapEncoder();
            bbe.Frames.Add(BitmapFrame.Create(imgSource));
            using (Stream stream = File.Create(fileName))
            {
                bbe.Save(stream); //保存图片  
            } 
        }

        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<FileInfo> GetFileList(string path)
        {
            List<FileInfo> fileList = new List<FileInfo>();
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)//判断所指的文件或文件夹是否存在
            {
                // Directory.CreateDirectory(Sdir);

                return fileList;
            }
            DirectoryInfo dirD = dir as DirectoryInfo;
            FileSystemInfo[] files = dirD.GetFileSystemInfos();//获取文件夹中所有文件和文件夹
            //对单个FileSystemInfo进行判断,如果是文件夹则进行递归操作
            foreach (FileSystemInfo FSys in files)
            {
                FileInfo file = FSys as FileInfo;
                if (file != null)//如果是文件的话，进行文件的复制操作
                {
                    if (!file.Name.EndsWith(".td"))
                    {
                        FileInfo SFInfo = new FileInfo(file.DirectoryName + "\\" + file.Name);//获取文件所在的原始路径 
                        fileList.Add(SFInfo);
                    }
                }
                else
                {
                    string pp = FSys.Name;//获取当前搜索到的文件夹名称                      
                }
            }
            return fileList;
        }

        public static List<EmrTemplate> LstFilesEmrTemplate = new List<EmrTemplate>();
        /// <summary>
        /// 递归rootPath所有文件,配合LstFilesEmrTemplate一起用
        /// </summary>
        /// <param name="rootPath"></param>
        public static void GetAllDirectoriesUnlimited(string rootPath)
        {
            string[] subPaths = System.IO.Directory.GetDirectories(rootPath);//得到所有子目录
            foreach (string path in subPaths)
            {
                GetAllDirectoriesUnlimited(path);
                //对每一个字目录做与根目录相同的操作：即找到子目录并将当前目录的文件名存入List
            }
            string[] files = System.IO.Directory.GetFiles(rootPath);
            foreach (string file in files)
            {
                //var xx = Path.GetDirectoryName(file);
                EmrTemplate emr = new Model.EmrTemplate();
                var start = file.LastIndexOf("\\") + 1;
                var end = file.LastIndexOf(".");
                emr.FileName = file.Substring(start, file.Length - start);
                emr.Path = file;
                LstFilesEmrTemplate.Add(emr);
                //将当前目录中的所有文件全名存入文件List
            }
        }
    }
}
