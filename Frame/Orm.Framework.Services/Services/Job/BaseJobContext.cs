using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 任务上下文信息基类
    /// </summary>
    public abstract class BaseJobContext
    {
        /// <summary>
        /// 任务Id
        /// </summary>
        public abstract string JobId
        {
            get;
        }

        /// <summary>
        /// 任务名称
        /// </summary>
        public abstract string JobName
        {
            get;
        }

        /// <summary>
        /// 日志记录接口
        /// </summary>
        public abstract IJobRunLogger Logger
        {
            get;
        }

        /// <summary>
        /// 获取参数值
        /// </summary>
        /// <param name="name">参数名称</param>
        /// <returns>参数值</returns>
        public abstract object GetArgument(string name);

        /// <summary>
        /// 获取指定类型的参数值
        /// </summary>
        /// <typeparam name="T">参数类型（String,DateTiem,Int,Double,Bool）</typeparam>
        /// <param name="name">参数名称</param>
        /// <returns>参数值</returns>
        public T GetArgument<T>(string name)
        {
            return (T)GetArgument(name);
        }

        /// <summary>
        /// 尝试获取参数值
        /// </summary>
        /// <param name="name">参数名称</param>
        /// <param name="value">参数值</param>
        /// <returns>是否成功获取参数值</returns>
        public abstract bool TryGetArgument(string name, out object value);
    }
}
