using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace Orm.Client.Common
{
   public class JsonHelper
    {
        #region Object转JSON
        /// <summary>
        /// 对象转JSON
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>JSON格式的字符串</returns>
        public static string ObjectToJSON(object obj)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                return jss.Serialize(obj);
            }
            catch (Exception ex)
            {

                throw new Exception("JSONHelper.ObjectToJSON(): " + ex.Message);
            }
        }
        #endregion

        #region 序列化、反序列化
        /// <summary>
        /// 对象序列化
        /// </summary>
        /// <typeparam name="T"><peparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static String Serialize<T>(T obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            String s;
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            s = ser.Serialize(obj);

            return s;
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"><peparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T Deserialize<T>(String json) where T : class, new()
        {
            if (String.IsNullOrEmpty(json))
            {
                return new T();
            }
            return JSONToObject<T>(json);
        }
        #endregion

        #region JSON文本转对象,泛型方法
        /// <summary>
        /// JSON文本转对象,泛型方法
        /// </summary>
        /// <typeparam name="T">类型<peparam>
        /// <param name="jsonText">JSON文本</param>
        /// <returns>指定类型的对象</returns>
        public static T JSONToObject<T>(string jsonText)
        {
            if (string.IsNullOrEmpty(jsonText))
            {
                return default(T);
            }

            string p = @"\\/Date\(\d+\)\\/";
            MatchEvaluator matchEvaluator = new MatchEvaluator(ConvertDateStringToJsonDate);
            Regex reg = new Regex(p);
            jsonText = reg.Replace(jsonText, matchEvaluator);

            JavaScriptSerializer jss = new JavaScriptSerializer();
            jss.MaxJsonLength = Int32.MaxValue; //create new by lb  
            try
            {

                return jss.Deserialize<T>(jsonText);
            }
            catch (Exception ex)
            {
                throw new Exception("JSONHelper.JSONToObject(): " + ex.Message);
            }
        }
        public static object JSONToObject(string jsonText, object obj)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                return jss.Deserialize(jsonText, obj.GetType());

            }
            catch (Exception ex)
            {
                throw new Exception("JSONHelper.JSONToObject(): " + ex.Message);
            }
        }
        #endregion

        /// <summary>    
        /// 将时间字符串转为Json时间    
        /// </summary>    
        private static string ConvertDateStringToJsonDate(Match m)
        {
            string result = string.Empty;

            string p = @"\d";
            var cArray = m.Value.ToCharArray();
            StringBuilder sb = new StringBuilder();

            Regex reg = new Regex(p);
            for (int i = 0; i < cArray.Length; i++)
            {
                if (reg.IsMatch(cArray[i].ToString()))
                {
                    sb.Append(cArray[i]);
                }
            }
            // reg.Replace(m.Value;

            DateTime dt = new DateTime(1970, 1, 1);

            dt = dt.AddMilliseconds(long.Parse(sb.ToString()));

            dt = dt.ToLocalTime();

            result = dt.ToString("yyyy-MM-dd HH:mm:ss");

            return result;
        }



    }
}
