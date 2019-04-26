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
    public class WeiChat_App: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AppSecret { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WeiXinAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CopyrightInformation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerInformation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int WeChatAppType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MchId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Paykey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SSLCERT_PATH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SSLCERT_PASSWORD { get; set; }
    }
}
