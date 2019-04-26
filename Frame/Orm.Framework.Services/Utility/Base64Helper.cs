using System;
using System.Text;

namespace Orm.Framework.Services
{
    public static class Base64Helper
    {
        /// <summary>
        /// 编码成Base64串
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string EncodeBase64(string code)
        {
            if (string.IsNullOrEmpty(code)) return string.Empty;

            try
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(code));
            }
            catch
            {
                return code; 
            }
        }

        /// <summary>
        /// 将Base64串解码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string DecodeBase64(string code)
        {
            if (string.IsNullOrEmpty(code)) return string.Empty;

            try
            {
                byte[] bytes = Convert.FromBase64String(code);
                string result= Encoding.UTF8.GetString(bytes);
                return result;
            }
            catch
            {
                return code;
            }
        }
    }
}
