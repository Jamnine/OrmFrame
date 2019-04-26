using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 下拉框基类 
    /// </summary>
    [Serializable]
    public class BsCmmonData
    {
        public BsCmmonData()
        {

        }
        public BsCmmonData(int key, string code, string name)
        {
            this.Key = key;
            this.Code = code;
            this.Name = name;
        }
        public BsCmmonData(string guid, string code, string name)
        {
            this.ID = guid;
            this.Code = code;
            this.Name = name;
        }

        public string ID { get; set; }
        /// <summary>
        /// 主键id
        /// </summary>
        public int Key { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// 发送消息信息模板
    /// </summary>
    [Serializable]
    public class TempTimingMessage
    {
        public TempTimingMessage()
        {
            TimingMessage = new TimingMessage();
        }
        /// <summary>
        /// 是否选择发送
        /// </summary>
        public bool IsSelectSend { get; set; }

        /// <summary>
        /// 是否是正确手机号码
        /// </summary>
        public bool IsRightPhone 
        { 
            get 
            {
                if (TimingMessage.Mobile == string.Empty || TimingMessage.Mobile == null)
                    return false;
                else
                    return TimingMessage.Mobile.Length == 11 && TimingMessage.Mobile.Substring(0, 1) == "1";
            } 
        }
        /// <summary>
        /// 定时信息集合
        /// </summary>
        public TimingMessage TimingMessage { get; set; }
    }
}
