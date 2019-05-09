using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WcfClient
{
    public class AppConfigCoder
    {
        public static void Write()
        {
            string path = BaseParams.WcfClientPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建AppConfig
            string filepath = Path.Combine(path, "App.config");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<configuration>");
            sw.WriteLine("    <system.serviceModel>");
            sw.WriteLine("        <bindings>");
            sw.WriteLine("            <wsHttpBinding>");
            sw.WriteLine("                <binding name=\"WSHttpBinding_IMainService\" closeTimeout=\"00:01:00\"");
            sw.WriteLine("                    openTimeout=\"00:01:00\" receiveTimeout=\"00:10:00\" sendTimeout=\"00:01:00\"");
            sw.WriteLine("                    bypassProxyOnLocal=\"false\" transactionFlow=\"false\" hostNameComparisonMode=\"StrongWildcard\"");
            sw.WriteLine("                    maxBufferPoolSize=\"524288\" maxReceivedMessageSize=\"65536\"");
            sw.WriteLine("                    messageEncoding=\"Text\" textEncoding=\"utf-8\" useDefaultWebProxy=\"true\"");
            sw.WriteLine("                    allowCookies=\"false\">");
            sw.WriteLine("                    <readerQuotas maxDepth=\"32\" maxStringContentLength=\"8192\" maxArrayLength=\"16384\"");
            sw.WriteLine("                        maxBytesPerRead=\"4096\" maxNameTableCharCount=\"16384\" />");
            sw.WriteLine("                    <reliableSession ordered=\"true\" inactivityTimeout=\"00:10:00\"");
            sw.WriteLine("                        enabled=\"false\" />");
            sw.WriteLine("                    <security mode=\"Message\">");
            sw.WriteLine("                        <transport clientCredentialType=\"Windows\" proxyCredentialType=\"None\"");
            sw.WriteLine("                            realm=\"\" />");
            sw.WriteLine("                        <message clientCredentialType=\"Windows\" negotiateServiceCredential=\"true\"");
            sw.WriteLine("                            algorithmSuite=\"Default\" establishSecurityContext=\"true\" />");
            sw.WriteLine("                    </security>");
            sw.WriteLine("                </binding>");
            sw.WriteLine("            </wsHttpBinding>");
            sw.WriteLine("        </bindings>");
            sw.WriteLine("        <client>");
            sw.WriteLine("            <endpoint address=\"http://localhost:" + BaseParams.WcfServicePort + "/MainService.svc\" binding=\"wsHttpBinding\"");
            sw.WriteLine("                bindingConfiguration=\"WSHttpBinding_IMainService\" contract=\"ServiceReference1.IMainService\"");
            sw.WriteLine("                name=\"WSHttpBinding_IMainService\">");
            sw.WriteLine("                <identity>");
            sw.WriteLine("                    <dns value=\"localhost\" />");
            sw.WriteLine("                </identity>");
            sw.WriteLine("            </endpoint>");
            sw.WriteLine("        </client>");
            sw.WriteLine("    </system.serviceModel>");
            sw.WriteLine("</configuration>");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
