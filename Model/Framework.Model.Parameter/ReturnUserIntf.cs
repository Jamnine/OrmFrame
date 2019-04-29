using System;

namespace Orm.Model.Parameter
{

    /// <summary>
    /// 返回用户接口
    /// </summary>
    [Serializable]
    public class ReturnUserIntf
    {
        private int _errorCode = -1;
        /// <summary>
        /// 错误信息
        /// </summary> 
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 0正常 非0错误
        /// </summary>
        public int ErrorCode
        {
            get { return _errorCode; }
            set { _errorCode = value; }
        }
    }
}
