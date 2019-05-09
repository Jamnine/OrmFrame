using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using WebBridgeContract;

namespace WebBridgeEndpoint
{
    public class RemoteEventOperation : IEventOC
    {
        private readonly object locker = new object();
        IDataPersist dataPers = ServiceTaker.GetService<IDataPersist>("WebBridge");
         
        /// <summary>
        /// 监听某个事件。
        /// </summary>
        /// <param name="theEvent">事件契约。</param>
        /// <param name="appRuntimeName">部署的实例名。</param>
        /// <param name="listenerClassName">监听者的类名。</param>
        /// <param name="handleMethodName">响应方法名。</param>
        public void ListenEvent(EventDC theEvent, string appRuntimeName, string listenerClassName, string handleMethodName)
        {
            RemoteEventListenEntity listenEt = new RemoteEventListenEntity();
            listenEt.AppRuntimeName = appRuntimeName;
            listenEt.EventName = theEvent.EventName;
            listenEt.HandleMethodName = handleMethodName;
            listenEt.ListenerClassName = listenerClassName;
            listenEt.SenderInterfaceName = theEvent.SenderInterfaceName;
            listenEt.SenderTypeName = theEvent.SenderTypeName;

            listenEt.ProxyMapConfigKey = string.Empty;

            lock (locker)
            {
                Action act = delegate()
                {
                    if (!(dataPers.GetQueryable<RemoteEventListenEntity>().Where(ww => ww.EventListenKey == listenEt.EventListenKey).Count() > 0))
                    {
                        dataPers.Add(listenEt);
                    }
                };

                dataPers.WorkUnitAct(act);
            }
        }

        /// <summary>
        /// 取消某个事件的监听。
        /// </summary>
        /// <param name="theEvent">事件契约。</param>
        /// <param name="appRuntimeName">部署的实例名。</param>
        /// <param name="listenerClassName">监听者的类名。</param>
        /// <param name="handleMethodName">响应方法名。</param>
        public void RepealListen(EventDC theEvent, string appRuntimeName, string listenerClassName, string handleMethodName)
        {
            RemoteEventListenEntity listenEt = new RemoteEventListenEntity();
            listenEt.AppRuntimeName = appRuntimeName;
            listenEt.EventName = theEvent.EventName;
            listenEt.HandleMethodName = handleMethodName;
            listenEt.ListenerClassName = listenerClassName;
            listenEt.SenderInterfaceName = theEvent.SenderInterfaceName;
            listenEt.SenderTypeName = theEvent.SenderTypeName;

            lock (locker)
            {
                dataPers.Delete(listenEt);
            }
        }

        /// <summary>
        /// 开始处理某个事件。
        /// </summary>
        /// <param name="EventKey">事件键。</param>
        /// <param name="appRuntimeName">应用运行时名称。</param>
        public bool StartEvent(string EventKey, string appRuntimeName)
        {
            bool isNotHandled = false;

            RemoteEventEntity pEventEt = new RemoteEventEntity(EventKey, appRuntimeName);

            lock (locker)
            {
                Action UpForStart = delegate()
                {
                    RemoteEventEntity theEventEt = dataPers.GetQueryable<RemoteEventEntity>()
                         .Where(ww => ww.EventEntityKey == pEventEt.EventEntityKey && ww.HandleState == HandleState.Unstarted).FirstOrDefault();

                    if (theEventEt != null)
                    {
                        theEventEt.HandleState = HandleState.Handling;
                        isNotHandled = dataPers.Update(theEventEt);
                    }
                };
                dataPers.WorkUnitAct(UpForStart);
            }

            return isNotHandled;
        }

        /// <summary>
        /// 处理完成某个事件。
        /// </summary>
        /// <param name="EventKey">事件键。</param>
        /// <param name="appRuntimeName">应用运行时名称。</param>
        public void FinishEvent(string EventKey, string appRuntimeName)
        {
            RemoteEventEntity eventEy = new RemoteEventEntity(EventKey, appRuntimeName);
            lock (locker)
            {
                dataPers.Update<RemoteEventEntity>(new { HandleState = HandleState.Finish }, ww => ww.EventEntityKey == eventEy.EventEntityKey);
            }
        }

        /// <summary>
        /// 处理某个事件出错。
        /// </summary>
        /// <param name="EventKey">事件键。</param>
        /// <param name="appRuntimeName">应用运行时名称。</param>
        public void ErredEvent(string EventKey, string appRuntimeName)
        {
            RemoteEventEntity eventEy = new RemoteEventEntity(EventKey, appRuntimeName);
            lock (locker)
            {
                dataPers.Update<RemoteEventEntity>(new { HandleState = HandleState.Erred }, ww => ww.EventEntityKey == eventEy.EventEntityKey);
            }
        }

        /// <summary>
        /// 将事件向远程监听者播送。
        /// </summary>
        /// <param name="pEvent">事件数据契约。</param>
        public void CastRemoteEvent(EventDC pEvent)
        {
            List<RemoteEventListenEntity> EventListenList = new List<RemoteEventListenEntity>();

            lock (locker)
            {
                EventListenList = dataPers.GetQueryable<RemoteEventListenEntity>()
                   .Where(ww => ww.SenderInterfaceName == pEvent.SenderInterfaceName
                   && ww.SenderTypeName == pEvent.SenderTypeName
                   && ww.EventName == pEvent.EventName).ToList();

                Action saveForCast = delegate()
                {
                    foreach (var EventListen in EventListenList)
                    {
                        RemoteEventEntity eventEt = new RemoteEventEntity();
                        eventEt.AppRuntimeName = EventListen.AppRuntimeName;
                        eventEt.EventKey = pEvent.EventKey;
                        eventEt.EventName = pEvent.EventName;
                        eventEt.HandleState = HandleState.Unstarted;
                        eventEt.MessageJsonValue = pEvent.Message.JsonValue;
                        eventEt.MessageTypeQuaName = pEvent.Message.TypeQualifiedName;
                        eventEt.SenderInterfaceName = pEvent.SenderInterfaceName;
                        eventEt.SenderTypeName = pEvent.SenderTypeName;

                        if (!dataPers.GetQueryable<RemoteEventEntity>().Contains(eventEt))
                        {
                            dataPers.Add(eventEt);
                        }
                    }
                };
                dataPers.WorkUnitAct(saveForCast);
            }
        }

        /// <summary>
        /// 按应用运行时名称取没被处理的监听的事件。
        /// </summary>
        /// <param name="appRuntimeName">应用运行时名称。</param>
        /// <returns></returns>
        public List<EventDC> GetEventList(string appRuntimeName)
        {
            List<RemoteEventEntity> EventList = new List<RemoteEventEntity>();
            lock (locker)
            {
                EventList = dataPers.GetQueryable<RemoteEventEntity>()
                   .Where(ww => ww.AppRuntimeName == appRuntimeName &&
                        ww.HandleState == HandleState.Unstarted).ToList();
            }

            List<EventDC> EventDcList = new List<EventDC>();
            foreach (var Event in EventList)
            {
                EventDC aEDc = new EventDC();
                aEDc.EventKey = Event.EventKey;
                aEDc.EventName = Event.EventName;


                ParameterDC message = new ParameterDC();
                message.JsonValue = Event.MessageJsonValue;
                message.TypeQualifiedName = Event.MessageTypeQuaName;

                aEDc.Message = message;
                aEDc.SenderInterfaceName = Event.SenderInterfaceName;
                aEDc.SenderTypeName = Event.SenderTypeName;

                EventDcList.Add(aEDc);
            }

            return EventDcList;
        }
    }
}
