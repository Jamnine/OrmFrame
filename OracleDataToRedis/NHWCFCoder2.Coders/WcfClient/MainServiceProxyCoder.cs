﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WcfClient
{
    public class MainServiceProxyCoder
    {
        public static void Write()
        {
            string path = BaseParams.WcfClientPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建MainServiceProxy类
            string filepath = Path.Combine(path, "MainServiceProxy.cs");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("MainServiceProxy", sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.ServiceModel.Security;");
            sw.WriteLine("using System.Reflection;");
            sw.WriteLine("using log4net;");
            sw.WriteLine("using " + BaseParams.DomainNameSpace + ";");
            sw.WriteLine("using " + BaseParams.UtilityNameSpace + ";");
            sw.WriteLine("using " + BaseParams.WcfClientNameSpace + ".ServiceReference1;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WcfClientNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MainServiceProxy<T>");
            sw.WriteLine("    {");
            sw.WriteLine("        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);");
            sw.WriteLine("");
            sw.WriteLine("        private static MainServiceProxy<T> _instance = new MainServiceProxy<T>();");
            sw.WriteLine("");
            sw.WriteLine("        private MainServiceProxy()");
            sw.WriteLine("        {");
            sw.WriteLine("");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获得单件模式对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public static MainServiceProxy<T> Instance");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return _instance; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 保存或更新对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\"></param>");
            sw.WriteLine("        public void SaveOrUpdate(ref T t)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            transObj.TransData = t;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.ObjectSaveOrUpdate(ref transObj);");
            sw.WriteLine("                    t = (T)transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 保存或更新对象列表");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\"></param>");
            sw.WriteLine("        public void SaveOrUpdate(ref List<T> lst)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (lst.Count > 0)");
            sw.WriteLine("            {");
            sw.WriteLine("                MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("                transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("                transObj.TransData = lst;");
            sw.WriteLine("                using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("                {");
            sw.WriteLine("                    try");
            sw.WriteLine("                    {");
            sw.WriteLine("                        wcfsvc.ObjectSaveOrUpdate(ref transObj);");
            sw.WriteLine("                        lst = (List<T>)transObj.TransData;");
            sw.WriteLine("                    }");
            sw.WriteLine("                    catch (Exception ex)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        wcfsvc.Abort();");
            sw.WriteLine("                        Logger.Error(ex);");
            sw.WriteLine("                        throw ex;");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 保存对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\"></param>");
            sw.WriteLine("        public void Save(ref T t)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            transObj.TransData = t;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.ObjectSave(ref transObj);");
            sw.WriteLine("                    t = (T)transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 更新对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\"></param>");
            sw.WriteLine("        /// <param name=\"key\"></param>");
            sw.WriteLine("        public void Update(ref T t, object key)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            transObj.TransData = t;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.ObjectUpdate(ref transObj, key);");
            sw.WriteLine("                    t = (T)transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 删除对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\"></param>");
            sw.WriteLine("        public void Delete(T t)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            transObj.TransData = t;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.ObjectDelete(transObj);");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 删除对象列表");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\"></param>");
            sw.WriteLine("        public void Delete(List<T> lst)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (lst.Count > 0)");
            sw.WriteLine("            {");
            sw.WriteLine("                MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("                transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("                transObj.TransData = lst;");
            sw.WriteLine("                using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("                {");
            sw.WriteLine("                    try");
            sw.WriteLine("                    {");
            sw.WriteLine("                        wcfsvc.ObjectDeleteList(transObj);");
            sw.WriteLine("                    }");
            sw.WriteLine("                    catch (Exception ex)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        wcfsvc.Abort();");
            sw.WriteLine("                        Logger.Error(ex);");
            sw.WriteLine("                        throw ex;");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获取对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"wcfTransObject\"></param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public T Get(object key)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            transObj.TransData = key;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    transObj = wcfsvc.ObjectGet(transObj);");
            sw.WriteLine("                    return (T)transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获取对应对象所有对象集合");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"objectTypeName\"></param>");
            sw.WriteLine("        /// <param name=\"qt\"></param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public List<T> GetObjectAll(QueryType qt)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    transObj = wcfsvc.ObjectAll(typeof(T).FullName, qt);");
            sw.WriteLine("                    return (List<T>)transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过HQL条件获取对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"objectTypeName\"></param>");
            sw.WriteLine("        /// <param name=\"condi\"></param>");
            sw.WriteLine("        /// <param name=\"qt\"></param>");
            sw.WriteLine("        /// <param name=\"ps\"></param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public List<T> GetObjectByHqlCondi(string condi, QueryType qt, List<object> ps)");
            sw.WriteLine("        {");
            sw.WriteLine("            Paging paging = new Paging();");
            sw.WriteLine("            paging.IsPaging = false;");
            sw.WriteLine("            return this.GetObjectByHqlCondi(condi, qt, ref paging, ps);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过HQL条件获取对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"condi\"></param>");
            sw.WriteLine("        /// <param name=\"qt\"></param>");
            sw.WriteLine("        /// <param name=\"paging\"></param>");
            sw.WriteLine("        /// <param name=\"ps\"></param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public List<T> GetObjectByHqlCondi(string condi, QueryType qt, ref Paging paging, List<object> ps)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    Paging p = paging;");
            sw.WriteLine("                    transObj = wcfsvc.GetObjectByHqlCondi(typeof(T).FullName, condi, qt, (int)qt, ref p, ps);");
            sw.WriteLine("                    paging = p;");
            sw.WriteLine("                    return (List<T>)transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过HQL条件获取对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"condi\"></param>");
            sw.WriteLine("        /// <param name=\"qt\"></param>");
            sw.WriteLine("        /// <param name=\"maxTransDepth\"></param>");
            sw.WriteLine("        /// <param name=\"paging\"></param>");
            sw.WriteLine("        /// <param name=\"ps\"></param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public List<T> GetObjectByHqlCondi(string condi, QueryType qt, int maxTransDepth, ref Paging paging, List<object> ps)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    Paging p = paging;");
            sw.WriteLine("                    transObj = wcfsvc.GetObjectByHqlCondi(typeof(T).FullName, condi, qt, maxTransDepth, ref p, ps);");
            sw.WriteLine("                    paging = p;");
            sw.WriteLine("                    return (List<T>)transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过HQL查询语句获取对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"hql\"></param>");
            sw.WriteLine("        /// <param name=\"ps\"></param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public List<T> GetObjectByHqlQuery(string hql, int maxTransDepth, List<object> ps)");
            sw.WriteLine("        {");
            sw.WriteLine("            Paging paging = new Paging();");
            sw.WriteLine("            paging.IsPaging = false;");
            sw.WriteLine("            return this.GetObjectByHqlQuery(hql, ref paging, maxTransDepth, ps);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过HQL查询语句获取对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"objectTypeName\"></param>");
            sw.WriteLine("        /// <param name=\"hql\"></param>");
            sw.WriteLine("        /// <param name=\"paging\"></param>");
            sw.WriteLine("        /// <param name=\"ps\"></param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public List<T> GetObjectByHqlQuery(String hql, ref Paging paging, int maxTransDepth, List<object> ps)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    Paging p = paging;");
            sw.WriteLine("                    transObj = wcfsvc.GetObjectByHqlQuery(typeof(T).FullName, hql, maxTransDepth, ref p, ps);");
            sw.WriteLine("                    paging = p;");
            sw.WriteLine("                    return (List<T>)transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 调用服务端事物方法的简单通用方法");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"objectTypeName\"></param>");
            sw.WriteLine("        /// <param name=\"hql\"></param>");
            sw.WriteLine("        /// <param name=\"paging\"></param>");
            sw.WriteLine("        /// <param name=\"ps\"></param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public object ExcuteTransationMethod(object transData, string transMethodName)");
            sw.WriteLine("        {");
            sw.WriteLine("            MyWcfTranserObject transObj = new MyWcfTranserObject();");
            sw.WriteLine("            transObj.ObjectTypeName = typeof(T).FullName;");
            sw.WriteLine("            transObj.TransData = transData;");
            sw.WriteLine("            using (MainServiceClient wcfsvc = WcfClientFactory.MainServiceClientInstance)");
            sw.WriteLine("            {");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    transObj = wcfsvc.ExcuteTransationMethod(transObj, typeof(T).FullName, transMethodName);");
            sw.WriteLine("                    return transObj.TransData;");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfsvc.Abort();");
            sw.WriteLine("                    Logger.Error(ex);");
            sw.WriteLine("                    throw ex;");
            sw.WriteLine("                }");
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
