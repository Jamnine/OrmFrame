namespace WebBridgeEndpoint
{
    public class ProxyCreaterSetting
    {
        /// <summary>
        /// 代理类的命名空间前缀。
        /// </summary>
        public const string ProxyNamespacePrefix = "Proxy_";

        /// <summary>
        /// 代理类的类名前缀。
        /// </summary>
        public const string ProxyClassPrefix = "Proxy_";

        /// <summary>
        /// 事件名模板。
        /// </summary>
        public const string EventName = "#EventName#";

        /// <summary>
        /// 事件类型模板。
        /// </summary>
        public const string EventTypeName = "#EventTypeName#";

        /// <summary>
        /// 形式参数。
        /// </summary>
        public const string FormalParameters = "#FormalParameters#";

        /// <summary>
        /// 实际参数。
        /// </summary>
        public const string ActualParameters = "#ActualParameters#";

        /// <summary>
        /// 事件代理引发方法的前缀。
        /// </summary>
        public const string EventTriggerPrefix = "trigger_";
    }
}
