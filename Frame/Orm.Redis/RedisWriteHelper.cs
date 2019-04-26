using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.Text;
using StackExchange.Redis;

namespace Orm.Redis
{
    public partial class RedisWriteHelper
    {
        public const string DefaultOrder = "desc";

        #region Strings

        #region 同步
        public static bool KeyExists(string key)
        {
            var bResult = Cache.KeyExists(key);
            return bResult;
        }

        public static bool SetExpire(string key, DateTime datetime)
        {
            return Cache.KeyExpire(key, datetime);
        }

        public static bool SetExpire(string key, int timeout = 0)
        {
            return Cache.KeyExpire(key, DateTime.Now.AddSeconds(timeout));
        }

        public static bool Set<T>(string key, T t, int timeout = 0)
        {
            var value = ConvertJson(t);// JsonSerializer.SerializeToString(t);
            var result = Cache.StringSet(key, value);
            if (timeout > 0)
            {
                Cache.KeyExpire(key, DateTime.Now.AddSeconds(timeout));
            }
            return result;
        }

        public static string Get(string key)
        {
            string value = Cache.StringGet(key);
            return value;
        }

        public static bool KeyDelete(string key)
        {
            return Cache.KeyDelete(key);
        }

        public static bool KeyRename(string oldKey, string newKey)
        {
            return Cache.KeyRename(oldKey, newKey);
        }

        /// <summary>
        /// 添加单个key value
        /// </summary>
        /// <param name="key">Redis Key</param>
        /// <param name="value">保存的值</param>
        /// <param name="expiry">过期时间</param>
        /// <returns></returns>
        public static bool StringSet(string key, string value)
        {            
            return Cache.StringSet(key, value);
        }

        /// <summary>
        /// 添加多个key/value
        /// </summary>
        /// <param name="valueList">key/value集合</param>
        /// <returns></returns>
        public static bool StringSet(Dictionary<string, string> valueList)
        {
            var newkeyValues = valueList.Select(p => new KeyValuePair<RedisKey, RedisValue>((p.Key), p.Value)).ToArray();
            return Cache.StringSet(newkeyValues);
        }

        /// <summary>
        /// 保存一个对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="key">保存的Key名称</param>
        /// <param name="value">对象实体</param>
        /// <param name="expiry">过期时间</param>
        /// <returns></returns>
        public static bool StringSet<T>(string key, T value)
        {
            string jsonValue = ConvertJson(value);
            return Cache.StringSet(key, jsonValue);
        }

        /// <summary>
        /// 在原有key的value值之后追加value
        /// </summary>
        /// <param name="key">追加的Key名称</param>
        /// <param name="value">追加的值</param>
        /// <returns></returns>
        public static long StringAppend(string key, string value)
        {            
            return Cache.StringAppend(key, value);
        }

        /// <summary>
        /// 获取单个key的值
        /// </summary>
        /// <param name="key">要读取的Key名称</param>
        /// <returns></returns>
        public static string StringGet(string key)
        {            
            return Cache.StringGet(key);
        }

        /// <summary>
        /// 获取多个key的value值
        /// </summary>
        /// <param name="keys">要获取值的Key集合</param>
        /// <returns></returns>
        public static List<string> StringGet(params string[] keys)
        {
            var newKeys = ConvertRedisKeysAddSysCustomKey(keys);
            var values = Cache.StringGet(newKeys);
            return values.Select(o => o.ToString()).ToList();
        }

        /// <summary>
        /// 获取单个key的value值
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="key">要获取值的Key集合</param>
        /// <returns></returns>
        public static T StringGet<T>(string key)
        {            
            var values = Cache.StringGet(key);
            return ConvertObj<T>(values);
        }

        /// <summary>
        /// 获取多个key的value值
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="keys">要获取值的Key集合</param>
        /// <returns></returns>
        public static List<T> StringGet<T>(params string[] keys)
        {
            var newKeys = ConvertRedisKeysAddSysCustomKey(keys);
            var values = Cache.StringGet(newKeys);
            return ConvetList<T>(values);
        }

