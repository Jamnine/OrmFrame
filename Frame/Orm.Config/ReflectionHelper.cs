using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Orm.Config
{
    /// <summary>
    /// 反射帮助类
    /// </summary>
    public class ReflectionHelper
    {
        /// <summary>
        /// 根据泛型获得下拉框列表，返回键值对列表（key对应ID,value对应Name）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<KeyValuePair<int, string>> GetComboBoxList<T>() where T : Model.BaseModel, new()
        {
            Type modelType = typeof(T);
            //return GetComboBoxList(modelType);

            List<KeyValuePair<int, string>> lst = null;

            if (ContainProperty(modelType, "ID") && ContainProperty(modelType, "Name"))
            {

                IEnumerable lstResult;
                if (ContainProperty(modelType, "IsActive"))
                    lstResult = Orm.Config.Service.DBClientService.GetList<T>("IsActive");
                else
                    lstResult = Orm.Config.Service.DBClientService.GetAllList<T>();

                if (lstResult != null)
                {
                    lst = new List<KeyValuePair<int, string>>();
                    foreach (var model in lstResult)
                    {
                        int id = Convert.ToInt32(GetModelValue("ID", model));
                        string name = Convert.ToString(GetModelValue("Name", model));
                        if (id > 0)
                            lst.Add(new KeyValuePair<int, string>(id, name));
                    }
                }
            }


            return lst;
        }
        /// <summary>
        /// 根据类型获得下拉框列表，返回键值对列表（key对应ID,value对应Name）
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        public static List<KeyValuePair<int, string>> GetComboBoxList(Type modelType)
        {
            List<KeyValuePair<int, string>> lst = null;

            if (ContainProperty(modelType, "ID") && ContainProperty(modelType, "Name"))
            {

                IEnumerable lstResult;
                if (ContainProperty(modelType, "IsActive"))
                    lstResult = Orm.Config.Service.DBClientService.GetType().GetMethod("GetList").MakeGenericMethod(modelType).Invoke(Orm.Config.Service.DBClientService, new object[] { "IsActive", new object[] { } }) as IEnumerable;
                else
                    lstResult = Orm.Config.Service.DBClientService.GetType().GetMethod("GetAllList").MakeGenericMethod(modelType).Invoke(Orm.Config.Service.DBClientService, null) as IEnumerable;

                if (lstResult != null)
                {
                    lst = new List<KeyValuePair<int, string>>();
                    foreach (var model in lstResult)
                    {
                        int id = Convert.ToInt32(GetModelValue("ID", model));
                        string name = Convert.ToString(GetModelValue("Name", model));
                        if (id > 0)
                            lst.Add(new KeyValuePair<int, string>(id, name));
                    }
                }
            }


            return lst;
        }

        /// <summary>
        /// 根据泛型判断类中是否存在属性
        /// </summary>
        /// <typeparam name="T">类的泛型</typeparam>
        /// <param name="propertyName">要判断的属性名称</param>
        /// <returns></returns>
        public static bool ContainProperty<T>(string propertyName) where T : class
        {
            Type classType = typeof(T);
            if (classType.GetProperty(propertyName) != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 根据类型判断类中是否存在属性
        /// </summary>
        /// <param name="classType">类的类型</param>
        /// <param name="propertyName">要判断的属性名称</param>
        /// <returns></returns>
        public static bool ContainProperty(Type classType, string propertyName)
        {
            if (classType.GetProperty(propertyName) != null)
                return true;
            else
                return false;
        }

        public static bool ContainMethod<T>(string methodName) where T : class
        {
            Type classType = typeof(T);
            if (classType.GetMethod(methodName) != null)
                return true;
            else
                return false;
        }

        public static bool ContainMethod(Type classType, string methodName)
        {
            if (classType.GetMethod(methodName) != null)
                return true;
            else
                return false;
        }

        //public static MethodInfo GetMethodInfo<T>(string methodName) where T : class
        //{
        //    Type classType = typeof(T);
        //    return classType.GetMethod()
        //}


        /// <summary>
        /// 反射获得属性值
        /// </summary>
        /// <param name="FieldName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object GetModelValue(string FieldName, object obj)
        {
            try
            {
                Type Ts = obj.GetType();
                object o = Ts.GetProperty(FieldName).GetValue(obj, null);
                return o;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 反射设置属性值
        /// </summary>
        /// <param name="FieldName"></param>
        /// <param name="Value"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool SetModelValue(string FieldName, object Value, object obj)
        {
            try
            {
                Type Ts = obj.GetType();
                object v = Convert.ChangeType(Value, Ts.GetProperty(FieldName).PropertyType);
                Ts.GetProperty(FieldName).SetValue(obj, v, null);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public static IEnumerable<dynamic> OrderBy(IEnumerable lst, Type modelType)
        //{
        //    IEnumerable<dynamic> items=null;
        //    if (lst != null)
        //    {
        //        items = lst as IEnumerable<dynamic>;

        //        bool orderBy = false;
        //        if (ContainProperty(modelType, "OrderBy"))
        //        {
        //            orderBy = true;
        //        }
        //        if (orderBy)
        //            items = items.OrderBy(x => x.GetType().GetProperty("OrderBy").GetValue(x, null)).ToList();
        //        else
        //            items = items.OrderBy(x => x.GetType().GetProperty("ID").GetValue(x, null)).ToList();


        //    }

        //    return items;
        //}

        public static List<T> OrderBy<T>(List<T> lst) where T : Model.BaseModel, new()
        {
            return OrderBy<T>(lst, "OrderBy");
        }

        public static List<T> OrderBy<T>(List<T> lst, string orderByProp) where T : Model.BaseModel, new()
        {
            if (string.IsNullOrWhiteSpace(orderByProp))
                return lst;
            Type modelType = typeof(T);
            if (lst != null)
            {

                bool orderBy = false;
                if (ContainProperty(modelType, orderByProp))
                {
                    orderBy = true;
                }
                if (orderBy)
                    lst = lst.OrderBy(x => modelType.GetProperty(orderByProp).GetValue(x, null)).ToList();
                else
                    lst = lst.OrderBy(x => modelType.GetProperty("ID").GetValue(x, null)).ToList();


            }

            return lst;
        }

        public static object Max<T>(List<T> lst, string prop) where T : Model.BaseModel, new()
        {
            object max = null;
            Type modelType = typeof(T);
            if (!string.IsNullOrWhiteSpace(prop) && ContainProperty(modelType, prop))
            {
                max = lst.Max(t => modelType.GetProperty(prop).GetValue(t, null));
            }

            return max;
        }
    }
}
