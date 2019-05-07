using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using WebBridgeContract;

namespace WebApiResponder
{
    public class ApiHandler : IHttpHandler
    {
        /// <summary>
        /// json序列化器。
        /// </summary>
        IJsonSerializer Serializer { get; set; }

        /// <summary>
        /// 构造函数。
        /// </summary>
        public ApiHandler()
        {
            Serializer = ServiceTaker.GetService<IJsonSerializer>();
        }

        /// <summary>
        /// 获取一个值，该值指示其他请求是否可以使用 IHttpHandler 实例。
        /// 如果 IHttpHandler 实例可再次使用，则为 true；否则为 false。
        /// </summary>
        public bool IsReusable
        {
            get { return false; }
        }

        /// <summary>
        /// 通过实现 IHttpHandler 接口的自定义 HttpHandler 启用 HTTP Web 请求的处理。
        /// </summary>
        /// <param name="context">System.Web.HttpContext 对象，它提供对用于为 HTTP 
        /// 请求提供服务的内部服务器对象（如 Request、Response、Session和 Server）的引用。</param>
        public void ProcessRequest(HttpContext context)
        {
            //WebApi分枝。
            if (context.Request.AppRelativeCurrentExecutionFilePath == "~/Handler.api")
            {
                ResolveWebApi(context);
            }
            else if (context.Request.AppRelativeCurrentExecutionFilePath == "~/ExternalHandler.api")
            {
                ResolveWebApiEx(context);
            }
        }

        /// <summary>
        /// 解析WebApi的请求。
        /// </summary>
        /// <param name="context">http上下文</param>
        private void ResolveWebApi(HttpContext context)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Stream streamResponse = context.Request.InputStream;
            StreamReader streamRead = new StreamReader(streamResponse, Encoding.UTF8);
            string strResponse = streamRead.ReadToEnd();
            streamResponse.Close();
            streamRead.Close();
            MethodDC theContract = new MethodDC();
            ApiResultDC theResult = new ApiResultDC();
            try
            {

                theContract = Serializer.Deserialize<MethodDC>(strResponse);
                ApiCore apiCpre = new ApiCore(theContract);
                var result = apiCpre.Invoke();

                if (result.ResultType.Name.ToLower() != "void")
                {
                    theResult.JsonValue = Serializer.Serialize(result.ResultValue);
                    theResult.TypeQualifiedName = result.ResultType.AssemblyQualifiedName;
                }
                else
                {
                    theResult.JsonValue = string.Empty;
                    theResult.TypeQualifiedName = result.ResultType.AssemblyQualifiedName;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException is Orm.Utilities.InformationException)
                {
                    theResult.HasException = true;
                    theResult.ExceptionMessage = ex.InnerException.Message;
                    theResult.ExceptionState = 1;

                }
                else if (ex.InnerException is Orm.Utilities.WarningException)
                {
                    theResult.HasException = true;
                    theResult.ExceptionMessage = ex.InnerException.Message;
                    theResult.ExceptionState = 2;
                }
                else if (ex.InnerException is Orm.Utilities.ErrorException)
                {
                    theResult.HasException = true;
                    theResult.ExceptionMessage = ex.InnerException.Message;
                    theResult.ExceptionState = 2;
                }
                else
                {
                    theResult.HasException = true;
                    theResult.ExceptionMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                    theResult.ExceptionStack = ex.InnerException == null ? ex.StackTrace : ex.InnerException.StackTrace;
                }

                //Orm.Framework.Services.AppLogger.Log(ex.InnerException == null ? ex.Message : ex.InnerException.Message + "\r\n" + ex.StackTrace);
                StringBuilder errLog = new StringBuilder();
                if (strResponse.Length > 500)
                {
                    errLog.Append(strResponse.Substring(0, 500));
                }
                else
                {
                    errLog.Append(strResponse);
                }
                Orm.Framework.Services.AppLogger.Log(ex.InnerException == null ? "\r\n\r\n" + ex.Message + "\r\n\r\n" + ex.StackTrace + "\r\n\r\n" + errLog.ToString() : "\r\n\r\n" + ex.InnerException.Message + "\r\n\r\n" + ex.InnerException.StackTrace + "\r\n\r\n" + errLog.ToString());
            }
            finally
            {
                //Orm.Redis.RedisAudit redis = new Orm.Redis.RedisAudit() { ClientIP = context.Request.UserHostAddress, ServiceName = theContract.InterfaceName, MethodName = theContract.MethodName, RequestTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ElapsedTime = watch.ElapsedMilliseconds.ToString(), RequestArguments = JsonConvert.SerializeObject(theContract.ParameterList), Result = JsonConvert.SerializeObject(theResult) };
                //TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                //Orm.Redis.RedisHelper.SetAsync(redis.ServiceName + "," + redis.MethodName + "," + redis.ClientIP + "," + redis.RequestTime + "," + Convert.ToInt64(ts.TotalSeconds).ToString(), JsonConvert.SerializeObject(redis), 3 * 60 * 60);
            }
            theContract.Result = theResult;
            string jsonResult = Serializer.Serialize(theContract);
            context.Response.Write(jsonResult);

            //如果返回的数据大点则采用GZip压缩。
            if (jsonResult.Length > 10000)
            {
                //向输出流头部添加压缩信息
                context.Response.AppendHeader("Content-encoding", "gzip");
                context.Response.Filter = new GZipStream(context.Response.Filter, CompressionMode.Compress);
            }

