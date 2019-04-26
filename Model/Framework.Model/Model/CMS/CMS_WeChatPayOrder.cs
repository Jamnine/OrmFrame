using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_WeChatPayOrder: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TenantId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Attach { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal ActuallyMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PayUse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StateCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MobileNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PayProcess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Transaction_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Serial_trade_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Openid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CompletionTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayUseInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Out_refund_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Refund_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ExpressTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserCode { get; set; }
    }
}
