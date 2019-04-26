using System;
using System.Collections;
using System.Collections.Generic;
using Orm.Framework.Services.SharedMemory;

namespace Orm.Framework.Services
{
    public class CacheHelper
    {
        private static Hashtable _hash = new Hashtable();

        public static bool ContainsKey(string key)
        {
            if (_hash.Count == 0)
            { 
                Init();
            }
            return _hash.ContainsKey(key);
        }

        public static Hashtable Caches
        {
            get
            {
                if (_hash.Count == 0)
                { 
                    Init();
                }
                return _hash;
            }
        }

        public static string NotifyPath
        {
            get
            {
                return "D:\\notify\\";
            }
        }

        private static void Init()
        {
            _hash = new Hashtable();
            _hash.Add("BsItem", "BsItem");
            _hash.Add("BsUser", "BsUser");
            _hash.Add("BsLocation", "BsLocation");
            _hash.Add("BsInvMzItem", "BsInvMzItem");
            _hash.Add("BsPayWay", "BsPayWay");
            _hash.Add("BsFrequency", "BsFrequency");
            _hash.Add("BsUsage", "BsUsage");
            _hash.Add("BsUnit", "BsUnit");
            _hash.Add("BsRoom", "BsRoom");
            _hash.Add("BsPatType", "BsPatType");
            _hash.Add("BsRegType", "BsRegType");
            _hash.Add("BsItemAttach", "BsItemAttach");
            _hash.Add("BsItemDrug", "BsItemDrug");
            _hash.Add("BsDrugForm", "BsDrugForm");
            _hash.Add("BsMzFeety", "BsMzFeety");
            _hash.Add("BsUsageItem", "BsUsageItem");
            _hash.Add("BsInvInItem", "BsInvInItem");
            _hash.Add("BsManufacturer", "BsManufacturer");
            _hash.Add("BsUnitRatio", "BsUnitRatio");
            _hash.Add("BsXdRp", "BsXdRp");
            _hash.Add("BsHouse", "BsHouse");
            _hash.Add("BsCompany", "BsCompany");
            _hash.Add("BsRegTimeSpan", "BsRegTimeSpan");
            _hash.Add("BsItemPacs", "BsItemPacs");
            _hash.Add("BSItemBASIC", "BSItemBASIC");
            _hash.Add("BsDocRegType", "BsDocRegType");
            _hash.Add("BsRegSpanSub", "BsRegSpanSub");
            _hash.Add("TmpEmr", "TmpEmr");
            _hash.Add("BsGroupSub", "BsGroupSub");
            _hash.Add("BsGroup", "BsGroup");
            _hash.Add("BsDocLevel", "BsDocLevel");
            _hash.Add("BsDiagRoom", "BsDiagRoom");
            _hash.Add("BsAreaProvince", "BsAreaProvince");
            _hash.Add("BsAreaRegion", "BsAreaRegion");
            _hash.Add("BsArea", "BsArea");
            _hash.Add("BsCertificate", "BsCertificate");
        }

        public static List<T> Get<T>(string key)
        {
            List<T> lst;
            var cache = ServiceTaker.GetService<ICacheClient>();
            var cacheKey = GetEntityCacheKey(key);
            lst = cache.Get<List<T>>(cacheKey);
            if (lst == null) lst = new List<T>();
            return lst;
        }
        /// <summary>
        /// 用T的类型名称做Key,取整表缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetCacheList<T>()
        {
            var name = typeof(T).Name;
            if (ContainsKey(name))
            {
                return Get<T>(name);
            }
            return new List<T>();
        }


        public static string GetEntityCacheKey(string key)
        {
            return string.Format("model_{0}", key);
        }



        public static List<RefreshEntity> GetRefresh()
        {
            var cache = ServiceTaker.GetService<ICacheClient>();
            var list = cache.Get<List<RefreshEntity>>("SYS_REFRESH");
            return list;
        }
    }

    [Serializable]
    public class RefreshEntity
    { 
        public DateTime LastTime { set; get; }
        public string Key { set; get; } 
    }
}
