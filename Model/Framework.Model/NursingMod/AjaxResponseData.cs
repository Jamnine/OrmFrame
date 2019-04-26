using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 请求返回内容
    /// </summary>
    public class AjaxResponseData
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 操作提示
        /// </summary>
        public string Message { get; set; }


        /// <summary>
        /// 创建<see cref="AjaxResponseData"/>
        /// <see cref="Success"/> 默认设置为True
        /// </summary>
        public AjaxResponseData()
        {
            Success = true;
            Message = "未处理的异常";
        }


        public AjaxResponseData(bool success)
        {
            Success = success;
        }

        public AjaxResponseData(bool success, string msg)
        {
            Success = success; Message = msg;
        }
        /// <summary>
        /// 设置值
        /// </summary>
        /// <param name="success"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public AjaxResponseData SetSelfValue(bool success, string msg)
        {
            this.Success = success;
            this.Message = msg;
            return this;
        }

        public void SetValueDefault(bool success = false, string msg = "未处理的异常")
        {
            this.Success = success;
            this.Message = msg;
        }

        public static AjaxResponseData GetAjaxResponse(string msg = "未处理")
        {
            AjaxResponseData ajax = new AjaxResponseData() { Success = false, Message = msg };
            return ajax;
        }
    }
}
