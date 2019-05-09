using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Orm.Client.Common
{
    public class UploadImage
    {
        public static void GetUnfinishedFiles()
        {
            var pathname = AppDomain.CurrentDomain.BaseDirectory + "Image\\unfinished";
            if (!Directory.Exists(pathname)) return;
            DirectoryInfo theFolder = new DirectoryInfo(pathname);
            var files = theFolder.GetFiles();
            foreach (var item in files)
            {
                var xmlPath = Path.Combine(item.DirectoryName, item.Name);
                var uploadfiles = ConvertXMLToDataDataTable(xmlPath);
                foreach (DataRow file in uploadfiles.Rows)
                {
                    //Orm.Config.Service.SystemService.SaveImageToLoc(file["ServerPath"].ToString(), BitmapImageToByteArray(file["LocalPath"].ToString()));
                }
                File.Delete(xmlPath);
            }
        }

        public static bool DataTableToXML(DataTable dtTable, string strXMLPath)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            StreamWriter sw = null;
            string pathname = AppDomain.CurrentDomain.BaseDirectory + "Image\\unfinished\\";
            try
            {
                if (!Directory.Exists(pathname)) Directory.CreateDirectory(pathname);
                stream = new MemoryStream();
                writer = new XmlTextWriter(stream, Encoding.UTF8);
                dtTable.WriteXml(writer, XmlWriteMode.WriteSchema);
                int nCount = (int)stream.Length;
                byte[] arr = new byte[nCount];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, nCount);
                UTF8Encoding utf = new UTF8Encoding();
                string strContent = utf.GetString(arr).Trim();
                sw = new StreamWriter(pathname + strXMLPath);
                sw.Write(strContent);

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
        private static DataTable ConvertXMLToDataDataTable(string xmlPath)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                //根据地址加载Xml文件  
                xmldoc.Load(xmlPath);
                DataTable dt = new DataTable();
                stream = new StringReader(xmldoc.InnerXml);
                reader = new XmlTextReader(stream);
                dt.ReadXml(reader);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (stream != null)
                    stream.Close();
            }
        }

        private static byte[] BitmapImageToByteArray(string fileName)
        {
            byte[] bytearray = null;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {          
                bytearray = new byte[fs.Length];
                fs.Read(bytearray, 0, (int)fs.Length);
            }
            catch
            {
                //other exception handling
            }
            finally
            {
                if (fs != null)
                {
                    //关闭资源  
                    fs.Close();
                }
            }
            if (bytearray != null)
                return Utils.Compress(bytearray);
            else
                return null;
        }
    }
}
