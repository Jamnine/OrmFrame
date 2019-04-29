using Microsoft.Win32;
using System;
using System.IO;
using System.Text;

namespace Orm.Utilities
{
    public static class FileHelper
    {
        public static void CopyFloderFile(string srcPath, string aimPath)
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
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    //Utilities.Information.ShowMsgBox("正在复制文件：" + file);
                    if (Directory.Exists(file))
                    {
                        CopyFloderFile(file, aimPath + Path.GetFileName(file));
                    }
                    // 否则直接Copy文件
                    else
                    {
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="filter">打开的文件类型</param>
        /// <param name="dialogTitle">窗体的标题</param>
        /// <param name="multiselect">是否允许选择多个文件</param>
        /// <returns></returns>
        public static OpenFileDialog OpenFile(string filter, string dialogTitle = "系统", bool multiselect = true)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.Title = dialogTitle;
            openFileDialog.Multiselect = multiselect;
            return openFileDialog;
        }

        /// <summary>
        /// 读取文本文件获取到所有内容
        /// </summary>
        /// <param name="dialogTitle">窗体的标题</param>
        /// <returns></returns>
        public static string ReadAllTextFile(string dialogTitle = "系统")
        {
            string filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            OpenFileDialog openFileDialog = OpenFile(filter, dialogTitle);

            return string.Empty;
        }

        /// <summary>
        /// 一行一行的方式读取文本文件
        /// </summary>
        /// <param name="dialogTitle">窗体的标题</param>
        /// <returns></returns>
        public static StreamReader ReadTextFile(string dialogTitle = "系统")
        {
            string filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            OpenFileDialog openFileDialog = OpenFile(filter, dialogTitle);
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                if (Path.GetExtension(fileName) == ".txt")
                {
                    throw new Exception("导入文件类型不正确，请导入TXT文件！");
                }
                using (StreamReader sr = FileRead(openFileDialog))
                {
                    return sr;
                }
            }
            return null;
        }

        /// <summary>
        /// 读取文件获取文件流
        /// </summary>
        /// <param name="openFileDialog">选择的文件信息</param>
        private static StreamReader FileRead(OpenFileDialog openFileDialog)
        {
            //读取文本信息
            using (FileStream readFileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(readFileStream, Encoding.GetEncoding("GBK")))
                {
                    return streamReader;
                }
            }
        }
    }
}
