using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace Orm.Redis
{
    public class RedisReadBusiHelper
    {
        public readonly object SyncObj = new object();
                
        /// <summary>
        /// 添加Hash数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="dataKey"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static bool AddForHash<T>(T data, string dataKey, string Key = "") where T : class, new()
        {
            var TypeArg = typeof(T).GenericTypeArguments;
            string _key = TypeArg.Count() <= 0 ? typeof(T).Name : TypeArg[0].Name;
            Key = string.IsNullOrWhiteSpace(Key) ? TypeArg.Count() <= 0 ? _key + "_Day" : _key + "_List_Day" : Key;
            if (RedisReadHelper.IsExist(Key, dataKey))
            {
                RedisReadHelper.Remove(Key, dataKey);
            }
            return RedisReadHelper.SetHash<T>(Key, dataKey, data);
        }
        /// <summary>
        /// 添加Sets数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static bool AddForSets<T>(T entity, string Key = "") where T : class, new()
        {
            var TypeArg = typeof(T).GenericTypeArguments;
            string _key = TypeArg.Count() <= 0 ? typeof(T).Name : TypeArg[0].Name;
            Key = string.IsNullOrWhiteSpace(Key) ? TypeArg.Count() <= 0 ? _key + "_Day" : _key + "_List_Day" : Key;
            if (RedisReadHelper.SetAdd<T>(Key, entity))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取Hash所有数据 For Dictionary
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static Dictionary<string, T> HashGetAll<T>(string Key = "")
        {
            var TypeArg = typeof(T).GenericTypeArguments;
            string _key = TypeArg.Count() <= 0 ? typeof(T).Name : TypeArg[0].Name;
            Key = string.IsNullOrWhiteSpace(Key) ? TypeArg.Count() <= 0 ? _key + "_Day" : _key + "_List_Day" : Key;
            return RedisReadHelper.HashGetAll<T>(Key);
        }

        /// <summary>
        /// 获取hash数据键值数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="QueryDB"></param>
        /// <param name="Datakey"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static T HashGet<T>(T QueryDB, string Datakey, string Key = "") where T : class, new()
        {
            var TypeArg = typeof(T).GenericTypeArguments;
            string _key = TypeArg.Count() <= 0 ? typeof(T).Name : TypeArg[0].Name;
            Key = string.IsNullOrWhiteSpace(Key) ? TypeArg.Count() <= 0 ? _key + "_Day" : _key + "_List_Day" : Key;
            var item = RedisReadHelper.HashGet<T>(Key, Datakey);
            if (item == null)
            {
                if (QueryDB != null)
                {
                    item = QueryDB;
                    AddForHash<T>(item, Datakey, Key);
                }
            }
            return item;
        }

        /// <summary>
        /// 获取Sets所有数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> SetsGetAll<T>(string Key = "") where T : class, new()
        {
            var TypeArg = typeof(T).GenericTypeArguments;
            string _key = TypeArg.Count() <= 0 ? typeof(T).Name : TypeArg[0].Name;
            Key = string.IsNullOrWhiteSpace(Key) ? TypeArg.Count() <= 0 ? _key + "_Day" : _key + "_List_Day" : Key;
            var item = RedisReadHelper.SetMembers<T>(Key);
            if (item.Count <= 0)
            {
                return item;
            }
            return new List<T>();
        }
        /*/// <summary>
        /// 获取Sets单条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="GuID"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static T SetsGet<T>(T QueryDB, string GuID, string Key = "") where T : class, new()
        {
            var TypeArg = typeof(T).GenericTypeArguments;
            string _key = TypeArg.Count() <= 0 ? typeof(T).Name : TypeArg[0].Name;
            Key = string.IsNullOrWhiteSpace(Key) ? TypeArg.Count() <= 0 ? _key + "_Day" : _key + "_List_Day" : Key;
            var rdsitem = RedisReadHelper.SetScan<T>(Key, 0, GuID, 2);
            var item = rdsitem.Count > 0 ? rdsitem[0] : null;
            if (item == null)
            {
                if (QueryDB != null)
                {
                    item = QueryDB;
                    AddForSets<T>(item);
                    //GuID = item.GetType().GetProperty("GUID").GetValue(item).ToString();
                    //rdsitem = RedisReadHelper.SetScan<T>(key, 0, GuID, 2);
                    //if (rdsitem.Count <= 0)

                }
            }
            return item;
        }

        /// <summary>
        /// 获取Sets数据列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strVal"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static List<T> SetsGetList<T>(string strVal, string Key = "") where T : class, new()
        {
            var TypeArg = typeof(T).GenericTypeArguments;
            string _key = TypeArg.Count() <= 0 ? typeof(T).Name : TypeArg[0].Name;
            Key = string.IsNullOrWhiteSpace(Key) ? TypeArg.Count() <= 0 ? _key + "_Day" : _key + "_List_Day" : Key;
            return RedisReadHelper.SetScan<T>(Key, 0, strVal, 50000);
        }*/
    }
}
