using System.Text.RegularExpressions;
using System;
using System.Web;

namespace Orm.Framework.Common
{

    /// <summary>
    /// 系统数据验证类
    /// </summary>
    public abstract class DataValidator
    {

        #region 判断对象是否为数值类型
        /// <summary>
        /// 判断对象是否为数值类型
        /// </summary>
        /// <param name="Expression"></param>
        /// <returns></returns>
        public static bool IsNumeric(object Expression)
        {
            string str = Commons.ToString(Expression);
            if (string.IsNullOrEmpty(str)) { return false; }
            if (str.Length > 0 && Regex.IsMatch(str, @"^[-]?[0-9]*[.]?[0-9]*$"))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 验证是否为整数
        /// <summary>
        /// 验证是否为整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsInt(object obj)
        {
            string str = Commons.ToString(obj);
            if (string.IsNullOrEmpty(str)) { return false; }
            int outValue;
            if (int.TryParse(str, out outValue))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 验证是否为正整数
        /// </summary>
        public static bool IsInt(object str, bool Plus)
        {
            str = Commons.ToString(str);
            if (string.IsNullOrEmpty(Commons.ToString(str))) { return false; }
            int outValue;
            if (int.TryParse(Commons.ToString(str), out outValue) && outValue >= 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 验证是否为Double类型的数字
        /// <summary>
        /// 判断对象是否为Double类型的数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDouble(object obj)
        {
            string str = Commons.ToString(obj);
            if (string.IsNullOrEmpty(str)) { return false; }
            double outValue;
            if (double.TryParse(str, out outValue))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 判断对象是否为正Double类型的数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDouble(object str, bool Plus)
        {
            if (string.IsNullOrEmpty(Commons.ToString(str))) { return false; }
            double outValue;
            if (double.TryParse(Commons.ToString(str), out outValue) && outValue >= 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 验证是否为Decimal类型的数字
        /// <summary>
        /// 判断对象是否为Decimal类型的数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDecimal(object obj)
        {
            string str = Commons.ToString(obj);
            if (string.IsNullOrEmpty(str)) { return false; }
            decimal outValue;
            if (decimal.TryParse(str, out outValue))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 判断对象是否为正Decimal类型的数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDecimal(object str, bool Plus)
        {
            if (string.IsNullOrEmpty(Commons.ToString(str))) { return false; }
            decimal outValue;
            if (decimal.TryParse(Commons.ToString(str), out outValue) && outValue >= 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 验是否可以转换为日期和时间
        /// <summary>
        /// 验是否可以转换为日期和时间
        /// </summary>
        /// <param name="strDateTime"></param>
        /// <returns></returns>
        public static bool IsDateTime(object obj)
        {
            string str = Commons.ToString(obj);
            if (string.IsNullOrEmpty(str)) { return false; }
            DateTime outValue;
            if (DateTime.TryParse(str, out outValue))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 验证是否可以转换为日期
        /// <summary>
        /// 验证是否可以转换为日期
        /// </summary>
        /// <param name="strDateTime"></param>
        /// <returns></returns>
        public static bool IsDate(object obj)
        {
            string str = Commons.ToString(obj);
            if (string.IsNullOrEmpty(str)) { return false; }
            try
            {
                DateTime newDateTime;
                newDateTime = DateTime.ParseExact(str, "yyyy-MM-dd", null);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 验证是否可以转换为时间
        /// <summary>
        /// 验证是否可以转换为时间
        /// </summary>
        /// <param name="strDateTime"></param>
        /// <returns></returns>
        public static bool IsTime(object obj)
        {
            string str = Commons.ToString(obj);
            if (string.IsNullOrEmpty(str)) { return false; }
            try
            {
                DateTime newDateTime = DateTime.ParseExact(str, "HH:mm:ss", null);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 验证是否可以转换为布尔值
        public static bool IsBool(object obj)
        {
            string str = Commons.ToString(obj);
            bool outValue;
            str = str == "1" ? "true" : str;
            str = str == "0" ? "false" : str;
            if (bool.TryParse(str, out outValue))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 验证是否可以转换为Guid类型
        /// <summary>
        /// 验证是否可以转换为Guid类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsGuid(object obj)
        {
            string str = Commons.ToString(obj);
            if (string.IsNullOrEmpty(str)) { return false; }
            try
            {
                Guid gd = new Guid(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 判断给定的字符串数组(strNumber)中的数据是不是都为数值型
        /// <summary>
        /// 判断给定的字符串数组(strNumber)中的数据是不是都为数值型
        /// </summary>
        /// <param name="strNumber">要确认的字符串数组</param>
        /// <returns>是则返加true 不是则返回 false</returns>
        public static bool IsNumericArray(string[] strNumber)
        {
            if (strNumber == null)
            {
                return false;
            }
            if (strNumber.Length < 1)
            {
                return false;
            }
            foreach (string id in strNumber)
            {
                if (!IsNumeric(id))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 验证注册用户名格式是否合法
        /// <summary>
        /// 验证注册用户名格式是否合法
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <returns>判断结果</returns>
        public static bool IsUserName(string strUserName)
        {
            return Regex.IsMatch(strUserName, @"^[a-zA-Z]{1}[a-zA-Z0-9_]{4,19}$");
        }
        #endregion



        #region 验证是否为IP
        /// <summary>
        /// 判断是否为IP
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");

        }
        #endregion

        #region 验证是否是Url
        /// <summary>
        /// 验证是否是正确的Url
        /// </summary>
        /// <param name="strUrl">要验证的Url</param>
        /// <returns>判断结果</returns>
        public static bool IsURL(string strUrl)
        {
            return Regex.IsMatch(strUrl, @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }
        #endregion

        #region 验证是否有Sql危险字符
        /// <summary>
        /// 验证是否有Sql危险字符
        /// </summary>
        /// <param name="str">要判断字符串</param>
        /// <returns>存在危险字符返回false,反之为true</returns>
        public static bool IsSafeSqlString(string str)
        {
            return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']");
        }
        #endregion

        #region 验证是否是手机号码
        /// <summary>
        /// 验证是否是手机号码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsMobile(string str)
        {
            return !string.IsNullOrEmpty(str) && new Regex("^(13|14|15|17|18)\\d{9}$").IsMatch(str);
        }

        /// <summary>
        /// 验证是否是移动的手机号码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsChinaMobile(string str)
        {
            return !string.IsNullOrEmpty(str) && new Regex("^(13[4-9]|15[0-2|7-9]|18[7|8])\\d{8}$").IsMatch(str);
        }


        /// <summary>
        /// 验证是否是联通的手机号码
        /// </summary>
        public static bool IsUnicomMobile(string str)
        {
            return !string.IsNullOrEmpty(str) && new Regex("^(13[0-2]|15[3|5|6]|186)\\d{8}$").IsMatch(str);
        }

        /// <summary>
        /// 判断是否CMWAP用户
        /// </summary>
        /// <returns>是否CMWAP用户</returns>
        public static bool IsCMWAP()
        {
            string sCMWAP = HttpContext.Current.Request.ServerVariables["HTTP_X_UP_BEAR_TYPE"];
            if (!string.IsNullOrEmpty(sCMWAP) && sCMWAP.ToUpper() == "GPRS/EDGE")
                return true;
            else
                return false;
        }
        #endregion

        #region 验证是否为固定电话号码
        /// <summary>
        /// 验证是否为固定电话号码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsTel(string str)
        {
            return Regex.IsMatch(str, @"(\(\d{3}\)|\d{3}-)?\d{8}");
        }
        #endregion

        #region 验证是否为邮政编码
        /// <summary>
        /// 验证是否为邮政编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPostCode(string str)
        {
            return Regex.IsMatch(str, @"\d{6}");
        }
        #endregion

        #region 验证是否为身份证号码
        /// <summary>
        /// 验证是否为身份证号码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsIDcard(string str)
        {
            return Regex.IsMatch(str, @"\d{17}[\d|X]|\d{15}");
        }
        #endregion

        #region 判断是否为图片文件名
        /// <summary>
        /// 判断文件名是否为浏览器可以直接显示的图片文件名
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <returns>是否可以直接显示</returns>
        public static bool IsImgFilename(string filename)
        {
            filename = filename.Trim();
            if (filename.EndsWith(".") || filename.IndexOf(".") == -1)
            {
                return false;
            }
            string extname = filename.Substring(filename.LastIndexOf(".") + 1).ToLower();
            return (extname == "jpg" || extname == "jpeg" || extname == "png" || extname == "bmp" || extname == "gif");
        }
        #endregion

        /// <summary>
        /// 检测字符串是否为数字
        /// </summary>
        /// <param name="input">需要检查的字符串</param>
        /// <returns>如果字符串为数字，则为 true；否则为 false。</returns>
        public static bool IsNumber(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, "^[0-9]+$");
            }
        }


        /// <summary>
        /// 检测字符串是否为数字，可带正负号
        /// </summary>
        /// <param name="input">需要检查的字符串</param>
        /// <returns>如果字符串为数字，则为 true；否则为 false。</returns>
        public static bool IsNumberSign(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, "^[+-]?[0-9]+$");
            }
        }

        /// <summary>
        /// 检测字符串是否为浮点数
        /// </summary>
        /// <param name="input">需要检查的字符串</param>
        /// <returns>如果字符串为浮点数，则为 true；否则为 false。</returns>
        public static bool IsDecimal(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, @"^[0-9]+(\.[0-9]+)?$");
            }
        }

        /// <summary>
        /// 检测字符串是否为浮点数 可带正负号
        /// </summary>
        /// <param name="input">需要检查的字符串</param>
        /// <returns>如果字符串为浮点数，则为 true；否则为 false。</returns>
        public static bool IsDecimalSign(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, @"^[+-]?[0-9]+(\.[0-9]+)?$");
            }
        }

        /// <summary>
        /// 检测字符串是否为有效的URL地址
        /// </summary>
        /// <param name="input">需要检查的字符串</param>
        /// <returns>如果字符串为有效的URL地址，则为 true；否则为 false。</returns>
        public static bool IsUrl(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$", RegexOptions.IgnoreCase);
            }
        }

        /// <summary>
        /// 检测字符串是否为有效的邮件地址
        /// </summary>
        /// <param name="input">需要检查的字符串</param>
        /// <returns>如果字符串为有效的邮件地址，则为 true；否则为 false。</returns>
        public static bool IsEmail(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            }
        }


        /// <summary>
        /// 检测字符串是否为有效的区号
        /// </summary>
        /// <param name="input">需要检查的字符串</param>
        /// <returns>如果字符串为有效的区号，则为 true；否则为 false。</returns>
        public static bool IsAreaCode(string input)
        {
            if (!IsNumber(input) || input.Length < 3 || input.Length > 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 检测字符串是否为有效的ID
        /// </summary>
        /// <param name="input">需要检查的字符串</param>
        /// <returns>如果字符串为有效的ID，则为 true；否则为 false。</returns>
        public static bool IsValidId(string input)
        {
            bool valid;
            if (string.IsNullOrEmpty(input))
            {
                valid = false;
            }
            else
            {
                input = input.Replace("|", string.Empty).Replace(",", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty).Trim();
                if (string.IsNullOrEmpty(input))
                {
                    valid = false;
                }
                else
                {
                    if (IsNumber(input))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
            }

            return valid;
        }

        /// <summary>
        /// 验证是否符合用户名规则
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>符合返回true，不符合返回false</returns>
        public static bool IsValidUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return false;
            }

            if (userName.Length > 20)
            {
                return false;
            }

            if (userName.Trim().Length == 0)
            {
                return false;
            }

            if (userName.Trim(new char[] { '.' }).Length == 0)
            {
                return false;
            }

            string notContains = @"\/""[]:|<>+=;,?*@";
            for (int i = 0; i < userName.Length; i++)
            {
                if (notContains.IndexOf(userName[i]) >= 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
