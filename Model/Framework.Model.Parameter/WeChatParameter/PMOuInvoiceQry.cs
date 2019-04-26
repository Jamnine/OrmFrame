using System;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 微信端查询获取收费单据信息参数类
    /// </summary>
    [Serializable]
    public class PMOuInvoiceQry
    {
        /// <summary>
        /// 收费发票信息id
        /// </summary>
        public string OuInvoiceId { get; set; }
        /// <summary>
        /// 病人id
        /// </summary>
        public string PatientId { get; set; }
        /// <summary>
        /// 挂号id
        /// </summary>
        public string MzRegId { get; set; }
        /// <summary>
        /// 生成发票时间
        /// </summary>
        public DateTime InvoiceTime { get; set; }
        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 病人档案号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegNo { get; set; }
        /// <summary>
        /// 发票流水号
        /// </summary>
        public string InvoiceNo { get; set; }
        /// <summary>
        /// 实收金额
        /// </summary>
        public double AmountPay { get; set; }
        /// <summary>
        /// 应收金额
        /// </summary>
        public double PaySelf { get; set; }
        /// <summary>
        /// 记账金额
        /// </summary>
        public double AccountAmount { get; set; }
        /// <summary>
        ///是否已作废(true已作废，默认false)
        /// </summary>
        public bool IsCancel { get; set; }
        /// <summary>
        ///是否定点;用于微信端接口收费判断是否医保缴费(为假时不是医保缴费)
        /// </summary>
        public bool IsFixedPoint { get; set; }
        /// <summary>
        /// 缴费类型
        /// </summary>
        public string InvoiceType { get; set; }
    }
}
