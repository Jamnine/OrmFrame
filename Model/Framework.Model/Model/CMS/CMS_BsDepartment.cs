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
    public class CMS_BsDepartment: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeptId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeptName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Bookable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DoctorLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
    }
}
