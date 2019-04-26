using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "config", Watch = true)]
namespace Orm.Log4Library
{
    //日志的公共帮助类
    public class LogHelper
    {
        #region
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public static void ErrorLog(object msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("logerror");
            //Task.Run(() => log.Error(msg));   //异步 需要.net framework 4.5以上
            Task.Factory.StartNew(() =>log.Error(msg));//  这种异步也可以 支持.net framework 4
            log.Error(msg);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        public static void ErrorLog(Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("logerror");
            //Task.Run(() => log.Error(ex.Message.ToString() + "/r/n" + ex.Source.ToString() + "/r/n" + ex.TargetSite.ToString() + "/r/n" + ex.StackTrace.ToString()));
            Task.Factory.StartNew(() => log.Error(ex.Message.ToString() + "/r/n" + ex.Source.ToString() + "/r/n" + ex.TargetSite.ToString() + "/r/n" + ex.StackTrace.ToString()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public static void ErrorLog(object msg, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("logerror");
            if (ex != null)
            {
                //Task.Run(() => log.Error(msg, ex));   //异步
                Task.Factory.StartNew(() => log.Error(msg, ex));   //异步
            }
            else
            {
                //Task.Run(() => log.Error(msg));   //异步
                Task.Factory.StartNew(() => log.Error(msg));   //异步
            }
        }
        #endregion
    }
}
