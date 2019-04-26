using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services.SharedMemory
{
    public interface ISharedMemoryCache
    {
        ///// <summary>
        ///// 加入缓存
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="key"></param>
        ///// <param name="obj"></param>
        //void Set<T>(string key, T obj);

        /// <summary>
        /// 加入缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        void Set(string key, object obj);

        /// <summary>
        /// 获取缓存对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key);


        object Get(string key);

        /// <summary>
        /// 移除缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Remove(string key);
        /// <summary>
        /// 获取已存在的缓存KEY值
        /// </summary>
        /// <returns></returns>
        List<string> GetCacheKey();
    }
}
