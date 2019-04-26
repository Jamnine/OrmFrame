// ===================================================================   
// Model  
// ===================================================================   
// File: TimingSendTask.cs  
//   
// Copyright   
// History:  
// 2016/2/16 9:51:22: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model
{     
    /// <summary>  
    ///  定时发送任务
    ///</summary> 
    [Serializable]  
    public partial class TimingSendTask : BaseModel  
    {  
        private string _name = String.Empty;  
        private string _messageContent = String.Empty;  
        private int _taskState;  
        private int _taskType;  
        private DateTime _sendTime;  
        private string _msgError = String.Empty;  
        private DateTime _createDate;  
        private string  _creatOperID;  
  
        public TimingSendTask()  
        {  
        }  
  
  
        /// <summary>  
        /// 任务名称  
        /// </summary>  
        public string Name  
        {  
            get { return this._name; }  
            set { this._name = value; }  
        }  
  
        /// <summary>  
        /// 模板信息 
        /// </summary>  
        public string MessageContent  
        {  
            get { return this._messageContent; }  
            set { this._messageContent = value; }  
        }  
  
        /// <summary>  
        /// 状态：0 待执行 1 发送执行 2执行失败  
        /// </summary>  
        public int TaskState  
        {  
            get { return this._taskState; }  
            set { this._taskState = value; }  
        }  
  
        /// <summary>  
        /// 类型  
        /// </summary>  
        public int TaskType  
        {  
            get { return this._taskType; }  
            set { this._taskType = value; }  
        }  
  
        /// <summary>  
        ///   发送时间
        /// </summary>  
        public DateTime SendTime  
        {  
            get { return this._sendTime; }  
            set { this._sendTime = value; }  
        }  
  
        /// <summary>  
        ///   错误信息
        /// </summary>  
        public string MsgError  
        {  
            get { return this._msgError; }  
            set { this._msgError = value; }  
        }  
  
        /// <summary>  
        ///   创建日期
        /// </summary>  
        public DateTime CreateDate  
        {  
            get { return this._createDate; }  
            set { this._createDate = value; }  
        }  
  
        /// <summary>  
        /// 创建人  
        /// </summary>  
        public string CreatOperID  
        {  
            get { return this._creatOperID; }  
            set { this._creatOperID = value; }  
        }  
  
    }  
}  

