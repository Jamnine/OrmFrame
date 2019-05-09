using System;
using System.Collections.Generic;
using System.Text;

namespace OracleDataToRedis.Utils
{
    public class StringHelper
    {
        /// <summary>
        /// 从字符串前后移除对应的需要移除的字符串.
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="trimstr">要移除的字符串</param>
        /// <returns>结果字符串</returns>
        public static string Trim(string str, string trimstr)
        {
            if (str.StartsWith(trimstr) == true)
            {
                str = str.Remove(0, trimstr.Length);
            }
            if (str.EndsWith(trimstr) == true)
            {
                str = str.Remove(str.Length - trimstr.Length);
            }
            return str;
        }

        /// <summary>
        /// 从字符串前移除对应的需要移除的字符串.
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="trimstr">要移除的字符串</param>
        /// <returns>结果字符串</returns>
        public static string TrimStart(string str, string trimstr)
        {
            if (str.StartsWith(trimstr) == true)
            {
                str = str.Remove(0, trimstr.Length);
            }
            return str;
        }

        /// <summary>
        /// 从字符串后移除对应的需要移除的字符串.
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="trimstr">要移除的字符串</param>
        /// <returns>结果字符串</returns>
        public static string TrimEnd(string str, string trimstr)
        {
            if (str.EndsWith(trimstr) == true)
            {
                str = str.Remove(str.Length - trimstr.Length);
            }
            return str;
        }
    }
}
