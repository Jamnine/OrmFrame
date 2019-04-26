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
    public class CMS_WeiChat_UserBinding: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        //public int PatId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TenantId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OperIdCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}
