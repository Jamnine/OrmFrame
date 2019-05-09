using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Utility
{
    public class UtilsCoder
    {
        public static void Write()
        {
            string path = Path.Combine(BaseParams.SolutionPath, BaseParams.UtilityPath);
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建QueryType类
            string filepath = Path.Combine(path, "Utils.cs");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("工具集", sw);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.UtilityNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public class Utils");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 提取list中的键值组合成sql语句中的字符串in条件");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"lst\">条件集合</param>");
            sw.WriteLine("        /// <param name=\"prop\">键值名称</param>");
            sw.WriteLine("        /// <returns>组合后的sql语句中的in条件</returns>");
            sw.WriteLine("        public static string GetSqlInCondiForChar(IList<Object> lst, string prop)");
            sw.WriteLine("        {");
            sw.WriteLine("            string result = \"(\";");
            sw.WriteLine("            foreach (object o in lst)");
            sw.WriteLine("            {");
            sw.WriteLine("                result += \"'\" + o.GetType().GetProperty(prop).GetValue(o, null).ToString() + \"',\";");
            sw.WriteLine("            }");
            sw.WriteLine("            if (lst.Count > 0)");
            sw.WriteLine("            {");
            sw.WriteLine("                result = result.Substring(0, result.Length - 1);");
            sw.WriteLine("            }");
            sw.WriteLine("            result += \")\";");
            sw.WriteLine("            return \"\";");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 提取list中的键值组合成sql语句中的数字in条件");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"lst\">条件集合</param>");
            sw.WriteLine("        /// <param name=\"prop\">键值名称</param>");
            sw.WriteLine("        /// <returns>组合后的sql语句中的in条件</returns>");
            sw.WriteLine("        public static string GetSqlInCondiForNumber(IList<Object> lst, string prop)");
            sw.WriteLine("        {");
            sw.WriteLine("            string result = \"(\";");
            sw.WriteLine("            foreach (object o in lst)");
            sw.WriteLine("            {");
            sw.WriteLine("                result += o.GetType().GetProperty(prop).GetValue(o, null).ToString() + \",\";");
            sw.WriteLine("            }");
            sw.WriteLine("            if (lst.Count > 0)");
            sw.WriteLine("            {");
            sw.WriteLine("                result = result.Substring(0, result.Length - 1);");
            sw.WriteLine("            }");
            sw.WriteLine("            result += \")\";");
            sw.WriteLine("            return \"\";");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