        /// <summary>
        /// 获取旧值赋上新值
        /// </summary>
        /// <param name="key">Key名称</param>
        /// <param name="value">新值</param>
        /// <returns></returns>
        public static string StringGetSet(string key, string value)
        {            
            return Cache.StringGetSet(key, value);
        }

        /// <summary>
        /// 获取旧值赋上新值
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="key">Key名称</param>
        /// <param name="value">新值</param>
        /// <returns></returns>
        public static T StringGetSet<T>(string key, T value)
        {            
            string jsonValue = ConvertJson(value);
            var oValue = Cache.StringGetSet(key, jsonValue);
            return ConvertObj<T>(oValue);
        }

        /// <summary>
        /// 获取值的长度
        /// </summary>
        /// <param name="key">Key名称</param>
        /// <returns></returns>
        public static long StringGetLength(string key)
        {            
            return Cache.StringLength(key);
        }

        /// <summary>
        /// 数字增长val，返回自增后的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val">可以为负</param>
        /// <returns>增长后的值</returns>
        public static double StringIncrement(string key, double val = 1)
        {            
            return Cache.StringIncrement(key, val);
        }

        /// <summary>
        /// 数字减少val，返回自减少的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val">可以为负</param>
        /// <returns>减少后的值</returns>
        public static double StringDecrement(string key, double val = 1)
        {            
            return Cache.StringDecrement(key, val);
        }
        #endregion

        #region 异步        

        public static async Task<bool> SetAsync<T>(string key, T t, int timeout = 0)
        {
            var value = JsonSerializer.SerializeToString(t);
            var result = await Cache.StringSetAsync(key, value);
            if (timeout > 0)
            {
                await Cache.KeyExpireAsync(key, DateTime.Now.AddSeconds(timeout));
            }
            return result;
        }

        public static async Task<T> StringGetAsync<T>(string key)
        {
            var value = await Cache.StringGetAsync(key);
            return JsonSerializer.DeserializeFromString<T>(Unescape(value));
        }
        #endregion

        #endregion
        
        #region Hashes

        #region 同步        
        public static bool IsExist(string hashId, string key)
        {
            return Cache.HashExists(hashId, key);
        }

        public static bool SetHash<T>(string hashId, string key, T t)
        {
            var value = ConvertJson<T>(t);// JsonSerializer.SerializeToString(t);
            return Cache.HashSet(hashId, key, value);
        }

        public static bool SetHash<T>(string hashId, string key, string conditonKeys)
        {
            return Cache.HashSet(hashId, key, conditonKeys);
        }

        /// <summary>
        /// 删除hash中的多个值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dataKeys"></param>
        /// <returns></returns>
        public static long HashDelete(string key, params string[] dataKeys)
        {
            var newValues = dataKeys.Select(o => (RedisValue)o).ToArray();
            return Cache.HashDelete(key, newValues);
        }

        /// <summary>
        /// 删除hash值
        /// </summary>
        /// <param name="hashId"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Remove(string hashId, string key)
        {
            return Cache.HashDelete(hashId, key);
        }

        public static long StringIncrement(string hashId, string key, long value = 1)
        {
            return Cache.HashIncrement(hashId, key, value);
        }
        /// <summary>
        /// 获取Hash
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="hashId"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(string hashId, string key)
        {
            string value = Cache.HashGet(hashId, key);
            //return JsonSerializer.DeserializeFromString<T>(value);
            return ConvertObj<T>(value);
        }

        public static long GetHashCount(string hashId)
        {
            var length = Cache.HashLength(hashId);
            return length;
        }

        public static List<T> GetAll<T>(string hashId)
        {
            var result = new List<T>();
            var list = Cache.HashGetAll(hashId).ToList();
            if (list.Count > 0)
            {
                list.ForEach(x =>
                {
                    var value = ConvertObj<T>(x.Value);// JsonSerializer.DeserializeFromString<T>(x.Value);
                    result.Add(value);
                });
            }
            return result;
        }

