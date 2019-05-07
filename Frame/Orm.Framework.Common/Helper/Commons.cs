using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;


namespace Orm.Framework.Common
{
    /// <summary>
    /// 单位
    /// </summary>
    public enum DW
    {
        KB = 0, MB = 1, GB = 2, TB = 3, PB = 4, EB = 5, ZB = 6, YB = 7, BB = 8, NB = 9, DB = 10
    }

    public class Commons
    {


        /// <summary>
        /// 获取MB
        /// </summary>
        /// <param name="length">字节</param>
        /// <returns></returns>
        public static decimal GetFileLength(long length, DW dw)
        {
            double res = length * 1.0;
            int size = (int)dw;
            long _dw = 1;

            for (int i = 0; i < size; i++)
            {
                _dw = _dw * 1024;
            }
            decimal fileLlength = (decimal)res / _dw;

            return RoundHelper.Round(fileLlength, 2);
        }

        /// <summary>
        /// 获取KB
        /// </summary>
        /// <param name="length">字节</param>
        /// <returns></returns>
        public static decimal GetFileLength(decimal length, DW dw)
        {
            int size = (int)dw;
            long _dw = 1;

            for (int i = 0; i < size; i++)
            {
                _dw = _dw * 1024;
            }

            decimal fileLlength = length / _dw;

            return RoundHelper.Round(fileLlength, 2);
        }



