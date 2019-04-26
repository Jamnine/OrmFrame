using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 评估应用
    /// </summary>
    [Serializable]
    public class AssessmentApply : Basics
    {
        /// <summary>
        /// 序列号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 申请人ID：对应申请人表：Applicant
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 被服务人ID：对应病人表：Patient
        /// </summary>
        public int OlderId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 使用日期
        /// </summary>
        public DateTime ApplyVisitDate { get; set; }

        /// <summary>
        /// 使用时间段
        /// </summary>
        public string ApplyVisitTimeSpan { get; set; }

        /// <summary>
        /// 审核ID
        /// </summary>
        public int AuditId { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AuditTime { get; set; }

        /// <summary>
        /// 审核失败备注
        /// </summary>
        public string AuditFailure { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public short Status { get; set; }
    }
}
