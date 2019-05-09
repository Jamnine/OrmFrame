using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Persistence
{
    public class SessionFactoryCoder
    {
        public static void Write()
        {
            string path = BaseParams.PersistencePath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, "SessionFactory.cs");

            #region 创建cs文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("NHSerssion工厂类", sw);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Web;");
            sw.WriteLine("using NHibernate;");
            sw.WriteLine("using NHibernate.Cfg;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.PersistenceNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public sealed class SessionFactory");
            sw.WriteLine("    {");
            sw.WriteLine("        private static ISessionFactory _factory;");
            sw.WriteLine("        private static ISession _session;");
            sw.WriteLine("        private static object obj = new object();");
            sw.WriteLine("        public ISession Session");
            sw.WriteLine("        {");
            sw.WriteLine("            get");
            sw.WriteLine("            {");
            sw.WriteLine("                if (_factory == null)");
            sw.WriteLine("                {");
            sw.WriteLine("                    lock (obj)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        if (_factory == null)");
            sw.WriteLine("                        {");
            sw.WriteLine("                            Configuration cfg = new Configuration().Configure();");
            sw.WriteLine("                            _factory = cfg.BuildSessionFactory();");
            sw.WriteLine("                        }");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("                return _factory.OpenSession();");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        public static ISession GetCurrentSession()");
            sw.WriteLine("        {");
            sw.WriteLine("            if (_session == null)");
            sw.WriteLine("                _session = new SessionFactory().Session;");
            sw.WriteLine("            else");
            sw.WriteLine("                _session.Clear();");
            sw.WriteLine("            if (_session.IsConnected == false)");
            sw.WriteLine("                _session.Reconnect();");
            sw.WriteLine("            return _session;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        public static ISession GetCurrentSession(bool sessClear)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (_session == null)");
            sw.WriteLine("                _session = new SessionFactory().Session;");
            sw.WriteLine("            else if(sessClear == true)");
            sw.WriteLine("                _session.Clear();");
            sw.WriteLine("            if (_session.IsConnected == false)");
            sw.WriteLine("                _session.Reconnect();");
            sw.WriteLine("            return _session;");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
