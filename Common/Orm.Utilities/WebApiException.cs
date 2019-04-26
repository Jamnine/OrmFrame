using System;

namespace Orm.Utilities
{
    [Serializable]
    public class WebApiException : Exception
    {
        public WebApiException() { }
        public WebApiException(string message) : base(message) { }
        public WebApiException(string message, Exception inner) : base(message, inner) { }
        protected WebApiException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    /// <summary>
    /// 执行失败信息
    /// </summary>
    public class WarningException : Exception
    {
        public WarningException() { }
        public WarningException(string message) : base(message) { }
        public WarningException(string message, Exception inner) : base(message, inner) { }
        protected WarningException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    /// <summary>
    /// 执行成功信息
    /// </summary>
    public class InformationException : ApplicationException
    {
        public InformationException() { }
        public InformationException(string message) : base(message) { }
        public InformationException(string message, Exception inner) : base(message, inner) { }
        protected InformationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    /// <summary>
    /// 系统错误信息
    /// </summary>
    public class ErrorException : Exception
    {
        public ErrorException() { }
        public ErrorException(string message) : base(message) { }
        public ErrorException(string message, Exception inner) : base(message, inner) { }
        protected ErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
