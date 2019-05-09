using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.WcfModels
{
    public class MyWcfTranserObjectCoder
    {
        public static void Write(IList<DbTable> dts)
        {
            string path = BaseParams.WcfModelsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, "MyWcfTranserObject.cs");

            #region 创建MyWcfTranserObject文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);

            CommentsCoder.CreateCsComments("MyWcfTranserObject", sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Runtime.Serialization;");
            sw.WriteLine("using System.ServiceModel;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using " + BaseParams.DomainNameSpace + ";");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WcfModelsNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    [Serializable]");
            sw.WriteLine("    [DataContract]    ");
            foreach (DbTable dt in dts)
            {
                sw.WriteLine("    [KnownType(typeof(" + dt.TitleCaseName + "))]");
                sw.WriteLine("    [KnownType(typeof(List<" + dt.TitleCaseName + ">))]");
            }
            sw.WriteLine("    public class MyWcfTranserObject");
            sw.WriteLine("    {");
            sw.WriteLine("        public MyWcfTranserObject(string objectTypeName)");
            sw.WriteLine("        {");
            sw.WriteLine("            this.ObjectTypeName = objectTypeName;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// WCF传递的对象数据");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        [DataMember]");
            sw.WriteLine("        public object TransData");
            sw.WriteLine("        {");
            sw.WriteLine("            get;");
            sw.WriteLine("            set;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 传递对象的实体名称");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        [DataMember]");
            sw.WriteLine("        public string ObjectTypeName");
            sw.WriteLine("        {");
            sw.WriteLine("            get;");
            sw.WriteLine("            set;");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
