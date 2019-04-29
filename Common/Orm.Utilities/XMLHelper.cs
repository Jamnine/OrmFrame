using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;

namespace Orm.Utilities
{
    public class XMLHelper
    {
        /// <summary>
        /// 判断是否存在column节点(测试用的,使用就不用此方法。)
        /// </summary>
        /// <param name="Request"></param>
        /// <param name="column">写法如:"str1,str2"</param>
        /// <returns></returns>
        public static string GetExist(string Request, string column)
        {
            foreach (string item in column.Split(','))
            {
                if (!Request.Contains(item))
                    return string.Format("<ResultCode>1</ResultCode><ErrorMsg>请联系接口程序员,参数{0}是否对应</ErrorMsg>", item);
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取指定节点参数
        /// </summary>
        /// <param name="xmlText">xml文本</param>
        /// <param name="node1">第一个节点</param>
        /// <param name="node2">第二个节点</param>
        /// <param name="node3">第三个节点</param>
        /// <returns></returns>
        public static string GetXmlValue(string xmlText, string node1, string node2, string node3)
        {
            string xmlvalue = string.Empty;
            XmlDocument xx = new XmlDocument();
            xx.LoadXml(xmlText);//加载xml
            XmlNodeList xxList = xx.GetElementsByTagName(node1); //取得节点名为row的XmlNode集合
            foreach (XmlNode xxNode in xxList)
            {
                XmlNodeList childList = xxNode.ChildNodes; //取得row下的子节点集合
                foreach (XmlNode xmNode in childList)
                {
                    if (xmNode.Name.ToLower().Equals(node2.ToLower()))
                    {
                        xmlvalue = xmNode.InnerText;
                    }
                    //xxNode.Attributes["name"].Value; //col节点name属性值                
                    XmlNodeList scHldList = xmNode.ChildNodes;
                    foreach (XmlNode xlNode in scHldList)
                    {
                        if (xlNode.Name.ToLower().Equals(node3.ToLower()))
                        {
                            xmlvalue = xlNode.InnerText;
                        }
                    }
                }
            }

            return xmlvalue;
        }

        /// <summary>
        /// DataTable转换成XML
        /// </summary>
        /// <param name="xmlDS"></param>
        /// <returns></returns>
        public static string ConvertDataTableToXML(DataTable xmlDS)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            try
            {
                stream = new MemoryStream();
                writer = new XmlTextWriter(stream, Encoding.UTF8);
                xmlDS.WriteXml(writer);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);
                UTF8Encoding utf = new UTF8Encoding();

                return utf.GetString(arr).Trim();
            }
            catch
            {
                return String.Empty;
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        /// <summary>
        /// XML转换成DataTable
        /// </summary>
        /// <param name="xmlData"></param>
        /// <returns></returns>
        public static DataSet ConvertXMLToDataSet(string xmlData)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmlData);
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                return xmlDS;
            }
            catch (Exception ex)
            {
                string strTest = ex.Message;
                return null;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public static Dictionary<string, string> ReadAllChild(string node)
        {
            XmlDocument doc = new XmlDocument();
            Dictionary<string, string> oscar = new Dictionary<string, string>();
            node = GetStr(node, "<DataTable>", "</DataTable>");
            doc.LoadXml(string.Format("<DataTable>{0}</DataTable>", node));
            XmlNode rootNode = doc.DocumentElement;
            for (int i = 0; i < rootNode.ChildNodes.Count; i++)
            {

                string name = rootNode.ChildNodes[i].Name;
                string value = rootNode.ChildNodes[i].InnerText;
                oscar.Add(name, value);
            }
            return oscar;
        }

        private static string GetStr(string TxtStr, string FirstStr, string SecondStr)
        {
            if (FirstStr.IndexOf(SecondStr, 0) != -1)
                return "";
            int FirstSite = TxtStr.IndexOf(FirstStr, 0);
            int SecondSite = TxtStr.IndexOf(SecondStr, FirstSite + 1);
            if (FirstSite == -1 || SecondSite == -1)
                return "";
            return TxtStr.Substring(FirstSite + FirstStr.Length, SecondSite - FirstSite - FirstStr.Length);
        }

        public static Dictionary<string, string> Getjson(string json)
        {
            var js = new System.Web.Script.Serialization.JavaScriptSerializer();
            Dictionary<string, object> jarr = js.Deserialize<Dictionary<string, object>>(json);
            return Getjson1(jarr);
        }

        public static Dictionary<string, string> Getjson1(Dictionary<string, object> jarr)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            string key = string.Empty;
            string value = string.Empty;
            foreach (var item in jarr)
            {
                key = item.Key;
                value = item.Value.ToString();
                if (key == "DataTable")
                {
                    System.Collections.ArrayList lststr = item.Value as System.Collections.ArrayList;
                    for (int i = 0; i < lststr.Count; i++)
                    {
                        Dictionary<string, object> doy = lststr[i] as Dictionary<string, object>;
                        foreach (var item2 in doy)
                        {
                            key = item2.Key.Contains("v_") ? item2.Key : string.Format("v_{0}", item2.Key);
                            value = item2.Value.ToString();
                            keyValuePairs.Add(key, value);
                        }
                    }
                }
                else
                {
                    keyValuePairs.Add(key, value);
                }
            }
            return keyValuePairs;
        }

        public static string GetValueByKeyName(string keyName, Dictionary<string, string> dataSet)
        {
            string value = string.Empty;
            foreach (var item in dataSet)
            {
                if (item.Key.ToString() == keyName)
                {
                    value = item.Value;
                }
            }
            return value;
        }

        public static string DataTableToJsonWithJsonNet<T>(T table)
        {
            string JsonString = string.Empty;
            JsonString = JsonConvert.SerializeObject(table);
            return JsonString;
        }
    }
}
