using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Framework.Services
{
    /// <summary>
    /// MQ服务接口
    /// </summary>
    public interface IMQService
    {
        /// <summary>
        /// 根据配置的主题方案发送单条消息给一个或者多个消费者
        /// </summary>
        /// <param name="msg">消息</param>
        /// <param name="topicId">主题编码</param>
        void SendMessage(object msg, string topicId);

        void SendMessage<T>(T msg, string topicId);

        void Receive<T>();
    }
}
