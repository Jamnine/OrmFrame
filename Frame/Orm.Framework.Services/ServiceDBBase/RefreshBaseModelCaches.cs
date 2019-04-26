using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services.ServiceDBBase
{
    public class RefreshBaseModelCaches
    {
        //static object objToLock = new object();
        ///// <summary>
        ///// 在缓存中插入记录
        ///// </summary>
        //public static void InsertEntityToCache<T>(Object entityObject)
        //{
        //    lock (objToLock)
        //    {
        //        try
        //        {
        //            if (Orm.Model.BaseModel.Caches.Keys.Contains(typeof(T).Name))
        //            {
        //                List<T> tList = Orm.Model.BaseModel.Caches[typeof(T).Name] as List<T>;
        //                tList.Add((T)entityObject);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw (ex);
        //        }
        //    }
        //}
        ///// <summary>
        ///// 修改缓存中的记录
        ///// </summary>
        //public static void UpdateEntityToCache<T>(Object entityObject, string entityId)
        //{
        //    lock (objToLock)
        //    {
        //        try
        //        {
        //            if (Orm.Model.BaseModel.Caches.Keys.Contains(typeof(T).Name))
        //            {
        //                List<T> tList = Orm.Model.BaseModel.Caches[typeof(T).Name] as List<T>;
        //                T entity = tList.Find(t => (string)t.GetType().GetProperty("GUID").GetValue(t, null) == entityId);
        //                if (entity != null)
        //                {
        //                    tList.Remove(entity);
        //                    tList.Add((T)entityObject);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw (ex);
        //        }
        //    }
        //}
        ///// <summary>
        ///// 删除缓存记录
        ///// </summary>
        //public static void DeleteEntityToCache<T>(string entityId)
        //{
        //    lock (objToLock)
        //    {
        //        try
        //        {
        //            if (Orm.Model.BaseModel.Caches.Keys.Contains(typeof(T).Name))
        //            {
        //                List<T> tList = Orm.Model.BaseModel.Caches[typeof(T).Name] as List<T>;
        //                T entity = tList.Find(t => (string)(t.GetType().GetProperty("GUID").GetValue(t, null)) == entityId);
        //                if (entity != null)
        //                {
        //                    tList.Remove(entity);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw (ex);
        //        }
        //    }
        //}

    }
}
