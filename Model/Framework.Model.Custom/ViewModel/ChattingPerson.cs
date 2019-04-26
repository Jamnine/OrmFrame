using System;
using System.ComponentModel;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 客服聊天
    /// </summary>
    [Serializable]

    public class ChattingPerson : INotifyPropertyChanged
    {
        /// <summary>
        /// 聊天的联系人
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private string _userCode;
        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserCode
        {
            get
            {
                return _userCode;
            }
            set
            {
                _userCode = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("UserCode"));
            }
        }

        private string _name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private string _userType;
        /// <summary>
        /// 用户类型 医生：doc  病人：pat
        /// </summary>
        public string UserType
        {
            get
            {
                return _userType;
            }
            set
            {
                _userType = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("UserType"));
            }
        }

        private string _content;
        /// <summary>
        /// 信息
        /// </summary>
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Content"));
            }
        }


        private int _unReadCount;
        /// <summary>
        /// 未读消息个数
        /// </summary>
        public int UnReadCount
        {
            get
            {
                return _unReadCount;
            }
            set
            {
                _unReadCount = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("UnReadCount"));
            }
        }

        private DateTime _msgTime;
        /// <summary>
        /// 信息时间
        /// </summary>
        public DateTime MsgTime
        {
            get
            {
                return _msgTime;
            }
            set
            {
                _msgTime = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("MsgTime"));
            }
        }
    }
}
