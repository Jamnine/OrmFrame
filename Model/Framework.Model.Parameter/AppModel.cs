using System;

namespace Orm.Model.Parameter
{

    /// <summary>
    ///  返回结果
    /// </summary>
    [Serializable]
    public class ReturnResult
    {
      
        public ReturnResult() { }

        /// <summary>
        /// 数据源
        /// </summary>
        public object source { get; set; }

        /// <summary>
        /// 动作
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// 返回编码
        /// </summary>
        public int resultCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        public string errCode { get; set; }
    }
}
