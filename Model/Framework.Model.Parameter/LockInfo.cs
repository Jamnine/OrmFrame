using System;

namespace Orm.Model.Parameter
{

    /// <summary>
    /// 返回结果
    /// </summary>
    [Serializable]
    public class LockInfoReturnResult
    {      
        public LockInfoReturnResult()
        {
            Message = string.Empty;
        }

        /// <summary>
        /// 返回的显示消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 状态为是否可修改
        /// </summary>
        public bool CanModify { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        public string errCode { get; set; }
    }
}
