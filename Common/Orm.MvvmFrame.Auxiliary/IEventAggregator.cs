using System;

namespace Orm.MvvmFrame.Auxiliary
{
    public interface IEventAggregator
    {

        //订阅消息
        void Subscribe<T>(object subscriber, Action<T> handler);

        //订阅消息（带回调）
        void Subscribe<TSent, TBack>(object subscriber, Func<TSent, TBack> handler);

        /// <summary>
        /// 订阅消息（带令牌，只接受此拥有令牌，所发送的消息）
        /// </summary>
        /// <typeparam name="T">发送的消息的类型</typeparam>
        /// <param name="subscriber">用户/收件人/订阅者</param>
        /// <param name="token">令牌</param>
        /// <param name="handler"></param>
        void Subscribe<T>(object subscriber, object token, Action<T> handler);


        /// <summary>
        /// 订阅消息
        /// （带令牌，只接受此拥有令牌，所发送的消息）
        /// （带回调,就是当有消息发送过来，接收后会向发送方发出提醒信息。例如：我是谁，已接收您发送的消息。）
        /// </summary>
        /// <typeparam name="TSent">发送的消息的类型</typeparam>
        /// <typeparam name="TBack">回调内容的类型</typeparam>
        /// <param name="subscriber">用户/收件人/订阅者</param>
        /// <param name="token">令牌</param>
        /// <param name="handler"></param>
        void Subscribe<TSent, TBack>(object subscriber, object token, Func<TSent, TBack> handler);

        /// <summary>
        /// 订阅消息
        /// (带消息的类型派生类消息接收，也就是也接收消息的类型的派生类的消息。)
        /// </summary>
        /// <typeparam name="T">发送的消息的类型</typeparam>
        /// <param name="subscriber">用户/收件人/订阅者</param>
        /// <param name="receiveDerivedMessagesToo">是否接收消息类型的派生类类型的消息</param>
        /// <param name="handler"></param>
        void Subscribe<T>(object subscriber, bool receiveDerivedMessagesToo, Action<T> handler);

        /// <summary>
        /// 订阅消息
        /// (带消息的类型派生类消息接收，也就是也接收消息的类型的派生类的消息。)
        /// （带回调,就是当有消息发送过来，接收后会向发送方发出提醒信息。例如：我是谁，已接收您发送的消息。）
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <typeparam name="TBack"></typeparam>
        /// <param name="subscriber">用户/收件人/订阅者</param>
        /// <param name="receiveDerivedMessagesToo">是否接收消息类型的派生类类型的消息</param>
        /// <param name="handler"></param>
        void Subscribe<TSent, TBack>(object subscriber, bool receiveDerivedMessagesToo, Func<TSent, TBack> handler);

        /// <summary>
        /// 订阅消息
        ///（带令牌，只接受此拥有令牌，所发送的消息）
        /// (带消息的类型派生类消息接收，也就是也接收消息的类型的派生类的消息。)
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <typeparam name="TBack"></typeparam>
        /// <param name="subscriber">用户/收件人/订阅者</param>
        /// <param name="token">令牌</param>
        /// <param name="receiveDerivedMessagesToo">是否接收消息类型的派生类类型的消息</param>
        /// <param name="handler"></param>
        void Subscribe<TSent>(object subscriber, object token, bool receiveDerivedMessagesToo, Action<TSent> handler);

        /// <summary>
        /// 订阅消息
        /// （带令牌，只接受此拥有令牌，所发送的消息）
        /// （带回调,就是当有消息发送过来，接收后会向发送方发出提醒信息。例如：我是谁，已接收您发送的消息。）
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <typeparam name="TBack"></typeparam>
        /// <param name="subscriber">用户/收件人/订阅者</param>
        /// <param name="token">令牌</param>
        /// <param name="receiveDerivedMessagesToo">如果是True则是也接收消息类型的派生类类型的消息</param>
        /// <param name="handler"></param>
        void Subscribe<TSent, TBack>(object subscriber, object token, bool receiveDerivedMessagesToo, Func<TSent, TBack> handler);

        //发送消息
        void Publish<TSent>(TSent data);

        //发送消息（带回调）
        void Publish<TSent, TBack>(TSent data, Action<TBack> callback);

        /// <summary>
        /// 发送消息
        /// (带消息令牌，只有拥有此令牌的订阅者才能接受消息)
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <param name="data"></param>
        /// <param name="token">令牌/标记</param>
        void Publish<TSent>(TSent data, object token);

        /// <summary>
        /// 发送消息
        /// (带消息令牌，只有拥有此令牌的订阅者才能接受消息)
        /// （带回调，消息发送后可以收到已收到消息的订阅者发送过来的信息）
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <typeparam name="TBack"></typeparam>
        /// <param name="data"></param>
        /// <param name="token"></param>
        /// <param name="callback"></param>
        void Publish<TSent, TBack>(TSent data, object token, Action<TBack> callback);

        /// <summary>
        /// 发送消息，带订阅者类型筛选。
        /// （带接收该消息的订阅者类型，消息不会被发送到另一类型的订阅者）
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <typeparam name="TTarget">接收该消息的订阅者类型</typeparam>
        /// <param name="data"></param>
        void Publish<TSent, TTarget>(TSent data);

        /// <summary>
        /// 发送消息
        /// （带接收该消息的订阅者类型，消息不会被发送到另一类型的订阅者）
        /// （带回调，消息发送后可以收到已收到消息的订阅者发送过来的信息）
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <typeparam name="TBack"></typeparam>
        /// <param name="data"></param>
        /// <param name="callback"></param>
        void Publish<TSent, TTarget, TBack>(TSent data, Action<TBack> callback);

        /// <summary>
        /// 发送消息
        /// (带消息令牌，只有拥有此令牌的订阅者才能接受消息)
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="data"></param>
        /// <param name="token"></param>
        void Publish<TSent, TTarget>(TSent data, object token);

        //注销订阅者
        void Unsubscribe(object subscriber);

        //注销消息订阅
        void Unsubscribe<T>(object subscriber);

        /// <summary>
        /// 注销消息订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subscriber"></param>
        /// <param name="token"></param>
        void Unsubscribe<T>(object subscriber, object token);

        //清除被回收的弱类型
        void Cleanup();

        //清除所有订阅者
        void Clear();

        #region 兼容老思路的方法，以后逐步消除掉

        /// <summary>
        /// 发送消息（带筛选订阅者）
        /// </summary>
        /// <typeparam name="TSent"></typeparam>
        /// <param name="data"></param>
        /// <param name="type"></param>
        void Publish<TSent>(TSent data, Type type);

        //发送消息（带筛选订阅者,带回调）
        void Publish<TSent, TBack>(TSent data, Type type, Action<TBack> callback);


        #endregion
    }
}
