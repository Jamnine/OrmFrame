using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Orm.Model;
using System.Collections.ObjectModel;

namespace Orm.Framework.Services
{
    #region  比较器
    public class MultiFieldComparer<T> : IComparer<T>
    {
        public string[] Fields
        {
            set;
            get;
        }
        //public IEmitService Service { set; get; }

        public int Compare(T x, T y)
        {
            for (int i = 0; i < Fields.Length; i++)
            {
                object valueX = Orm.Utilities.Common.GetPropertyValue(x, Fields[i]); //Orm.Utilities.Common.GetPropertyValue(x, Fields[i]);
                object valueY = Orm.Utilities.Common.GetPropertyValue(y, Fields[i]);
                if (valueX == null)
                    return -1;
                if (valueY == null)
                    return 1;
                var type = valueX.GetType();
                switch (type.Name)
                {
                    case "Int32":
                    case "Double":
                    case "Int64":
                    case "Float":
                    case "Single":
                    case "Decimal":
                        var result2 = Decimal.Parse(valueX.ToString()) - Decimal.Parse(valueY.ToString());
                        if (result2 != 0)
                            return result2 > 0 ? 1 : -1;
                        break;
                    case "DateTime":
                        var result3 = DateTime.Compare(DateTime.Parse(valueX.ToString()), DateTime.Parse(valueY.ToString()));
                        if (result3 != 0)
                            return result3;
                        break;
                    default:
                        var result = System.String.Compare(valueX.ToString(), valueY.ToString());
                        if (result != 0)
                            return result;
                        break;
                }
            }
            return 0;
        }
    }

    #endregion

    public static class Extension
    {
        /// <summary>
        /// 对集合分组统计，统计它的总和，平均值，最大值最小值，个数
        /// </summary>
        /// <typeparam name="T">集合里实体的类型</typeparam>
        /// <typeparam name="TKey">需要分组的key值的类型</typeparam>
        /// <typeparam name="TCompute">需要统计的字段的类型</typeparam>
        /// <param name="lst"></param>
        /// <param name="_groupKey">分组的key</param>
        /// <param name="_computeKey">统计的字段</param>
        /// <param name="_dec">描述信息</param>
        /// <returns>返回分组实体</returns>
        public static IEnumerable<ComputeSummary> GroupBy<T, TKey, TCompute>(this List<T> lst, string _groupKey, string _computeKey, string _dec)
        {
            /*
             * 使用方法 :
             var tt = l.GroupBy<BsUser, int,int>("ID", "ID", "123");
             */

            string key = string.Format("t=>t.{0}", _groupKey);

            string decimalResult = string.Format(" t => (decimal)t.{0}", _computeKey);

            Expression<Func<T, TKey>> groupExpression = LambdaParser.Parse<Func<T, TKey>>(key, typeof(T).Namespace);
            Expression<Func<T, decimal>> resultExpression = LambdaParser.Parse<Func<T, decimal>>(decimalResult, typeof(T).Namespace);

            var funGroup = groupExpression.Compile();
            var funResult = resultExpression.Compile();

            var query = from item in lst.GroupBy(funGroup)
                        select new ComputeSummary()
                        {
                            Sum = item.Sum(funResult),
                            Avg = item.Average(funResult),
                            Max = item.Max(funResult),
                            Min = item.Min(funResult),
                            Count = item.Count(),
                            GroupKey = item.Key.ToString(),
                            Description = _dec
                        };
            return query;
        }



        /// <summary>
        ///  
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static void Sort<T>(this List<T> lst, string key)
        {
            var comparer = new MultiFieldComparer<T>();
            comparer.Fields = key.Split(new char[] { ',' });
            lst.Sort(comparer);
        }

        /// <summary>
        /// 将子项的某一属性全Copy到数组
        /// </summary>
        /// <param name="ItemPropertyName"></param>
        /// <returns></returns>
        public static string[] CopyTo<T>(this List<T> lst, string ItemPropertyName)
        {
            int length = lst.Count;
            string[] ary = new string[length];
            int icounter = 0;
            foreach (T info in lst)
            {
                object propertyValue = info.GetType().GetProperty(ItemPropertyName).GetValue(info, null);
                if (propertyValue == null) continue;
                string a1 = propertyValue.ToString();
                ary[icounter] = a1;
                icounter++;
            }
            return ary;
        }
        /// <summary>
        /// 过滤与指定条件不等的对象
        /// </summary>
        /// <param name="key">属性名</param>
        /// <param name="value">值，全匹配</param>
        /// <returns>过滤后的List</returns>
        public static List<T> Filter<T>(this List<T> lst, string key, string value)
        {
            List<T> list = new List<T>();
            foreach (T info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (propertyValue.ToString() != value) list.Add((T)info);
            }
            return list;
        }

