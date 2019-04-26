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
    public class CMS_Bespoke: BaseModel
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
        public DateTime BespokeTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StateCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FansId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AdminNote { get; set; }
    }
}
