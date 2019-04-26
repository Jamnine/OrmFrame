using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AssessmentHuLi : Basics
    {
        public int AssessmentApplyId { get; set; }

        /// <summary>
        /// 填表人时间
        /// </summary>
        public DateTime FormHolderTime { get; set; }

        /// <summary>
        /// 填表人ID
        /// </summary>
        public int FormHolderId { get; set; }

        /// <summary>
        /// 量表标题主ID
        /// </summary>
        public int AsScaleId { get; set; }

        /// <summary>
        /// 评估有效期
        /// </summary>
        public DateTime AssessmentValidUntil { get; set; }

        public DateTime ToTakeCareTime { get; set; }

        /// <summary>
        /// 评估分数
        /// </summary>
        public double AssessmentFraction { get; set; }

        /// <summary>
        /// 评估等级
        /// </summary>
        public int AssessmentGrade { get; set; }

        /// <summary>
        /// 评估结果
        /// </summary>
        public string AssessmentResult { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public int AuditId { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AuditTime { get; set; }

        public string ReviewReason { get; set; }

        public DateTime ReviewTime { get; set; }

        public DateTime CompletionTime { get; set; }

        public int AdminAuditId { get; set; }

        public DateTime AdminAuditTime { get; set; }

        public int AdminReAuditId { get; set; }

        public DateTime AdminReAuditTime { get; set; }

        public DateTime CheckTime { get; set; }

        public bool IsOldFool { get; set; }

        public int OperId { get; set; }

        public DateTime OperTime { get; set; }

        public int Status { get; set; }
    }
}
