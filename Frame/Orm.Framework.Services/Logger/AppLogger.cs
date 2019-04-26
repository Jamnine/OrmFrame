using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 该静态类用于记录Orm.Framework框架本身的调试信息。该类限于框架使用，外部业务系统不应使用该类
    /// 可以在配置文件的appSettings配置节设置Orm.Framework.AppLogEnabled为false来关闭该功能
    /// 目前框架日志采用文本文件存储，以后可以考虑采用MongoDB或RDBMS存储
    /// </summary>
    public static class AppLogger
    {
        private static bool _AppLogEnabled = true;

        private static object LockObj = new object();

        static AppLogger()
        {
            _AppLogEnabled = AppSettings.AppLogEnabled;

            if (!_AppLogEnabled) WriteLog("未开启该功能。可以通过在配置文件的appSettings配置节设置Orm.FrameWork.AppLogEnabled为true来开启该项功能");   
        }

        private static void WriteLog(string msg, string logfile=null)
        {
            lock (LockObj)
            {
                string Log_File = string.Empty;
                if (!string.IsNullOrWhiteSpace(logfile))
                {
                    Log_File = @"FrameWork_Log\" + logfile;  //例如：orm.log
                }
                else
                {
                    Log_File = @"FrameWork_Log\" + DateTime.Now.ToString("yyyyMMddHH") + "_" + AppDomain.CurrentDomain.Id.ToString() + ".log";
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

        /// <summary>
        /// 记录框架的调试信息
        /// </summary>
        /// <param name="msg">调试信息字符串</param>
        public static void Log(string msg)
        {
            Log(msg, null);
        }

        /// <summary>
        /// 记录框架的调试信息
        /// </summary>
        /// <param name="msg">调试信息字符串</param>
        /// <param name="logfile">日志文件</param>
        public static void Log(string msg,string logfile)
        {
            if (!_AppLogEnabled) return;

            if (string.IsNullOrEmpty(msg)) return;

            WriteLog(msg, logfile);
        }

        /// <summary>
        /// 记录框架的异常信息
        /// </summary>
        /// <param name="ex">异常对象</param>
        public static void Log(Exception ex)
        {
            Log(ex,null);
        }

        /// <summary>
        /// 记录框架的异常信息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="logfile">日志文件</param>
        public static void Log(Exception ex, string logfile)
        {
            if (!_AppLogEnabled) return;

            if (ex == null) return;

            StringBuilder error = new StringBuilder();
            error.AppendFormat("发生［{0}］异常，异常相关信息如下：", ex.GetType().ToString());
            error.AppendFormat("\r\n异常描述：{0}", ex.Message);
            error.AppendFormat("\r\n异 常 源：{0}", ex.Source);
            error.AppendFormat("\r\n堆栈跟踪：\r\n{0}", ex.StackTrace);
            if (ex.InnerException != null)
            {
                error.AppendFormat("\r\n内含异常：{0}", ex.InnerException.GetType().ToString());
                error.AppendFormat("\r\n异常描述：{0}", ex.InnerException.Message);
                error.AppendFormat("\r\n异 常 源：{0}", ex.InnerException.Source);
                error.AppendFormat("\r\n堆栈跟踪：\r\n{0}\r\n", ex.InnerException.StackTrace);
            }
            else
            {
                error.Append("\r\n内含异常：无\r\n");
            }

            WriteLog(error.ToString(), logfile);
        }

        public static void Log(string msg, string filePath, string fileName)
        {
            lock (LockObj)
            {
                string logFile = string.Empty;
                if (string.IsNullOrWhiteSpace(msg) || string.IsNullOrWhiteSpace(filePath))
                {
                    return;
                }
                logFile = Path.Combine(filePath, fileName);
                string directoryName = Path.GetDirectoryName(logFile);
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
                string str3 = string.Format("{0}：{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"), msg);
                using (StreamWriter writer = new StreamWriter(logFile, true, Encoding.UTF8))
                {
                    writer.WriteLine(str3);
                }
            }
        }
    }
}
