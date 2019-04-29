using Orm.Model.EnumDefine;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Orm.Model.Parameter
{

    /// <summary>
    /// 返回信息
    /// </summary>
    [Serializable]

    public class ReturnValue
    {
        public string _saveStatus = "";
        private string _errorMsg = string.Empty;
        /// <summary>
        /// 错误信息 （ErrorCode !=0）
        /// </summary> 
        public string ErrorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; }
        }

        private string _warningMsg = string.Empty;
        /// <summary>
        /// 警告信息（ErrorCode=0），可用于提示
        /// </summary>
        public string WarningMsg
        {
            get { return _warningMsg; }
            set { _warningMsg = value; }
        }

        private int _errorCode = -1;
        /// <summary>
        /// 0正常 非0错误
        /// </summary>
        public int ErrorCode
        {
            get { return _errorCode; }
            set { _errorCode = value; }
        }

        private object _returns = new object();
        /// <summary>
        /// 返回可选属性
        /// </summary>
        public object Returns
        {
            get { return _returns; }
            set { _returns = value; }
        }

        /// <summary>
        /// 体检项目id
        /// </summary>
        public string GUID { get; set; }

        #region His项目所需要的返回类型
        /// <summary>
        /// 是否成功
        /// </summary>
        [Description("默认值为false")]
        public bool IsSuccess { set; get; }

        /// <summary>
        /// 显示状态
        /// </summary>
        [Description("使用枚举MsgStates")]
        public int State { set; get; }

        /// <summary>
        /// 消息提示
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// 消息显示
        /// </summary>
        public string ShowMsg { set; get; }

        /// <summary>
        /// 字符串集合
        /// </summary>
        public List<string> _showMessages = new List<string>();

        /// <summary>
        /// Object 集合
        /// </summary>
        public List<Object> _showObjectList = new List<object>();

        /// <summary>
        /// Object 集合列表
        /// </summary>
        public List<Object> ShowObjectList
        {
            get { return _showObjectList; }
            set { _showObjectList = value; }
        }

        /// <summary>
        /// 消息显示列表
        /// </summary>
        public List<string> ShowMessages
        {
            get { return _showMessages; }
            set { _showMessages = value; }
        }


        /// <summary>
        /// 执行成功消息
        /// </summary>
        /// <param name="mssage">需要提示的消息</param>
        public void Success(string mssage)
        {
            this.State = (int)MsgStates.Success;
            this.ShowMsg = mssage;
        }

        /// <summary>
        /// 警告消息
        /// </summary>
        /// <param name="mssage"></param>
        public void Warning(string mssage)
        {
            this.State = (int)MsgStates.Waring;
            this.ShowMsg = mssage;
        }
        /// <summary>
        /// 警告消息
        /// </summary>
        /// <param name="mssage"></param>
        public void WarningList(params string[] mssage)
        {
            this.State = (int)MsgStates.WaringList;
            this.ShowMessages.AddRange(mssage);
        }

        /// <summary>
        /// 错误消息
        /// </summary>
        /// <param name="mssage"></param>
        public void Error(string mssage)
        {
            this.State = (int)MsgStates.Error;
            this.ShowMsg = mssage;
        }

        /// <summary>
        /// 错误消息
        /// </summary>
        /// <param name="mssage"></param>
        public void ErrorList(params string[] mssage)
        {
            this.State = (int)MsgStates.ErrorList;
            this.ShowMessages.AddRange(mssage);
        }

        /// <summary>
        /// 设置消息
        /// </summary>
        /// <param name="state">消息级别</param>
        /// <param name="mssage">消息内容</param>
        public void StateMssage(MsgStates state, string mssage)
        {
            this.State = (int)state;
            this.ShowMsg = mssage;
        }

        /// <summary>
        /// 设置消息
        /// </summary>
        /// <param name="state">消息级别</param>
        /// <param name="mssage">消息内容</param>
        public void SetStateMssage(MsgStates state, string mssage)
        {
            this.State = (int)state;
            this.Message = mssage;
        }
        #endregion
    }

    /// <summary>
    /// 返回消息
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ReturnValue<T> : ReturnValue where T : new()
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public T ReturnT;
    }
}
