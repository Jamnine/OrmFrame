using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OracleDataToRedis.Utils
{
    public class ConfigHelper
    {
        public static void ModifyConfig(string key, string strValue)
        {
            string XPath = "/configuration/appSettings/add[@key='?']";
            XmlDocument xdocConfig = new XmlDocument();

            xdocConfig.Load(System.Windows.Forms.Application.ProductName + ".exe.config");
            XmlNode addKey = xdocConfig.SelectSingleNode((XPath.Replace("?", key)));
            if (addKey == null)
            {
                throw new ArgumentException("没有找到<add   key='" + key + "'   value=.../>的配置节");
            }
            addKey.Attributes["value"].InnerText = strValue;
            xdocConfig.Save(System.Windows.Forms.Application.ProductName + ".exe.config");

        }
    }
}
