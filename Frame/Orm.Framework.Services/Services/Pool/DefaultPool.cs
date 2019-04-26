using System;
using System.Collections;
using System.Collections.Generic;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 线程安全的对象池的默认实现,池大小一经初始化确定后不能修改
    /// </summary>
    public class DefaultPool<T> : IObjectPool<T> where T : class
    {
        private readonly object lockObj = new object();
        private readonly IPoolableObjectFactory<T> factory;
        private int size = 0;
        private IList free = new List<T>();
        private IList busy = new List<T>();

        /// <summary>
        /// 构造函数，使用默认池大小
        /// </summary>
        /// <param name="factory"></param>
        public DefaultPool(IPoolableObjectFactory<T> factory) : this(factory,0)
        {
        }

        /// <summary>
        /// 构造函数,默认池大小为16
        /// </summary>
        /// <param name="factory">the factory used to instantiate and manage lifecycle of pooles object</param>
        /// <param name="size">对象池大小</param>
        public DefaultPool(IPoolableObjectFactory<T> factory, int size)
        {
            this.factory = factory;
            this.size = size <= 0 ? 16 : size;
            Init(this.size);
        }

        /// <summary>
        /// 初始化池
        /// </summary>
        protected virtual void Init(int size)
        {
            for (int i = 0; i < size; i++)
            {
                free.Add(factory.CreateObject());
            }
        }

        #region IObjectPool 成员
        /// <summary>
        /// 从对象池中获取一个可用对象
        /// </summary>
        public virtual T Get()
        {
            T t= DoBorrow ();
            if (t != null) return t; 
            
            throw new ApplicationException("对象池中没有可用对象");//No more valid object in pool        
        }

        /// <summary>
        /// 释放一个对象回对象池
        /// </summary>
        /// <param name="o"></param>
        public virtual bool Release(T o)
        {
            if (o == null) return false;

            return DoReturn(o);
        }

        /// <summary>
        /// 关闭池，并销毁池中全部对象
        /// </summary>
        public virtual void Close()
        {
            lock (lockObj)
            {
                //1.先释放已经使用的对象[会调用钝化方法]
                foreach (T o in busy)
                {
                    DoReturn(o);
                }

                //2.销毁全部对象
                foreach (T o in free)
                {
                    factory.DestroyObject(o);
                }

                //3.释放内部的free和busy集合
                free = busy = new List<T>();
            }
        }

        /// <summary>
        /// 池中已经使用的对象数
        /// </summary>
        public virtual int ActiveObjects
        {
            get { return this.busy.Count; }
        }

        /// <summary>
        /// 池中空闲的对象数
        /// </summary>
        public virtual int IdleObjects
        {
            get { return this.free.Count; }
        }

        #endregion

        /// <summary>
        /// 从池中分配一个对象供调用方使用
        /// </summary>
        /// <returns></returns>
        private T DoBorrow()
        {
            lock (lockObj)
            {
                while (free.Count > 0)
                {
                    int i = free.Count - 1;
                    T o = (T)free[i];
                    free.RemoveAt(i);
                    busy.Add(o);
                    return o;
                }
            }
            return default(T);
        }

        /// <summary>
        /// 释放一个对象回对象池，内部会调用钝化对象的方法
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        private bool DoReturn(T o)
        {
            lock (lockObj)
            {
                if (busy.Contains(o))
                {
                    busy.Remove(o);
                    factory.PassivateObject(o);
                    free.Add(o);
                    return true;
                }
                return false;
            }
        }
    }
}