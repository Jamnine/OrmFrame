using System;
using System.Security.Cryptography;
using System.Text;

namespace Orm.Framework.Services
{
    public static class MD5Helper
    {
        public static string Encrypt(string text)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider MD5CSP = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] MD5Source = System.Text.Encoding.UTF8.GetBytes(text);
            byte[] MD5Out = MD5CSP.ComputeHash(MD5Source);
            return Convert.ToBase64String(MD5Out);
        }
        public static string GetStringByMd5(string str)
        {
            string password = "";
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] byteArray = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < byteArray.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                password = password + byteArray[i].ToString("x2");
            }
            return password;
        }
    }
}
