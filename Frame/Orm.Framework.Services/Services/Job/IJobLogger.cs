using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 任务日志记录接口
    /// </summary>
    public interface IJobRunLogger
    {
        /// <summary>
        /// 记录普通日志
        /// </summary>
        /// <param name="msg">日志信息</param>
        void Log(string msg);

        /// <summary>
        /// 记录异常日志
        /// </summary>
        /// <param name="ex">异常信息</param>
        /// <param name="msg"></param>
        void Log(Exception ex);
    }
}
