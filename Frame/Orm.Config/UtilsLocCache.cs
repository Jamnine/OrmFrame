using Orm.Framework.Services;
using Orm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Orm.Config
{
    /// <summary>
    /// 读取本地缓存数据类
    /// (本地缓存的key默认情况下与服务器的key值保持一致)
    /// </summary>
    public static class UtilsLocCache
    {
        /// <summary>
        /// 同步锁
        /// </summary>
        private static object locker;
        /// <summary>
        /// 本地缓冲
        /// </summary>
        private static Dictionary<string, object> cache;

        public static Dictionary<string, object> Cache
        {
            get { return UtilsLocCache.cache; }
            set { UtilsLocCache.cache = value; }
        }

        /// <summary>
        /// 记录对应缓冲是否需要更新数据
        /// </summary>
        private static Dictionary<string, bool> updateDic;

        public static Dictionary<string, bool> UpdateDic
        {
            get { return UtilsLocCache.updateDic; }
            set { UtilsLocCache.updateDic = value; }
        }

        #region 私有方法
        static UtilsLocCache()
        {
            cache = new Dictionary<string, object>();
            updateDic = new Dictionary<string, bool>();
            //  service = Orm.Config.Service.DBClientService;
            // cacheService = Orm.Config.Service.RemoteCache;
            locker = new object();
        }


        ///// <summary>
        ///// 从服务器更新部分条件的数据
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //private static IList<T> GetDataFromService<T>(Expression<Func<T, bool>> where) where T : BaseModel, new()
        //{
        //    var obj = service.GetList<T>(where);
        //    return obj;
        //}
        /// <summary>
        /// 从服务器更新表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        //private static IList<T> GetDataFromService<T>() where T : class,new()
        //{
        //    var obj = service.GetAllList<T>();
        //    return obj;
        //}
        #endregion

        #region 初始化
        /// <summary>
        /// 加载缓存服务器的数据到本地
        /// </summary>
        public static void InitCache()
        {
            //try
            //{
            //    var lst = cacheService.GetClientCacheKey();
            //    foreach (string key in lst.Keys)
            //    {
            //        AddEntity(cacheService, key, cache);
            //    }
            //}
            //catch
            //{ }
        }

        private static void AddEntity<T>(string key, Dictionary<string, object> dict) where T : class, new()
        {
            if (dict.ContainsKey(key))
            {
                return;
            }
            #region
            var lstItem = new List<T>();
            if (typeof(T) == typeof(Orm.Model.Custom.BsPatientCache))
            {
                var dt = Orm.Config.Service.DBClientService.GetServerTime().Date;
                if (Global.CanSeeIllness)
                {
                    //lstItem = Orm.Config.Service.OutpatientRegistrationService.GetPatientListByDate(dt.AddMonths(-3), dt.Date,Config.UserProfiles.HospitalID) as List<T>;
                }
                else
                {
                    //lstItem = Orm.Config.Service.OutpatientRegistrationService.GetPatientListByDate(dt.AddMonths(-3), dt.Date, Config.UserProfiles.HospitalID).Where(t=>!t.IsHideIllness).ToList() as List<T>;

                }
            }
            else if (typeof(T) == typeof(Orm.Model.Custom.OuHosInfoCache))
            {
                //lstItem = Orm.Config.Service.OutpatientRegistrationService.SearchOuHosInfoByDate(DateTime.Now, DateTime.Now) as List<T>;
            }
            else
                lstItem = Orm.Config.Service.DBClientService.GetAllList<T>();
            if (dict.ContainsKey(key))
            {
                return;
            }
            dict.Add(key, lstItem);
            #endregion
        }


        /// <summary>
        /// 手动设置本地缓存，设置时key值请保持与服务器key一致
        /// </summary>
        public static void InitCache<T>(string key) where T : class, new()
        {
            // 初始化时先根据key查 cache服务器
            //object data = cacheService.GetCacheList<T>(key);
            //if (data == null)
            //{
            //}
            //else
            //{
            //    if (data != null && data is IList && ((IList)data).Count > 0)
            //    {
            //        cache.Add(key, data);
            //    }

            //}
        }

        public static void RefreshCache<T>(List<T> list) where T : class, new()
        {
            var key = typeof(T).Name;
            if (cache.ContainsKey(key))
            {
                cache.Remove(key);
                cache.Add(key, list);
            }
        }

        #endregion

        #region 公有方法
        /// <summary>
        /// 根据条件获取数据集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        private static List<T> GetCache<T>(string key, Expression<Func<T, bool>> where, bool queryDb) where T : BaseModel, new()
        {
            //在缓存服务没有加载完成的情况下调用。
            if (!cache.ContainsKey(key))
            {
                AddEntity<T>(key, cache);
                if (!updateDic.ContainsKey(key))
                    updateDic.Add(key, false);
            }
            else if (UpdateDic.ContainsKey(key))
            {
                if (UpdateDic[key])
                {
                    Cache.Remove(key);//先去掉
                    AddEntity<T>(key, cache);//再添加 等于更新数据
                    UpdateDic[key] = false;
                }
            }
            List<T> list = new List<T>();
            if (cache.ContainsKey(key))
            {

                list = cache[key] as List<T>;
                if (list != null && list.Count > 0)
                {
                    var whereList = list.Where(where.Compile());
                    if (whereList != null && whereList.Count() > 0)
                    {
                        return whereList.ToList();
                    }
                    else
                    {
                        if (queryDb)
                        {
                            lock (locker)
                            {

                                ////当前条件没有cache数据时，从服务器中获取数据并更新到cache
                                ////update cache
                                //var data = GetDataFromService<T>();
                                //list.AddRange(data);
                                //return data.ToList();

                                return new List<T>();
                            }
                        }
                        else
                        {
                            return new List<T>();
                        }
                    }
                }
                else
                {
                    if (queryDb)
                    {
                        lock (locker)
                        {
                            //////当前条件没有cache数据时，从服务器中获取数据并更新到cache
                            //////update cache
                            //var data = GetDataFromService<T>(where);
                            //if (list == null)
                            //    list = new List<T>();
                            //list.AddRange(data);
                            //return data.ToList();
                            return new List<T>();
                        }
                    }
                    else
                    {
                        return new List<T>();
                    }
                }
            }
            else
            {
                if (queryDb)
                {
                    lock (locker)
                    {
                        ////当前没有cache数据时，从服务器中获取数据并更新到cache
                        ////update cache
                        //var data = GetDataFromService<T>(where);
                        //if (list == null)
                        //    list = new List<T>();
                        //list.AddRange(data);
                        //return data.ToList();
                        return new List<T>();
                    }
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// 根据条件获取数据集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <param name="queryDb">当需要查数据库传入false</param>
        /// <returns></returns>
        public static List<T> GetCache<T>(Expression<Func<T, bool>> where, bool queryDb = true) where T : BaseModel, new()
        {
            string key = typeof(T).Name;
            return GetCache(key, where, queryDb);
        }
        /// 根据ID获取单个数据
        /// </summary>  
        public static T GetCacheByID<T>(string ID) where T : BaseModel, new()
        {
            //T info;  
            //string key = typeof(T).Name + "_" + ID;
            //info = (T)cache[key];
            //if (info == null) info = new T();
            //return info;
            List<T> TList = GetCache<T>(m => m.GUID == ID);
            T info = new T();
            if (TList.Count > 0)
            {
                info = TList.FirstOrDefault();
                //if (info == null) info = new T();
            }
            return info;
        }

        /// <summary>
        /// 添加到内存当中
        /// </summary>
        /// <param name="key"></param>
        /// <param name="keyValue"></param>
        public static void AddCache(string key, object keyValue)
        {
            // cacheService.GetCacheList<>
            cache.Add(key, keyValue);
        }

        /// <summary>
        /// 根据条件获取数据集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="queryDb">判断是否需要查数据库</param>
        /// <returns></returns>
        public static List<T> GetCacheAll<T>(string key, bool queryDb = true) where T : class, new()
        {
            //在缓存服务没有加载完成的情况下调用。
            if (!cache.ContainsKey(key))
            {
                AddEntity<T>(key, cache);
            }
            if (cache.ContainsKey(key))
            {
                var list = (IEnumerable<T>)cache[key];
                if (list != null && list.Count() > 0)
                {
                    var whereList = list;
                    if (whereList != null && whereList.Count() > 0)
                    {
                        return whereList.ToList();
                    }
                    else
                    {
                        if (queryDb)
                        {
                            lock (locker)
                            {
                                //当前条件没有cache数据时，从服务器中获取数据并更新到cache
                                //update cache
                                //var data = GetDataFromService<T>(where);
                                //list.AddRange(data);
                                //return data.ToList();
                                return new List<T>();
                            }
                        }
                        else
                        {
                            return new List<T>();
                        }
                    }
                }
                else
                {
                    return new List<T>();
                }
            }
            else
            {
                lock (locker)
                {
                    //当前没有cache数据时，从服务器中获取数据并更新到cache
                    //update cache
                    //var data = GetDataFromService<T>();
                    //cache.Add(key, data);
                    //return data.Where(where).ToList();
                    return new List<T>();
                }

            }
        }

        /// <summary>
        /// 根据条件获取数据集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="queryDb">判断是否需要查数据库</param>
        /// <returns></returns>
        public static List<T> GetCacheAll<T>(bool queryDb = true) where T : class, new()
        {
            string key = typeof(T).Name;
            //在缓存服务没有加载完成的情况下调用。
            if (!cache.ContainsKey(key))
            {
                AddEntity<T>(key, cache);
            }
            //获取缓存中的数据
            if (cache.ContainsKey(key))
            {
                var list = (IEnumerable<T>)cache[key];
                if (list != null && list.Count() > 0)
                {
                    var whereList = list;
                    if (whereList != null && whereList.Count() > 0)
                    {
                        return whereList.ToList();
                    }
                    else
                    {
                        if (queryDb)
                        {
                            lock (locker)
                            {
                                return new List<T>();
                            }
                        }
                        else
                        {
                            return new List<T>();
                        }
                    }
                }
                else
                {
                    return new List<T>();
                }
            }
            else
            {
                lock (locker)
                {
                    //当前没有cache数据时，从服务器中获取数据并更新到cache
                    return new List<T>();
                }

            }
        }
        /// <summary>
        /// 根据条件获取单个数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        private static T GetCacheEntity<T>(string key, Expression<Func<T, bool>> where) where T : BaseModel, new()
        {
            var data = GetCache<T>(where);
            return data.FirstOrDefault();
        }

        /// <summary>
        /// 根据条件获取单个数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetCacheEntity<T>(Expression<Func<T, bool>> where) where T : BaseModel, new()
        {
            var data = GetCache<T>(where);
            if (data.Count > 0)
                return data.FirstOrDefault();
            else
                return new T();//default(T);
        }


        /// <summary>
        /// 刷新缓存中数据的实体对象
        /// </summary>
        /// <typeparam name="T">传入的实体类类型</typeparam>
        /// <param name="model">传入的实体类</param>
        public static void RenewCacheEntity<T>(T model) where T : BaseModel, new()
        {
            string key = typeof(T).Name;
            if (cache.ContainsKey(key))
            {
                if (cache[key] != null)
                {
                    List<T> list = cache[key] as List<T>;
                    if (list.Find(t => t.GUID == model.GUID) != null && !string.IsNullOrWhiteSpace(model.GUID))
                        list.Remove("GUID", model.GUID.ToString()); //移除旧的数据
                    list.Insert(0, model);//增加新的数据
                    cache[key] = list;

                }
            }
        }

        /// <summary>
        /// 移除缓存中数据的实体对象
        /// </summary>
        /// <typeparam name="T">传入的实体类类型</typeparam>
        /// <param name="model">传入的实体类</param>
        public static void RemoveCacheEntityByID<T>(string ID) where T : BaseModel, new()
        {
            string key = typeof(T).Name;
            if (cache.ContainsKey(key))
            {
                if (cache[key] != null)
                {
                    List<T> list = cache[key] as List<T>;
                    if (list.Find(t => t.GUID == ID) != null)
                        list.Remove("GUID", ID.ToString()); //移除旧的数据 
                    cache[key] = list;

                }
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
            string key = typeof(T).Name;
            if (queryDb)
                cache.Remove(key);
            //在缓存服务没有加载完成的情况下调用。
            if (!cache.ContainsKey(key))
            {
                AddEntity<T>(key, cache);
                if (!updateDic.ContainsKey(key))
                    updateDic.Add(key, false);
            }
            else if (UpdateDic.ContainsKey(key))
            {
                if (UpdateDic[key])
                {
                    Cache.Remove(key);//先去掉
                    AddEntity<T>(key, cache);//再添加 等于更新数据
                    UpdateDic[key] = false;
                }
            }

            List<T> list = new List<T>();
            if (cache.ContainsKey(key))
            {

                list = cache[key] as List<T>;
                if (string.IsNullOrEmpty(where))
                {
                    lstReturn = list;
                }
                else
                {
                    if (list != null && list.Count > 0)
                    {
                        var whereList = list.AsQueryable().Where(where, arr);
                        if (whereList != null && whereList.Count() > 0)
                        {
                            //return whereList.ToList();
                            lstReturn = whereList.ToList();
                        }
                        else
                        {
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
                        }
                    }
                    else
                    {
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
                    }
                }
            }
            else
            {
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
            }
            if (lstReturn != null)
                lstReturn = ReflectionHelper.OrderBy<T>(lstReturn, "Name");
            return lstReturn;
        }

        /// <summary>
        /// 通知更新缓冲,会在下次调用缓冲时更新
        /// </summary>
        /// <param name="key"></param>
        public static void NeedUpdate(string key)
        {
            if (Cache.ContainsKey(key))
            {
                if (UpdateDic.ContainsKey(key))
                {
                    updateDic[key] = true;
                }
                else
                {
                    updateDic.Add(key, true);
                }
            }

        }

        #endregion
    }
}
