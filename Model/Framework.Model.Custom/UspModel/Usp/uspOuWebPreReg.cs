using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// web预约病人
    /// </summary>
    [Serializable]
    public class uspOuWebPreReg:BaseModel
    {
        public uspOuWebPreReg() { }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }


        /// <summary>
        /// 出生日期
        /// </summary>
        public string BirthDate { get; set; }


        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 预约时间
        /// </summary>
        public string PreRegTime { get; set; }

        /// <summary>
        /// 时段ID
        /// </summary>
        public string TimeSpanSubID { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorId { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public string ApplyTime { get; set; }

        /// <summary>
        /// 医院ID
        /// </summary>
        public string HospitalID { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        public string HospitalName { get; set; }

        /// <summary>
        /// 诊所ID
        /// </summary>
        public string LocationID { get; set; }

        /// <summary>
        /// 时段
        /// </summary>
        public string TimeSpanSubName { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 诊所名称
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 预约目的
        /// </summary>
        public string BookingPurpose { get; set; }

        /// <summary>
        /// 预约备注(病情描述)  
        /// </summary>
        public string BookingComments { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
    }
}
