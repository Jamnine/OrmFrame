using System;
using System.Threading;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 线程上下文操作类(不跨应用程序域)
    /// </summary>
    public sealed class ThreadContext
    {
        /// <summary>
        /// 获取线程上下文相关的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T GetData<T>(string key)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException("key");

            object obj = Thread.GetData(Thread.GetNamedDataSlot(key));
            if (obj != null) return (T)obj;

            return default(T);
        }

        /// <summary>
        /// 设置线程上下文相关数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public void SetData(string key, object data)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException("key");

            Thread.SetData(Thread.GetNamedDataSlot(key), data);
        }
    }
}
