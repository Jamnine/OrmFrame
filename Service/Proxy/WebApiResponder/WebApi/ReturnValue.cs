using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiResponder
{
    /// <summary>
    /// 返回值类
    /// </summary>
    [Serializable]
    public class ReturnValue
    {

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
    }
}
