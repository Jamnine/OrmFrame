using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 病人信息查询组合条件
    /// </summary>
    [Serializable]
    public class PMArrearageInvoice
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        /// 病人id
        /// </summary>
        public string Patid { get; set; }

        /// <summary>
        /// 诊所ID
        /// </summary>
        public int HospitalID { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorId { get; set; }
        /// <summary>
        /// 记账
        /// </summary>
        public int TallyCode { get; set; }
    }
}
