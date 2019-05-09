using System.Linq;

namespace WebBridgeContract
{
    public class EventDC
    {
        /// <summary>
        /// 事件对象的唯一标识（数据主键）。
        /// </summary>
        public string EventKey { get; set; }

        private string senderInterfaceName;
        /// <summary>
        /// 事件产生者的接口全名而非限定名。
        /// </summary>
        public string SenderInterfaceName
        {
            get
            {
                return senderInterfaceName;
            }
            set
            {
                if (value.Contains(","))
                {
                    senderInterfaceName = value.Split(",".ToArray()).Where(ww => !string.IsNullOrWhiteSpace(ww)).FirstOrDefault();
                }
                else
                {
                    senderInterfaceName = value;
                }
            }
        }

        private string senderTypeName;
        /// <summary>
        /// 事件产生者的类型全名而非限定名。
        /// </summary>
        public string SenderTypeName
        {
            get
            {
                return senderTypeName;
            }
            set
            {
                if (value.Contains(","))
                {
                    senderTypeName = value.Split(",".ToArray()).Where(ww => !string.IsNullOrWhiteSpace(ww)).FirstOrDefault();
                }
                else
                {
                    senderTypeName = value;
                }
            }
        }

        /// <summary>
        /// 事件名。
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// 事件的参数。
        /// </summary>
        public ParameterDC Message { get; set; }

        public EventDC()
        {
            Message = new ParameterDC();
        }
    }
}
