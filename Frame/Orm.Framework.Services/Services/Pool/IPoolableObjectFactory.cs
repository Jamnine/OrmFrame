using System;

namespace Orm.Framework.Services
{
    /// <summary>
    /// IObjectPool实现类使用该对象管理池中的对象的创建，销毁和钝化
    /// </summary>
    public interface IPoolableObjectFactory<T> where T : class
    {
        /// <summary>
        /// 由池调用该方法用于创建对象新实例
        /// </summary>
        /// <returns></returns>
        T CreateObject();		

        /// <summary>
        /// 由池调用该方法用于销毁对象
        /// </summary>
        /// <param name="o"></param>
        void DestroyObject(T o);

        /// <summary>
        /// 钝化(重置对象状态)对象，每次对象归还给池时调用该方法重置状态
        /// </summary>
        /// <param name="o"></param>
        void PassivateObject(T o);
    }
}