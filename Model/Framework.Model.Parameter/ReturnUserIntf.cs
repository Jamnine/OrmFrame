using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private ZhongXin.API.Models.UserInfo _userInfo;
         /// <summary>
         /// 用户信息
         /// </summary>
        public ZhongXin.API.Models.UserInfo UserInfo 
        {
            get { return _userInfo; }
            set { _userInfo = value; }
        } 
    }
}
