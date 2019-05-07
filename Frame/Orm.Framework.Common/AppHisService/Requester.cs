using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebBridgeContract;
using Orm.Model;

namespace Orm.Framework.Common
{
    public class Requester : IRequester
    {
        

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public DateTime GetCurrentDateTime()
        {
            throw new NotImplementedException();
        }

        public void HttpRequest(RequestModel requestModel, string tbName)
        {
            HttpWebResponse response = null;
            Stream streamResponse = null;
            try
            {
                MethodDC transDataClass = new MethodDC();
                transDataClass.ApiConfigKey = requestModel.IServiceName;
                transDataClass.InterfaceName = requestModel.IServiceName;
                transDataClass.MethodName = requestModel.MethodName;
                string[] strTypeArguments = new string[] { string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", tbName.Replace("Dto", string.Empty)) };
                transDataClass.TypeArguments = strTypeArguments; //requestModel.Types;

                List<ParameterDC> webParamerList = new List<ParameterDC>();
                foreach (object param in requestModel.ParameterList)
                {
                    ParameterDC aWebParamer = new ParameterDC();
                    if (requestModel.Types != null && param.GetType().AssemblyQualifiedName.Contains("HisPlus.Contract.Messages"))
                    {
                        aWebParamer.TypeQualifiedName = requestModel.Types[0];
                    }
                    else
                    {
                        aWebParamer.TypeQualifiedName = param.GetType().AssemblyQualifiedName;
                    }

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
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestModel.ApiUrl);//"http://ys1.api1.yun.Orm.com/Handler.api" 
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

                if (reObj.Result.HasException)
                {
                    throw new Exception("Message: " + reObj.Result.ExceptionMessage + "\r\n"
                           + "Stack: " + reObj.Result.ExceptionStack);
                }
                else
                {
                    Type relType = Type.GetType(reObj.Result.TypeQualifiedName);

                    object relResult = null;

                    if (relType.Name.ToLower() != "void")
                    {
                        relResult = JsonConvert.DeserializeObject(reObj.Result.JsonValue, relType);
                    }

                    //var result = JsonConvert.DeserializeObject<T>(reObj.Result.JsonValue);
                    //return result;
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


        public T HttpRequest<T>(RequestModel requestModel, string tbName, string childName)
        {
            HttpWebResponse response = null;
            Stream streamResponse = null;
            try
            {
                MethodDC transDataClass = new MethodDC();
                transDataClass.ApiConfigKey = requestModel.IServiceName;
                transDataClass.InterfaceName = requestModel.IServiceName;
                transDataClass.MethodName = requestModel.MethodName;
                transDataClass.TypeArguments = requestModel.Types;

                List<ParameterDC> webParamerList = new List<ParameterDC>();
                foreach (object param in requestModel.ParameterList)
                {
                    ParameterDC aWebParamer = new ParameterDC();
                    aWebParamer.TypeQualifiedName = param.GetType().AssemblyQualifiedName;
                    aWebParamer.JsonValue = JsonConvert.SerializeObject(param);
                    webParamerList.Add(aWebParamer);
                }
                transDataClass.ParameterList = webParamerList;

                foreach (var item in transDataClass.ParameterList)
                {
                    if (!string.IsNullOrEmpty(childName))
                    {
                        string str = string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", childName);
                        if (item.TypeQualifiedName.Contains(str))
                        {
                            string strchildName = string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0,", childName.Replace("Dto", string.Empty));
                            item.TypeQualifiedName = item.TypeQualifiedName.Replace(string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", childName), strchildName);

                        }
                    }
                    if (item.TypeQualifiedName.Contains(string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", tbName)))
                    {
                        item.TypeQualifiedName = item.TypeQualifiedName.Replace(string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", tbName), string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0,", tbName.Replace("Dto", string.Empty)));
                    }
                    if (item.TypeQualifiedName.Contains(string.Format("HisPlus.Contract.Messages.Generated.{0}, HisPlus.Contract, Version=0.0.0.0,", tbName)))
                    {
                        item.TypeQualifiedName = item.TypeQualifiedName.Replace(string.Format("HisPlus.Contract.Messages.Generated.{0}, HisPlus.Contract, Version=0.0.0.0,", tbName), string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0,", tbName.Replace("Dto", string.Empty)));
                    }
                }

                //将要传递的数据序列化成json格式
                string jsonContract = JsonConvert.SerializeObject(transDataClass);
                //TODO:加密或压缩对jsonContract,密文可根据日期变化。服务端验证密文 
                MethodDC vdf = JsonConvert.DeserializeObject<MethodDC>(jsonContract);
                //将要传递的json转成byte[]
                byte[] PostData = Encoding.UTF8.GetBytes(jsonContract);

                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestModel.ApiUrl);//http://localhost:6848/Handler.api
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

                if (reObj.Result.HasException)
                {
                    throw new Exception("Message: " + reObj.Result.ExceptionMessage + "\r\n"
                           + "Stack: " + reObj.Result.ExceptionStack);
                }
                else
                {
                    var result = JsonConvert.DeserializeObject<T>(reObj.Result.JsonValue);

                    return result;
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




        public string RequestService<T>(RequestModel requestModel, string tbName, string childName)
        {
            HttpWebResponse response = null;
            Stream streamResponse = null;
            try
            {
                MethodDC transDataClass = new MethodDC();
                transDataClass.ApiConfigKey = requestModel.IServiceName;
                transDataClass.InterfaceName = requestModel.IServiceName;
                transDataClass.MethodName = requestModel.MethodName;
                transDataClass.TypeArguments = requestModel.Types;

                List<ParameterDC> webParamerList = new List<ParameterDC>();
                foreach (object param in requestModel.ParameterList)
                {
                    ParameterDC aWebParamer = new ParameterDC();
                    aWebParamer.TypeQualifiedName = param.GetType().AssemblyQualifiedName;
                    aWebParamer.JsonValue = JsonConvert.SerializeObject(param);
                    webParamerList.Add(aWebParamer);
                }
                transDataClass.ParameterList = webParamerList;

                foreach (var item in transDataClass.ParameterList)
                {
                    if (!string.IsNullOrEmpty(childName))
                    {
                        string str = string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", childName);
                        if (item.TypeQualifiedName.Contains(str))
                        {
                            string strchildName = string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0,", childName.Replace("Dto", string.Empty));
                            item.TypeQualifiedName = item.TypeQualifiedName.Replace(string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", childName), strchildName);

                        }
                    }

                    if (item.TypeQualifiedName.Contains(string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", tbName)))
                    {
                        item.TypeQualifiedName = item.TypeQualifiedName.Replace(string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", tbName), string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0,", tbName.Replace("Dto", string.Empty)));
                    }

                    if (item.TypeQualifiedName.Contains(string.Format("HisPlus.Contract.Messages.Generated.{0}, HisPlus.Contract, Version=0.0.0.0,", tbName)))
                    {
                        item.TypeQualifiedName = item.TypeQualifiedName.Replace(string.Format("HisPlus.Contract.Messages.Generated.{0}, HisPlus.Contract, Version=0.0.0.0,", tbName), string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0,", tbName.Replace("Dto", string.Empty)));
                    }
                }

                //将要传递的数据序列化成json格式
                string jsonContract = JsonConvert.SerializeObject(transDataClass);
                //TODO:加密或压缩对jsonContract,密文可根据日期变化。服务端验证密文 
                MethodDC vdf = JsonConvert.DeserializeObject<MethodDC>(jsonContract);
                //将要传递的json转成byte[]
                byte[] PostData = Encoding.UTF8.GetBytes(jsonContract);

                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestModel.ApiUrl);//http://localhost:6848/Handler.api
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

                if (reObj.Result.HasException)
                {
                    throw new Exception("Message: " + reObj.Result.ExceptionMessage + "\r\n"
                           + "Stack: " + reObj.Result.ExceptionStack);
                }
                else
                {
                    #region
                    //Newtonsoft.Json.JsonSerializerSettings setting = new Newtonsoft.Json.JsonSerializerSettings();

                    //JsonConvert.DefaultSettings = new Func<JsonSerializerSettings>(() =>
                    //{
                    //    //日期类型默认格式化处理
                    //    setting.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
                    //    setting.DateFormatString = "yyyy-MM-dd HH:mm:ss";

                    //    setting.DefaultValueHandling = DefaultValueHandling.Ignore;

                    //    //空值处理
                    //    //setting.NullValueHandling = NullValueHandling.Ignore;

                    //    //高级用法九中的Bool类型转换 设置
                    //    //setting.Converters.Add(new BoolConvert("是,否"));

                    //    return setting;

                    //});
                    //JsonConvert.DefaultSettings();
                    #endregion 

                    return reObj.Result.JsonValue;
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

        public string RequestService<T>(RequestModel requestModel, List<String> lstTbName)
        {
            HttpWebResponse response = null;
            Stream streamResponse = null;
            try
            {
                MethodDC transDataClass = new MethodDC();
                transDataClass.ApiConfigKey = requestModel.IServiceName;
                transDataClass.InterfaceName = requestModel.IServiceName;
                transDataClass.MethodName = requestModel.MethodName;
                transDataClass.TypeArguments = requestModel.Types;
                List<ParameterDC> webParamerList = new List<ParameterDC>();
                foreach (object param in requestModel.ParameterList)
                {
                    ParameterDC aWebParamer = new ParameterDC();
                    aWebParamer.TypeQualifiedName = param.GetType().AssemblyQualifiedName;
                    aWebParamer.JsonValue = JsonConvert.SerializeObject(param);
                    webParamerList.Add(aWebParamer);
                }
                transDataClass.ParameterList = webParamerList;

                if (lstTbName != null)
                {
                    foreach (var strName in lstTbName)
                    {
                        foreach (var item in transDataClass.ParameterList)
                        {
                            if (item.TypeQualifiedName.Contains(strName))
                            {
                                if (item.TypeQualifiedName.Contains(string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", strName)))
                                {
                                    item.TypeQualifiedName = item.TypeQualifiedName.Replace(string.Format("HisPlus.Contract.Messages.{0}, HisPlus.Contract, Version=0.0.0.0,", strName), string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0,", strName.Replace("Dto", string.Empty)));
                                }
                                if (item.TypeQualifiedName.Contains(string.Format("HisPlus.Contract.Messages.Generated.{0}, HisPlus.Contract, Version=0.0.0.0,", strName)))
                                {
                                    item.TypeQualifiedName = item.TypeQualifiedName.Replace(string.Format("HisPlus.Contract.Messages.Generated.{0}, HisPlus.Contract, Version=0.0.0.0,", strName), string.Format("Orm.Model.{0}, Orm.Model, Version=1.0.0.0,", strName.Replace("Dto", string.Empty)));
                                }
                            }
                        }
                    }
                }


                //将要传递的数据序列化成json格式
                string jsonContract = JsonConvert.SerializeObject(transDataClass);
                //TODO:加密或压缩对jsonContract,密文可根据日期变化。服务端验证密文 
                MethodDC vdf = JsonConvert.DeserializeObject<MethodDC>(jsonContract);
                //将要传递的json转成byte[]
                byte[] PostData = Encoding.UTF8.GetBytes(jsonContract);

                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestModel.ApiUrl);//http://localhost:6848/Handler.api
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

                if (reObj.Result.HasException)
                {
                    throw new Exception("Message: " + reObj.Result.ExceptionMessage + "\r\n"
                           + "Stack: " + reObj.Result.ExceptionStack);
                }
                else
                {
                    return reObj.Result.JsonValue;
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

    }
}
