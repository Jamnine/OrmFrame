using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Run
{
    public class Log4netConfigCoder
    {
        public static void Write()
        {
            string path = BaseParams.RunPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, "log4net.config");

            #region 创建log4net.config文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<configuration>");
            sw.WriteLine("  <configSections>");
            sw.WriteLine("    <section name=\"log4net\" type=\"log4net.Config.Log4NetConfigurationSectionHandler, log4net\"  />");
            sw.WriteLine("  </configSections>");
            sw.WriteLine("");
            sw.WriteLine("  <log4net>");
            sw.WriteLine("    <appender name=\"RollingFileAppender\" type=\"log4net.Appender.RollingFileAppender\">");
            sw.WriteLine("      <param name=\"File\" value=\"logs\\clt-log\"/>");
            sw.WriteLine("      <param name=\"appendToFile\" value=\"true\"/>");
            sw.WriteLine("      <param name=\"datePattern\" value=\"-yyyy-MMdd\"/>");
            sw.WriteLine("      <param name=\"rollingStyle\" value=\"Date\"/>");
            sw.WriteLine("      <param name=\"MaxSizeRollBackups\" value=\"60\"/>");
            sw.WriteLine("      <layout type=\"log4net.Layout.PatternLayout\">");
            sw.WriteLine("        <param name=\"conversionPattern\" value=\"%d{yyy-MM-dd HH:mm:ss} [%t] [%c]-[%-5p]  %m%n\"/>");
            sw.WriteLine("      </layout>");
            sw.WriteLine("    </appender>");
            sw.WriteLine("    <root>");
            sw.WriteLine("      <level value=\"Error\" />");
            sw.WriteLine("      <appender-ref ref=\"RollingFileAppender\" />");
            sw.WriteLine("    </root>");
            sw.WriteLine("  </log4net>");
            sw.WriteLine("</configuration>");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
