using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 护士用到的收费信息
    /// </summary>
    [Serializable]
    public class uspSCChargeByNurse
    {
        public uspSCChargeByNurse() { }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoNo { get; set; }
        //public int PatId { get; set; }
        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 护士名
        /// </summary>
        public string NurseName { get; set; }
        /// <summary>
        /// 项目应收
        /// </summary>
        public double ActuallyPay { get; set; }
        /// <summary>
        /// 发票应收
        /// </summary>
        public double ShouldePay { get; set; }
        /// <summary>
        /// 上次欠费
        /// </summary>
        public double PreviousArrears { get; set; }
        /// <summary>
        /// 本次欠费
        /// </summary>
        public double CurrentArrears { get; set; }
        /// <summary>
        /// 收费类别
        /// </summary>
        public string FeeName { get; set; }
        /// <summary>
        /// 实收金额
        /// </summary>
        public double Paid { get; set; }
        public string LocationId { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public double DiscountAmount { get; set; }
        /// <summary>
        /// 应结算总金额
        /// </summary>
        public double Beprice { get; set; }
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
