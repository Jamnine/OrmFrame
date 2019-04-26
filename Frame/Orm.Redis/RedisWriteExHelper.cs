using ServiceStack.Text;
using StackExchange.Redis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Orm.Log4Library;
using Orm.Model;

namespace Orm.Redis
{
    public class RedisWriteExHelper
    {
        public static object lockObj = new object();
        private static string ExchangeName { get; set; }
        private static string Routingkey { get; set; }
        private static string RedisDefaultKey { get; set; }
        static RedisWriteExHelper()
        {
            ExchangeName = ConfigurationManager.AppSettings["Orm.RabbitMQ.ExchangeName"].ToString();
            Routingkey = ConfigurationManager.AppSettings["Orm.RabbitMQ.Routingkey"].ToString();
            RedisDefaultKey = ConfigurationManager.AppSettings["Redis.DefaultKey"].ToString();
        }

        #region 操作相关

        #region 取数
        //根据IQueryable，获取一条数据
        public static T GetModelByIQueryable<T>(string key, IQueryable<T> query, string HospitalID, string tableName) where T : class, new()
        {
            T value = null;
            if (RedisWriteHelper.KeyExists(key))
            {
                var result = RedisWriteHelper.StringGetAsync<T>(key);//内存取数
                return result.Result;
            }
            else
            {
                try
                {
                    value = query.FirstOrDefault();//数据取数据
                    RedisWriteHelper.SetAsync(key, value).Wait();//加到内存里
                }
                catch (Exception)
                {
                    return value;
                }
            }
            return value;
        }

        #endregion

        #region crud set
        //获取指定的类型的所有数据
        public static List<T> RetrieveSet<T>(string key) where T : class, new()
        {
            var value = new List<T>();
            if (RedisWriteHelper.KeyExists(key))
            {
                var result = RedisWriteHelper.SetMembersAsync<T>(key);//内存取数
                return result.Result;
            }
            return value;
        }

