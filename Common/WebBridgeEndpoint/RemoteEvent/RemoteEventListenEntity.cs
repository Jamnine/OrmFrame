namespace WebBridgeEndpoint
{
    public class RemoteEventListenEntity
    {
        string eventListenKey;
        /// <summary>
        /// 事件监听键（数据主键）。
        /// </summary>
        public string EventListenKey
        {
            get
            {
                eventListenKey = SenderTypeName + "__"
                    + EventName + "__"
                    + ListenerClassName+"__"
                    + HandleMethodName;
                return eventListenKey;
            }
            set
            {
                eventListenKey = value;
            }
        }

        /// <summary>
        /// Web映射Key，也是从ProxyList获取唯一代理对象的键。
        /// </summary>
        public string ProxyMapConfigKey { get; set; }

        /// <summary>
        /// 事件产生者的接口全名而非限定名。
        /// </summary>
        public string SenderInterfaceName { get; set; }

        /// <summary>
        /// 事件产生者的类型全名。
        /// </summary>
        public string SenderTypeName { get; set; }

        /// <summary>
        /// 事件名。
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// 响应者运行名。
        /// </summary>
        public string AppRuntimeName { get; set; }

        /// <summary>
        /// 监听者类。
        /// </summary>
        public string ListenerClassName { get; set; }

        /// <summary>
        /// 响应方法名。
        /// </summary>
        public string HandleMethodName { get; set; }

        public RemoteEventListenEntity()
        {

        }

        public RemoteEventListenEntity(string senderTypeName, string eventName, string listenerClassName, string handleMethodName)
        {
            SenderTypeName = senderTypeName;
            EventName = eventName;
            ListenerClassName = listenerClassName;
            HandleMethodName = handleMethodName;
        }
    }
}
