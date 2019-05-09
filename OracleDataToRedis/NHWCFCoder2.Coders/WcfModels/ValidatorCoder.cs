using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.WcfModels
{
    public class ValidatorCoder
    {
        public static void Write()
        {
            string path = BaseParams.WcfModelsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, "MyUserNamePasswordValidator.cs");

            #region 创建domain cs文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.ServiceModel;");
            sw.WriteLine("using System.IdentityModel.Tokens;");
            sw.WriteLine("using System.IdentityModel.Selectors;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WcfModelsNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    class MyUserNamePasswordValidator : UserNamePasswordValidator");
            sw.WriteLine("    {");
            sw.WriteLine("        public override void Validate(string userName, string password)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (null == userName || null == password)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw new ArgumentNullException(\"用户名或密码不能为空！\");");
            sw.WriteLine("            }");
            sw.WriteLine("");
            sw.WriteLine("            if (userName != \"user\" || password != \"pwd\")");
            sw.WriteLine("            {");
            sw.WriteLine("                throw new SecurityTokenException(\"用户名或密码错误！\");");
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
