using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WcfClient
{
    public class WcfClientFactoryCoder
    {
        public static void Write()
        {
            string path = BaseParams.WcfClientPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建WcfClientFactory类
            string filepath = Path.Combine(path, "WcfClientFactory.cs");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("Wcf客户代理工厂类", sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.ServiceModel.Security;");
            sw.WriteLine("using " + BaseParams.WcfClientNameSpace + ".ServiceReference1;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WcfClientNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public class WcfClientFactory");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 用户名");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public static string UserName");
            sw.WriteLine("        {");
            sw.WriteLine("            get;");
            sw.WriteLine("            set;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 密码");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public static string Password");
            sw.WriteLine("        {");
            sw.WriteLine("            get;");
            sw.WriteLine("            set;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获取MainServiceClient对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public static MainServiceClient MainServiceClientInstance");
            sw.WriteLine("        {");
            sw.WriteLine("            get { ");
            sw.WriteLine("                MainServiceClient service = new MainServiceClient();");
            sw.WriteLine("                if (UserName != null && UserName != String.Empty)");
            sw.WriteLine("                {");
            sw.WriteLine("                    service.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;");
            sw.WriteLine("                    service.ClientCredentials.UserName.UserName = UserName;");
            sw.WriteLine("                    service.ClientCredentials.UserName.Password = Password;");
            sw.WriteLine("                }");
            sw.WriteLine("                return service;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
