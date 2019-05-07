using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Orm.Framework.Common
{
    public class QueryStringHelper
    {
        /// <summary>
        /// 获取string类型的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns>参数为空返回""</returns>
        public static string GetString(string request)
        {
            if (HttpContext.Current == null)
            {
                return string.Empty;
            }
            string requestValue = HttpContext.Current.Request[request];

            //return requestValue == null ? String.Empty :Commons.strSQLFilter(requestValue.Trim());
            return requestValue == null ? String.Empty : requestValue.Trim();

        }


        /// <summary>
        /// 获取string类型的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns>参数为空返回""</returns>
        public static string GetString(string request, string defaultVal)
        {
            if (HttpContext.Current == null)
            {
                return string.Empty;
            }
            string requestValue = HttpContext.Current.Request[request];
            if (string.IsNullOrEmpty(requestValue))
            {
                requestValue = defaultVal;
            }
            //return requestValue == null ? String.Empty :Commons.strSQLFilter(requestValue.Trim());
            return requestValue == null ? String.Empty : requestValue.Trim();

        }

        /// <summary>
        /// 获取Int32类型的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns>参数为空或转换出错返回0</returns>
        public static int GetInt(string request)
        {
            string requestValue = GetString(request);
            return StringHelper.StringToInt(requestValue);
        }
        /// <summary>
        /// 获取Int32类型的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns>参数为空或转换出错返回0</returns>
        public static int GetInt(string request, int defaultVal)
        {
            string requestValue = GetString(request);
            return StringHelper.StringToInt(requestValue, defaultVal);
        }


        /// <summary>
        /// 获取Int32类型的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns>参数为空或转换出错返回0</returns>
        public static long GetLong(string request)
        {
            string requestValue = GetString(request);
            return StringHelper.StringToLong(requestValue);
        }

        /// <summary>
        /// 获取Decimal类型的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns>参数为空或转换出错返回0</returns>
        public static decimal GetDecimal(string request)
        {
            string requestValue = GetString(request);
            return StringHelper.StringToDecimal(requestValue);
        }

        /// <summary>
        /// 获取Bool类型的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns>参数为空或转换出错返回false</returns>
        public static bool GetBool(string request)
        {
            string requestValue = GetString(request);
            return StringHelper.StringToBool(requestValue);
        }

        /// <summary>
        /// 获取时间类型的参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns>参数为空或转换出错返回1900-1-1</returns>
        public static DateTime? GetDateTime(string request)
        {
            string requestValue = GetString(request);
            DateTime dt = new DateTime(1900, 1, 1);
            try
            {
                if (string.IsNullOrEmpty(requestValue))
                {
                    return null;
                }
                dt = Convert.ToDateTime(requestValue);
            }
            catch
            { }
            return dt;
        }

        public static void ResponseWrite(object msg, bool endRespons)
        {
            HttpContext.Current.Response.Write(msg);
            if (endRespons)
            {
                HttpContext.Current.Response.End();
            }
        }
        public static void ResponseWrite(object msg)
        {
            HttpContext.Current.Response.Write(msg);
        }
        public static void ResponseWriteAndEnd(object msg)
        {
            HttpContext.Current.Response.Write(msg);
            HttpContext.Current.Response.End();
        }
        public static void ResponseWriteJsoncallback(object msg)
        {
            string jsoncallback = GetString("jsoncallback");
            if (String.IsNullOrEmpty(jsoncallback))
            {
                ResponseWriteAndEnd(msg);
            }
            else
            {
                HttpContext.Current.Response.Write(jsoncallback + "(" + msg + ")");
                HttpContext.Current.Response.End();
            }
        }

        public static void ResponseRedirect(string url)
        {
            HttpContext.Current.Response.Redirect(url, false);
        }

        public static void ResponseRedirect(string url, bool endResponse)
        {
            HttpContext.Current.Response.Redirect(url, endResponse);
        }

        /// <summary>
        /// 根据请求信息，以“key value”的形式组成集合
        /// </summary>
        /// <returns>request回来的信息组成的集合</returns>
        public static Hashtable GetRequestPostParams()
        {
            int i;
            Hashtable sArray = new Hashtable();
            String[] requestItem;

            NameValueCollection coll;
            if (HttpContext.Current.Request.HttpMethod != "GET")
            {
                coll = HttpContext.Current.Request.Form;
                requestItem = coll.AllKeys;
            }
            else
            {
                coll = HttpContext.Current.Request.QueryString;
                requestItem = coll.AllKeys;
            }
            for (i = 0; i < requestItem.Length; i++)
            {
                //if (requestItem[i] != "md5_sign")
                sArray.Add(requestItem[i], HttpContext.Current.Request[requestItem[i]]);
            }
            return sArray;
        }

        /// <summary>
        /// 参数按参数名称a-z排序排序
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static string GetSortQueryString(Hashtable parameters)
        {
            StringBuilder sb = new StringBuilder();
            ArrayList akeys = new ArrayList(parameters.Keys);
            //按参数名称a-z排序
            akeys.Sort();
            foreach (string k in akeys)
            {
                string v = (string)parameters[k];
                if (null != v && "".CompareTo(v) != 0)
                {
                    sb.Append(k + "=" + v + "&");
                }
            }
            //去掉最后一个&
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }
        #region 读取form 提交的文件
        /// <summary>
        /// 读取form 提交的文件
        /// </summary>
        /// <param name="name">key</param>
        /// <returns></returns>
        public static HttpPostedFile Getfiles(string name)
        {
            return HttpContext.Current.Request.Files[name];
        }

        public static HttpPostedFile Getfiles(int index)
        {
            return HttpContext.Current.Request.Files[index];
        }
        #endregion
    }
}
