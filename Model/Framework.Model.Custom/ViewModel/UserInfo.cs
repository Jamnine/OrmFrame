using System;

namespace Orm.Model.Custom
{

    /// <summary>
    /// 用户登录检查
    /// </summary>
    [Serializable]
    public class UserInfo
    {
        public UserInfo() {
            ViewName = new ViewName();
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int Userid { get; set; }
        /// <summary>
        /// 是否自动登录
        /// </summary>
        [System.ComponentModel.DefaultValue(false)]
        public bool AutomaticLogon { get; set; }
        /// <summary>
        /// 是否记住密码
        /// </summary>
        [System.ComponentModel.DefaultValue(false)]
        public bool RememberPwd { get; set; }
        /// <summary>
        /// 视图名称
        /// </summary>
        public ViewName ViewName { get; set; }

    }
}
