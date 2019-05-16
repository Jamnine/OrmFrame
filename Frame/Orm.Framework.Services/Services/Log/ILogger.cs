using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XYHis.Framework.Services
{
    /// <summary>
    /// 日志服务接口
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="type">产生信息的类型</param>
        /// <param name="msg">要记录的信息</param>
        /// <param name="keywords">关键字，用于查阅日志时按关键字快速搜索</param>
        /// <param name="typeName">信息的保存类别，默认为类型全名</param>
        void Debug(string msg, Type type = null, string keywords = "",  string typeName = null);

        /// <summary>
        /// 记录一般信息
        /// </summary>
        /// <param name="type">产生信息的类型</param>
        /// <param name="msg">要记录的信息</param>
        /// <param name="keywords">关键字，用于查阅日志时按关键字快速搜索</param>
        /// <param name="typeName">信息的保存类别，默认为类型全名</param>
        void Info(string msg, Type type = null, string keywords = "", string typeName = null);

        /// <summary>
        /// 记录警告信息
        /// </summary>
        /// <param name="type">产生信息的类型</param>
        /// <param name="msg">要记录的信息</param>
        /// <param name="keywords">关键字，用于查阅日志时按关键字快速搜索</param>
        /// <param name="typeName">信息的保存类别，默认为类型全名</param>
        void Warn(string msg, Type type = null, string keywords = "", string typeName = null);

        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="type">产生异常的类型</param>
        /// <param name="ex">异常对象</param>
        /// <param name="keywords">关键字，用于查阅日志时按关键字快速搜索</param>
        /// <param name="typeName">信息的保存类别，默认为类型全名</param>
        void Error(Exception ex, Type type = null, string keywords = "", string typeName = null);

        /// <summary>
        /// 记录严重错误信息
        /// </summary>
        /// <param name="type">产生异常的类型</param>
        /// <param name="ex">异常对象</param>
        /// <param name="keywords">关键字，用于查阅日志时按关键字快速搜索</param>
        /// <param name="typeName">信息的保存类别，默认为类型全名</param>
        void Fatal(Exception ex, Type type = null, string keywords = "", string typeName = null);
    }
}
