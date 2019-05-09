using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.WcfModels
{
    public class NHibernateUnProxyHelperCorder
    {
        public static void Write()
        {
            string path = BaseParams.WcfModelsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, "NHibernateUnProxyHelper.cs");

            #region 创建IMainService文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);

            CommentsCoder.CreateCsComments("NHibernateUnProxyHelper", sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Runtime.Serialization;");
            sw.WriteLine("using System.ServiceModel;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Reflection;");
            sw.WriteLine("using NHibernate.Proxy;");
            sw.WriteLine("using NHibernate;");
            sw.WriteLine("using NHibernate.Metadata;");
            sw.WriteLine("using NHibernate.Collection;");
            sw.WriteLine("using " + BaseParams.PersistenceNameSpace + ";");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WcfModelsNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public static class NHibernateUnProxyHelper");
            sw.WriteLine("    {");
            sw.WriteLine("        public static T Unproxy<T>(T persistentObject)");
            sw.WriteLine("        {");
            sw.WriteLine("            var proxy = persistentObject as INHibernateProxy;");
            sw.WriteLine("");
            sw.WriteLine("            if (proxy != null)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    return (T)proxy.HibernateLazyInitializer.GetImplementation();");
            sw.WriteLine("                }");
            sw.WriteLine("                catch(Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    throw new ApplicationException(\"无法在断开的情况下加载数据，请修改数据获取深度(maxDepth)！\",ex); ;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("            return persistentObject;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        public static Type GetUnproxiedType<T>(T persistentObject)");
            sw.WriteLine("        {");
            sw.WriteLine("            var proxy = persistentObject as INHibernateProxy;");
            sw.WriteLine("            if (proxy != null)");
            sw.WriteLine("                return proxy.HibernateLazyInitializer.PersistentClass;");
            sw.WriteLine("");
            sw.WriteLine("            return persistentObject.GetType();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        public static T UnproxyObjectTree<T>(T persistentObject, int maxDepth)");
            sw.WriteLine("        {");
            sw.WriteLine("            ISessionFactory sessionFactory = SessionFactory.GetCurrentSession(false).SessionFactory;");
            sw.WriteLine("            return UnproxyObjectTree<T>(persistentObject, sessionFactory, maxDepth);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private static T UnproxyObjectTree<T>(T persistentObject, ISessionFactory sessionFactory, int maxDepth)");
            sw.WriteLine("        {");
            sw.WriteLine("            var persistentType = NHibernateUnProxyHelper.GetUnproxiedType(persistentObject);");
            sw.WriteLine("");
            sw.WriteLine("            var classMetadata = sessionFactory.GetClassMetadata(persistentType);");
            sw.WriteLine("");
            sw.WriteLine("            if (maxDepth < 0)");
            sw.WriteLine("                return CreatePlaceholder<T>(persistentObject, persistentType, classMetadata);");
            sw.WriteLine("");
            sw.WriteLine("            var unproxiedObject = NHibernateUnProxyHelper.Unproxy(persistentObject);");
            sw.WriteLine("");
            sw.WriteLine("            if (unproxiedObject != null)");
            sw.WriteLine("            {");
            sw.WriteLine("                for (int i = 0; i < classMetadata.PropertyTypes.Length; i++)");
            sw.WriteLine("                {");
            sw.WriteLine("                    var nhType = classMetadata.PropertyTypes[i];");
            sw.WriteLine("                    var propertyName = classMetadata.PropertyNames[i];");
            sw.WriteLine("                    var propertyInfo = persistentType.GetProperty(propertyName);");
            sw.WriteLine("");
            sw.WriteLine("                    if (nhType.IsCollectionType)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        propertyInfo.SetValue(unproxiedObject, null, null);");
            sw.WriteLine("                        continue;");
            sw.WriteLine("                    }");
            sw.WriteLine("                    if (nhType.IsEntityType)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        var propertyValue = propertyInfo.GetValue(unproxiedObject, null);");
            sw.WriteLine("");
            sw.WriteLine("                        if (propertyValue == null)");
            sw.WriteLine("                            continue;");
            sw.WriteLine("");
            sw.WriteLine("                        propertyInfo.SetValue(unproxiedObject, NHibernateUnProxyHelper.UnproxyObjectTree(propertyValue, sessionFactory, maxDepth - 1), null);");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("");
            sw.WriteLine("            return unproxiedObject;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private static T CreatePlaceholder<T>(T persistentObject, Type persistentType, IClassMetadata classMetadata)");
            sw.WriteLine("        {");
            sw.WriteLine("            var placeholderObject = (T)Activator.CreateInstance(persistentType);");
            sw.WriteLine("");
            sw.WriteLine("            if (classMetadata.HasIdentifierProperty)");
            sw.WriteLine("            {");
            sw.WriteLine("                var identifier = classMetadata.GetIdentifier(persistentObject, EntityMode.Poco);");
            sw.WriteLine("                classMetadata.SetIdentifier(placeholderObject, identifier, EntityMode.Poco);");
            sw.WriteLine("            }");
            sw.WriteLine("");
            sw.WriteLine("            return placeholderObject;");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}