        public static List<string> GetAllFields(string hashId)
        {
            var result = new List<string>();
            var list = Cache.HashKeys(hashId).ToList();
            if (list.Count > 0)
            {
                list.ForEach(x =>
                {
                    var value = ConvertObj<string>(x); //JsonSerializer.DeserializeFromString<string>(x);
                    result.Add(value);
                });
            }
            return result;
        }

        /// <summary>
        /// 获取hashkey所有key与值，必须保证Key内的所有数据类型一致
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Dictionary<string, T> HashGetAll<T>(string key)
        {
            var query = Cache.HashGetAll(key);
            Dictionary<string, T> dic = new Dictionary<string, T>();
            foreach (var item in query)
            {
                dic.Add(item.Name, ConvertObj<T>(item.Value));
            }
            return dic;
        }

        public static List<T> HashScan<T>(string key, int cursor, string pattern, int count)
        {
            List<T> list = new List<T>();
            var result = Cache.ScriptEvaluate(LuaScript.Prepare("return redis.call('HSCAN',@key,@cursor,'MATCH',@pattern,'COUNT',@count)"), new { key = key, cursor = cursor, pattern = "*" + pattern + "*", count = count });
            if (!result.IsNull)
            {
                var vals = ((StackExchange.Redis.RedisResult[])((StackExchange.Redis.RedisResult[])result)[1]);
                foreach (var item in vals)
                {
                    //list.Add(JsonSerializer.DeserializeFromString<T>(Unescape(item.ToString())));
                    list.Add(ConvertObj<T>(Unescape(item.ToString())));
                }
            }
            return list;
        }
        #endregion

        #region 异步
        /// <summary>
        /// 判断某个数据是否已经被缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <returns></returns>
        public static async Task<bool> HashExistsAsync(string key, string dataKey)
        {
            return await Cache.HashExistsAsync(key, dataKey);
        }

        /// <summary>
        /// 存储数据到hash表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static async Task<bool> HashSetAsync<T>(string key, string dataKey, T t)
        {
            string json = ConvertJson(t);
            return await Cache.HashSetAsync(key, dataKey, json);
        }

        /// <summary>
        /// 移除hash中的某值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <returns></returns>
        public static async Task<bool> HashDeleteAsync(string key, string dataKey)
        {
            return await Cache.HashDeleteAsync(key, dataKey);
        }

        /// <summary>
        /// 移除hash中的多个值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dataKeys"></param>
        /// <returns></returns>
        public static async Task<long> HashDeleteAsync(string key, params string[] dataKeys)
        {
            var newValues = dataKeys.Select(o => (RedisValue)o).ToArray();
            return await Cache.HashDeleteAsync(key, newValues);
        }

        /// <summary>
        /// 从hash表获取数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <returns></returns>
        public static async Task<T> HashGetAsync<T>(string key, string dataKey)
        {
            string value = await Cache.HashGetAsync(key, dataKey);
            return ConvertObj<T>(value);
        }

        /// <summary>
        /// 异步方法 数字增长val，返回自增后的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <param name="val">可以为负</param>
        /// <returns>增长后的值</returns>
        public static async Task<double> HashIncrementAsync(string key, string dataKey, double val = 1)
        {
            return await Cache.HashIncrementAsync(key, dataKey, val);
        }

        /// <summary>
        /// 数字减少val，返回自减少的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <param name="val">可以为负</param>
        /// <returns>减少后的值</returns>
        public static async Task<double> HashDecrementAsync(string key, string dataKey, double val = 1)
        {
            return await Cache.HashDecrementAsync(key, dataKey, val);
        }

        /// <summary>
        /// 异步方法 获取hashkey所有key名称
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static async Task<string[]> HashKeysAsync(string key)
        {
            RedisValue[] values = await Cache.HashKeysAsync(key);
            return values.Select(o => o.ToString()).ToArray();
        }

        /// <summary>
        /// 获取hashkey所有key与值，必须保证Key内的所有数据类型一致
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static async Task<Dictionary<string, T>> HashGetAllAsync<T>(string key)
        {
            var query = await Cache.HashGetAllAsync(key);
            Dictionary<string, T> dic = new Dictionary<string, T>();
            foreach (var item in query)
            {
                dic.Add(item.Name, ConvertObj<T>(item.Value));
            }
            return dic;
        }
        #endregion

