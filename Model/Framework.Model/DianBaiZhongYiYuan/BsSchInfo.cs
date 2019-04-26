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
    public class BsSchInfo: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DoctorId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShiftId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShiftType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SchDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SchRegTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal SchFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal SchRegfee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal SchTreatfee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SchBegintime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SchEndtime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SchRegMax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SchLimited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SchSegmented { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LocationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Available { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SchRegCount { get; set; }
    }
}
