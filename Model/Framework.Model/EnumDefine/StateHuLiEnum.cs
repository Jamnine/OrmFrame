using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Orm.Model.EnumDefine
{
    public class StateHuLiEnum
    {
        public enum State
        {

            ///// <summary>
            ///// 未审核
            ///// </summary>
            //NotAudit = 2,
            ///// <summary>
            ///// 已审核
            ///// </summary>
            //EndAudit = 3,

            ///// <summary>
            ///// 非抽中
            ///// </summary>
            //NoExtract = 5,

            ///// <summary>
            ///// 二次评估
            ///// </summary>
            //TwoAssess = 7,
            /// <summary>
            /// 申请表-申请待审核状态-对应的值为1
            /// </summary>
            [Description("申请待审核")]
            ApplyNotAudit = 1001,
            /// <summary>
            /// 申请表-申请待审核状态-对应的值为1
            /// </summary>
            [Description("申请未通过")]
            ApplyNoPass = 1002,
            /// <summary>
            /// 上门评估中
            /// </summary>
            [Description("上门评估中")]
            Assessing = 1,
            /// <summary>
            /// 待抽查
            /// </summary>
            [Description("等待抽查中")]
            NotExtract = 2,
            /// <summary>
            /// 抽中
            /// </summary>
            [Description("抽中")]
            PassExtract = 3,
            /// <summary>
            /// 待分配专家
            /// </summary>
            [Description("二次评估中")]
            NotAllot = 4,
            /// <summary>
            /// 审核中
            /// </summary>
            [Description("二次评估中")]
            Auditing = 5,
            /// <summary>
            /// 待确认（申请人确认）
            /// </summary>
            [Description("等待复核确认中")]
            NotAffirm = 6,
            /// <summary>
            /// 待复核-复核待分配
            /// </summary>
            [Description("复核评估中")]
            NotReAudit = 7,
            /// <summary>
            /// 复审中-复核待确认(专家确认)
            /// </summary>
            [Description("复核评估中")]
            ReAuditing = 8,
            /// <summary>
            /// 评估完成
            /// </summary>
            [Description("评估完成")]
            EndAssess = 9
        }

    }
}
