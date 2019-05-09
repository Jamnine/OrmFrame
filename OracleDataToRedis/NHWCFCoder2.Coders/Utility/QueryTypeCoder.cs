using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Utility
{
    public class QueryTypeCoder
    {
        public static void Write()
        {
            string path = Path.Combine(BaseParams.SolutionPath, BaseParams.UtilityPath);
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建QueryType类
            string filepath = Path.Combine(path, "QueryType.cs");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("查询种类", sw);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.UtilityNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    /// <summary>");
            sw.WriteLine("    /// 对象查询对象范围");
            sw.WriteLine("    /// </summary>");
            sw.WriteLine("    [Serializable]");
            sw.WriteLine("    public enum QueryType");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 只查询对象本身");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        hql_slf,");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 查询对象以及父对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        hql_pnt,");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 查询出对象以及子对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        hql_son,");
            sw.WriteLine(" ");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 查询对象、父对象以及子对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        hql_pnt_son");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
