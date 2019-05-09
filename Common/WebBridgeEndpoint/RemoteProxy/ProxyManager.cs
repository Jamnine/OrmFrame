using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using WebBridgeContract;

namespace WebBridgeEndpoint
{
    /// <summary>
    /// 管理远程代理，全部远程代理对象均为单例模式。
    /// </summary>
    public sealed class ProxyManager : IRemoteProxyManager, IRemoteEventCaster
    {
        static List<ProxyBase> ProxyList = new List<ProxyBase>();
        static readonly object proxyLocker = new object();

        static List<RemoteEventListenEntity> EventListenList = new List<RemoteEventListenEntity>();
        static readonly object eventList = new object();

        static IJsonSerializer Serializer = ServiceTaker.GetService<IJsonSerializer>();

        static ProxyManager()
        {
        }

        /// <summary>
        /// 取得给定接口的代理类对象，没有则新建一个。
        /// </summary>
        /// <typeparam name="T">要取代理的接口。</typeparam>
        /// <param name="theTypeMap">类型映射。</param>
        /// <returns></returns>
        public T GetApiProxy<T>(TypeMap theTypeMap)
        {
            ProxyBase TheProxy = null;

            //统一由MapKey标识
            if (string.IsNullOrWhiteSpace(theTypeMap.MapConfigKey))
            {
                theTypeMap.MapConfigKey = theTypeMap.InterfaceName;
            }

            if (ProxyList.Where(ww => ww.ApiTypeMap.MapConfigKey == theTypeMap.MapConfigKey).Count() > 0)
            {
                TheProxy = ProxyList.Where(ww => ww.ApiTypeMap.MapConfigKey == theTypeMap.MapConfigKey).FirstOrDefault();
            }
            else
            {
                Type TheType = null;

                string[] name = theTypeMap.InterfaceName.Split('.');
                string className = name[3];
                string nameSpace = theTypeMap.InterfaceName.Substring(0, theTypeMap.InterfaceName.Length - className.Length - 1);
                var type = $"{ProxyCreaterSetting.ProxyNamespacePrefix}{nameSpace}.{ProxyCreaterSetting.ProxyClassPrefix}{className},{ProxyCreaterSetting.ProxyNamespacePrefix}{nameSpace}";
                TheType = Type.GetType(type);

                TheProxy = (ProxyBase)Activator.CreateInstance(TheType);
                TheProxy.ApiTypeMap = theTypeMap;

                if (TheProxy != null)
                {
                    lock (proxyLocker)
                    {
                        //锁后在判断一次，杜绝重复。
                        if (ProxyList.Where(ww => ww.ApiTypeMap.MapConfigKey == theTypeMap.MapConfigKey).Count() < 1)
                        {
                            ProxyList.Add(TheProxy);
                        }
                    }
                }
            }

            ProxyBase proxyBase = TheProxy as ProxyBase;
            proxyBase.ApiTypeMap = theTypeMap;

            object theResult = TheProxy;
            return (T)theResult;
        }

        /// <summary>
        /// 监听某事件。
        /// </summary>
        /// <param name="theTypeMap">代理映射。</param>
        /// <param name="EventName">事件名。</param>
        /// <param name="ListenerFullName">事件响映函数所在的类名。</param>
        /// <param name="HandleMethodName">事件响映函数名。</param>
        public void LisetenEvent(TypeMap theTypeMap, string EventName, string ListenerFullName, string HandleMethodName)
        {
            RemoteEventListenEntity listenEnti = new RemoteEventListenEntity();

            listenEnti.AppRuntimeName = AppSettings.AppRuntimeName;
            listenEnti.EventName = EventName;
            listenEnti.HandleMethodName = HandleMethodName;
            listenEnti.ListenerClassName = ListenerFullName;
            listenEnti.ProxyMapConfigKey = string.IsNullOrWhiteSpace(theTypeMap.MapConfigKey) ? theTypeMap.InterfaceName : theTypeMap.MapConfigKey;
            listenEnti.SenderInterfaceName = theTypeMap.InterfaceName;
            listenEnti.SenderTypeName = theTypeMap.MapToType;

            lock (eventList)
            {
                if (!EventListenList.Exists(ww => ww.EventListenKey == listenEnti.EventListenKey))
                {
                    EventListenList.Add(listenEnti);
                }
            }
        }

        /// <summary>
        /// 取消某事件的监听。
        /// </summary>
        /// <param name="theTypeMap">代理映射。</param>
        /// <param name="EventName">事件名。</param>
        /// <param name="ListenerFullName">事件响映函数所在的类名。</param>
        /// <param name="HandleMethodName">事件响映函数名。</param>
        public void RepealListen(TypeMap theTypeMap, string EventName, string ListenerFullName, string HandleMethodName)
        {
            RemoteEventListenEntity listenEnti = new RemoteEventListenEntity();
            listenEnti.EventName = EventName;
            listenEnti.HandleMethodName = HandleMethodName;
            listenEnti.ListenerClassName = ListenerFullName;
            listenEnti.ProxyMapConfigKey = string.IsNullOrWhiteSpace(theTypeMap.MapConfigKey) ? theTypeMap.InterfaceName : theTypeMap.MapConfigKey;
            listenEnti.SenderInterfaceName = theTypeMap.InterfaceName;
            listenEnti.SenderTypeName = theTypeMap.MapToType;

            lock (eventList)
            {
                EventListenList.Remove(listenEnti);
            }
        }

        /// <summary>
        /// 取远端引发的并在本地有监听的事件，然后在本地代理引发。
        /// </summary>
        public static void EventProcyTrigger()
        {
        }

        /// <summary>
        /// 从契约中反序列化取参数列表。
        /// </summary>
        /// <param name="theRemoteEven">方法数据契约。</param>
        /// <returns>参数列表。</returns>
        private static RemoteEventArgs<T> GetEventArgs<T>(EventDC theRemoteEven) where T : class, new()
        {
            RemoteEventArgs<T> Args = new RemoteEventArgs<T>();
            Args.EventName = theRemoteEven.EventName;

            Type relType = Type.GetType(theRemoteEven.Message.TypeQualifiedName);
            object value = Serializer.Deserialize(theRemoteEven.Message.JsonValue, relType);

            return Args;
        }

        public void CastEvent<T>(object sender, RemoteEventArgs<T> args) where T : class, new()
        {
            IEventOC eventOC = ServiceTaker.GetRemoteService<IEventOC>();
            IJsonSerializer serializer = ServiceTaker.GetService<IJsonSerializer>();

            EventDC evDc = new EventDC();
            evDc.EventKey = Guid.NewGuid().ToString();
            evDc.EventName = args.EventName;
            evDc.Message.TypeQualifiedName = args.Message.GetType().AssemblyQualifiedName;
            evDc.Message.JsonValue = serializer.Serialize(args.Message);

            Type senderType = sender.GetType();
            Type senderInterface = null;
            Type[] theInterfaces = senderType.GetInterfaces();
            if (theInterfaces.Length == 1)
            {
                senderInterface = theInterfaces[0];
            }
            else
            {
                senderInterface = theInterfaces.Where(ww => ww.GetEvents().Select(ss => ss.Name).Contains(args.EventName)).FirstOrDefault();
            }

            evDc.SenderInterfaceName = senderInterface == null ? string.Empty : senderInterface.FullName;
            evDc.SenderTypeName = senderType.FullName;

            eventOC.CastRemoteEvent(evDc);
        }
    }
}