        /// <summary>
        /// 获取指定规格图片
        /// </summary>
        /// <param name="url"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string GetSizeImgUrl(string url, string size)
        {
            if (!string.IsNullOrEmpty(url))
            {
                int index = url.LastIndexOf('.');

                if (index > 0)
                {
                    string format = url.Substring(index);
                    return url + "_" + size + "x" + size + format;//Path.GetExtension 
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// 根据URL生成图片HTML代码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetImage(string url)
        {
            return "<img src='" + url + "' />";
        }

        #region 基本数据类型转换

        /// <summary>
        /// 转换成字符串类型数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                return obj.ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// 转换成Int类型数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(object obj)
        {
            int outValue = (int)ToDecimal(obj);
            return outValue;
        }

        /// <summary>
        /// 转换成double类型数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double ToDouble(object obj)
        {
            double outValue = 0;
            if (!double.TryParse(ToString(obj), out outValue))
            {
                outValue = 0;
            }
            return outValue;
        }

        /// <summary>
        /// 转换成decimal类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal ToDecimal(object obj)
        {
            decimal outValue = 0;

            if (!decimal.TryParse(ToString(obj), out outValue))
            {
                outValue = 0;
            }
            return outValue;
        }

        /// <summary>
        /// 转换成bool类型数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool ToBool(object obj)
        {
            bool outValue = false;
            string str = ToString(obj);
            str = str == "1" ? "true" : str;
            str = str == "0" ? "false" : str;
            if (!bool.TryParse(str, out outValue))
            {
                outValue = false;
            }
            return outValue;
        }

        /// <summary>
        /// 获取字节
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte ToByte(object obj)
        {
            byte outValue = 0;
            if (byte.TryParse(ToString(obj), out outValue))
            {
                return outValue;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 获取byte数组
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Byte[] ToBytes(object obj)
        {
            if (!string.IsNullOrEmpty(ToString(obj)))
            {
                return (Byte[])obj;
            }
            else
                return null;
        }

        /// <summary>
        /// 转换成日期时间
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(object obj)
        {
            DateTime outValue;
            if (!DateTime.TryParse(ToString(obj), out outValue))
            {
                return DateTime.Now;
            }
            return outValue;
        }

        /// <summary>
        /// 转换成日期时间
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="isNullable">如果为true,当obj不能转换为datetime时返回null</param>
        /// <returns></returns>
        public static DateTime? ToDateTime(object obj, bool isNullable)
        {
            DateTime outValue;
            if (!DateTime.TryParse(ToString(obj), out outValue))
            {
                if (isNullable == true)
                {
                    return null;
                }
                else
                {
                    return DateTime.Now;
                }
            }
            return outValue;
        }

        /// <summary>
        /// 转换成日期时间字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToDateTimeString(object obj)
        {
            if (!DataValidator.IsDateTime(ToString(obj)))
            {
                return string.Empty;
            }
            else
            {
                return Convert.ToDateTime(obj).ToString();
            }
        }

        /// <summary>
        /// 转换成短日期字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToDateString(object obj)
        {
            if (!DataValidator.IsDateTime(ToString(obj)))
            {
                return string.Empty;
            }
            else
            {
                return Convert.ToDateTime(obj).ToString("yyyy-MM-dd");
            }
        }

        /// <summary>
        /// 转换成时间字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToTimeString(object obj)
        {
            if (!DataValidator.IsDateTime(ToString(obj)))
            {
                return string.Empty;
            }
            else
            {
                return Convert.ToDateTime(obj).ToString("HH:mm:ss");
            }
        }

        /// <summary>
        /// 转换成Guid
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Guid ToGuid(object obj)
        {
            string str = ToString(obj);
            if (string.IsNullOrEmpty(str)) return Guid.Empty;
            try
            {
                return new Guid(str);
            }
            catch
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// 转换成Guid
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="isNullable">如果为true,当obj不能转换为Guid类型时返回null</param>
        /// <returns></returns>
        public static Guid? ToGuid(object obj, bool isNullable)
        {
            string str = ToString(obj);
            try
            {
                Guid gd = new Guid(str);
                return gd;
            }
            catch
            {
                if (isNullable)
                {
                    return null;
                }
                else
                {
                    return Guid.Empty;
                }
            }
        }

        #endregion

        #region 获取整数或小数部分

        /// <summary>
        /// 返回整数部分
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToTruncate(object obj)
        {
            return (int)Math.Truncate(ToDecimal(obj));
        }

        /// <summary>
        /// 返回小数部分
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>返回小数位</returns>
        public static decimal ToTrunDecimal(object obj)
        {
            decimal d = ToDecimal(obj);
            decimal outValue = d - Math.Truncate(d);
            return outValue;
        }

        /// <summary>
        /// 获取小数部分字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>返回小数位的字符串</returns>
        public static string ToTrunDecimalString(object obj)
        {
            string s = ToString(obj);
            string[] ss = s.Split('.');
            if (ss.Length <= 1) return "";
            return ss[1];
        }

        #endregion

        #region Url编码、解码
        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="str">原字符串</param>
        /// <returns>字符串</returns>
        public static string UrlEncode(string str)
        {
            return UrlEncode(str, Encoding.UTF8);
        }

        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="str">原字符串</param>
        /// <param name="encode">编码类型</param>
        /// <returns>字符串</returns>
        public static string UrlEncode(string str, Encoding encode)
        {
            return HttpUtility.UrlEncode(str, encode);
        }

        /// <summary>
        /// URL解码
        /// </summary>
        /// <param name="str">编码过的字符串</param>
        /// <returns>字符串</returns>
        public static string UrlDecode(string str)
        {
            return UrlDecode(str, Encoding.UTF8);
        }

        /// <summary>
        /// URL解码
        /// </summary>
        /// <param name="str">编码过的字符串</param>
        /// <param name="encode">编码类型</param>
        /// <returns>字符串</returns>
        public static string UrlDecode(string str, Encoding encode)
        {
            return HttpUtility.UrlDecode(str, encode);
        }

        #endregion

        #region Html编码、解码

        /// <summary>
        /// 将字符转化为HTML编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HtmlEncode(object str)
        {
            return HtmlEncode(str, false);
        }

        /// <summary>
        /// 将字符转化为HTML编码
        /// </summary>
        /// <param name="str"></param>
        /// <param name="isReserveBR">是否保留&lt;br/&gt;</param>
        /// <returns></returns>
        public static string HtmlEncode(object str, bool isReserveBR)
        {
            string str2 = ToString(str);
            if (string.IsNullOrEmpty(str2))
            {
                return string.Empty;
            }
            if (isReserveBR)
            {
                return HttpContext.Current.Server.HtmlEncode(str2).Replace("\r\n", "<br />").Replace("\r", "<br />").Replace("\n", "<br />").Replace("&lt;br /&gt;", "<br />");
            }
            else
            {
                return HttpContext.Current.Server.HtmlEncode(str2);
            }
        }

        /// <summary>
        /// 将字符HTML解码
        /// <param name="str"></param>
        /// <param name="isReserveBR">是否保留&lt;br/&gt;</param>
        /// </summary>
        public static string HtmlDecode(object str)
        {
            return HtmlDecode(str, false);
        }

        /// <summary>
        /// 将字符HTML解码
        /// <param name="str"></param>
        /// <param name="isReserveBR">是否保留&lt;br/&gt;</param>
        /// </summary>
        public static string HtmlDecode(object str, bool isReserveBR)
        {
            string str2 = ToString(str);
            if (string.IsNullOrEmpty(str2))
            {
                return string.Empty;
            }
            if (isReserveBR)
            {
                return HttpContext.Current.Server.HtmlDecode(str2).Replace("\r\n", "<br />").Replace("\r", "<br />").Replace("\n", "<br />");
            }
            else
            {
                return HttpContext.Current.Server.HtmlDecode(str2);
            }
        }

        #endregion

        #region Base64编码、解码

        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string Base64Encode(string source)
        {
            return Base64Encode(source, Encoding.UTF8);
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <param name="codeName">加密采用的编码方式</param>
        /// <returns></returns>
        public static string Base64Encode(string source, Encoding encode)
        {
            byte[] bytes = encode.GetBytes(source);
            string encodeStr;
            try
            {
                encodeStr = Convert.ToBase64String(bytes);
            }
            catch
            {
                encodeStr = source;
            }
            return encodeStr;
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(string result)
        {
            return Base64Decode(result, Encoding.UTF8);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <param name="codeName">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(string result, Encoding encode)
        {
            string decodeStr = "";
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decodeStr = encode.GetString(bytes);
            }
            catch
            {
                decodeStr = result;
            }
            return decodeStr;
        }

        #endregion

        #region SQL转义

        /// <summary>
        /// 过滤SQL不安全字符
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static string SafeSqlEscape(string sqlString)
        {
            if (string.IsNullOrEmpty(sqlString))
            {
                return "";
            }

            string str = sqlString;

            str = str.Replace("'", "''");

            return str;
        }

        /// <summary>
        /// SQL Like通配符转义
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public static string SqlLikeCharEscape(string sqlString)
        {
            if (string.IsNullOrEmpty(sqlString)) return "";
            string str = sqlString;
            str = str.Replace("'", "''");
            str = str.Replace("[", "[[]");
            str = str.Replace("%", "[%]");
            str = str.Replace("_", "[_]");
            return str;
        }

        #region 字符串sql危险字段过滤

        /// <summary>
        /// 过滤sql语句危险关键字
        /// </summary>
        /// <param name="str">危险语句</param>
        /// <returns>过滤后的语句</returns>
        public static string strSQLFilter(string str)
        {
            str = str.Replace("%", "％");
            //str = str.Replace("<", "&lt;");
            //str = str.Replace(">", "&gt;");
            //str = str.Replace("'", "＇");
            str = str.Replace("select", "ｓｅｌｅｃｔ");
            str = str.Replace("update", "ｕｐｄａｔｅ");
            str = str.Replace("delete", "ｄｅｌｅｔｅ");
            str = str.Replace("xp_cmdshell", "ｘｐ＿ｃｍｄｓｈｅｌｌ");
            str = str.Replace("xp_dirtree", "ｘｐ＿ｄｉｒｔｒｅｅ");
            str = str.Replace("xp_fileexist", "ｘｐ＿ｆｉｌｅｅｘｉｓｔ");
            str = str.Replace("xp_terminate_process", "ｘｐ＿ｔｅｒｍｉｎａｔｅ＿ｐｒｏｃｅｓｓ");
            str = str.Replace("sp_oamethod", "ｓｐ＿ｏａｍｅｔｈｏｄ");
            str = str.Replace("sp_oacreate", "ｓｐ＿ｏａｃｒｅａｔｅ");
            str = str.Replace("xp_regaddmultistring", "ｘｐ＿ｒｅｇａｄｄｍｕｌｔｉｓｔｒｉｎｇ");
            str = str.Replace("xp_regdeletekey", "ｘｐ＿ｒｅｇｄｅｌｅｔｅｋｅｙ");
            str = str.Replace("xp_regdeletevalue", "ｘｐ＿ｒｅｇｄｅｌｅｔｅｖａｌｕｅ");
            str = str.Replace("xp_regenumkeys", "ｘｐ＿ｒｅｇｅｎｕｍｋｅｙｓ");
            str = str.Replace("xp_regenumvalues", "ｘｐ＿ｒｅｇｅｎｕｍｖａｌｕｅｓ");
            str = str.Replace("sp_add_job", "ｓｐ＿ａｄｄ＿ｊｏｂ");
            str = str.Replace("sp_addtask", "ｓｐ＿ａｄｄｔａｓｋ");
            str = str.Replace("xp_regread", "ｘｐ＿ｒｅｇｒｅａｄ");
            str = str.Replace("xp_regwrite", "ｘｐ＿ｒｅｇｗｒｉｔｅ");
            str = str.Replace("xp_readwebtask", "ｘｐ＿ｒｅａｄｗｅｂｔａｓｋ");
            str = str.Replace("xp_makewebtask", "ｘｐ＿ｍａｋｅｗｅｂｔａｓｋ");
            return str;
        }

        /// <summary>
        /// 反过滤sql语句
        /// </summary>
        /// <param name="str">经过过滤的语句</param>
        /// <returns>原来的语句</returns>
        public static string strReSQLFilter(string str)
        {
            str = str.Replace("％", "%");
            //str = str.Replace( "&lt;", "<");
            //str = str.Replace( "&gt;", ">");
            str = str.Replace("＇", "'");
            str = str.Replace("ｓｅｌｅｃｔ", "select");
            str = str.Replace("ｕｐｄａｔｅ", "update");
            str = str.Replace("ｄｅｌｅｔｅ", "delete");
            str = str.Replace("ｘｐ＿ｃｍｄｓｈｅｌｌ", "xp_cmdshell");
            str = str.Replace("ｘｐ＿ｄｉｒｔｒｅｅ", "xp_dirtree");
            str = str.Replace("ｘｐ＿ｆｉｌｅｅｘｉｓｔ", "xp_fileexist");
            str = str.Replace("ｘｐ＿ｔｅｒｍｉｎａｔｅ＿ｐｒｏｃｅｓｓ", "xp_terminate_process");
            str = str.Replace("ｓｐ＿ｏａｍｅｔｈｏｄ", "sp_oamethod");
            str = str.Replace("ｓｐ＿ｏａｃｒｅａｔｅ", "sp_oacreate");
            str = str.Replace("ｘｐ＿ｒｅｇａｄｄｍｕｌｔｉｓｔｒｉｎｇ", "xp_regaddmultistring");
            str = str.Replace("ｘｐ＿ｒｅｇｄｅｌｅｔｅｋｅｙ", "xp_regdeletekey");
            str = str.Replace("ｘｐ＿ｒｅｇｄｅｌｅｔｅｖａｌｕｅ", "xp_regdeletevalue");
            str = str.Replace("ｘｐ＿ｒｅｇｅｎｕｍｋｅｙｓ", "xp_regenumkeys");
            str = str.Replace("ｘｐ＿ｒｅｇｅｎｕｍｖａｌｕｅｓ", "xp_regenumvalues");
            str = str.Replace("ｓｐ＿ａｄｄ＿ｊｏｂ", "sp_add_job");
            str = str.Replace("ｓｐ＿ａｄｄｔａｓｋ", "sp_addtask");
            str = str.Replace("ｘｐ＿ｒｅｇｒｅａｄ", "xp_regread");
            str = str.Replace("ｘｐ＿ｒｅｇｗｒｉｔｅ", "xp_regwrite");
            str = str.Replace("ｘｐ＿ｒｅａｄｗｅｂｔａｓｋ", "xp_readwebtask");
            str = str.Replace("ｘｐ＿ｍａｋｅｗｅｂｔａｓｋ", "xp_makewebtask");
            return str;
        }

        #endregion

        #endregion

        #region Json字符编码

        /// <summary>
        /// 将Json字符串转成Unicode
        /// </summary>
        /// <param name="jsonString">原字符串</param>
        /// <returns></returns>
        public static string StringToJsonUnicode(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString)) return "";
            string str = jsonString;
            str = str.Replace("'", "\\u0027");
            str = str.Replace("\"", "\\u0022");
            str = str.Replace("\\", "\\u005C");
            str = str.Replace("/", "\\u002f");
            str = str.Replace("\b", "\\u0008");
            str = str.Replace("\t", "\\u0009");
            str = str.Replace("\f", "\\u000c");
            str = str.Replace("\r", "\\u000d");
            str = str.Replace("\n", "\\u000a");
            return str;
        }

        /// <summary>
        /// 过滤特殊字符
        /// </summary>
        /// <param name="srcText">原字符串</param>
        /// <returns></returns>
        public static string StringToJson(String srcText)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < srcText.Length; i++)
            {
                char c = srcText.ToCharArray()[i];
                switch (c)
                {
                    case '\"':
                        sb.Append("\\\""); break;
                    case '\\':
                        sb.Append("\\\\"); break;
                    case '/':
                        sb.Append("\\/"); break;
                    case '\b':
                        sb.Append("\\b"); break;
                    case '\f':
                        sb.Append("\\f"); break;
                    case '\n':
                        sb.Append("\\n"); break;
                    case '\r':
                        sb.Append("\\r"); break;
                    case '\t':
                        sb.Append("\\t"); break;
                    default:
                        sb.Append(c); break;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 格式化字符型、日期型、布尔型
        /// </summary>
        /// <param name="srcText">原字符串</param>
        /// <param name="type">类型[限字符串、日期、布尔三种]</param>
        /// <returns></returns>
        public static string StringFormat(string srcText, Type type)
        {
            if (type == typeof(string))
            {
                srcText = StringToJson(srcText);
                srcText = "\"" + srcText + "\"";
            }
            else if (type == typeof(DateTime))
            {
                srcText = "\"" + srcText + "\"";
            }
            else if (type == typeof(bool))
            {
                srcText = srcText.ToLower();
            }
            else if (type != typeof(string) && string.IsNullOrEmpty(srcText))
            {
                srcText = "\"" + srcText + "\"";
            }
            return srcText;
        }

        #endregion

        #region unicode与字符串相互转换

        /// <summary>
        /// 将原始字符串转换为unicode,格式为\u....\u....
        /// </summary>
        /// <param name="srcText">原始字符串</param>
        /// <returns>Uncode字符</returns>
        public static string StringToUnicode(string srcText)
        {
            string dst = "";
            char[] src = srcText.ToCharArray();
            for (int i = 0; i < src.Length; i++)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(src[i].ToString());
                string str = @"\u" + bytes[1].ToString("X2") + bytes[0].ToString("X2");
                dst += str;
            }
            return dst;
        }

        /// <summary>
        /// 将Unicode字串\u....\u....格式字串转换为原始字符串
        /// </summary>
        /// <param name="srcText">unicode字符串</param>
        /// <returns>原始字符串</returns>
        public static string UnicodeToString(string srcText)
        {
            string dst = "";
            string src = srcText;
            int len = srcText.Length / 6;

            for (int i = 0; i <= len - 1; i++)
            {
                string str = "";
                str = src.Substring(0, 6).Substring(2);
                src = src.Substring(6);
                byte[] bytes = new byte[2];
                bytes[1] = byte.Parse(int.Parse(str.Substring(0, 2), NumberStyles.HexNumber).ToString());
                bytes[0] = byte.Parse(int.Parse(str.Substring(2, 2), NumberStyles.HexNumber).ToString());
                dst += Encoding.Unicode.GetString(bytes);
            }
            return dst;
        }

        #endregion



        #region 取得前一个（上次提交或链接进来的）网页的URL

        /// <summary>
        /// 取得前一个（上次提交或链接进来的）网页的URL
        /// </summary>
        /// <returns></returns>
        public static string GetReferrerUrl()
        {
            Uri uri = HttpContext.Current.Request.UrlReferrer;
            if (uri != null)
            {
                return uri.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion

        #region 取得客户端真实IP。如果有代理则取第一个非内网地址

        //// <summary> 
        /// 取得客户端真实IP。如果有代理则取第一个非内网地址 
        /// by flower.b 
        /// </summary> 
        public static string GetRequestIP()
        {
            string result = String.Empty;

            result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (result != null && result != String.Empty)
            {
                //可能有代理 
                if (result.IndexOf(".") == -1) //没有“.”肯定是非IPv4格式 
                {
                    result = null;
                }
                else
                {
                    if (result.IndexOf(",") != -1)
                    {
                        //有“,”，估计多个代理。取第一个不是内网的IP。 
                        result = result.Replace(" ", "").Replace("'", "");
                        string[] temparyip = result.Split(",;".ToCharArray());
                        for (int i = 0; i < temparyip.Length; i++)
                        {
                            if (DataValidator.IsIP(temparyip[i])
                            && temparyip[i].Substring(0, 3) != "10."
                            && temparyip[i].Substring(0, 7) != "192.168"
                            && temparyip[i].Substring(0, 7) != "172.16.")
                            {
                                return temparyip[i]; //找到不是内网的地址 
                            }
                        }
                    }
                    else if (DataValidator.IsIP(result)) //代理即是IP格式 
                    {
                        return result;
                    }
                    else
                    {
                        result = null; //代理中的内容 非IP，取IP 
                    }
                }
            }

            if (null == result || result == String.Empty)
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            if (result == null || result == String.Empty)
            {
                result = HttpContext.Current.Request.UserHostAddress;
            }

            if (result == "127.0.0.1" || result == "::1")//获取本机内网IP
            {
                System.Net.IPAddress[] addressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;//获取本机内网IP

                string strgetIP = addressList.Length > 0 ? addressList[0].ToString() : String.Empty;

                if (DataValidator.IsIP(strgetIP)) //代理即是IP格式 
                {
                    result = strgetIP;
                }
            }
            return result;
        }

        #endregion

        #region  获取网站目录的物理路径

        /// <summary>
        /// 获取网站根目录的物理路径
        /// </summary>
        /// <returns>物理路径</returns>
        public static string GetMapPath()
        {
            string AppPath = "";

            HttpContext HttpCurrent = HttpContext.Current;

            if (HttpCurrent != null)
            {
                AppPath = HttpCurrent.Server.MapPath("~");
            }
            else //非web程序引用
            {
                AppPath = AppDomain.CurrentDomain.BaseDirectory;

                if (Regex.Match(AppPath, @"\\$", RegexOptions.Compiled).Success)
                {
                    AppPath = AppPath.Substring(0, AppPath.Length - 1);
                }
            }
            return AppPath;
        }

        /// <summary>
        /// 获取指定目录(或Url)的物理路径
        /// </summary>
        /// <param name="path">指定的路径</param>
        /// <returns>物理路径</returns>
        public static string GetMapPath(string path)
        {
            if (HttpContext.Current != null)
            {
                return HttpContext.Current.Server.MapPath(path);
            }
            else //非web程序引用
            {
                path = path.Replace("/", "\\");
                if (path.StartsWith("\\"))
                {
                    path = path.Substring(path.IndexOf('\\', 1)).TrimStart('\\');
                }
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            }
        }

        #endregion

        #region 获取网站根目录的URL

        /// <summary>
        /// 获取网站的根目录的URL
        /// </summary>
        /// <returns></returns>
        public static string GetRootURI()
        {
            string AppPath = "";
            HttpContext HttpCurrent = HttpContext.Current;
            HttpRequest Req;

            if (HttpCurrent != null)
            {
                Req = HttpCurrent.Request;

                string UrlAuthority = Req.Url.GetLeftPart(UriPartial.Authority);

                if (Req.ApplicationPath == null || Req.ApplicationPath == "/")
                {
                    //直接安装在   Web   站点   
                    AppPath = UrlAuthority;
                }
                else
                {
                    //安装在虚拟子目录下   
                    AppPath = UrlAuthority + Req.ApplicationPath;
                }
            }
            return AppPath;
        }

        /// <summary>
        /// 获取网站的根目录的URL
        /// </summary>
        /// <param name="Req"></param>
        /// <returns></returns>
        public static string GetRootURI(HttpRequest Req)
        {
            string AppPath = "";
            if (Req != null)
            {
                string UrlAuthority = Req.Url.GetLeftPart(UriPartial.Authority);
                if (Req.ApplicationPath == null || Req.ApplicationPath == "/")
                {
                    //直接安装在   Web   站点   
                    AppPath = UrlAuthority;
                }
                else
                {
                    //安装在虚拟子目录下   
                    AppPath = UrlAuthority + Req.ApplicationPath;
                }
            }
            return AppPath;
        }

        #endregion

        #region 取得与当前时间的间隔描述

        /// <summary>
        /// 取得与当前时间的间隔(MM-dd hh:mm 刚刚更新)
        /// </summary>
        public static string GetTimeSpanDescription(DateTime time1)
        {
            string strTime = "";
            DateTime date1 = DateTime.Now;
            DateTime date2 = time1;
            TimeSpan dt = date1 - date2;

            // 相差天数
            int days = dt.Days;
            // 时间点相差小时数
            int hours = dt.Hours;
            // 相差总小时数
            double Minutes = dt.Minutes;
            // 相差总秒数
            int second = dt.Seconds;

            if (second < 0) { second = 0; }
            if (days == 0 && hours == 0 && Minutes == 0)
            {
                strTime = "刚刚更新";
            }
            else if (days == 0 && hours == 0)
            {
                strTime = Minutes + "分钟前";
            }
            else if (days == 0)
            {
                strTime = hours + "小时前";
            }
            else
            {
                strTime = time1.ToString("yyyy-MM-dd HH:mm");
            }
            return strTime;
        }
        #endregion

        #region 获取时间间隔
        /// <summary>
        /// 获取与当前时间相隔天数
        /// </summary>
        /// <param name="time1">时间1</param>
        /// <returns>天数</returns>
        public static int GetDaysSpan(DateTime time1)
        {
            TimeSpan ts = DateTime.Now - time1;
            return ts.Days;
        }

        /// <summary>
        /// 获取与当前时间相隔小时数
        /// </summary>
        /// <param name="time1">时间1</param>
        /// <returns>小时数</returns>
        public static int GetHoursSpan(DateTime time1)
        {
            TimeSpan ts = DateTime.Now - time1;
            return ts.Hours;
        }

        /// <summary>
        /// 获取与当前时间相隔分钟数
        /// </summary>
        /// <param name="time1">时间1</param>
        /// <returns>分钟数</returns>
        public static int GetMinutesSpan(DateTime time1)
        {
            TimeSpan ts = DateTime.Now - time1;
            return ts.Minutes;
        }

        /// <summary>
        /// 获取与当前时间相隔秒数
        /// </summary>
        /// <param name="time1">时间1</param>
        /// <returns>秒数</returns>
        public static int GetSecondsSpan(DateTime time1)
        {
            TimeSpan ts = DateTime.Now - time1;
            return ts.Seconds;
        }

        /// <summary>
        /// 获取与当前时间相隔毫秒数
        /// </summary>
        /// <param name="time1">时间1</param>
        /// <returns>毫秒数</returns>
        public static int GetMillisecondsSpan(DateTime time1)
        {
            TimeSpan ts = DateTime.Now - time1;
            return ts.Milliseconds;
        }

        #endregion /// 去除iframe

        #region 返回星期

        /// <summary>
        /// 返回星期
        /// </summary>
        /// <returns></returns>
        public static string GetWeek()
        {
            string weekName = DateTime.Now.DayOfWeek.ToString();
            switch (weekName)
            {
                case "Sunday": return "星期天";
                case "Monday": return "星期一";
                case "Tuesday": return "星期二";
                case "Wednesday": return "星期三";
                case "Thursday": return "星期四";
                case "Friday": return "星期五";
                case "Saturday": return "星期六";
                default: return "星期天";
            }
        }

        /// <summary>
        /// 返回指定日期星期
        /// </summary>
        /// <param name="date">2012-10-01</param>
        /// <returns></returns>
        public static string GetWeek(DateTime date)
        {
            switch (date.DayOfWeek.ToString())
            {
                case "Sunday": return "星期天";
                case "Monday": return "星期一";
                case "Tuesday": return "星期二";
                case "Wednesday": return "星期三";
                case "Thursday": return "星期四";
                case "Friday": return "星期五";
                case "Saturday": return "星期六";
                default: return "星期天";
            }
        }

        #endregion

        #region IsPost/IsGet/IsBrowserGet/IsSearchEnginesGet

        /// <summary>
        /// 判断当前页面是否接收到了Post请求
        /// </summary>
        /// <returns>是否接收到了Post请求</returns>
        public static bool IsPost()
        {
            return HttpContext.Current.Request.HttpMethod.Equals("POST");
        }

        /// <summary>
        /// 判断当前页面是否接收到了Get请求
        /// </summary>
        /// <returns>是否接收到了Get请求</returns>
        public static bool IsGet()
        {
            return HttpContext.Current.Request.HttpMethod.Equals("GET");
        }

        /// <summary>
        /// 判断当前访问是否来自浏览器软件
        /// </summary>
        /// <returns>当前访问是否来自浏览器软件</returns>
        public static bool IsBrowserGet()
        {
            string[] BrowserName = { "ie", "opera", "netscape", "mozilla", "konqueror", "firefox" };
            string curBrowser = HttpContext.Current.Request.Browser.Type.ToLower();
            for (int i = 0; i < BrowserName.Length; i++)
            {
                if (curBrowser.IndexOf(BrowserName[i]) >= 0) return true;
            }
            return false;
        }

        /// <summary>
        /// 判断是否来自搜索引擎链接
        /// </summary>
        /// <returns>是否来自搜索引擎链接</returns>
        public static bool IsSearchEnginesGet()
        {
            if (HttpContext.Current.Request.UrlReferrer != null)
            {
                string[] strArray = new string[] { "google", "yahoo", "msn", "baidu", "sogou", "sohu", "sina", "163", "lycos", "tom", "yisou", "iask", "soso", "gougou", "zhongsou" };
                string str = HttpContext.Current.Request.UrlReferrer.ToString().ToLower();
                for (int i = 0; i < strArray.Length; i++)
                {
                    if (str.IndexOf(strArray[i]) >= 0) return true;
                }
            }
            return false;
        }

        #endregion

        #region  GetServerString/GetPageName/GetCurrentFullHost/GetRawUrl/GetCurrentUrl/GetOS/GetBrowser/

        /// <summary>
        /// 返回指定的服务器变量信息
        /// </summary>
        /// <param name="strName">服务器变量名</param>
        /// <returns>服务器变量信息</returns>
        public static string GetServerString(string strName)
        {
            if (HttpContext.Current.Request.ServerVariables[strName] == null)
            {
                return "";
            }
            return HttpContext.Current.Request.ServerVariables[strName].ToString();
        }

        //// <summary>
        /// 获得当前页面的名称
        /// </summary>
        /// <returns>当前页面的名称</returns>
        public static string GetPageName()
        {
            string[] urlArr = HttpContext.Current.Request.Url.AbsolutePath.Split('/');
            return urlArr[urlArr.Length - 1].ToLower();
        }

        /// <summary>
        /// 取全IP包括端口
        /// </summary>
        /// <returns>IP和端口</returns>
        public static string GetCurrentFullHost()
        {
            HttpRequest request = HttpContext.Current.Request;
            if (!request.Url.IsDefaultPort)
            {
                return string.Format("{0}:{1}", request.Url.Host, request.Url.Port.ToString());
            }
            return request.Url.Host;
        }

        /// <summary>
        /// 取主机名
        /// </summary>
        /// <returns></returns>
        public static string GetHost()
        {
            return HttpContext.Current.Request.Url.Host;
        }

        /// <summary>
        /// 获取当前请求的原始 URL(URL 中域信息之后的部分,包括查询字符串(如果存在))
        /// </summary>
        /// <returns>原始URL</returns>
        public static string GetRawUrl()
        {
            return HttpContext.Current.Request.RawUrl;
        }

        /// <summary>
        /// 当前页面URL
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentUrl()
        {
            return HttpContext.Current.Request.Url.ToString();
        }

        /// <summary>
        /// 取操作系统
        /// </summary>
        /// <returns>返回操作系统</returns>
        public static string GetOS()
        {
            HttpBrowserCapabilities bc = new HttpBrowserCapabilities();
            bc = System.Web.HttpContext.Current.Request.Browser;
            return bc.Platform;
        }

        /// <summary>
        /// 取游览器
        /// </summary>
        /// <returns>返回游览器</returns>
        public static string GetBrowser()
        {
            HttpBrowserCapabilities bc = new HttpBrowserCapabilities();
            bc = System.Web.HttpContext.Current.Request.Browser;
            return bc.Type;
        }

        #endregion

        #region 返回表单或Url参数的总个数

        /// <summary>
        /// 返回表单或Url参数的总个数
        /// </summary>
        /// <returns></returns>
        public static int GetParamCount()
        {
            return HttpContext.Current.Request.Form.Count + HttpContext.Current.Request.QueryString.Count;
        }

        /// <summary>
        /// 返回Url Get参数的总个数
        /// </summary>
        /// <returns></returns>
        public static int GetQueryParamCount()
        {
            return (HttpContext.Current.Request.QueryString.Count);
        }
        /// <summary>
        /// 返回表单Post参数的总个
        /// </summary>
        /// <returns></returns>
        public static int GetFormParamCount()
        {
            return (HttpContext.Current.Request.Form.Count);
        }
        #endregion

        #region 返回文件路径

        /// <summary>
        /// 返回文件路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetMapPaht(string path)
        {
            return HttpContext.Current.Server.MapPath(path);
        }

        #endregion

        #region 隐藏手机中邮箱间数字
        public static string GetSubStr(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (DataValidator.IsMobile(str))
                {
                    return str.Substring(0, 2) + "***" + str.Substring(str.Length - 3);
                }

                if (DataValidator.IsEmail(str))
                {
                    return str.Substring(0, 2) + "***" + str.Substring(str.Length - 3);
                }

                if (str.Length > 3)
                {
                    return str.Substring(0, 2) + "**" + str.Substring(str.Length - 2);
                }
                return str;
            }
            return "";
        }
        #endregion
    }
}
