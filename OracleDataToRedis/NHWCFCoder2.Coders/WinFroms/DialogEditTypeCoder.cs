using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WinFroms
{
    public class DialogEditTypeCoder
    {
        public static void Write()
        {

            string path = BaseParams.WinFromsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建类detail文件
            string className = Path.Combine(path, "DialogEditType.cs");
            FileStream file = new FileStream(className, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("弹出对话框类型", sw);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WinFromsNameSpace );
            sw.WriteLine("{");
            sw.WriteLine("    public enum DialogEditType");
            sw.WriteLine("    {");
            sw.WriteLine("        Add,");
            sw.WriteLine("        Edit");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
