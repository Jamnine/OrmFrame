namespace WebBridgeEndpoint
{
    /// <summary>
    /// 远程事件实体。
    /// </summary>
    public class RemoteEventEntity
    {
        string eventEntityKey;
        /// <summary>
        /// 事件实体标识。
        /// </summary>
        public string EventEntityKey
        {
            get
            {
                eventEntityKey = EventKey + "__" + AppRuntimeName;

                return eventEntityKey;
            }
            set
            {
                eventEntityKey = value;
            }
        }

        /// <summary>
        /// 事件的唯一标识（数据主键）。
        /// </summary>
        public string EventKey { get; set; }

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
        /// 处理状态。
        /// </summary>
        public HandleState HandleState { get; set; }

        /// <summary>
        /// 事件参数Json值。
        /// </summary>
        public string MessageJsonValue { get; set; }

        /// <summary>
        /// 事件参数类型限定名。
        /// </summary>
        public string MessageTypeQuaName { get; set; }

        public RemoteEventEntity()
        {

        }

        public RemoteEventEntity(string eventKey, string appRuntimeName)
        {
            EventKey = eventKey;
            AppRuntimeName = appRuntimeName;
        }
    }

    /// <summary>
    /// 处理的状态。
    /// </summary>
    public enum HandleState
    {
        /// <summary>
        /// 没开始的。
        /// </summary>
        Unstarted,

        /// <summary>
        /// 处理中的。
        /// </summary>
        Handling,

        /// <summary>
        /// 已完成的。
        /// </summary>
        Finish,

        /// <summary>
        /// 出错的。
        /// </summary>
        Erred
    }
}

