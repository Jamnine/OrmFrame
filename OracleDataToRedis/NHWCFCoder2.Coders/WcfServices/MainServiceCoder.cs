using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WcfServices
{
    public class MainServiceCoder
    {
        public static void Write()
        {
            string path = BaseParams.WcfServicesPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建AppConfig
            string filepath = Path.Combine(path, "MainService.svc");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<%@ ServiceHost Language=\"C#\" Debug=\"true\" Service=\"" + BaseParams.WcfModelsNameSpace + ".MainService\" CodeBehind=\"MainService.svc.cs\" %>");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
