using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Orm.Client.Common
{
    public class BaiDuSDK
    {
        public string strJSON = "";

        public string getStrAccess(string para_API_key, string para_API_secret_key)
        {

            //方法参数说明:
            //para_API_key:API_key(你的KEY)
            //para_API_secret_key(你的SECRRET_KEY)

            //方法返回值说明:
            //百度认证口令码,access_token
            string access_html = null;
            string access_token = null;
            string getAccessUrl = "https://openapi.baidu.com/oauth/2.0/token?grant_type=client_credentials" +
           "&client_id=" + para_API_key + "&client_secret=" + para_API_secret_key;
            try
            {
                HttpWebRequest getAccessRequest = WebRequest.Create(getAccessUrl) as HttpWebRequest;
                //getAccessRequest.Proxy = null;
                getAccessRequest.ContentType = "multipart/form-data";
                getAccessRequest.Accept = "*/*";
                getAccessRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)";
                getAccessRequest.Timeout = 30000;//30秒连接不成功就中断 
                getAccessRequest.Method = "post";

                HttpWebResponse response = getAccessRequest.GetResponse() as HttpWebResponse;
                using (StreamReader strHttpComback = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    access_html = strHttpComback.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                //Orm.Client.Base.FrmMessageRemind.Show(ex.Message);
                throw ex;
            }

            JObject jo = JObject.Parse(access_html);
            access_token = jo["access_token"].ToString();//得到返回的toke
            return access_token;
        }




        public string getStrText(string para_API_id, string para_API_access_token, string para_API_language, string para_API_record, string para_format, string para_Hz)
        {
            //方法参数说明:
            //para_API_id: API_id (你的ID)
            //para_API_access_token (getStrAccess(...)方法得到的access_token口令)
            //para_API_language (你要识别的语言,zh,en,ct)
            //para_API_record(语音文件的路径)
            //para_format(语音文件的格式)
            //para_Hz(语音文件的采样率 16000或者8000)

            //该方法返回值:
            //该方法执行正确返回值是语音翻译的文本,错误是错误号,可以去看百度语音文档,查看对应错误

            string strText = null;
            string error = null;
            FileInfo fi = new FileInfo(para_API_record);
            FileStream fs = new FileStream(para_API_record, FileMode.Open);
            byte[] voice = new byte[fs.Length];
            fs.Read(voice, 0, voice.Length);
            fs.Close();

            string getTextUrl = "http://vop.baidu.com/server_api?lan=" + para_API_language + "&cuid=" + para_API_id + "&token=" + para_API_access_token;
            // string getTextUrl = "http://vop.baidu.com/server_api?lan="  + "&cuid=" + para_API_id + "&token=" + para_API_access_token;
            HttpWebRequest getTextRequst = WebRequest.Create(getTextUrl) as HttpWebRequest;

            /* getTextRequst.Proxy = null;
             getTextRequst.ServicePoint.Expect100Continue = false;
             getTextRequst.ServicePoint.UseNagleAlgorithm = false;
             getTextRequst.ServicePoint.ConnectionLimit = 65500;
             getTextRequst.AllowWriteStreamBuffering = false;*/

            getTextRequst.ContentType = "audio /" + para_format + ";rate=" + para_Hz;
            getTextRequst.ContentLength = fi.Length;
            getTextRequst.Method = "post";
            getTextRequst.Accept = "*/*";
            getTextRequst.KeepAlive = true;
            //serverreq.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727)";
            getTextRequst.Timeout = 60000;//30秒连接不成功就中断 
            using (Stream writeStream = getTextRequst.GetRequestStream())
            {
                writeStream.Write(voice, 0, voice.Length);
            }
            try
            {
                HttpWebResponse getTextResponse = getTextRequst.GetResponse() as HttpWebResponse;
                using (StreamReader strHttpText = new StreamReader(getTextResponse.GetResponseStream(), Encoding.UTF8))
                {
                    strJSON = strHttpText.ReadToEnd();
                }
                JObject jsons = JObject.Parse(strJSON);//解析JSON
                if (jsons["err_msg"].Value<string>() == "success.")
                {
                    strText = jsons["result"][0].ToString();
                    return strText;
                }
                else
                {
                    error = jsons["err_no"].Value<string>() + jsons["err_msg"].Value<string>();
                    return error;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                return "null";
            }
        }
    }
}
