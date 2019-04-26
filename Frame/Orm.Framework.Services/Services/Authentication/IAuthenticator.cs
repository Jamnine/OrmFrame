using System;

namespace Orm.Framework.Services
{

    /// <summary>
    /// 身份认证接口
    /// </summary>
    public interface IAuthenticator
    {
        /// <summary>
        /// 登陆接口，验证通过返回令牌
        /// </summary>
        string Login(string user, string password,string ipaddr="");

        /// <summary>
        /// 注销接口,返回无效令牌
        /// </summary>
        string Logout(string user);

        /// <summary>
        /// 验证令牌的有效性
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>

         /// <summary>
         /// 刷新令牌，延长令牌有效期
         /// </summary>
         /// <param name="token"></param>
         /// <returns></returns>
        string Refresh(string user,string token);
    }

    public sealed class Token
    {
        public string LoginName { get; set; }

        public string LoginIP { get; set; }

        public string Domain { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