        /// <summary>
        ///  根据字段、值查询 集合里面相同的记录
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<T> Find<T>(this List<T> lst, string key, string value)
        {
            List<T> findLst = new List<T>();

            for (int i = 0; i < lst.Count; i++)
            {
                T info = lst[i];
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null)
                {
                    continue;
                }
                if (propertyValue.ToString() == value)
                {
                    findLst.Add(info);
                }
            }
            return findLst;
        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static void Remove<T>(this List<T> lst, string key, string value)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                T info = lst[i];
                object propertyValue = Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (propertyValue.ToString() == value)
                {
                    lst.Remove(info);
                    i--;
                }
            }
        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T AddNew<T>(this List<T> lst) where T : new()
        {
            T t = new T();
            lst.Add(t);
            return t;
        }

        /// <summary>
        /// 深拷贝，复制一份对象新的数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object DeepClone(this object obj)
        {
            if (obj == null)
            { 
                return null;
            }

            object cloneObj;
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter bf = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                cloneObj = bf.Deserialize(ms);
                ms.Close();
            }
            return cloneObj;
        }

        /// <summary>
        /// 深拷贝，复制一份对象新的数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T DeepClone<T>(this object obj) where T : class, new()
        {
            object cloneObj;
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter bf = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                cloneObj = bf.Deserialize(ms);
                ms.Close();
            }
            return cloneObj as T;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="key">属性名称</param>
        /// <returns></returns>
        public static int GetIntMax<T>(this List<T> lst, string key)
        {
            int max = 0;
            foreach (var info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (max < Convert.ToInt32(propertyValue))
                {
                    max = Convert.ToInt32(propertyValue);
                }
            }
            return max;
        }

        public static double GetSum<T>(this List<T> lst, string key)
        {
            double intTotal = 0;
            foreach (T info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null)
                { 
                    continue;
                }
                intTotal += Convert.ToDouble(propertyValue.ToString());
            }
            return intTotal;
        }

        public static Double GetDoubleMax<T>(this List<T> lst, string key)
        {
            Double max = Double.MinValue;
            foreach (T info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (max < Convert.ToDouble(propertyValue))
                {
                    max = Convert.ToDouble(propertyValue);
                }
            }
            return max;
        }

        public static Double GetDoubleMin<T>(this List<T> lst, string key)
        {
            Double min = Double.MaxValue;
            foreach (T info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (min > Convert.ToDouble(propertyValue))
                {
                    min = Convert.ToDouble(propertyValue);
                }
            }
            return min;
        }
        public static DateTime GetDateTimeMax<T>(this List<T> lst, string key)
        {
            DateTime max = DateTime.MinValue;
            foreach (T info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (max < Convert.ToDateTime(propertyValue))
                {
                    max = Convert.ToDateTime(propertyValue);
                }
            }
            return max;
        }
        public static DateTime GetDateTimeMin<T>(this List<T> lst, string key)
        {
            DateTime min = DateTime.MaxValue;
            foreach (T info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (min > Convert.ToDateTime(propertyValue))
                {
                    min = Convert.ToDateTime(propertyValue);
                }
            }
            return min;
        }

        /// <summary>
        /// 找出包含指定字符串的数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<T> FindInclude<T>(this List<T> lst, string key, string value)
        {
            List<T> list = new List<T>();
            foreach (T info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (propertyValue.ToString().Contains(value))
                {
                    list.Add((T)info.DeepClone());
                }
            }
            return list;
        }

        public static int IndexOf<T>(this List<T> lst, string key, string value)
        {
            int i = 0;
            foreach (T info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null) continue;
                if (propertyValue.ToString() == value)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        public static void Fill<T>(this List<T> lst, string key, object value)
        {
            if (lst == null) return;
            foreach (T info in lst)
            {
                Orm.Utilities.Common.SetPropertyValue(info, key, value);
            }
        }


        /// <summary>
        /// 过滤是否包含与指定字符串的对象
        /// </summary>
        /// <param name="key">属性名</param>
        /// <param name="value">值，包含</param>
        /// <param name="equal">条件false为是否包含,true则不包含</param>
        /// <returns>过滤后的List</returns>
        public static List<M> FilterInclude<M>(this List<M> lst, string key, string value, bool equal) where M : class, new()
        {
            List<M> list = new List<M>();
            foreach (var info in lst)
            {
                object propertyValue = Orm.Utilities.Common.GetPropertyValue(info, key);
                if (propertyValue == null)
                { 
                    continue;
                }

                if (!equal)
                {
                    if (propertyValue.ToString().IndexOf(value) >= 0) list.Add(info);
                }
                else
                {
                    if (Orm.Utilities.Common.IsNumeric(propertyValue.ToString()) && propertyValue.ToString().IndexOf(value) != 0)
                    {
                        list.Add((M)info);
                    }
                    if ((!Orm.Utilities.Common.IsNumeric(propertyValue.ToString())) && propertyValue.ToString().IndexOf(value) < 0)
                    {
                        list.Add((M)info);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 取多少位小数值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="digit">精度值</param>
        /// <returns></returns>
        public static double Round(this double obj, int digit)
        {
            return Math.Round(obj, digit);
        }
        /// <summary>
        /// 对 source 的每个元素执行指定操作.
        /// </summary>
        /// <typeparam name="T">source 中的元素类型</typeparam>
        /// <param name="obj">数据源.</param>
        /// <param name="action">需要执行的逻辑方法.</param>
        public static void Foreach<T>(this IEnumerable<T> source, Action<T, int> action)
        {
            int index = 0;
            foreach (var item in source)
            {
                action(item, index++);
            }
        }

        /// <summary>
        /// 获取去掉可空类型（Nullable<>）的类型.
        /// </summary>
        /// <param name="type">当前类型的实例对象.</param>
        /// <returns>去掉可空类型（Nullable<>）的类型.</returns>
        public static Type GetNoneNullableType(this Type type)
        {
            if (IsNullable(type))
            {
                return Nullable.GetUnderlyingType(type);
            }
            return type;
        }

        /// <summary>
        /// 获取可空类型（Nullable<>）的类型.
        /// </summary>
        /// <param name="type">当前类型的实例对象.</param>
        /// <returns>可空类型（Nullable<>）的类型.</returns>
        public static Type GetNullableType(this Type type)
        {
            if (!IsNullable(type) && type.IsValueType)
            {
                return typeof(Nullable<>).MakeGenericType(type);
            }
            return type;
        }

        /// <summary>
        /// 获取一个值, 通过该值指示当前类型是否为可空类型（Nullable<>）.
        /// </summary>
        /// <param name="type">当前类型的实例对象.</param>
        /// <returns>
        ///   <c>true</c> 表示为可空类型（Nullable<>）; 否则返回 <c>false</c>.
        /// </returns>
        public static bool IsNullable(this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        /// <summary>
        /// DataTable转化成对应结构对象集合
        /// </summary>
        /// <typeparam name="T">要转化成的类型</typeparam>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static List<T> TableToList<T>(this DataTable tb) where T : class, new()
        {
            List<T> newListObj = new List<T>();
            if (tb == null) return newListObj;
            try
            {
                BindingFlags BINDING_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.GetField | BindingFlags.SetField;
                PropertyInfo[] newObjProperties = typeof(T).GetProperties(BINDING_FLAGS);
                //先找出DataTable与Model的列匹配
                Dictionary<string, Type> ht = FindSameColomnName(tb, newObjProperties);
                foreach (DataRow dr in tb.Rows)
                {
                    T newObject = new T();
                    foreach (var p in newObjProperties)
                    {
                        if (ht.ContainsKey(p.Name))
                        {
                            if (ht[p.Name] != typeof(byte[]))
                            {
                                string strValue = dr[p.Name].ToString();
                                if (ht[p.Name] == typeof(string))
                                {
                                    p.SetValue(newObject, strValue, null);
                                }
                                else if (p.PropertyType == typeof(long))
                                {
                                    long value;
                                    long.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(decimal))
                                {
                                    decimal value;
                                    decimal.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(int))
                                {
                                    int value;
                                    int.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(DateTime))
                                {
                                    DateTime value;
                                    DateTime.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(float))
                                {
                                    float value;
                                    float.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(double))
                                {
                                    double value;
                                    double.TryParse(strValue, out value);
                                    p.SetValue(newObject, value, null);
                                }
                                else if (p.PropertyType == typeof(bool))
                                {
                                    bool value;
                                    int result = 0;
                                    if (int.TryParse(strValue, out result))
                                    {
                                        if (result > 0)
                                        {
                                            p.SetValue(newObject, true, null);
                                        }
                                        else
                                        {
                                            p.SetValue(newObject, false, null);
                                        }
                                    }
                                    else
                                    {
                                        bool.TryParse(strValue, out value);
                                        p.SetValue(newObject, value, null);
                                    }
                                }
                                else
                                {
                                    p.SetValue(newObject, strValue, null);
                                }
                            }
                            else
                            {
                                if (dr[p.Name].GetType().Name != "DBNull")
                                {
                                    p.SetValue(newObject, dr[p.Name], null);
                                }
                            }
                        }
                    }
                    newListObj.Add(newObject);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return newListObj;
        }

        /// <summary>
        /// List集合转换为DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ListToDataTable<T>(this IEnumerable<T> list)
        {
            //创建属性的集合    
            List<PropertyInfo> pList = new List<PropertyInfo>();
            //获得反射的入口    

            Type type = typeof(T);
            DataTable dt = new DataTable();
            //把所有的public属性加入到集合 并添加DataTable的列    
            Array.ForEach<PropertyInfo>(type.GetProperties(), p => { pList.Add(p); dt.Columns.Add(p.Name, p.PropertyType); });
            foreach (var item in list)
            {
                //创建一个DataRow实例    
                DataRow row = dt.NewRow();
                //给row 赋值    
                pList.ForEach(p => row[p.Name] = p.GetValue(item, null));
                //加入到DataTable    
                dt.Rows.Add(row);
            }
            return dt;
        }


        /// <summary>
        /// 转化成对应结构对象
        /// </summary>
        /// <typeparam name="M">要转化成的类型</typeparam>
        /// <param name="thisObj"></param>
        /// <returns></returns>
        public static T ConvertTo<T>(this object thisObj) where T : class, new()
        {
            if (thisObj == null) return null;
            BindingFlags BINDING_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.GetField | BindingFlags.SetField;
            T newObject = new T();
            PropertyInfo[] newObjProperties = newObject.GetType().GetProperties(BINDING_FLAGS);
            PropertyInfo[] curObjProperties = thisObj.GetType().GetProperties(BINDING_FLAGS);
            try
            {
                foreach (var pro in curObjProperties)
                {

                    var newPro = newObjProperties.FirstOrDefault(t => t.Name == pro.Name);
                    if (newPro != null)
                    {
                        if (newPro.GetType() == pro.GetType())
                        {
                            object value = pro.GetValue(thisObj, null);
                            newPro.SetValue(newObject, value, null);
                        }
                    }

                }
            }
            catch { }

            return newObject;
        }

        /// <summary>
        /// 不区分大小写，判断字符串值相等
        /// </summary>
        public static bool EqualsIgnoreCase(this string source, string value)
        {
            return EqualsIgnoreCase(source, value, false);
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> list)
        {
            var c = new ObservableCollection<T>();
            foreach (var e in list)
            {
                c.Add(e);
            }
            return c;
        }
        /// <summary>
        /// 将指定集合的元素添加到 System.Collections.ObjectModel.ObservableCollection&lt;T&gt; 的末尾。
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"> </param>
        /// <param name="collection">一个集合，其元素应被添加到 System.Collections.ObjectModel.ObservableCollection&lt;T&gt; 的末尾。集合自身不能为 null，但它可以包含为 null 的元素（如果类型 T 为引用类型）。</param>
        public static void AddRange<TSource>(this System.Collections.ObjectModel.ObservableCollection<TSource> source, IEnumerable<TSource> collection)
        {
            if (source == null)
            {
                throw new Exception("source is null");
            }
            if ((collection != null))
            {
                using (IEnumerator<TSource> enumerator = collection.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        source.Add(enumerator.Current);
                    }
                }
            }
        }

        #region 私有方法
        /// <summary>
        /// 查找DataTable和实体之间相同的属性，返回一个HashTabel，key：model的列名，value：datatable列类型
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        private static Dictionary<string, Type> FindSameColomn(DataTable tb, PropertyInfo[] props)
        {
            Dictionary<string, Type> ht = new Dictionary<string, Type>();
            foreach (DataColumn dc in tb.Columns)
            {
                var prop = props.First(t => t.Name.EqualsIgnoreCase(dc.ColumnName));
                if (prop == null) continue;
                if (prop.PropertyType == dc.DataType)
                {
                    ht.Add(prop.Name, dc.DataType);
                }
            }
            return ht;
        }

        /// <summary>
        /// 查找DataTable和实体之间相同的属性名称，返回一个HashTabel，key：model的列名，value：model列类型
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        private static Dictionary<string, Type> FindSameColomnName(DataTable tb, PropertyInfo[] props)
        {
            Dictionary<string, Type> ht = new Dictionary<string, Type>();
            foreach (DataColumn dc in tb.Columns)
            {
                var prop = props.FirstOrDefault(t => t.Name.EqualsIgnoreCase(dc.ColumnName));
                if (prop == null)
                {
                    continue;
                }
                ht.Add(prop.Name, prop.PropertyType);
            }
            return ht;
        }

        private static bool EqualsIgnoreCase(this string source, string value, bool ignoreNullOrEmpty)
        {
            if (ignoreNullOrEmpty && string.IsNullOrEmpty(source) && string.IsNullOrEmpty(value))
            {
                return true;
            }
            return string.Equals(source, value, StringComparison.CurrentCultureIgnoreCase);
        }
        #endregion
    }
}