            watch.Stop();
            //写请求日志，用于跟踪请求的时间和数据大小。
            if (watch.ElapsedMilliseconds > 2000)
            {
                StringBuilder errLog = new StringBuilder();
                if (strResponse.Length > 500)
                {
                    errLog.Append(strResponse.Substring(0, 500));
                }
                else
                {
                    errLog.Append(strResponse);
                }
                string strRequestTimeLog = string.Format("Url：{0} 大于2秒：{1} JSON:{2}", context.Request.Url.ToString(), watch.ElapsedMilliseconds.ToString(), errLog);
                //  Orm.Framework.Services.AppLogger.Log(strRequestTimeLog, @"D:\PerformanceLog\" + DateTime.Now.ToString("yyyyMMdd"), AppDomain.CurrentDomain.Id.ToString() + ".log");
                strRequestTimeLog = null;
            }

            //如果是大对象85000的10倍
            if (System.Text.Encoding.Default.GetByteCount(jsonResult) > 840000)
            {
                StringBuilder errLog = new StringBuilder();
                if (strResponse.Length > 500)
                {
                    errLog.Append(strResponse.Substring(0, 500));
                }
                else
                {
                    errLog.Append(strResponse);
                }
                //向输出流头部添加压缩信息
                // Orm.Framework.Services.AppLogger.Log(string.Format("Url：{0} 大于850K的对象：{1}", context.Request.Url.ToString(), errLog), @"D:\PerformanceLog\" + DateTime.Now.ToString("yyyyMMdd"), AppDomain.CurrentDomain.Id.ToString() + ".log");
            }
            jsonResult = null;
            strResponse = null;
        }

        /// <summary>
        /// 解析WebApi的请求。
        /// </summary>
        /// <param name="context">http上下文</param>
        private void ResolveWebApiEx(HttpContext context)
        {
            HttpRequest request = context.Request;

            var nameSpace = "Orm.Framework.Common";//接口所在命名空间
            var className = "WebAPI";//接口类名
            var methodName = request.QueryString["action"];//.Form["action"]

            //methodName = "UpdateFollowInfo"; 

            Assembly assembly = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + @"bin\" + nameSpace + ".dll");

            //   动态调用方法。     
            object eval = assembly.CreateInstance(nameSpace + "." + className);
            MethodInfo method = eval.GetType().GetMethod(methodName);

            MethodDC theContract = new MethodDC();
            ApiResultDC theResult = new ApiResultDC();
            try
            {
                theContract.MethodName = methodName;
                #region 参数设置 
                //获取反射方法的参数和参数的类型
                Dictionary<string, Type> dicParam = new Dictionary<string, Type>();
                ParameterInfo[] paramters = method.GetParameters();
                foreach (ParameterInfo item in paramters)
                {
                    dicParam.Add(item.Name, item.ParameterType);
                }
                //参数赋值
                List<ParameterDC> paramList = new List<ParameterDC>();
                foreach (var item in request.Form.AllKeys)
                {
                    string paramValue = request.Form[item].ToString();
                    if (dicParam[item].Name == "String")
                    {
                        paramValue = "\"" + paramValue + "\"";
                    }

                    paramList.Add(new ParameterDC { JsonValue = paramValue, TypeQualifiedName = dicParam[item].FullName });
                }
                //if (paramList.Count > 0)
                theContract.ParameterList = paramList;
                //else
                //{
                //    var p = new ParameterDC { JsonValue = "344", TypeQualifiedName = typeof(int).FullName };
                //    var p2 = new ParameterDC { JsonValue = "5", TypeQualifiedName = typeof(int).FullName };
                //    var p1 = new ParameterDC { JsonValue = "\"更新\"", TypeQualifiedName = typeof(string).FullName };
                //    var plist = new List<ParameterDC>();
                //    plist.Add(p);
                //    plist.Add(p2);
                //    plist.Add(p1);
                //    theContract.ParameterList = plist;
                //}

                if (paramters.Count() != theContract.ParameterList.Count)
                {
                    ReturnValue returnValue = new ReturnValue();
                    returnValue.ErrorCode = -1;
                    returnValue.ErrorMsg = "参数个数不匹配";
                    var jsonResult = Serializer.Serialize(returnValue);
                    context.Response.Write(jsonResult);
                    return;
                }
                #endregion
                ApiCore apiCpre = new ApiCore(theContract);
                var result = apiCpre.Invoke(eval);

                if (result.ResultType.Name.ToLower() != "void")
                {
                    theResult.JsonValue = Serializer.Serialize(result.ResultValue);
                    theResult.TypeQualifiedName = result.ResultType.AssemblyQualifiedName;
                    context.Response.Write(theResult.JsonValue);
                    //context.Response = theResult.JsonValue;
                }
                else
                {
                    theResult.JsonValue = string.Empty;
                    theResult.TypeQualifiedName = result.ResultType.AssemblyQualifiedName;
                    ReturnValue returnValue = new ReturnValue();
                    returnValue.ErrorCode = -1;
                    returnValue.ErrorMsg = "此接口方法没有返回值";
                    var jsonResult = Serializer.Serialize(returnValue);
                    context.Response.Write(jsonResult);
                    return;
                }
            }
            catch (Exception ex)
            {
                ReturnValue returnValue = new ReturnValue();
                returnValue.ErrorCode = -1;
                returnValue.ErrorMsg = "接口调用异常：" + ex.Message;
                var jsonResult = Serializer.Serialize(returnValue);
                context.Response.Write(jsonResult);
            }

        }

        private void WriteLog(string msg)
        {
            string str = string.Empty;
            if (string.IsNullOrWhiteSpace(msg))
            {
                return;
            }
            //str = @"D:\PerformanceLog\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            string directoryName = Path.GetDirectoryName(str);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            string str3 = string.Format("{0}：{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"), msg);
            using (StreamWriter writer = new StreamWriter(str, true, Encoding.UTF8))
            {
                writer.WriteLine(str3);
            }
        }
    }
}
