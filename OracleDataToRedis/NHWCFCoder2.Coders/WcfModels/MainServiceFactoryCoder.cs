﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.WcfModels
{
    public class MainServiceFactoryCoder
    {
        public static void Write(IList<DbTable> dts)
        {
            string path = BaseParams.WcfModelsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, "MainServiceFactory.cs");

            #region 创建MainServiceFactory文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);

            CommentsCoder.CreateCsComments("MainServiceFactory", sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Runtime.Serialization;");
            sw.WriteLine("using System.ServiceModel;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Reflection;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using NHibernate;");
            sw.WriteLine("using " + BaseParams.DomainNameSpace + ";");
            sw.WriteLine("using " + BaseParams.ServicesNameSpace + ";");
            sw.WriteLine("using " + BaseParams.UtilityNameSpace + ";");
            sw.WriteLine("using " + BaseParams.PersistenceNameSpace + ";");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WcfModelsNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public class MainServiceFactory");
            sw.WriteLine("    {");
            sw.WriteLine("        private static Hashtable _cacheServices;");
            sw.WriteLine("        private static MainServiceFactory _instance = new MainServiceFactory();");
            sw.WriteLine("        private MainServiceFactory()");
            sw.WriteLine("        {");
            sw.WriteLine("            _cacheServices = new Hashtable();");
            foreach (DbTable dt in dts)
            {
                sw.WriteLine("            _cacheServices.Add(\"" + BaseParams.DomainNameSpace + "." + dt.TitleCaseName + "\", " + dt.TitleCaseName + "Service.Instance);");
            }
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获得单件模式对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public static MainServiceFactory Instance");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return _instance; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获取对象的对应服务对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"objectTypeName\">对象名称</param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public object GetService(string objectTypeName)");
            sw.WriteLine("        {");
            sw.WriteLine("            return _cacheServices[objectTypeName];");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        ///  通过反射调用对应的服务方法,保存或更新对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\">WCF传递对象</param>");
            sw.WriteLine("        public void ExcuteSaveOrUpdate(MyWcfTranserObject transObj)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(transObj.ObjectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"SaveOrUpdate\");");
            sw.WriteLine("                object[] pObjs = new object[] { transObj.TransData };");
            sw.WriteLine("                method.Invoke(obj, pObjs);");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,保存或更新对象列表");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\">WCF传递对象</param>");
            sw.WriteLine("        public void ExcuteSaveOrUpdateList(MyWcfTranserObject transObj)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(transObj.ObjectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"SaveOrUpdateList\");");
            sw.WriteLine("                object[] pObjs = new object[] { transObj.TransData };");
            sw.WriteLine("                method.Invoke(obj, pObjs);");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,保存对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\">WCF传递对象</param>");
            sw.WriteLine("        public void ExcuteSave(MyWcfTranserObject transObj)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(transObj.ObjectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"Save\");");
            sw.WriteLine("                object[] pObjs = new object[] { transObj.TransData };");
            sw.WriteLine("                method.Invoke(obj, pObjs);");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,更新对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\">WCF传递对象</param>");
            sw.WriteLine("        /// <param name=\"id\">对象主键</param>");
            sw.WriteLine("        public void ExcuteUpdate(MyWcfTranserObject transObj, Object id)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(transObj.ObjectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"Update\");");
            sw.WriteLine("                object[] Objs = new object[] { transObj.TransData, id };");
            sw.WriteLine("                method.Invoke(obj, Objs);");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,删除对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\">WCF传递对象</param>");
            sw.WriteLine("        public void ExcuteDelete(MyWcfTranserObject transObj)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(transObj.ObjectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"Delete\");");
            sw.WriteLine("                object[] Objs = new object[] { transObj.TransData };");
            sw.WriteLine("                method.Invoke(obj, Objs);");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,删除对象列表");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\">WCF传递对象</param>");
            sw.WriteLine("        public void ExcuteDeleteList(MyWcfTranserObject transObj)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(transObj.ObjectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"DeleteList\");");
            sw.WriteLine("                object[] Objs = new object[] { transObj.TransData };");
            sw.WriteLine("                method.Invoke(obj, Objs);");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,获取对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"transObj\">WCF传递对象</param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public MyWcfTranserObject ExcuteObjectGet(MyWcfTranserObject transObj)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(transObj.ObjectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"Get\");");
            sw.WriteLine("                object[] Objs = new object[] { transObj.TransData };");
            sw.WriteLine("                object tmpObj = method.Invoke(obj, Objs);");
            sw.WriteLine("");
            sw.WriteLine("                transObj.TransData = tmpObj;");
            sw.WriteLine("                return transObj;");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,获取所有对应对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"objectTypeName\">对象名称</param>");
            sw.WriteLine("        /// <param name=\"qt\">提取类型</param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public MyWcfTranserObject ExcuteObjectAll(string objectTypeName, QueryType qt)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(objectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"GetAllEntitys\");");
            sw.WriteLine("                object[] Objs = new object[] { qt };");
            sw.WriteLine("                object tmpObj = method.Invoke(obj, Objs);");
            sw.WriteLine("");
            sw.WriteLine("                IEnumerator ienum = (tmpObj as IEnumerable).GetEnumerator();");
            sw.WriteLine("                while (ienum.MoveNext() == true)");
            sw.WriteLine("                    NHibernateUnProxyHelper.UnproxyObjectTree<Object>(ienum.Current, (int)qt);");
            sw.WriteLine("");
            sw.WriteLine("                MyWcfTranserObject transObj = new MyWcfTranserObject(objectTypeName);");
            sw.WriteLine("                transObj.TransData = tmpObj;");
            sw.WriteLine("                return transObj;");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,用Hql条件提取对象列表");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"objectTypeName\">对象名称</param>");
            sw.WriteLine("        /// <param name=\"condi\">Hql条件</param>");
            sw.WriteLine("        /// <param name=\"qt\">提取类型</param>");
            sw.WriteLine("        /// <param name=\"maxDepth\">NH过滤深度</param>");
            sw.WriteLine("        /// <param name=\"paging\">分页对象</param>");
            sw.WriteLine("        /// <param name=\"ps\">Hql条件参数</param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public MyWcfTranserObject ExcuteGetObjectByHqlCondi(string objectTypeName, string condi, QueryType qt, int maxDepth, Paging paging, params Object[] ps)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(objectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"GetEntitysByHqlCondi\");");
            sw.WriteLine("                object[] Objs = new object[] { condi, qt, paging, ps };");
            sw.WriteLine("                object tmpObj = method.Invoke(obj, Objs);");
            sw.WriteLine("");
            sw.WriteLine("                IEnumerator ienum = (tmpObj as IEnumerable).GetEnumerator();");
            sw.WriteLine("                while (ienum.MoveNext() == true)");
            sw.WriteLine("                    NHibernateUnProxyHelper.UnproxyObjectTree<Object>(ienum.Current, (int)qt);");
            sw.WriteLine("");
            sw.WriteLine("                MyWcfTranserObject transObj = new MyWcfTranserObject(objectTypeName);");
            sw.WriteLine("                transObj.TransData = tmpObj;");
            sw.WriteLine("                return transObj;");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,用独立Hql语句提取对象列表");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"objectTypeName\">对象名称</param>");
            sw.WriteLine("        /// <param name=\"hql\">Hql语句</param>");
            sw.WriteLine("        /// <param name=\"maxDepth\">NH过滤深度</param>");
            sw.WriteLine("        /// <param name=\"paging\">分页对象</param>");
            sw.WriteLine("        /// <param name=\"ps\">Hql条件参数</param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public MyWcfTranserObject ExcuteGetObjectByHqlQuery(string objectTypeName, String hql, int maxDepth, Paging paging, params Object[] ps)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(objectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(\"HqlQuery\");");
            sw.WriteLine("                object[] Objs = new object[] { hql, paging, ps };");
            sw.WriteLine("                object tmpObj = method.Invoke(obj, Objs);");
            sw.WriteLine("");
            sw.WriteLine("                IEnumerator ienum = (tmpObj as IEnumerable).GetEnumerator();");
            sw.WriteLine("                while (ienum.MoveNext() == true)");
            sw.WriteLine("                    NHibernateUnProxyHelper.UnproxyObjectTree<object>(ienum.Current, maxDepth);");
            sw.WriteLine("");
            sw.WriteLine("                MyWcfTranserObject transObj = new MyWcfTranserObject(objectTypeName);");
            sw.WriteLine("                transObj.TransData = tmpObj;");
            sw.WriteLine("                return transObj;");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,用Sql条件提取DataTable数据");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"sql\">sql语句</param>");
            sw.WriteLine("        /// <param name=\"ps\">sql参数</param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public DataTable ExcuteSqlFillDataTable(String sql, params Object[] ps)");
            sw.WriteLine("        {");
            sw.WriteLine("            return new BaseService<BaseEntity>().SqlFillDataTable(sql, ps);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 通过反射调用对应的服务方法,执行事物方法");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"wcfTransObjs\">WCF传递对象</param>");
            sw.WriteLine("        /// <param name=\"objectTypeName\">对象名称</param>");
            sw.WriteLine("        /// <param name=\"transMethodName\">事物方法名称</param>");
            sw.WriteLine("        /// <returns></returns>");
            sw.WriteLine("        public MyWcfTranserObject ExcuteTransationMethod(MyWcfTranserObject wcfTransObjs, string objectTypeName, string transMethodName)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                object obj = GetService(objectTypeName);");
            sw.WriteLine("                MethodInfo method = obj.GetType().GetMethod(transMethodName);");
            sw.WriteLine("                object[] Objs = new object[] { wcfTransObjs.TransData };");
            sw.WriteLine("                object tmpObj = method.Invoke(obj, Objs);");
            sw.WriteLine("");
            sw.WriteLine("                MyWcfTranserObject transObj = new MyWcfTranserObject(objectTypeName);");
            sw.WriteLine("                transObj.TransData = tmpObj;");
            sw.WriteLine("                return transObj;");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                throw ex.InnerException;");
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