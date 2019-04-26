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
    public class WeiChat_MessagesTemplate: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TemplateNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShortNo { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string OneIndustry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TwoIndustry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string Demo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool AllowTest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TenantId { get; set; }
    }
}
