using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Framework.Services
{
    /// <summary>
    /// MQ消息体对象,被添加到消息体中的业务数据必须可序列化
    /// </summary>
    [Serializable]
    public sealed class Message
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Message()
        {
            Data = new Dictionary<string, object>();
            ContentKey = "";
            TimeOut = 0;
        }
  
        /// <summary>
        /// 消息内容关键字(用于查询跟踪消息用途,不作为业务数据传递)
        /// </summary>
        public string ContentKey { get; set; }

        /// <summary>
        /// 消息过期时间,默认0表示不过期(单位：分钟)
        /// </summary>
        public int TimeOut { get; set; }

        /// <summary>
        /// 业务数据字典
        /// </summary>
        public IDictionary<string, object> Data { get; private set; }

        /// <summary>
        /// 添加业务数据到消息体
        /// </summary>
        /// <param name="key">键值</param>
        /// <param name="value">业务数据对象</param>
        public void AddData(string key, object value)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException("key");

            if (value == null) throw new ArgumentNullException("value");

            key = key.Trim();
         
            Data[key] = value;
        }
    }
}
