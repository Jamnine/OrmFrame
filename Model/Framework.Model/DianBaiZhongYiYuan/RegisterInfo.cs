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
    public class RegisterInfo: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime RegTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TimeSpan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeptId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DoctorId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Totalfee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ShiftId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StateCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RefundTime { get; set; }
    }
}
