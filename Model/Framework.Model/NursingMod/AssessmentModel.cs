using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 评估表
    /// </summary>
    public class AssessmentModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AssessmentApplyId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FormHolderTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FormHolderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AsScaleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> AssessmentGrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime AssessmentValidUntil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> ToTakeCareTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> AssessmentFraction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AssessmentResult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> AuditId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> AuditTime { get; set; }
        /// <summary>`
        /// 
        /// </summary>
        public string ReviewReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> CompletionTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> AdminAuditId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> AdminAuditTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> AdminReAuditId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> AdminReAuditTime { get; set; }
        /// <summary>
        /// 申请时间
        /// 2017-11-2 添加
        /// </summary>
        public Nullable<System.DateTime> ReviewTime { get; set; }
        /// <summary>
        /// 是否老人痴呆
        /// 添加时间2017-10-27
        /// </summary>
        public bool IsOldFool { get; set; }
        /// <summary>
        /// 最后操作人id
        /// 添加时间2017-10-27
        /// </summary>
        public int OperId { get; set; }
        /// <summary>
        /// 最后操作时间
        /// 添加时间2017-10-27
        /// </summary>
        public System.DateTime OperTime { get; set; }
        /// <summary>
        /// 抽查时间
        /// </summary>
        public Nullable<System.DateTime> CheckTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 填表人名称
        /// </summary>
        public string FormHolderName { get; set; }
        /// <summary>
        /// 审核人名称
        /// </summary>
        public string AuditName { get; set; }
        /// <summary>
        /// 申请人名称
        /// </summary>
        public string ApplyUserName { get; set; }
        /// <summary>
        /// 申请人电话
        /// </summary>
        public string ApplyUserPthone { get; set; }
        /// <summary>
        /// 上门评估时间
        /// </summary>
        public DateTime ApplyVisitDate { get; set; }
        /// <summary>
        /// 上门评估时间段
        /// </summary>
        public string ApplyVisitTimeSpan { get; set; }
        /// <summary>
        /// 被服务人姓名
        /// </summary>
        public string OlderName { get; set; }
        /// <summary>
        /// 被服务人id
        /// </summary>
        public int OlderId { get; set; }
        /// <summary>
        /// 被服务人电话
        /// </summary>
        public string OlderPhone { get; set; }
        /// <summary>
        /// 被服务人地址
        /// </summary>
        public string OlderAddress { get; set; }

        /// <summary>
        /// 所患慢性病,多个用英文逗号隔开
        /// </summary>
        public string ChronicDisease { get; set; }
        /// <summary>
        /// 初审时间（评估端审核时间）
        /// </summary>
        public DateTime AssessPortAuditTime { get; set; }
        /// <summary>
        /// 专家组
        /// </summary>
        public string ExperGroupList { get; set; }
        /// <summary>
        /// 审核状态 1:未审核 2:已审核
        /// </summary>
        public int AuditStatus { get; set; }

        /// <summary>
        /// 格式化的CompletionTimeStr
        /// </summary>
        public string CompletionTimeStr { get; set; }

        /// <summary>
        /// 排序集合体
        /// </summary>
        public Nullable<DateTime> aggregation { get; set; }
    }
}
