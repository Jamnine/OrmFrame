using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 微信端保存挂号参数类
    /// </summary>
    [Serializable]
    public class PMSaveRegistration
    {
        /// <summary>
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
        /// 挂号时间
        /// </summary>
        public DateTime RegistrationTime { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 挂号时间段id
        /// </summary>
        public string TimeSpanId { get; set; }

        /// <summary>
        /// 挂号费
        /// </summary>
        public double RegFee { get; set; }


        /// <summary>
        /// 项目名称
        /// </summary>
        public string BsItemName { get; set; }

        /// <summary>
        /// 预约项目ID
        /// </summary>
        public int PreRegItemId { get; set; }

        /// <summary>
        /// 科室ID
        /// </summary>
        public string LocationId { get; set; }

        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalId { get; set; }
    }
}
