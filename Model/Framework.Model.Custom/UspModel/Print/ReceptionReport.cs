using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 前台统计报表
    /// </summary>
    [Serializable]
    public class ReceptionReport
    {

        public ReceptionReport() { }
        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorId { get; set; }
        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 诊所ID
        /// </summary>
        public string LocationId { get; set; }
        /// <summary>
        /// 诊所
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 收费类别
        /// </summary>
        public string ChargeType { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public double Amount { get; set; }
        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }
    }
}
