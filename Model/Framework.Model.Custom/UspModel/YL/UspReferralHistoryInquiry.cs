using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 转诊历史查询
    /// </summary>
    [Serializable] 
    public class UspReferralHistoryInquiry : BaseModel
    {
        /// <summary>
        /// 病人
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 原医院.
        /// </summary>
        public string OriginalHospitalid { get; set; }
        /// <summary>
        /// 原科室
        /// </summary>
        public string OriginaDepartment { get; set; }
        /// <summary>
        /// 原医生.
        /// </summary>
        public string OriginaDoctor { get; set; }
        /// <summary>
        /// 转诊医院 
        /// </summary>
        public string ReferralHospital { get; set; }
        /// <summary>
        /// 转诊科室ID
        /// </summary>
        public string ReferralDepartment { get; set; }
        /// <summary>
        /// 转诊医生
        /// </summary>
        public string ReferralDoctor { get; set; }
        /// <summary>
        /// 转诊时间开始
        /// </summary>
        public DateTime ReferralTimeBegin { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 转诊目的 
        /// </summary>
        public string ReferralObjective { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperatorTime { get; set; }
        /// <summary>
        /// 转诊时间结束
        /// </summary>
        public DateTime ReferralTimeEnd { get; set; }
        /// <summary>
        /// 初步诊断
        /// </summary>
        public string PreliminaryDiagnosis { get; set; }
        /// <summary>
        /// 紧急程度
        /// </summary>
        public string EmergencyDegree { get; set; }
        /// <summary>
        /// 紧急程度ID
        /// </summary>
        public int EmergencyDegreeID { get; set; }
    }
}
