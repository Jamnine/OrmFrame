using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using WebBridgeContract;

namespace WebBridgeEndpoint
{
    /// <summary>
    /// 远程事件。
    /// </summary>
    public class RemoteEventCaster : IRemoteEventCaster
    {
        /// <summary>
        /// 远程事件的播送方法。
        /// </summary>
        /// <param name="sender">发送者。这个参数用于计算响应者路由但不会发往远程响应端。</param>
        /// <param name="args">参数，参数将传弟到响应端。要发给远程响应端的数据必须放在这个参数中。</param>
        public void CastEvent<T>(object sender, RemoteEventArgs<T> args) where T : class, new()
        {
            Type senderType = sender.GetType();
            EventDC evData = new EventDC();
            evData.EventKey = Guid.NewGuid().ToString("N");
           
            if (senderType.GetEvent(args.EventName)!=null || senderType.GetEvent(args.EventName).EventHandlerType.FullName == typeof(RemoteEventHandler<>).FullName)
            {
                evData.EventName = args.EventName;
            }
            else
            {
                throw new Exception("不存在RemoteEventHandler型事件" + evData.EventName);
            }

            Type[] interfaces = senderType.GetInterfaces();
            List<Type> inheritInterfaceList = interfaces.Where(ww => (ww.GetMembers().Select(ss => ss.Name)).Contains(args.EventName)).ToList();
            if (inheritInterfaceList.Count != 1)
            {
                throw new Exception("不存在或多于一个事件发送者所继承的接口中声名事件" + evData.EventName);
            }
            else
            {
                evData.SenderInterfaceName = inheritInterfaceList.First().FullName;
            }

            ParameterDC Message = new ParameterDC();
            Message.TypeQualifiedName = args.Message.GetType().AssemblyQualifiedName;
            Message.JsonValue = ServiceTaker.GetService<IJsonSerializer>().Serialize(args.Message);

            evData.Message = Message;
            evData.SenderTypeName = senderType.FullName;

            IEventOC evOperation = ServiceTaker.GetRemoteService<IEventOC>();
            evOperation.CastRemoteEvent(evData);
        }

    }   
}
