using ServiceStack.Text;
using StackExchange.Redis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Redis
{
    public class RedisReadExHelper
    {
        private static string ExchangeName { get; set; }
        private static string Routingkey { get; set; }
        static RedisReadExHelper()
        {
            ExchangeName = ConfigurationManager.AppSettings["Orm.RabbitMQ.ExchangeName"].ToString();
            Routingkey = ConfigurationManager.AppSettings["Orm.RabbitMQ.Routingkey"].ToString();
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
            if (RedisReadHelper.KeyExists(key))
            {
                var result = RedisReadHelper.SetMembers<T>(key);//内存取数
                return result;
            }
            return value;
        }

        public void ImportDataToSet<T>(string key, List<T> value) where T : class, new()
        {
            if (value.Count() > 0)
            {
                ArrayList arrayList = new ArrayList();

                RedisValue[] redisValues = new RedisValue[] { };
                foreach (var item in value)
                {
                    //RedisHelper.SetAddAsync(key, JsonSerializer.SerializeToString(item)).Wait();
                    //RedisHelper.SetAdd(key, JsonSerializer.SerializeToString(item));
                    RedisValue redisValue = (RedisValue)JsonSerializer.SerializeToString(item);
                    arrayList.Add(redisValue);
                }
                redisValues = (RedisValue[])arrayList.ToArray(typeof(RedisValue));
                RedisWriteHelper.SetMutiAdd(key, redisValues);
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
        public static bool SetAdd<T>(string key, T value, string sql, string user, string HospitalID, string tableName)
        {
            bool b = false;
            if (RedisWriteHelper.KeyExists(key))
            {
                try
                {
                    var result = RedisWriteHelper.SetAddAsync(key, JsonSerializer.SerializeToString(value));
                    if (result.Result)
                    {
                        //MsgSyncRecord msgRecord = new MsgSyncRecord() { HospitalID = Convert.ToInt32(HospitalID), tableName = tableName, cacheKey = key, oldValue = "", newValue = JsonSerializer.SerializeToString(value), curUser = user, sqlRecord = sql, updateTime = DateTime.Now.ToString("yyyyMMddhhmmss") };
                        //Producer.Topic(ExchangeName, Routingkey, msgRecord);//发消息 
                    }
                    b = result.Result;
                }
                catch (Exception)
                {
                    RedisWriteHelper.SetRemoveAsync(key, JsonSerializer.SerializeToString(value)).Wait();
                    return false;
                }
            }
            return b;
        }
        //从集合中删除元素
        public static bool SetRemove<T>(string key, T value, string sql, string user, string HospitalID, string tableName)
        {
            bool b = false;
            if (RedisWriteHelper.KeyExists(key))
            {
                try
                {
                    var result = RedisWriteHelper.SetRemoveAsync(key, JsonSerializer.SerializeToString(value));
                    if (result.Result)
                    {
                        //MsgSyncRecord msgRecord = new MsgSyncRecord() { HospitalID = Convert.ToInt32(HospitalID), tableName = tableName, cacheKey = key, oldValue = "", newValue = JsonSerializer.SerializeToString(value), curUser = user, sqlRecord = sql, updateTime = DateTime.Now.ToString("yyyyMMddhhmmss") };
                       // Producer.Topic(ExchangeName, Routingkey, msgRecord);//发消息
                    }
                    b = result.Result;
                }
                catch (Exception)
                {
                    RedisWriteHelper.SetAddAsync(key, JsonSerializer.SerializeToString(value)).Wait();
                    return false;
                }
            }
            return b;
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
                            //MsgSyncRecord msgRecord = new MsgSyncRecord() { HospitalID = Convert.ToInt32(HospitalID), tableName = tableName, cacheKey = key, oldValue = JsonSerializer.SerializeToString(oldValue), newValue = JsonSerializer.SerializeToString(newValue), curUser = user, sqlRecord = sql, updateTime = DateTime.Now.ToString("yyyyMMddhhmmss") };
                            //Producer.Topic(ExchangeName, Routingkey, msgRecord);//发消息
                        }
                        b = isSuccess.Result;
                    }
                }
                catch (Exception)
                {
                    RedisWriteHelper.SetRemoveAsync(key, JsonSerializer.SerializeToString(newValue)).Wait();
                    RedisWriteHelper.SetAddAsync(key, JsonSerializer.SerializeToString(oldValue)).Wait();
                    return false;
                }
            }
            return b;
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
            //else
            //{
            //    value = _dbService.DataRepository.GetQueryable<T>().ToList();//数据取数据
            //    if (value.Count() > 0)
            //    {
            //        foreach (var item in value)
            //        {
            //            RedisWriteHelper.SetHash<T>(key, item.GUID, item);
            //        }
            //    }
            //}
            return value;
        }

        public static string GetHashKeyValue(string hashId, string key)
        {
            return RedisReadHelper.Get(hashId, key);
        }
        #endregion

        #endregion

    }
}