        #endregion

        #region Sets

        #region 同步
        public static bool SetAdd(string key, string value)
        {
            return Cache.SetAdd(key, value);
        }

        public static long SetMutiAdd(string key, RedisValue[] value)
        {
            return Cache.SetAdd(key, value);
        }

        /// <summary>
        /// 在Key集合中添加一个value值
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="key">Key名称</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        public static bool SetAdd<T>(string key, T value)
        {
            string jValue = ConvertJson(value);
            return Cache.SetAdd(key, jValue);
        }

        /// <summary>
        /// 在Key集合中添加多个value值
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="key">Key名称</param>
        /// <param name="value">值列表</param>
        /// <returns></returns>
        public static long SetAdd<T>(string key, List<T> value)
        {
            RedisValue[] valueList = ConvertRedisValue(value.ToArray());
            return Cache.SetAdd(key, valueList);
        }

        /// <summary>
        /// 判断Key集合中是否包含指定的值
        /// </summary>
        /// <typeparam name="T">值类型</typeparam>
        /// <param name="key"></param>
        /// <param name="value">要判断是值</param>
        /// <returns></returns>
        public static bool SetContains<T>(string key, T value)
        {
            string jValue = ConvertJson(value);
            return Cache.SetContains(key, jValue);
        }

        /// <summary>
        /// 删除key集合中指定的value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetRemove(string key, string value)
        {
            return Cache.SetRemove(key, value);
        }

        /// <summary>
        /// 删除key集合中指定的value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long SetRemove<T>(string key, params T[] value)
        {
            RedisValue[] valueList = ConvertRedisValue(value);
            return Cache.SetRemove(key, valueList);
        }
                
        /// <summary>
        /// 获取key集合中的一个值
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T SetRandomMember<T>(string key)
        {
            var rValue = Cache.SetRandomMember(key);
            return ConvertObj<T>(rValue);
        }

        //public static List<T> SetMembers<T>(string key)
        //{
        //    var result = new List<T>();
        //    var list = Cache.SetMembers(key).ToList();
        //    if (list.Count > 0)
        //    {
        //        list.ForEach(x =>
        //        {
        //            var value = JsonSerializer.DeserializeFromString<T>(x);
        //            result.Add(value);
        //        });
        //    }
        //    return result;
        //}

        /// <summary>
        /// 获取key所有值的集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static List<T> SetMembers<T>(string key)
        {
            var rValue = Cache.SetMembers(key);
            return ConvetList<T>(rValue);
        }

        //SetScan<Student>("T_Student",0,"\"StudentName\":\"张三\"",10000)  这里T_Student为key,0为cursor,"\"StudentName\":\"张三\""为pattern,10000为count
        public static List<T> SetScan<T>(string key, int cursor, string pattern, int count)
        {
            List<T> list = new List<T>();
            var result = Cache.ScriptEvaluate(LuaScript.Prepare("return redis.call('SSCAN',@key,@cursor,'MATCH',@pattern,'COUNT',@count)"), new { key = key, cursor = cursor, pattern = "*" + pattern + "*", count = count });
            if (!result.IsNull)
            {
                var vals = ((StackExchange.Redis.RedisResult[])((StackExchange.Redis.RedisResult[])result)[1]);
                foreach (var item in vals)
                {
                    //list.Add(JsonSerializer.DeserializeFromString<T>(Unescape(item.ToString())));
                    list.Add(ConvertObj<T>(Unescape(item.ToString())));
                }
            }
            return list;
        }

