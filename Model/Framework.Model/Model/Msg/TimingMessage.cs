// ===================================================================   
// Model  
// ===================================================================   
// File: TimingMessage.cs  
//   
// Copyright   
// History:  
// 2016/2/16 9:49:22: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    /// 定时发送信息表
    /// </summary> 
    [Serializable]  
 
    public partial class TimingMessage : BaseModel  
    {  
        private string _taskID;  
        private string _patID;  
        private string _patientName = String.Empty;  
        private string _sex;  
        private string _mobile = String.Empty;  
        private string _messageContent = String.Empty;  
        private int _sendType;  
        private int _sendNum;  
        private int _sendState;  
        private string _msgError = String.Empty;  
        private DateTime _createDate;  
        private DateTime _sendTime;
        private string _address = String.Empty;  
  
        public TimingMessage()  
        {  
        }  
  
  
        /// <summary>  
        /// 任务ID  
        /// </summary>  
        public string TaskID  
        {  
            get { return this._taskID; }  
            set { this._taskID = value; }  
        }

        /// <summary>  
        /// 病人id
        /// </summary>  
     
        public string PatID  
        {  
            get { return this._patID; }  
            set { this._patID = value; }  
        }  
  
        /// <summary>  
        /// 病人名称
        /// </summary>  
        public string PatientName  
        {  
            get { return this._patientName; }  
            set { this._patientName = value; }  
        }  
  
        /// <summary>  
        /// 性别
        /// </summary>  
        public string Sex  
        {  
            get { return this._sex; }  
            set { this._sex = value; }  
        }  
  
        /// <summary>  
        /// 手机号
        /// </summary>  
        public string Mobile  
        {  
            get { return this._mobile; }  
            set { this._mobile = value; }  
        }  
  
        /// <summary>  
        /// 信息内容  
        /// </summary>  
        public string MessageContent  
        {  
            get { return this._messageContent; }  
            set { this._messageContent = value; }  
        }  
  
        /// <summary>  
        /// 类型  
        /// </summary>  
        public int SendType  
        {  
            get { return this._sendType; }  
            set { this._sendType = value; }  
        }  
  
        /// <summary>  
        /// 发送次数  
        /// </summary>  
        public int SendNum  
        {  
            get { return this._sendNum; }  
            set { this._sendNum = value; }  
        }  
  
        /// <summary>  
        /// 状态：0 待发送 1 发送成功 2发送失败  
        /// </summary>  
        public int SendState  
        {  
            get { return this._sendState; }  
            set { this._sendState = value; }  
        }  
  
        /// <summary>  
        /// 错误信息  
        /// </summary>  
        public string MsgError  
        {  
            get { return this._msgError; }  
            set { this._msgError = value; }  
        }  
  
        /// <summary>  
        /// 导入时间  
        /// </summary>  
        public DateTime CreateDate  
        {  
            get { return this._createDate; }  
            set { this._createDate = value; }  
        }  
  
        /// <summary>  
        /// 最后发送时间  
        /// </summary>  
        public DateTime SendTime  
        {  
            get { return this._sendTime; }  
            set { this._sendTime = value; }  
        }  
  
        /// <summary>  
        /// 住址
        /// </summary>  
        public string Address  
        {
            get { return this._address; }
            set { this._address = value; }  
        }  
  
    }  
}  

