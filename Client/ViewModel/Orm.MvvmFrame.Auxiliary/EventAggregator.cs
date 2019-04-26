using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Orm.MvvmFrame.Auxiliary
{
    /// <summary>
    /// 自定义消息聚合器
    /// </summary>
    public class EventAggregator : IEventAggregator
    {


        /// <summary>
        /// 订阅者信息（弱类型保存）
        /// </summary>
        private class Handler
        {
            public object Action { get; set; }

            /// <summary>
            /// 令牌，用于筛选订阅者。
            /// 或者 标记，细分类型下面的分类。
            /// </summary>

            [DefaultValueAttribute(null)]
            public object Token { get; set; }

            /// <summary>
            /// 是否也接收派生类的消息。
            /// 即消息类型的派生类（子类）的消息。
            /// </summary>
            [DefaultValueAttribute(false)]
            public bool ReceiveDerivedMessagesToo { get; set; }

            /// <summary>
            /// 消息订阅者（sender）
            /// </summary>
            public WeakReference Sender { get; set; }

            /// <summary>
            /// 消息类型
            /// </summary>
            public Type Type { get; set; }

            /// <summary>
            /// 回掉的类型
            /// </summary>
            public Type BackType { get; set; }


        }

        /// <summary>
        /// 线程锁
        /// </summary>
        private readonly object locker = new object();

        /// <summary>
        /// 订阅者列表
        /// </summary>
        private readonly List<Handler> handlers = new List<Handler>();

        /// <summary>
        /// 默认的实例
        /// </summary>
        private static IEventAggregator _defaultInstance;
        /// <summary>
        /// 创建锁
        /// </summary>
        private static readonly object CreationLock = new object();







        ///// <summary>
        ///// 发布消息
        ///// </summary>
        ///// <typeparam name="TSent">发送的消息类型</typeparam>
        ///// <param name="data"></param>
        ///// <param name="type">接收消息的Type,Type不一致的订阅者不可接受消息</param>
        //public void Publish<TSent>(TSent data,Type type)
        //{
        //    lock (locker)
        //    {
        //        Cleanup();

        //        foreach (var l in handlers.Where(a => a.Type.IsAssignableFrom(typeof(TSent)) && a.Sender.GetType()==type).ToList())
        //        {
        //            var action = l.Action as Action<TSent>;
        //            if (action != null) action(data);
        //        }
        //    }
        //}




        /// <summary>
        /// 默认的事件聚合器
        /// </summary>
        public static IEventAggregator Default
        {
            get
            {
                if (_defaultInstance == null)
                {
                    lock (CreationLock)
                    {
                        if (_defaultInstance == null)
                        {
                            _defaultInstance = new EventAggregator();
                        }
                    }
                }
                return _defaultInstance;
            }
        }


        public void Subscribe<TSent>(object subscriber, Action<TSent> handler)
        {
            lock (locker)
            {
                handlers.Add(new Handler
                {
                    Action = handler,
                    Sender = new WeakReference(subscriber),
                    Type = typeof(TSent),
                });
            }
        }

        public void Subscribe<TSent, TBack>(object subscriber, Func<TSent, TBack> handler)
        {
            lock (locker)
            {
                handlers.Add(new Handler
                {
                    Action = handler,
                    Sender = new WeakReference(subscriber),
                    Type = typeof(TSent),
                    BackType = typeof(TBack)
                });
            }
        }

        public void Subscribe<TSent>(object subscriber, object token, Action<TSent> handler)
        {
            lock (locker)
            {
                handlers.Add(new Handler
                {
                    Action = handler,
                    Sender = new WeakReference(subscriber),
                    Type = typeof(TSent),
                    Token = token,
                });
            }
        }

        public void Subscribe<TSent, TBack>(object subscriber, object token, Func<TSent, TBack> handler)
        {
            lock (locker)
            {
                handlers.Add(new Handler
                {
                    Action = handler,
                    Sender = new WeakReference(subscriber),
                    Type = typeof(TSent),
                    BackType = typeof(TBack),
                    Token = token,
                });
            }
        }

        public void Subscribe<TSent>(object subscriber, bool receiveDerivedMessagesToo, Action<TSent> handler)
        {
            lock (locker)
            {
                handlers.Add(new Handler
                {
                    Action = handler,
                    Sender = new WeakReference(subscriber),
                    Type = typeof(TSent),
                    ReceiveDerivedMessagesToo = receiveDerivedMessagesToo
                });
            }
        }

        public void Subscribe<TSent, TBack>(object subscriber, bool receiveDerivedMessagesToo, Func<TSent, TBack> handler)
        {
            lock (locker)
            {
                handlers.Add(new Handler
                {
                    Action = handler,
                    Sender = new WeakReference(subscriber),
                    Type = typeof(TSent),
                    BackType = typeof(TBack),
                    ReceiveDerivedMessagesToo = receiveDerivedMessagesToo
                });
            }
        }

        public void Subscribe<TSent>(object subscriber, object token, bool receiveDerivedMessagesToo, Action<TSent> handler)
        {
            lock (locker)
            {
                handlers.Add(new Handler
                {
                    Action = handler,
                    Sender = new WeakReference(subscriber),
                    Type = typeof(TSent),
                    Token = token,
                    ReceiveDerivedMessagesToo = receiveDerivedMessagesToo
                });
            }
        }

        public void Subscribe<TSent, TBack>(object subscriber, object token, bool receiveDerivedMessagesToo, Func<TSent, TBack> handler)
        {
            lock (locker)
            {
                handlers.Add(new Handler
                {
                    Action = handler,
                    Sender = new WeakReference(subscriber),
                    Type = typeof(TSent),
                    BackType = typeof(TBack),
                    Token = token,
                    ReceiveDerivedMessagesToo = receiveDerivedMessagesToo
                });
            }
        }


        /// <summary>
        /// 发布消息
        /// </summary>
        /// <typeparam name="TSent">发送的消息类型</typeparam>
        /// <param name="data"></param>
        public void Publish<TSent>(TSent data)
        {
            lock (locker)
            {
                Cleanup();
                foreach (var l in handlers.Where(a => (a.ReceiveDerivedMessagesToo ? (a.Type.IsAssignableFrom(typeof(TSent)) || typeof(TSent).IsSubclassOf(a.Type)) : a.Type.IsAssignableFrom(typeof(TSent))) && a.Token == null).ToList())
                {
                    var action = l.Action as Action<TSent>;
                    if (action != null)
                    {
                        action(data);
                    }
                }
            }
        }

        /// <summary>
        /// 发布消息，在执行完成后调用回掉函数（订阅函数有返回值）
        /// </summary>
        /// <typeparam name="TSent">发送的消息类型</typeparam>
        /// <typeparam name="TBack">返回的消息类型</typeparam>
        /// <param name="data">发送的消息</param>
        /// <param name="callback">回掉函数</param>
        public void Publish<TSent, TBack>(TSent data, Action<TBack> callback)
        {
            lock (locker)
            {
                Cleanup();
                foreach (var l in handlers.Where(a => (a.ReceiveDerivedMessagesToo ? (a.Type.IsAssignableFrom(typeof(TSent)) || typeof(TSent).IsSubclassOf(a.Type)) : a.Type.IsAssignableFrom(typeof(TSent))) && typeof(TBack).IsAssignableFrom(a.BackType) && a.Token == null).ToList())
                {
                    var action = l.Action as Func<TSent, TBack>;
                    if (action != null)
                    {
                        var re = action(data);
                        callback(re);
                    }
                }
            }
        }


        /// <summary>
        /// 发布消息
        /// </summary>
        /// <typeparam name="TSent">发送的消息类型</typeparam>
        /// <param name="data">发送的消息</param>
        /// <param name="token">令牌/标识</param>
        public void Publish<TSent>(TSent data, object token)
        {
            lock (locker)
            {
                Cleanup();
                foreach (var l in handlers.Where(a => (a.ReceiveDerivedMessagesToo ? (a.Type.IsAssignableFrom(typeof(TSent)) || typeof(TSent).IsSubclassOf(a.Type)) : a.Type.IsAssignableFrom(typeof(TSent))) && a.Token != null && a.Token.Equals(token)).ToList())
                {
                    var action = l.Action as Action<TSent>;
                    if (action != null)
                    {
                        action(data);
                    }
                }
            }
        }


        /// <summary>
        /// 发布消息，在执行完成后调用回掉函数（订阅函数有返回值）
        /// </summary>
        /// <typeparam name="TSent">发送的消息类型</typeparam>
        /// <typeparam name="TBack">返回的消息类型</typeparam>
        /// <param name="data">发送的消息</param>
        /// <param name="token">令牌/标识</param>
        /// <param name="callback">回掉函数</param>
        public void Publish<TSent, TBack>(TSent data, object token, Action<TBack> callback)
        {
            TSent obj = default(TSent);
            lock (locker)
            {
                Cleanup();
                List<Handler> list = handlers.Where(a => (a.ReceiveDerivedMessagesToo ? (a.Type.IsAssignableFrom(typeof(TSent)) || typeof(TSent).IsSubclassOf(a.Type)) : a.Type.IsAssignableFrom(typeof(TSent))) && typeof(TBack).IsAssignableFrom(a.BackType) && a.Token != null && a.Token.Equals(token)).ToList();
                foreach (var l in list)
                {
                    var action = l.Action as Func<TSent, TBack>;
                    if (action != null)
                    {
                        if (obj!=null)
                            if (obj.ToString().Equals(data.ToString())) return;
                        var re = action(data);
                        obj = data;
                        callback(re);
                    }
                }
            }
        }

        public void Publish<TSent, TTarget>(TSent data)
        {
            lock (locker)
            {
                Cleanup();
                foreach (var l in handlers.Where(a => (a.ReceiveDerivedMessagesToo ? (a.Type.IsAssignableFrom(typeof(TSent)) || typeof(TSent).IsSubclassOf(a.Type)) : a.Type.IsAssignableFrom(typeof(TSent))) && typeof(TTarget).IsAssignableFrom(a.Sender.GetType())).ToList())
                {
                    var action = l.Action as Action<TSent>;
                    if (action != null)
                    {
                        action(data);
                    }
                }
            }
        }

        public void Publish<TSent, TTarget, TBack>(TSent data, Action<TBack> callback)
        {
            lock (locker)
            {
                Cleanup();
                foreach (var l in handlers.Where(a => (a.ReceiveDerivedMessagesToo ? (a.Type.IsAssignableFrom(typeof(TSent)) || typeof(TSent).IsAssignableFrom(a.Type)) : a.Type.IsAssignableFrom(typeof(TSent))) && typeof(TBack).IsAssignableFrom(a.BackType) && typeof(TTarget).IsAssignableFrom(a.Sender.GetType())).ToList())
                {
                    var action = l.Action as Func<TSent, TBack>;
                    if (action != null)
                    {
                        var re = action(data);
                        callback(re);
                    }
                }
            }
        }

        public void Publish<TSent, TTarget>(TSent data, object token)
        {
            lock (locker)
            {
                Cleanup();
                foreach (var l in handlers.Where(a => (a.ReceiveDerivedMessagesToo ? (a.Type.IsAssignableFrom(typeof(TSent)) || typeof(TSent).IsSubclassOf(a.Type)) : a.Type.IsAssignableFrom(typeof(TSent))) && typeof(TTarget).IsAssignableFrom(a.Sender.GetType()) && a.Token != null && a.Token.Equals(token)).ToList())
                {
                    var action = l.Action as Action<TSent>;
                    if (action != null)
                    {
                        action(data);
                    }
                }
            }
        }

        /// <summary>
        /// 取消消息订阅
        /// </summary>
        /// <param name="subscriber"></param>
        public void Unsubscribe(object subscriber)
        {
            lock (locker)
            {
                Cleanup();

                var query = handlers.Where(a => a.Sender.Target.Equals(subscriber));

                foreach (var h in query.ToList())
                {
                    handlers.Remove(h);
                }
            }
        }

        /// <summary>
        /// 取消指定消息类型的消息订阅
        /// </summary>
        public void Unsubscribe<T>(object subscriber)
        {
            lock (locker)
            {
                Cleanup();

                var query = handlers.Where(a => a.Sender.Target.Equals(subscriber) && a.Type.IsAssignableFrom(typeof(T)));

                foreach (var h in query.ToList())
                {
                    handlers.Remove(h);
                }
            }
        }

        /// <summary>
        /// 取消指定消息类型及指定的令牌的消息订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subscriber"></param>
        /// <param name="token"></param>
        public void Unsubscribe<T>(object subscriber, object token)
        {
            lock (locker)
            {
                Cleanup();
                var query = handlers.Where(a => a.Sender.Target.Equals(subscriber) && a.Type.IsAssignableFrom(typeof(T)) && a.Token != null && a.Token.Equals(token));
                foreach (var h in query.ToList())
                {
                    handlers.Remove(h);
                }
            }
        }

        /// <summary>
        ///  清理被回收的订阅者
        /// </summary>
        public void Cleanup()
        {
            List<Handler> list = handlers.Where(a => !a.Sender.IsAlive).ToList();
            foreach (var l in list)
            {
                handlers.Remove(l);
            }
        }


        /// <summary>
        /// 清空所有订阅者
        /// </summary>
        public void Clear()
        {
            handlers.Clear();
        }

        #region 兼容老思路的方法，以后逐步消除掉

        /// <summary>
        /// 发布消息，在执行完成后调用回掉函数（订阅函数有返回值）
        /// </summary>
        /// <typeparam name="TSent">发送的消息类型</typeparam>
        /// <typeparam name="TBack">返回的消息类型</typeparam>
        /// <param name="data">发送的消息</param>
        /// <param name="senderType">订阅者Type,接收消息的Type,Type不一致的订阅者不可接受消息</param>
        /// <param name="callback">回掉函数</param>
        public void Publish<TSent, TBack>(TSent data, Type senderType, Action<TBack> callback)
        {
            lock (locker)
            {
                Cleanup();
                foreach (var l in handlers.Where(a =>
                    a.Type.IsAssignableFrom(typeof(TSent)) &&
                   typeof(TBack).IsAssignableFrom(a.BackType) && a.Sender.Target.GetType().IsAssignableFrom(senderType)).ToList())
                {
                    var action = l.Action as Func<TSent, TBack>;
                    if (action != null)
                    {
                        var re = action(data);
                        callback(re);
                    }
                }
            }
        }

        /// <summary>
        /// 发布消息，在执行完成后调用回掉函数
        /// </summary>
        /// <typeparam name="TSent">发送的消息类型</typeparam>
        /// <param name="data">发送的消息</param>
        /// <param name="senderType">订阅者Type,接收消息的Type,Type不一致的订阅者不可接受消息</param>
        public void Publish<TSent>(TSent data, Type senderType)
        {
            lock (locker)
            {
                Cleanup();
                foreach (var l in handlers.Where(a => a.Type.IsAssignableFrom(typeof(TSent)) && a.Sender.Target.GetType().IsAssignableFrom(senderType)).ToList())
                {
                    var action = l.Action as Action<TSent>;
                    if (action != null) action(data);
                }
            }
        }


        #endregion

    }

}
