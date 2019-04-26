using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 总检信息
    /// </summary>
    [Serializable]
    public class uspTjTotalSummary
    {
        public uspTjTotalSummary()
        {

        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }

        /// <summary>
        /// 档案编号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        /// 病人性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 性别（字符串）
        /// </summary>
        public string AgeString { get; set; }

        /// <summary>
        /// 总检医生
        /// </summary>
        public string ZjDoctorName { get; set; }

        /// <summary>
        /// 总检小结
        /// </summary>
        public string ZjSummary { get; set; }

        /// <summary>
        /// 总检时间
        /// </summary>
        public DateTime ZjOperTime { get; set; }

        /// <summary>
        /// 体检时间
        /// </summary>
        public DateTime RegTime { get; set; }

        /// <summary>
        /// 防治建议
        /// </summary>
        public string PreventingSuggestion { get; set; }

        /// <summary>
        /// 体检诊断
        /// </summary>
        public string TotalDiagnosis { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 门诊ID
        /// </summary>
        public string MZRegID { get; set; }

        /// <summary>
        /// 是否总检完成
        /// </summary>
        public bool IsTjOver { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }
    }
}
