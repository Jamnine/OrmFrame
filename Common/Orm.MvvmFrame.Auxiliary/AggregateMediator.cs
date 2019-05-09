using System;
using System.Collections.Generic;
using System.Linq;

namespace Orm.MvvmFrame.Auxiliary
{
    /// <summary>
    /// 聚合器中间人
    /// (单例模式)
    /// </summary>
    public class AggregateMediator
    {
        private AggregateMediator() { }

        private static AggregateMediator instance;

        private readonly static object obj = typeof(object);
        public static AggregateMediator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new AggregateMediator();
                        }
                    }
                }
                return instance;
            }
        }
        private Dictionary<String, IEventAggregator> internalList = new Dictionary<String, IEventAggregator>();

        //private Dictionary<Type, IEventAggregator> internalList = new Dictionary<Type, IEventAggregator>();

        /// <summary>
        /// 添加一个特定的事件聚合器
        /// </summary>
        /// <param name="type"></param>
        //public void AddAggregator(Type type)
        //{
        //    if (!internalList.Keys.Contains(type))
        //    {
        //        internalList.Add(type,new EventAggregator());
        //    }
        //}

        /// <summary>
        /// 获取特定的事件聚合器
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        //public IEventAggregator GetEventAggregator(Type type)
        //{
        //    IEventAggregator aggregator;
        //    if (!internalList.Keys.Contains(type))
        //    {
        //        if (!EstimateType(type))
        //        {
        //            throw new Exception("不支持此类型生成事件聚合器");
        //        }
        //        internalList.Add(type, new EventAggregator());
        //    }
        //    aggregator = internalList[type];
        //    return aggregator;
        //}
        public IEventAggregator GetEventAggregator(Type type)
        {
            IEventAggregator aggregator;
            if (!internalList.Keys.Contains(type.FullName))
            {
                if (!EstimateType(type))
                {
                    throw new Exception("不支持此类型生成事件聚合器");
                }
                internalList.Add(type.FullName, new EventAggregator());
            }
            aggregator = internalList[type.FullName];
            return aggregator;
        }

        /// <summary>
        ///  System.Type 的完全限定名，包括 System.Type 的命名空间，但不包括程序集,及本身的类名名称
        ///  例如Orm.ViewModel.Presenter.MianViewModel
        /// </summary>
        /// <param name="typeFullName"></param>
        /// <returns></returns>
        public IEventAggregator GetEventAggregator(string typeFullName)
        {
            IEventAggregator aggregator;
            if (!internalList.Keys.Contains(typeFullName))
            {
                if (!true)
                {
                    throw new Exception("不支持此类型生成事件聚合器");
                }
                internalList.Add(typeFullName, new EventAggregator());
            }
            aggregator = internalList[typeFullName];
            return aggregator;
        }

        /// <summary>
        /// 判断类型
        /// </summary>
        /// <returns></returns>
        private bool EstimateType(Type type)
        {
            bool flag = false;
            if (type == typeof(ViewModelBase))
            {
                flag = true;
            }
            else if (type.BaseType != null)
            {
                flag = EstimateType(type.BaseType);
            }
            return flag;
        }

    }
}
