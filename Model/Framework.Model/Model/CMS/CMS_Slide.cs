using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Model.CMS
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_Slide: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ToTop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TypeId { get; set; }
    }
}
