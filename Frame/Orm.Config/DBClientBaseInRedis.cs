using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Orm.Framework.Services;
using Orm.Log4Library;
using Orm.Model;
using Orm.Redis;

namespace Orm.Config
{
    public class DBClientBaseInRedis
    {
        public static List<T> GetList<T>(string where, params object[] arr) where T : class, new()
        {
            string modelTypeStr = typeof(T).Name;
            try
            {   //构建pattern
                if (AppSettings.IsEnableRedis)
                {
                    string pattern = GetPattern<T>(where, modelTypeStr, arr);
                    if (pattern != "")
                    {//pattern如果为空，将从数据库中查询
                        List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, pattern, 10000);
                        return list.Count == 0 ? Service.DBClientService.GetList<T>(where, arr) : list;
                    }
                }
                return Service.DBClientService.GetList<T>(where, arr);
            }
            catch (Exception ex)
            {//如果出现异常，将从数据库中查询
                LogHelper.ErrorLog(ex.ToString());
                return Service.DBClientService.GetList<T>(where, arr);
            }
        }


        /// <summary>
        ///  返回 业务表 整表数据   该方法仅仅用于业务表的取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<T> GetOuList<T>(string where, params object[] arr) where T : class, new()
        {
            string modelTypeStr = typeof(T).Name;
            try
            {   //构建pattern
                if (AppSettings.IsEnableRedis)
                {
                    string pattern = GetPattern<T>(where, modelTypeStr, arr);
                    if (pattern != "")
                    {//pattern如果为空，将从数据库中查询
                        List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, pattern, 10000);
                        return  list;
                    }
                }
                return Service.DBClientService.GetList<T>(where, arr);
            }
            catch (Exception ex)
            {//如果出现异常，将从数据库中查询
                LogHelper.ErrorLog(ex.ToString());
                return   Service.DBClientService.GetList<T>(where, arr);
            }
        }

        /// <summary>
        /// 返回整表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetAllList<T>() where T : class, new()
        {
            try
            {
                string modelTypeStr = typeof(T).Name;
                if (AppSettings.IsEnableRedis)
                {
                    List<T> list = RedisReadExHelper.RetrieveSet<T>(modelTypeStr);
                    return list.Count == 0 ? Service.DBClientService.GetAllList<T>() : list;
                }
                else
                {
                    return Service.DBClientService.GetAllList<T>();
                }
            }
            catch (Exception ex)
            {
                LogHelper.ErrorLog(ex.ToString());
                return   new List<T>();
            }
          
        }

        /// <summary>
        /// 传入查询字段条件，查询,例：Get<BsUser>("Code = @0 or Code=@1", "251","999999");
        /// </summary>
        /// <typeparam name="T">泛型，对应的实体</typeparam>
        /// <param name="where">查询条件</param>
        /// <param name="arr">条件的值</param>
        /// <returns></returns>
        public static T Get<T>(string where, params object[] arr) where T : BaseModel, new()
        {
            try
            {
                string modelTypeStr = typeof(T).Name;
                if (AppSettings.IsEnableRedis)
                {
                    //构建pattern
                    string pattern = GetPattern<T>(where, modelTypeStr, arr);
                    if (pattern != "")
                    {//pattern如果为空，将从数据库中查询
                        List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, pattern, 10000);
                        return list.Count == 0 ? Service.DBClientService.Get<T>(where, arr) : list[0];
                    }
                }  
                return Service.DBClientService.Get<T>(where, arr);
            }
            catch (Exception ex)
            {//如果出现异常，将从数据库中查询
                LogHelper.ErrorLog(ex.ToString());
                return Service.DBClientService.Get<T>(where, arr);
            }
        }

        public static T GetModelByGuid<T>(string guid) where T : BaseModel, new()
        {
            
            try
            {
                string modelTypeStr = typeof(T).Name;
                if (AppSettings.IsEnableRedis)
                {
                    List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, guid, 10000);
                    return list.Count == 0 ? Service.DBClientService.GetModelByGuid<T>(guid) : list[0];
                }
                return Service.DBClientService.GetModelByGuid<T>(guid);
            }
            catch (Exception ex)
            {//如果出现异常，将从数据库中查询
                LogHelper.ErrorLog(ex.ToString());
                return Service.DBClientService.GetModelByGuid<T>(guid);
            }

        }

        /// <summary>
        /// 传入查询Lambda表达式的字符串,例：GetListByLambda &lt;Model.BsUser&gt;( "Code = @0", false, "999999")
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <param name="queryDb"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<T> GetListByLambda<T>(string where, bool queryDb, params object[] arr) where T : BaseModel, new()
        {
            List<T> lstReturn = null;          

            List<T> list = new List<T>(); 
                if (queryDb)
                {
                    lock (locker)
                    {
                        lstReturn = Orm.Config.Service.DBClientService.GetList<T>(where, arr);
                    }
                }
                else
                {
                    lstReturn = new List<T>();
                }           
            if (lstReturn != null)
                lstReturn = ReflectionHelper.OrderBy<T>(lstReturn, "Name");
            return lstReturn;
        }

        /// <summary>
        /// 同步锁
        /// </summary>
        private static object locker;
        #region reids判断
        /// <summary>
        /// 获取redis查询的pattern，eg:"\"Name\":\"公里\""
        /// </summary>
        /// <param name="where">eg：Name=@0 and CardNo = @1 and IsActive</param>
        /// <param name="modelTypeStr">hash中的key,用于在redis获取查询字段, eg:BsHouse</param>
        /// <param name="arr">查询参数的值集合</param>
        /// <returns></returns>
        static string GetPattern<T>(string where, string modelTypeStr, params object[] arr) where T : class, new()
        {
            string pattern = "";
            string where_lower = where.ToLower();
            if (where_lower.Contains("or") || where_lower.Contains("||") || where_lower.Contains("&&"))
                return "";

            #region 暂时不用
            /*
             * 获取redis中的表的查询字段，eg:HospitalID,Name,CareGroupId,DocLevId,LevelId,IsActive;其中HospitalID,Name,IsActive是很多基础表都有的字段,
             * 很多表的查询是基于这三个字段进行查询，中间的那几个字段是一些外键，在二级联动、三级联动中可能会用到。
             */
            //string redisSearchConditionStr = null;//RedisReadExHelper.GetHashKeyValue(AppSettings.RedisDefaultKey, modelTypeStr);
            //if (redisSearchConditionStr != null)
            //{//在redis中有记录查询条件
            //    string[] redisSearchConditionKeys = redisSearchConditionStr.Split(',');
            //    string redisSearchConditionStr_lower = redisSearchConditionStr.ToLower();
            //    string keys = "RedisConditionValus";//pattern中的key
            //    string values = "";//pattern中的value
            //    //通过正则表达式分析where语句
            //    Regex rege = new Regex(@"[A-Za-z0-9]+(\s)?=(\s)?@[0-9]");
            //    MatchCollection Matches = rege.Matches(where);//Name=@0  CardNo = @1
            //    bool isAllContain = true;//Name,CardNo,IsActive是否都包含在redisSearchConditionStr中,默认为true
            //    bool isBaseComBox = true;
            //    foreach (Match NextMatch in Matches)
            //    {
            //        isBaseComBox = false;
            //        string str = NextMatch.Groups[0].Value;
            //        int k = str.IndexOf("=");
            //        string file = str.Substring(0, k).Trim();
            //        if (!redisSearchConditionStr_lower.Contains(file.ToLower()))
            //        {
            //            isAllContain = false;
            //            break;
            //        }
            //    }
            //    if (!isAllContain)
            //    {
            //        if (where_lower.Contains("isactive") && arr == null)
            //            isAllContain = true;//只有IsActive一个查询条件的情况
            //    }
            //    if (isBaseComBox)
            //    {
            //        GeneratePattern<T>(where, ref pattern, where_lower, redisSearchConditionKeys, keys, ref values, isBaseComBox);
            //    }
            //    else
            //    {
            //        //下面将结合where和redisSearchConditionKeys构建pattern
            //        GeneratePattern<T>(where, arr, ref pattern, where_lower, redisSearchConditionKeys, keys, ref values, isAllContain);
            //    }

            //}
            #endregion
            //else
            //{//在redis中没有记录查询条件
            if (arr.Length == 1)
            {
                int k = where.IndexOf("=");
                string key = where.Substring(0, k).Trim();
                if (key.EndsWith("!"))
                    key = key.Substring(0, key.Length - 1);
                PropertyInfo propertyInfo = typeof(T).GetProperty(key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (propertyInfo != null)
                {
                    if (propertyInfo.PropertyType.Name == "String")
                        pattern = "\"" + key + "\":\"" + arr[0].ToString() + "\"";
                    else
                        pattern = "\"" + key + "\":" + arr[0].ToString() + "";
                }
            }
            else
            {
                string[] strArray = where.Split('=');
                if (strArray.Length > 1 && strArray.Length < 3)
                {
                    PropertyInfo propertyInfo = typeof(T).GetProperty(strArray[0], BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (propertyInfo.PropertyType.Name == "String")
                        pattern = "\"" + strArray[0] + "\":\"" + strArray[1].ToString() + "\"";
                    else
                        pattern = "\"" + strArray[0] + "\":" + strArray[1].ToString() + "";

                }
            }
            //}
            return pattern;
        }

        /// <summary>
        /// 结合where和redisSearchConditionKeys构建pattern
        /// </summary>
        private static void GeneratePattern<T>(string where, object[] arr, ref string pattern, string where_lower, string[] redisSearchConditionKeys, string keys, ref string values, bool isAllContain) where T : class, new()
        {
            int j = 0;
            if (isAllContain)
            {
                foreach (string s in redisSearchConditionKeys)
                {
                    if (where_lower.Contains(s.ToLower()))
                    {
                        if (s != "IsActive")
                        {
                            values += arr[j] + ",";
                            j++;
                        }
                        else
                        {
                            values += "true";
                        }
                    }
                    else
                    {//不包含的查询条件用*代替,表示可以是任何内容 eg:5037,*,true(可匹配查询条件为HospitalID,Name,【外键】,IsActive的情况)
                        if (!values.Contains("*,"))
                            values += "*,";
                    }
                }
                if (values.EndsWith(","))
                    values = values.Substring(0, values.Length - 1);
                pattern = "\"" + keys + "\":\"" + values + "\"";
            }
            else
            {
                if (arr.Length == 1)
                {
                    int k = where.IndexOf("=");
                    string key = where.Substring(0, k).Trim();
                    if (key.EndsWith("!")) //有些条件是以fild!=@0形式出现的
                        key = key.Substring(0, key.Length - 1);
                    PropertyInfo propertyInfo = typeof(T).GetProperty(key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.PropertyType.Name == "String")
                            pattern = "\"" + key + "\":\"" + arr[0].ToString() + "\"";
                        else
                            pattern = "\"" + key + "\":" + arr[0].ToString() + "";
                    }
                }
            }
        }


        string[] _expTypes = new string[] { "||", "!", "Contains", "GreaterThan", ">", "GreaterThanOrEqual", ">=", "LessThan", "<", "LessThanOrEqual", "<=", "NotEqual", "<>", "Or" };
        internal string GetExpPattern<T>(string where, string modelTypeStr) where T : class, new()
        {
            string pattern = "";
            foreach (string expType in _expTypes)
            {
                if (where.Contains(expType))
                    return "";
            }
            where = where.Substring(3, where.Length - 3);
            /*
             * 获取redis中的表的查询字段，eg:HospitalID,Name,CareGroupId,DocLevId,LevelId,IsActive;其中HospitalID,Name,IsActive是很多基础表都有的字段,
             * 很多表的查询是基于这三个字段进行查询，中间的那几个字段是一些外键，在二级联动、三级联动中可能会用到。
             */
            string redisSearchConditionStr = RedisReadExHelper.GetHashKeyValue(AppSettings.RedisDefaultKey, modelTypeStr);
            string[] fileArr = new string[10];
            string[] valueArr = new string[10];
            if (redisSearchConditionStr != null)
            {//在redis中有记录查询条件
                string[] redisSearchConditionKeys = redisSearchConditionStr.Split(',');
                string keys = "RedisConditionValus";//pattern中的key
                string values = "";//pattern中的value
                //通过正则表达式分析where语句
                Regex rege = new Regex(@"[A-Za-z].[A-Za-z0-9]+(\s)?=(\s)?(\S)+");
                MatchCollection Matches = rege.Matches(where);//t.Name = "张三"  t.ClassName= "四(2)班"
                bool isAllContain = true;//Name,ClassName是否都包含在redisSearchConditionStr中,默认为true
                int i = 0;
                foreach (Match NextMatch in Matches)
                {
                    string str = NextMatch.Groups[0].Value;
                    int k = str.IndexOf("=");
                    string file = str.Substring(0, k).Trim().Substring(2);//去掉空格和t. eg:Name
                    string fileValue = str.Substring(k + 1).Trim();//eg:\"张三\"
                    fileValue = fileValue.Trim(new char[] { '\"' });//eg:张三
                    valueArr[i] = fileValue;
                    fileArr[i] = file;
                    i++;
                    if (!redisSearchConditionStr.Contains(file))
                    {
                        isAllContain = false;
                        break;
                    }
                }
                if (!isAllContain)
                {
                    if (where.Contains("IsActive") && where.Length < 14)
                        isAllContain = true;//只有IsActive一个查询条件的情况
                }
                //下面将结合where和redisSearchConditionKeys构建pattern
                GenerateExpPattern<T>(where, fileArr, valueArr, ref pattern, redisSearchConditionKeys, keys, ref values, isAllContain);
            }
            else
            {//在redis中没有记录查询条件
                if (valueArr.Length == 1)
                {
                    if (where.Contains("IsActive")) //eg:"t => t.IsActive AndAlso t.ClassName = \"四(2)班\""
                        return "";
                    //下面处理形如："t => t.IsActive AndAlso t.ClassName = \"四(2)班\""
                    string key = fileArr[0];
                    PropertyInfo propertyInfo = typeof(T).GetProperty(key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.PropertyType.Name == "String")
                            pattern = "\"" + key + "\":\"" + valueArr[0].ToString() + "\"";
                        else
                            pattern = "\"" + key + "\":" + valueArr[0].ToString() + "";
                    }
                }
            }
            return pattern;
        }


        /// <summary>
        /// 结合where和redisSearchConditionKeys构建pattern
        /// </summary>
        private void GenerateExpPattern<T>(string where, string[] fileArr, string[] valueArr, ref string pattern, string[] redisSearchConditionKeys, string keys, ref string values, bool isAllContain) where T : class, new()
        {
            int j = 0;
            if (isAllContain)
            {
                foreach (string s in redisSearchConditionKeys)
                {
                    if (where.Contains(s))
                    {
                        if (s != "IsActive")
                        {
                            values += valueArr[j] + ",";
                            j++;
                        }
                        else
                        {
                            values += "true";
                        }
                    }
                    else
                    {//不包含的查询条件用*代替,表示可以是任何内容 eg:5037,*,true(可匹配查询条件为HospitalID,Name,【外键】,IsActive的情况)
                        if (!values.Contains("*,"))
                            values += "*,";
                    }
                }
                if (values.EndsWith(","))
                    values = values.Substring(0, values.Length - 1);
                pattern = "\"" + keys + "\":\"" + values + "\"";
            }
            else
            {
                if (valueArr.Length == 1)
                {
                    if (where.Contains("IsActive")) //eg:"t => t.IsActive AndAlso t.ClassName = \"四(2)班\""
                    {
                        pattern = "";
                        return;
                    }
                    //下面处理形如："t => t.IsActive AndAlso t.ClassName = \"四(2)班\""
                    string key = fileArr[0];
                    PropertyInfo propertyInfo = typeof(T).GetProperty(key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.PropertyType.Name == "String")
                            pattern = "\"" + key + "\":\"" + valueArr[0].ToString() + "\"";
                        else
                            pattern = "\"" + key + "\":" + valueArr[0].ToString() + "";
                    }
                }
            }
        }

        #endregion
    }
}
