using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class Results
    {


        /// <summary>
        /// 初始化参数
        /// </summary>
        public Results()
        {
            Success = true;
            Code = "00";
            Message = "成功";

        }

        /// <summary>
        /// 直接返回成功数据
        /// </summary>
        /// <param name="data">数据</param>
        public Results(object data)
        {
            Data = data;
            Success = true;
            Code = "00";
            Message = "成功";
        }

        /// <summary>
        /// 失败返回结果
        /// </summary>
        /// <param name="code">错误代码</param>
        /// <param name="message">错误消息</param>
        public Results(string code, string message)
        {
            Code = code;
            Message = message;
            Success = false;
        }

        /// <summary>
        /// 成功提示信息
        /// </summary>
        /// <param name="code">错误代码</param>
        /// <param name="message">错误消息</param>
        public Results(string message, bool success)
        {
            Code = "00";
            Message = message;
            Success = success;
        }


        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="code">错误代码</param>
        /// <param name="message">错误消息</param>
        public Results(string code, string message, bool success)
        {
            Code = code;
            Message = message;
            Success = success;


        }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 消息代码（错误代码），00成功
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }
    }
}
