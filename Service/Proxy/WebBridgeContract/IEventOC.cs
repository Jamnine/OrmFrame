using System.Collections.Generic;

namespace WebBridgeContract
{
    /// <summary>
    /// 事件的操作契约。
    /// </summary>
    public interface IEventOC
    {
        /// <summary>
        /// 监听某个事件。
        /// </summary>
        /// <param name="theEvent">事件契约。</param>
        /// <param name="appRuntimeName">部署的实例名。</param>
        /// <param name="listenerClassName">监听者的类名。</param>
        /// <param name="handleMethodName">响应方法名。</param>
        void ListenEvent(EventDC theEvent, string appRuntimeName, string listenerClassName, string handleMethodName);

        /// <summary>
        /// 取消某个事件的监听。
        /// </summary>
        /// <param name="theEvent">事件契约。</param>
        /// <param name="appRuntimeName">部署的实例名。</param>
        /// <param name="listenerClassName">监听者的类名。</param>
        /// <param name="handleMethodName">响应方法名。</param>
        void RepealListen(EventDC theEvent, string appRuntimeName, string listenerClassName, string handleMethodName);

        /// <summary>
        /// 开始处理某个事件。
        /// </summary>
        /// <param name="EventKey">事件键。</param>
        /// <param name="appRuntimeName">应用运行时名称。</param>
        bool StartEvent(string EventKey, string appRuntimeName);

        /// <summary>
        /// 处理完成某个事件。
        /// </summary>
        /// <param name="EventKey">事件键。</param>
        /// <param name="appRuntimeName">应用运行时名称。</param>
        void FinishEvent(string EventKey, string appRuntimeName);

        /// <summary>
        /// 某个事件处理出错。
        /// </summary>
        /// <param name="EventKey">事件键。</param>
        /// <param name="appRuntimeName">应用运行时名称。</param>
        void ErredEvent(string EventKey, string appRuntimeName);

        /// <summary>
        /// 将事件向远程监听者播送。
        /// </summary>
        /// <param name="pEvent">事件数据契约。</param>
        void CastRemoteEvent(EventDC pEvent);

        /// <summary>
        /// 按应用运行时名称取没被处理的监听的事件。
        /// </summary>
        /// <param name="appRuntimeName">应用运行时名称。</param>
        /// <returns></returns>
        List<EventDC> GetEventList(string appRuntimeName);
    }
}