        /// <summary>
        /// 将数据库数据导入到redis
        /// </summary>
        /// <typeparam name="T">表类型</typeparam>
        /// <param name="key">表的model类名</param>
        /// <param name="value">表记录</param>
        /// <param name="relationColumns">表外键</param>
        public void ImportDataToSet<T>(string key, List<T> value, string[] relationColumns, int recordCount) where T : class, new()
        {
            if (value.Count() > 0)
            {
                ArrayList arrayList = new ArrayList();
                RedisValue[] redisValues = new RedisValue[] { };
                PropertyInfo property;
                Type classType = typeof(T);
                //表属性
                PropertyInfo[] propertyInfoArray = classType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                string RedisConditionKeys = "";//查询条件keys
                int k = 0;
                Dictionary<string, object> recordDic = null;
                foreach (var item in value)
                {//循环表记录
                    string RedisConditionValus = ""; //查询条件values
                                                     //给RedisConditionValus字段赋值   
                    property = propertyInfoArray.FirstOrDefault(t => t.Name.ToUpper() == "HOSPITALID");
                    if (property != null)
                    {
                        object propertyValue = property.GetValue(item);
                        if (propertyValue != null)
                            RedisConditionValus += propertyValue.ToString() + ",";
                        if (k == 0)
                            RedisConditionKeys += "HospitalId,";
                    }
                    property = propertyInfoArray.FirstOrDefault(t => t.Name.ToUpper() == "NAME");
                    if (property != null)
                    {
                        object propertyValue = property.GetValue(item);
                        if (propertyValue != null)
                            RedisConditionValus += propertyValue.ToString() + ",";
                        if (k == 0)
                            RedisConditionKeys += "Name,";
                    }
                    property = propertyInfoArray.FirstOrDefault(t => t.Name.ToUpper() == "CODE");
                    if (property != null)
                    {
                        object propertyValue = property.GetValue(item);
                        if (propertyValue != null)
                            RedisConditionValus += propertyValue.ToString() + ",";
                        if (k == 0)
                            RedisConditionKeys += "Code,";
                    }
                    foreach (string relationColumn in relationColumns)
                    {
                        property = propertyInfoArray.FirstOrDefault(t => t.Name.ToUpper() == relationColumn.ToUpper());
                        if (property != null)
                        {
                            object propertyValue = property.GetValue(item);
                            if (propertyValue != null)
                                RedisConditionValus += propertyValue.ToString() + ",";
                            if (k == 0)
                                RedisConditionKeys += relationColumn + ",";
                        }
                    }
                    property = propertyInfoArray.FirstOrDefault(t => t.Name.ToUpper() == "ISACTIVE");
                    if (property != null)
                    {
                        object propertyValue = property.GetValue(item);
                        if (propertyValue != null)
                            RedisConditionValus += propertyValue.ToString().ToLower() + ",";
                        if (k == 0)
                            RedisConditionKeys += "IsActive";
                    }
                    if (RedisConditionValus.EndsWith(","))
                        RedisConditionValus = RedisConditionValus.Substring(0, RedisConditionValus.Length - 1);
                    property = classType.GetProperty("RedisConditionValus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    property.SetValue(item, RedisConditionValus);

                    //去掉带图片的字段
                    recordDic = new Dictionary<string, object>();
                    string guid = null;
                    foreach (PropertyInfo propertyInfo in propertyInfoArray)
                    {
                        if (propertyInfo.PropertyType.FullName == "System.Byte[]")
                        {
                            continue;
                        }
                        if (propertyInfo.Name == "GUID")
                        {
                            guid = propertyInfo.GetValue(item).ToString();
                        }

                        recordDic.Add(propertyInfo.Name, propertyInfo.GetValue(item));
                    }

                    //string rowsJson = Newtonsoft.Json.JsonConvert.SerializeObject(recordDic);
                    //RedisWriteHelper.SetHash(key, guid, rowsJson);

                    RedisValue redisValue = (RedisValue)JsonSerializer.SerializeToString(recordDic);
                    arrayList.Add(redisValue);
                    k++;
                }
                if (arrayList.Count > 30000)
                {
                    ArrayList arrayListPartOne = arrayList.GetRange(0, 20000);
                    ArrayList arrayListPartTwo = arrayList.GetRange(20000, arrayList.Count - 20000);

                    redisValues = (RedisValue[])arrayListPartOne.ToArray(typeof(RedisValue));
                    RedisWriteHelper.SetMutiAdd(key, redisValues);

                    redisValues = (RedisValue[])arrayListPartTwo.ToArray(typeof(RedisValue));
                    RedisWriteHelper.SetMutiAdd(key, redisValues);
                }
                else
                {
                    redisValues = (RedisValue[])arrayList.ToArray(typeof(RedisValue));
                    RedisWriteHelper.SetMutiAdd(key, redisValues);
                }

                if (RedisConditionKeys != "")
                {
                    if (RedisConditionKeys.EndsWith(","))
                        RedisConditionKeys = RedisConditionKeys.Substring(0, RedisConditionKeys.Length - 1);
                    RedisWriteHelper.SetHash<T>(RedisDefaultKey, key, RedisConditionKeys);
                }
            }
        }

        //根据IQueryable，获取指定的类型的部分数据
        //public static List<T> RetrieveSetByIQueryable<T>(string key, IQueryable<T> query) where T : class, new()
        public static List<T> RetrieveSetByIQueryable<T>(string key, IQueryable<T> query) where T : Orm.Model.BaseModel, new()
        {
            var value = new List<T>();
            if (RedisWriteHelper.KeyExists(key))
            {
                var result = RedisWriteHelper.SetMembersAsync<T>(key);//内存取数
                return result.Result;
            }
            else
            {
                value = query.ToList();//数据取数据
                if (value.Count() > 0)
                {
                    foreach (var item in value)
                    {
                        RedisWriteHelper.SetAddAsync(key, JsonSerializer.SerializeToString(item)).Wait();
                        //RedisHelper.SetHash<T>(key, item.GUID, item);
                        //RedisHelper.SetAsync(item.GUID, item).Wait();
                    }
                }
            }
            return value;
        }

        //添加到集合
        public static bool SetAdd(string key, string guid, string value)
        {
            lock (lockObj)
            {
                bool b = false;
                try
                {
                    //var result = RedisWriteHelper.SetAddAsync(key, JsonSerializer.SerializeToString(value));
                    var result = RedisWriteHelper.SetAdd(key, value);
                    b = result;
                }
                catch (Exception ex)
                {
                    LogHelper.ErrorLog(string.Format("SetAdd失败,key:{0},guid:{1},错误信息:{2}", key, guid, ex.ToString()));
                }
                return b;
            }
        }

        //从集合中删除元素
        public static bool SetRemove<T>(string key, T value, string sql, string user, string HospitalID, string tableName)
        {
            bool b = false;
            if (RedisWriteHelper.KeyExists(key))
            {
                try
                {
                    var result = RedisWriteHelper.SetRemove(key, JsonSerializer.SerializeToString(value));
                    if (result)
                    {
                        //BsMsgRecord msgRecord = new BsMsgRecord() { HospitalID = Convert.ToInt32(HospitalID), tableName = tableName, cacheKey = key, oldValue = "", newValue = JsonSerializer.SerializeToString(value), curUser = user, sqlRecord = sql, updateTime = DateTime.Now.ToString("yyyyMMddhhmmss") };
                        //Producer.Topic(ExchangeName, Routingkey, msgRecord);//发消息
                    }
                    b = result;
                }
                catch (Exception)
                {
                    RedisWriteHelper.SetAdd(key, JsonSerializer.SerializeToString(value));
                    return false;
                }
            }
            return b;
        }

        public static bool SetRemove(string key, string guid, string value)
        {
            lock (lockObj)
            {
                bool b = false;
                try
                {
                    //var result = RedisWriteHelper.SetRemoveAsync(key, value);
                    //b = result.Result;
                    b = RedisWriteHelper.SetRemove(key, value);
                }
                catch (Exception ex)
                {
                    LogHelper.ErrorLog(string.Format("SetRemoveAsync失败,key:{0},guid:{1},错误信息:{2}", key, guid, ex.ToString()));
                }
                return b;
            }
        }

        public static bool SetRemove(string key, string guid)
        {
            lock (lockObj)
            {
                bool b = false;
                try
                {
                    List<object> list = RedisReadExHelper.SetSearch(key, 0, "\"GUID\":\"" + guid + "\"", 1000000);
                    if (list.Count > 0)
                    {
                        var result = RedisWriteHelper.SetRemoveAsync(key, list[0].ToString());
                        b = result.Result;
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.ErrorLog(string.Format("SetRemoveAsync失败,key:{0},guid:{1},错误信息:{2}", key, guid, ex.ToString()));
                }
                return b;
            }
        }


        //更新集合
        public static bool SetUpdate<T>(string key, T oldValue, T newValue, string sql, string user, string HospitalID, string tableName)
        {
            bool b = false;
            if (RedisWriteHelper.KeyExists(key))
            {
                try
                {
                    var result = RedisWriteHelper.SetRemoveAsync(key, JsonSerializer.SerializeToString(oldValue));
                    if (result.Result)
                    {
                        var isSuccess = RedisWriteHelper.SetAddAsync(key, JsonSerializer.SerializeToString(newValue));
                        if (isSuccess.Result)
                        {
                            //BsMsgRecord msgRecord = new BsMsgRecord() { HospitalID = Convert.ToInt32(HospitalID), tableName = tableName, cacheKey = key, oldValue = JsonSerializer.SerializeToString(oldValue), newValue = JsonSerializer.SerializeToString(newValue), curUser = user, sqlRecord = sql, updateTime = DateTime.Now.ToString("yyyyMMddhhmmss") };
                            //Producer.Topic(ExchangeName, Routingkey, msgRecord);//发消息
                        }
                        b = isSuccess.Result;
                    }
                }
                catch (Exception)
                {
                    RedisWriteHelper.SetRemove(key, JsonSerializer.SerializeToString(newValue));
                    RedisWriteHelper.SetAdd(key, JsonSerializer.SerializeToString(oldValue));
                    return false;
                }
            }
            return b;
        }

        public static bool SetUpdate(string key, string guid, string value)
        {
            lock (lockObj)
            {
                bool b = false;
                try
                {
                    List<object> list = RedisReadExHelper.SetSearch(key, 0, "\"GUID\":\"" + guid + "\"", 1000000);
                    if (list.Count > 0)
                    {
                        var result = RedisWriteHelper.SetRemoveAsync(key, list[0].ToString());

                        if (result.Result)
                        {
                            var isSuccess = RedisWriteHelper.SetAddAsync(key, value);
                            b = isSuccess.Result;
                        }
                    }
                    else
                    {
                        var isSuccess = RedisWriteHelper.SetAddAsync(key, value);
                        b = isSuccess.Result;
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.ErrorLog(string.Format("SetUpdate失败,key:{0},guid:{1},错误信息:{2}", key, guid, ex.ToString()));
                }
                return b;
            }
        }

        //从集合中模糊查找
        public static List<T> SetSearch<T>(string key, int cursor, string pattern, int count)
        {
            var value = new List<T>();
            if (RedisWriteHelper.KeyExists(key))
            {
                value = RedisWriteHelper.SetScan<T>(key, cursor, pattern, count);
            }
            return value;
        }

        //从集合中模糊查找
        public static List<Object> SetSearch(string key, int cursor, string pattern, int count)
        {
            var value = new List<object>();
            if (RedisWriteHelper.KeyExists(key))
            {
                value = RedisWriteHelper.SetScan(key, cursor, pattern, count);
            }
            return value;
        }

        //从Hash中模糊查找
        public static List<T> HashSearch<T>(string key, int cursor, string pattern, int count)
        {
            var value = new List<T>();
            if (RedisWriteHelper.KeyExists(key))
            {
                value = RedisWriteHelper.HashScan<T>(key, cursor, pattern, count);
            }
            return value;
        }

        //获取指定的HashTable
        public static List<T> RetrieveHash<T>(string key) where T : Orm.Model.BaseModel, new()
        {
            var value = new List<T>();
            if (RedisWriteHelper.KeyExists(key))
            {
                var result = RedisWriteHelper.GetAll<T>(key);//内存取数
                return result;
            }
            return value;
        }
        #endregion

        #endregion

    }
}
