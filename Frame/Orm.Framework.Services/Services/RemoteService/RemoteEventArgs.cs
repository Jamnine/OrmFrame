using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 远程事件参数的泛型类。
    /// </summary>
    /// <typeparam name="T">事件消息的类型参数。</typeparam>
    public class RemoteEventArgs<T> : EventArgs where T : class,new()
    {
        /// <summary>
        /// 要传递的消息,消息的实际类型必须在契约中定义。
        /// </summary>
        public T Message { get; set; }

        /// <summary>
        /// 事件名。
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// 构造函数。
        /// </summary>
        public RemoteEventArgs()
            : base()
        {

        }

        /// <summary>
        /// 构造函数。
        /// </summary>
        /// <param name="msg">要传递的参数,其类型必须在契约中定义。</param>
        /// <param name="eventName">事件名。</param>
        public RemoteEventArgs(T msg, string eventName)
            : this()
        {
            Message = msg;
            EventName = eventName;
        }
    }
}