        public static List<object> SetScan(string key, int cursor, string pattern, int count)
        {
            List<object> list = new List<object>();
            var result = Cache.ScriptEvaluate(LuaScript.Prepare("return redis.call('SSCAN',@key,@cursor,'MATCH',@pattern,'COUNT',@count)"), new { key = key, cursor = cursor, pattern = "*" + pattern + "*", count = count });
            if (!result.IsNull)
            {
                var vals = ((StackExchange.Redis.RedisResult[])((StackExchange.Redis.RedisResult[])result)[1]);
                foreach (var item in vals)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public static List<T> SetScan<T>(string key, int cursor, string pattern, int count, out int nextCursor)
        {
            List<T> list = new List<T>();
            var result = Cache.ScriptEvaluate(LuaScript.Prepare("return redis.call('SSCAN',@key,@cursor,'MATCH',@pattern,'COUNT',@count)"), new { key = key, cursor = cursor, pattern = "*" + pattern + "*", count = count });
            nextCursor = 0;
            if (!result.IsNull)
            {
                nextCursor = (int)((StackExchange.Redis.RedisResult[])result)[0];
                var vals = ((StackExchange.Redis.RedisResult[])((StackExchange.Redis.RedisResult[])result)[1]);
                foreach (var item in vals)
                {
                    //list.Add(JsonSerializer.DeserializeFromString<T>(Unescape(item.ToString())));
                    list.Add(ConvertObj<T>(Unescape(item.ToString())));
                }
            }
            return list;
        }

        #endregion

        #region 异步
        public static async Task<bool> SetAddAsync(string key, string value)
        {
            return await Cache.SetAddAsync(key, value);
        }

        /// <summary>
        /// 在Key集合中添加一个value值
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="key">Key名称</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        public static async Task<bool> SetAddAsync<T>(string key, T value)
        {
            string jValue = ConvertJson(value);
            return await Cache.SetAddAsync(key, jValue);
        }
        /// <summary>
        /// 在Key集合中添加多个value值
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="key">Key名称</param>
        /// <param name="value">值列表</param>
        /// <returns></returns>
        public static async Task<long> SetAddAsync<T>(string key, List<T> value)
        {
            RedisValue[] valueList = ConvertRedisValue(value.ToArray());
            return await Cache.SetAddAsync(key, valueList);
        }
        /// <summary>
        /// 判断Key集合中是否包含指定的值
        /// </summary>
        /// <typeparam name="T">值类型</typeparam>
        /// <param name="key"></param>
        /// <param name="value">要判断是值</param>
        /// <returns></returns>
        public static async Task<bool> SetContainsAsync<T>(string key, T value)
        {
            string jValue = ConvertJson(value);
            return await Cache.SetContainsAsync(key, jValue);
        }

        /// <summary>
        /// 删除key集合中指定的value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static async Task<bool> SetRemoveAsync(string key, string value)
        {
            return await Cache.SetRemoveAsync(key, value);
        }

        /// <summary>
        /// 删除key集合中指定的value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static async Task<long> SetRemoveAsync<T>(string key, params T[] value)
        {
            RedisValue[] valueList = ConvertRedisValue(value);
            return await Cache.SetRemoveAsync(key, valueList);
        }

        /// <summary>
        /// 获取key集合中的一个值
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static async Task<T> SetRandomMemberAsync<T>(string key)
        {
            var rValue = await Cache.SetRandomMemberAsync(key);
            return ConvertObj<T>(rValue);
        }

        //public static async Task<List<T>> SetMembersAsync<T>(string key)
        //{
        //    var result = new List<T>();
        //    var redisValues = await Cache.SetMembersAsync(key);
        //    var list = redisValues.ToList();
        //    if (list.Count > 0)
        //    {
        //        list.ForEach(x =>
        //        {
        //            var value = JsonSerializer.DeserializeFromString<T>(x);
        //            result.Add(value);
        //        });
        //    }
        //    return result;
        //}

        /// <summary>
        /// 获取key所有值的集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static async Task<List<T>> SetMembersAsync<T>(string key)
        {
            var rValue = await Cache.SetMembersAsync(key);
            return ConvetList<T>(rValue);
        }

        #endregion

        #endregion

        #region Sorted Sets
        public static bool SortedSetItemIsExist(string setId, string item)
        {
            var value = GetItemScoreFromSortedSet(setId, item);
            if (value != null)
            {
                return true;
            }
            return false;
        }

        public static bool SortedSetAdd(string setId, string item, double score, int timeout = 0)
        {
            return Cache.SortedSetAdd(setId, item, score);
        }

        public static List<string> GetSortedSetRangeByRank(string setId, long fromRank, long toRank, string order = DefaultOrder)
        {
            var result = new List<string>();
            var list = Cache.SortedSetRangeByRank(setId, fromRank, toRank, order == Order.Descending.ToString().ToLower() ? Order.Descending : Order.Ascending).ToList();
            if (list.Any())
            {
                list.ForEach(x =>
                {
                    var value = JsonSerializer.DeserializeFromString<string>(x);
                    result.Add(value);
                });
            }
            return result;
        }

        public static List<T> GetSortedSetRangeByRankWithScores<T>(string setId, long fromRank, long toRank, string order = DefaultOrder)
        {
            var result = new List<T>();
            var list = Cache.SortedSetRangeByRankWithScores(setId, fromRank, toRank, order == Order.Descending.ToString().ToLower() ? Order.Descending : Order.Ascending).ToList();
            if (list.Any())
            {
                list.ForEach(x =>
                {
                    result.Add(JsonSerializer.DeserializeFromString<T>(x.Element));
                });
            }
            return result;
        }
        #region 备用
        //public static Dictionary<string, double> GetSortedSetRangeByRankWithScores(string setId, long fromRank, long toRank, string order = DefaultOrder)
        //{
        //    var result = new Dictionary<string, double>();
        //    var list = Cache.SortedSetRangeByRankWithScores(setId, fromRank, toRank, order == Order.Descending.ToString().ToLower() ? Order.Descending : Order.Ascending).ToList();
        //    if (list.Any())
        //    {
        //        list.ForEach(x =>
        //        {
        //            result.Add(x.Element, x.Score);
        //        });
        //    }
        //    return result;
        //} 
        #endregion
        public static List<string> GetSortedSetRangeByValue(string setId, long minValue, long maxValue)
        {
            var result = new List<string>();
            var list = Cache.SortedSetRangeByValue(setId, minValue, maxValue).ToList();
            if (list.Any())
            {
                list.ForEach(x =>
                {
                    var value = JsonSerializer.DeserializeFromString<string>(x);
                    result.Add(value);
                });
            }
            return result;
        }

        public static long GetSortedSetLength(string setId)
        {
            return Cache.SortedSetLength(setId);
        }

        public static long GetSortedSetLength(string setId, double minValue, double maxValue)
        {
            return Cache.SortedSetLength(setId, minValue, maxValue);
        }

        public static long? GetItemRankFromSortedSet(string setId, string item, string order = DefaultOrder)
        {
            return Cache.SortedSetRank(setId, item, order == Order.Descending.ToString().ToLower() ? Order.Descending : Order.Ascending);
        }

        public static double? GetItemScoreFromSortedSet(string setId, string item)
        {
            return Cache.SortedSetScore(setId, item);
        }

        public static double SetSortedSetItemIncrement(string setId, string item, double score = 1)
        {
            return Cache.SortedSetIncrement(setId, item, score);
        }

        public static double SortedSetItemDecrement(string setId, string item, double score = -1)
        {
            return Cache.SortedSetDecrement(setId, item, score);
        }

        public static bool RemoveItemFromSortedSet(string setId, string item)
        {
            return Cache.SortedSetRemove(setId, item);
        }

        public static long RemoveByRankFromSortedSet(string setId, long fromRank, long toRank)
        {
            return Cache.SortedSetRemoveRangeByRank(setId, fromRank, toRank);
        }

        public static long RemoveByScoreFromSortedSet(string setId, double minValue, double maxValue)
        {
            return Cache.SortedSetRemoveRangeByScore(setId, minValue, maxValue);
        }

        public static long RemoveByLexFromSortedSet(string setId, int minValue, int maxValue)
        {
            //TODO： Don't know its meaning
            //return Cache.SortedSetRemoveRangeByValue(setId, minValue, maxValue);
            return 0;
        }
        public static List<T> GetSortedSetByPattern<T>(string key, string pattern, int pageSize = 10, int pageOffset = 0)
        {
            var result = new List<T>();
            var list2 = Cache.SortedSetScan(key, pattern, pageSize, pageOffset);
            var list = list2.ToList();
            if (list.Any())
            {
                list.ForEach(x =>
                {
                    result.Add(JsonSerializer.DeserializeFromString<T>(x.Element));
                });
            }
            return result;
        }
        #endregion

        #region Lists

        public static long AddList<T>(string listId, T t)
        {
            var value = JsonSerializer.SerializeToString(t);
            return Cache.ListLeftPush(listId, value);
        }

        public static List<T> GetList<T>(string listId, long start = 0, long stop = -1)
        {
            var result = new List<T>();
            var list = Cache.ListRange(listId, start, stop).ToList();
            if (list.Count > 0)
            {
                list.ForEach(x =>
                {
                    var value = JsonSerializer.DeserializeFromString<T>(x);
                    result.Add(value);
                });
            }
            return result;
        }
        #endregion
                                
        #region Extend
        //使用Keys *模糊匹配Key
        public static List<string> GetKeys(string key)
        {
            var result = (string[])Cache.ScriptEvaluate(LuaScript.Prepare("return redis.call('KEYS',@keypattern)"), new { keypattern = key });
            return result.ToList();
        }
        /// <summary>
        /// 转义
        /// </summary>
        public static string Unescape(string input)
        {
            input = input.TrimStart(new char[] { '"' });
            input = input.TrimEnd(new char[] { '"' });
            //input = input.Replace("\\", "");
            input = input.Replace("\"[", "[");
            input = input.Replace("]\"", "]");
            input = input.Replace("\"{", "{");
            input = input.Replace("}\"", "}");
            input = input.Replace("\"Result\":\"\"", "\"Result\":\"");
            input = input.Replace("\"\",\"RequestTime\"", "\",\"RequestTime\"");
            return input;
        }

        /// <summary>
        /// 将对象转换成string字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        protected static string ConvertJson<T>(T value)
        {
            string result = value is string ? value.ToString() :
            Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.None);
            //JsonSerializer.SerializeToString<T>(value);
            return result;
        }
        /// <summary>
        /// 将值反系列化成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        protected static T ConvertObj<T>(RedisValue value)
        {
            return value.IsNullOrEmpty ? default(T) : Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value);
            //return value.IsNullOrEmpty ? default(T) : JsonSerializer.DeserializeFromString<T>(value);
        }

