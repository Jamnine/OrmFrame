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
    public class CMS_Setting: BaseModel
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
        public string Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ValType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OrderBy { get; set; }
    }
}
