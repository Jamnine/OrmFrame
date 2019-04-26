using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    public class AssessmentApplyModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OlderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime ApplyVisitDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ApplyVisitTimeSpan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> AuditId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> AuditTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AuditFailure { get; set; }
        /// <summary>
        /// 申请状态：1-待处理 2-申请不通过 3-申请已通过
        /// </summary>
        public short Status { get; set; }

        //扩展属性
        /// <summary>
        /// 时间段字符串
        /// </summary>
        public string ApplyVisitTimeSpanSrc { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 老人名称
        /// </summary>
        public string OlderName { get; set; }
        /// <summary>
        /// 审核人名称
        /// </summary>
        public string AuditName { get; set; }
        /// <summary>
        /// 申请状态名称
        /// </summary>
        public string StatusSrc { get; set; }
        /// <summary>
        /// 老人地址
        /// </summary>
        public string OlderAddress { get; set; }
        /// <summary>
        /// 对象完整性检测
        /// </summary>
        /// <param name="mod"></param>
        /// <returns></returns>
        public static bool Check(AssessmentApplyModel mod)
        {

            if (string.IsNullOrWhiteSpace(mod.SerialNumber) || mod.UserId == 0
                || mod.OlderId == 0 || mod.CreateTime == null || mod.ApplyVisitDate == null
                || string.IsNullOrWhiteSpace(mod.ApplyVisitTimeSpan) || mod.Status == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// int转时间段字符
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        //public static string ParseTimeSpanSrc(int i)
        //{
        //    string TimeSpanStr = "";
        //    switch (i) {
        //        case 1:
        //            TimeSpanStr = "9:00-10:00";
        //            break;
        //        case 2:
        //            TimeSpanStr = "9.00-10.00";
        //            break;
        //        case 3:
        //            TimeSpanStr = "10.00-11.00";
        //            break;
        //        default:
        //            break;
        //    }
        //    return TimeSpanStr;
        //}
        /// <summary>
        /// int转申请状态字符串
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string ParseStatusSrc(int i)
        {
            string StatusSrc = "";
            switch (i)
            {
                case 1:
                    StatusSrc = "待审核";
                    break;
                case 2:
                    StatusSrc = "审核不通过";
                    break;
                case 3:
                    StatusSrc = "审核已通过";
                    break;
                default:
                    break;
            }
            return StatusSrc;
        }
    }
}