        /// <summary>
        /// 将值反系列化成对象集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        protected static List<T> ConvetList<T>(RedisValue[] values)
        {
            List<T> result = new List<T>();
            foreach (var item in values)
            {
                var model = ConvertObj<T>(item);
                result.Add(model);
            }
            return result;
        }
        /// <summary>
        /// 将string类型的Key转换成 <see cref="RedisKey"/> 型的Key
        /// </summary>
        /// <param name="redisKeys"></param>
        /// <returns></returns>
        protected static RedisKey[] ConvertRedisKeys(List<string> redisKeys) => redisKeys.Select(redisKey => (RedisKey)redisKey).ToArray();

        /// <summary>
        /// 将string类型的Key转换成 <see cref="RedisKey"/> 型的Key
        /// </summary>
        /// <param name="redisKeys"></param>
        /// <returns></returns>
        protected static RedisKey[] ConvertRedisKeys(params string[] redisKeys) => redisKeys.Select(redisKey => (RedisKey)redisKey).ToArray();

        /// <summary>
        /// 将string类型的Key转换成 <see cref="RedisKey"/> 型的Key，并添加前缀字符串
        /// </summary>
        /// <param name="redisKeys"></param>
        /// <returns></returns>
        protected static RedisKey[] ConvertRedisKeysAddSysCustomKey(params string[] redisKeys) => redisKeys.Select(redisKey => (RedisKey)redisKey).ToArray();
        /// <summary>
        /// 将值集合转换成RedisValue集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="redisValues"></param>
        /// <returns></returns>
        protected static RedisValue[] ConvertRedisValue<T>(params T[] redisValues) => redisValues.Select(o => (RedisValue)ConvertJson<T>(o)).ToArray();

        #endregion

    }
}
