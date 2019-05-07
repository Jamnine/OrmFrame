using System;
using System.IO;
using System.Net;
using System.Text;
using Orm.Framework.Services;
using Orm.Model.Parameter;

namespace Orm.Framework.Common
{
    public static class AppAPI
    {
        public static ReturnResult Post(string url, string jsonData)
        {
            return HttpRequest<ReturnResult>(url, jsonData, "POST");
        }

        private static T HttpRequest<T>(string url, string jsonData, string method)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = method;
            request.ContentType = "application/json";
            request.Timeout = 180000;
            request.ReadWriteTimeout = 180000;
            request.KeepAlive = false;
            if (method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                if (!string.IsNullOrEmpty(jsonData))
                {
                    byte[] datas = Encoding.UTF8.GetBytes(jsonData);
                    if (datas.Length > 0)
                    {
                        request.ContentLength = datas.Length;
                        try
                        {
                            Stream requestStream = request.GetRequestStream();
                            requestStream.Write(datas, 0, datas.Length);
                            requestStream.Close();
                        }
                        catch (ProtocolViolationException)
                        {
                            request.Abort();
                            throw;
                        }
                        catch (WebException)
                        {
                            request.Abort();
                            throw;
                        }
                        catch (ObjectDisposedException)
                        {
                            request.Abort();
                            throw;
                        }
                        catch (InvalidOperationException)
                        {
                            request.Abort();
                            throw;
                        }
                        catch (NotSupportedException)
                        {
                            request.Abort();
                            throw;
                        }
                    }
                }
            }
            HttpWebResponse response = null;
            string responseDatas = string.Empty;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                Stream streamResponse = response.GetResponseStream();
                using (StreamReader sr = new StreamReader(streamResponse))
                {
                    responseDatas = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                    response = null;
                }
                request.Abort();
                request = null;
            }
            try
            {
                return ServiceTaker.GetService<IJsonSerializer>().Deserialize<T>(responseDatas); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
