using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 定义标准事件的委托。
    /// </summary>
    /// <typeparam name="T">参数类型</typeparam>
    /// <param name="sender">发送者。这个参数用于计算响应者路由但不会发往远程响应端。</param>
    /// <param name="args">参数，参数将传弟到响应端。要发给远程响应端的数据必须放在这个参数中。</param>
    public delegate void RemoteEventHandler<T>(object sender, RemoteEventArgs<T> args) where T :class,new();

    /// <summary>
    /// 事件远程播送器接口。这通常是一个本地接口。
    /// </summary>
    public interface IRemoteEventCaster
    {
        /// <summary>
        /// 远程事件的播送方法。
        /// </summary>
        /// <typeparam name="T">事件的消息类型。</typeparam>
        /// <param name="sender">发送者。这个参数用于计算响应者路由但不会发往远程响应端。</param>
        /// <param name="args">参数，参数将传弟到响应端。要发给远程响应端的数据必须放在这个参数中。</param>
        void CastEvent<T>(object sender, RemoteEventArgs<T> args) where T : class,new();
    }
}
