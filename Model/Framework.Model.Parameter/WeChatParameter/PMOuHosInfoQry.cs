using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 微信端查询获取挂号参数类
    /// </summary>
    [Serializable]
    public class PMOuHosInfoQry
    {   /// <summary>
        /// 病人id
        /// </summary>
        public string PatientId { get; set; }
        /// <summary>
        /// 医生id
        /// </summary>
        public string DoctorId { get; set; }
        /// <summary>
        /// 科室id
        /// </summary>
        public string DepartmentId { get; set; }
        /// <summary>
        /// 挂号id
        /// </summary>
        public string OuHosInfoId { get; set; }
        /// <summary>
        /// 挂号时间
        /// </summary>
        public DateTime RegistrationTime { get; set; }
        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorLevel { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 诊所名称
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// 挂号费
        /// </summary>
        public double RegistrationFee { get; set; }
        /// <summary>
        ///是否已作废
        /// </summary>
        public bool IsCancel { get; set; }

        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalID { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        public string HospitalName { get; set; }
    }
}
