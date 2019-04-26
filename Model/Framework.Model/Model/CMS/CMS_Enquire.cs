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
    public class CMS_Enquire: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EMail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime HandleTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HandleAdminId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EnquireNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AdminNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StateCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FansId { get; set; }
    }
}
