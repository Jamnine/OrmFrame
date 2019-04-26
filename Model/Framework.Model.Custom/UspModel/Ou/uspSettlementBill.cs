using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 结算清单
    /// </summary>
    [Serializable]
    public class uspSettlementBill
    {
        /// <summary>
        /// 诊所名称
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// 诊所电话
        /// </summary>
        public string LocationTel { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }
        
        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorID { get; set; }
        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OperID { get; set; }
        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string OperName { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string Provider { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoNo { get; set; }
        /// <summary>
        /// 单据ID
        /// </summary>
        public string InvoID { get; set; }

        /// <summary>
        /// 门诊流水号。外键，引用OuHosInfo.GUID.
        /// </summary>
        public string MzRegId { get; set; }
        /// <summary>
        /// 收费项目名称
        /// </summary>
        public string PayDescription { get; set; }
        /// <summary>
        /// 收费项目编号
        /// </summary>
        public string PayCode{ get; set; }
        public double Number { get; set; }
        /// <summary>
        /// 应交金额
        /// </summary>
        public double AmountPay { get; set; }

        /// <summary>
        /// 支付方应支付
        /// </summary>
        public double PayorDue { get; set; }
        /// <summary>
        /// 患者应支付
        /// </summary>
        public double PatDue { get; set; }
        /// <summary>
        /// 项目费用
        /// </summary>
        public double DescriptionAmount { get; set; }
        /// <summary>
        /// 套餐名称
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// 原总金额
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount { get; set; }
        /// <summary>
        /// 英文名
        /// </summary>
        public string EngDesc { get; set; }
        /// <summary>
        /// 英文名(明细用)
        /// </summary>
        public string EngDesc1 { get; set; }
        /// <summary>
        /// 是否打印套餐名
        /// </summary>
        public bool IsPrintName { get; set; }
        /// <summary>
        /// 会员总金额
        /// </summary>
        public double TotalVipAmount { get; set; }
        /// <summary>
        /// 会员消费金额
        /// </summary>
        public double ConVipAmount { get; set; }
        /// <summary>
        /// 会员余额
        /// </summary>
        public double VipBalance { get; set; }
        /// <summary>
        /// 会员等级
        /// </summary>
        public string  VipLevel { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayWayName { get; set; }
        /// <summary>
        /// 支付金额
        /// </summary>
        public string PayWayAmount { get; set; }

        /// <summary>
        /// 是否会员消费扣减项目
        /// </summary>
        public bool IsVipDeduction { get; set; }
        /// <summary>
        /// 记账金额
        /// </summary>
        public double AccountAmount{ get; set; }
        
        /// <summary>
        /// 是否记账
        /// </summary>
        public bool IsTally { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        public string TjPackageName { get; set; }

        /// <summary>
        /// 折扣金额
        /// </summary>
        public double DiscountAmount { get; set; }
    }
}
