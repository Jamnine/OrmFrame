using System;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 泛型对象池接口（只有资源开销比较大的对象才需要池化）
    /// </summary>
    public interface IObjectPool<T> where T : class
	{
        /// <summary>
        /// 从对象池中获取一个可用对象
        /// </summary>
        /// <returns></returns>
        T Get();

        /// <summary>
        /// 释放一个对象回到对象池(不是从对象池出去的对象不能释放回对象池)
        /// </summary>
        /// <param name="target"></param>
        bool Release(T target);

        /// <summary>
        /// 关闭对象池并销毁池中全部对象
        /// </summary>
        void Close();

        /// <summary>
        /// 当前池中已经使用的对象个数
        /// </summary>
        int ActiveObjects { get; }

        /// <summary>
        /// 当前池中还有多少个可用对象
        /// </summary>
        int IdleObjects { get; }
	}
}
