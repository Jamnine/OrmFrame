using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using WebBridgeContract;
using System.IO.Compression;
using Newtonsoft.Json;
using Orm.Config;
using Orm.Model;
using System.Threading.Tasks;

namespace WebBridgeEndpoint
{
    public class WebRequseter
    {
        IJsonSerializer Serializer { get; set; }

        public WebRequseter()
        {
            Serializer = ServiceTaker.GetService<IJsonSerializer>();
        }

        public object RequseteWeb(string apiMapKey, string apiInterfaceName, string methodName, List<object> parameterList, string apiUrl = "")
        {
            return RequseteWeb(apiMapKey, apiInterfaceName, methodName, parameterList, null, apiUrl);
        }
        public object RequseteWeb(string apiMapKey, string apiInterfaceName, string methodName, List<object> parameterList, string[] types, string apiUrl = "")
        {
            HttpWebResponse response = null;
            Stream streamResponse = null;
            try
            {
                MethodDC theContract = new MethodDC();
                theContract.ApiConfigKey = apiMapKey;
                theContract.InterfaceName = apiInterfaceName;
                theContract.MethodName = methodName;
                theContract.TypeArguments = types;

                List<ParameterDC> webParamerList = new List<ParameterDC>();
                foreach (object param in parameterList)
                {
                    ParameterDC aWebParamer = new ParameterDC();
                    aWebParamer.TypeQualifiedName = param.GetType().AssemblyQualifiedName;
                    aWebParamer.JsonValue = Serializer.Serialize(param);
                    webParamerList.Add(aWebParamer);
                }
                theContract.ParameterList = webParamerList;
                string jsonContract = Serializer.Serialize(theContract);
                //TODO:加密或压缩对jsonContract,密文可根据日期变化。服务端验证密文 
                MethodDC vdf = Serializer.Deserialize<MethodDC>(jsonContract);

                byte[] PostData = Encoding.UTF8.GetBytes(jsonContract);

                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.GetRequestStream().Write(PostData, 0, PostData.Length);
                request.ContentType = "text/xml";
                ServicePoint currentServicePoint = request.ServicePoint;
                currentServicePoint.ConnectionLimit = 1000;
                response = (HttpWebResponse)request.GetResponse();
                
                streamResponse = response.GetResponseStream();

                string strResponse = string.Empty;
                //如果服务端采用了GZIP压缩,则先解压缩。
                if (response.ContentEncoding.ToLower().Contains("gzip"))
                {
                    using (GZipStream gz = new GZipStream(streamResponse, CompressionMode.Decompress))
                    {
                        using (StreamReader readerGzip = new StreamReader(gz, Encoding.UTF8))
                        {
                            strResponse = readerGzip.ReadToEnd();
                        }
                    }
                }
                else
                {
                    using (StreamReader streamRead = new StreamReader(streamResponse, Encoding.UTF8))
                    {
                        strResponse = streamRead.ReadToEnd();
                    }
                }

                //TODO:解密或解压缩对strResponse
                MethodDC reObj = Serializer.Deserialize<MethodDC>(strResponse);
                watch.Stop();

                //写请求日志，用于跟踪请求的时间和数据大小。
                string writeWebRequestLog = System.Configuration.ConfigurationManager.AppSettings["WriteClientHttpWebRequestLog"];
                if (writeWebRequestLog == null) { writeWebRequestLog = "false"; }
                if (bool.Parse(writeWebRequestLog) && !apiInterfaceName.Contains("DBClientBase"))
                {
                    Task task = Task.Factory.StartNew(() =>
                    {
                        byte[] responseData = Encoding.UTF8.GetBytes(strResponse);
                        var counter = watch.ElapsedMilliseconds;
                        string Parameters = "";
                        for (int i = 0; i < theContract.ParameterList.Count; i++)
                        {
                            Parameters += theContract.ParameterList[i].JsonValue + "@";
                        }

                        CountUserData countUserData = new CountUserData
                        {
                            ApiInterfaceName = apiInterfaceName,
                            ClientComputerIP = UserProfiles.ClientComputerGuid,
                            UserName = UserProfiles.UserName,
                            LocationName = UserProfiles.HospitalName,
                            MethodName = methodName,
                            CounterTime = counter,
                            ResponseData = (responseData.Length / 1024.00).ToString("f0"),
                            OperTime = DateTime.Now,
                            ParameterContents = Parameters,
                        };
                        Orm.Config.Service.DBClientService.Add<CountUserData>(countUserData);
                    });
                    //string strRequestTimeLog = string.Format(" 诊所：{0} ip地址：{1}  操作人：{2} 操作时间：{3} 接口：{4}调用方法：{5} 请求响应时间：{6}(毫秒) 返回值大小：{7}Kb", 
                    //    UserProfiles.LocationName, UserProfiles.ClientComputerGuid,UserProfiles.UserName,DateTime.Now, apiInterfaceName, methodName, counter.ToString(), (responseData.Length / 1024.00).ToString("f0"));
                    //WriteLog(strRequestTimeLog, null);

                }

                if (reObj.Result.HasException)
                {
                    if (reObj.Result.ExceptionState == 1)
                    {
                        System.Windows.Forms.MessageBox.Show(reObj.Result.ExceptionMessage, "消息", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        return null;
                    }
                    else if (reObj.Result.ExceptionState == 2)
                    {
                        System.Windows.Forms.MessageBox.Show(reObj.Result.ExceptionMessage, "警告", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        return null;
                    }
                    else if (reObj.Result.ExceptionState == 3)
                    {
                        System.Windows.Forms.MessageBox.Show(reObj.Result.ExceptionMessage, "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        return null;
                    }
                    else
                    {
                        throw new Exception("Message: " + reObj.Result.ExceptionMessage + "\r\n"
                            + "Stack: " + reObj.Result.ExceptionStack);
                    }
                }
                else
                {
                    Type relType = Type.GetType(reObj.Result.TypeQualifiedName);

                    object relResult = null;
                    if (relType.Name.ToLower() != "void")
                    {
                        relResult = Serializer.Deserialize(reObj.Result.JsonValue, relType);
                    }
                    return relResult;
                }
            }
            finally
            {
                if (streamResponse != null)
                {
                    streamResponse.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
            }
        }
        
        /// <summary>
        /// http请求(行心云)
        /// </summary>
        /// <param name="apiMapKey"></param>
        /// <param name="apiInterfaceName"></param>
        /// <param name="methodName"></param>
        /// <param name="parameterList"></param>
        /// <param name="types"></param>
        /// <param name="apiUrl"></param>
        /// <returns></returns>
        public object HttpRequest(string apiInterfaceName, string methodName, List<object> parameterList, string[] types, string apiUrl = "")
        {
            HttpWebResponse response = null;
            Stream streamResponse = null;
            try
            {
                MethodDC transDataClass = new MethodDC();
                transDataClass.ApiConfigKey = apiInterfaceName;
                transDataClass.InterfaceName = apiInterfaceName;
                transDataClass.MethodName = methodName;
                transDataClass.TypeArguments = types;

                List<ParameterDC> webParamerList = new List<ParameterDC>();
                foreach (object param in parameterList)
                {
                    ParameterDC aWebParamer = new ParameterDC();
                    aWebParamer.TypeQualifiedName = param.GetType().AssemblyQualifiedName;
                    aWebParamer.JsonValue = JsonConvert.SerializeObject(param);
                    webParamerList.Add(aWebParamer);
                }
                transDataClass.ParameterList = webParamerList;
                //将要传递的数据序列化成json格式
                string jsonContract = JsonConvert.SerializeObject(transDataClass);
                //TODO:加密或压缩对jsonContract,密文可根据日期变化。服务端验证密文 
                MethodDC vdf = JsonConvert.DeserializeObject<MethodDC>(jsonContract);
                //将要传递的json转成byte[]
                byte[] PostData = Encoding.UTF8.GetBytes(jsonContract);

                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.GetRequestStream().Write(PostData, 0, PostData.Length);
                request.ContentType = "text/xml; charset=utf-8";
                ServicePoint currentServicePoint = request.ServicePoint;
                currentServicePoint.ConnectionLimit = 1000;

                response = (HttpWebResponse)request.GetResponse();
                streamResponse = response.GetResponseStream();

                string strResponse = string.Empty;
                //如果服务端采用了GZIP压缩,则先解压缩。
                if (response.ContentEncoding.ToLower().Contains("gzip"))
                {
                    using (GZipStream gz = new GZipStream(streamResponse, CompressionMode.Decompress))
                    {
                        using (StreamReader readerGzip = new StreamReader(gz, Encoding.UTF8))
                        {
                            strResponse = readerGzip.ReadToEnd();
                        }
                    }
                }
                else
                {
                    using (StreamReader streamRead = new StreamReader(streamResponse, Encoding.UTF8))
                    {
                        strResponse = streamRead.ReadToEnd();
                    }
                }

                //TODO:解密或解压缩对strResponse
                MethodDC reObj = JsonConvert.DeserializeObject<MethodDC>(strResponse);
                watch.Stop();

                //写请求日志，用于跟踪请求的时间和数据大小。
                string writeWebRequestLog = System.Configuration.ConfigurationManager.AppSettings["WriteClientHttpWebRequestLog"];
                if (writeWebRequestLog == null) { writeWebRequestLog = "false"; }
                if (bool.Parse(writeWebRequestLog) && watch.ElapsedMilliseconds > 1000)
                {
                    byte[] responseData = Encoding.UTF8.GetBytes(strResponse);
                    var counter = watch.ElapsedMilliseconds;
                    string strRequestTimeLog = string.Format(" 接口：{0} 调用方法：{1} 请求响应时间：{2}(毫秒) 返回值大小：{3}Kb", apiInterfaceName, methodName, counter.ToString(), (responseData.Length / 1024.00).ToString("f0"));
                    WriteLog(strRequestTimeLog, null);
                }

                if (reObj.Result.HasException)
                {
                    if (reObj.Result.ExceptionState == 1)
                    {
                        System.Windows.Forms.MessageBox.Show(reObj.Result.ExceptionMessage, "消息", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        return null;
                    }
                    else if (reObj.Result.ExceptionState == 2)
                    {
                        System.Windows.Forms.MessageBox.Show(reObj.Result.ExceptionMessage, "警告", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                        return null;
                    }
                    else if (reObj.Result.ExceptionState == 3)
                    {
                        System.Windows.Forms.MessageBox.Show(reObj.Result.ExceptionMessage, "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        return null;
                    }
                    else
                    {
                        throw new Exception("Message: " + reObj.Result.ExceptionMessage + "\r\n"
                            + "Stack: " + reObj.Result.ExceptionStack);
                    }
                }
                else
                {
                    Type relType = Type.GetType(reObj.Result.TypeQualifiedName);

                    object relResult = null;
                    if (relType.Name.ToLower() != "void")
                    {
                        relResult = JsonConvert.DeserializeObject(reObj.Result.JsonValue, relType);
                    }
                    return relResult;
                }
            }
            finally
            {
                if (streamResponse != null)
                {
                    streamResponse.Close();
                }
                if (response != null)
                {
                    response.Close();
                }

            }

        }
        private static void WriteLog(string msg, string logfile = null)
        {

            string Log_File = "";
            if (!string.IsNullOrWhiteSpace(logfile))
            {
                Log_File = @"HttpWebRequest_Log\" + logfile;
            }
            else
            {
                Log_File = @"HttpWebRequest_Log\" + DateTime.Now.ToString("yyyyMMdd") + "_WebRequest.log";
            }

            Log_File = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Log_File);

            //目录不存在时创建目录
            string FileDir = Path.GetDirectoryName(Log_File);
            if (!Directory.Exists(FileDir)) Directory.CreateDirectory(FileDir);

            //写入日志
            string Msg = string.Format("{0}：{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"), msg);
            using (StreamWriter writer = new StreamWriter(Log_File, true, Encoding.UTF8))
            {
                writer.WriteLine(Msg);
            }
        }

    }
}
