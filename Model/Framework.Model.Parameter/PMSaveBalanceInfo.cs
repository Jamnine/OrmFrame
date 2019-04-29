using System;
using System.Collections.Generic;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 病人消费信息
    /// </summary>
    [Serializable]
    public class PMSaveBalanceInfo
    {
        public PatPricereCords PatPricereCord { get; set; }
        /// <summary>
        /// 会员充值表 
        /// </summary>
        public OuRecharge OuRecharge { get; set; }
        /// <summary>
        /// 发票信息
        /// </summary>
        public OuInvoice OuInvoice { get; set; }
        /// <summary>
        /// 发票明细
        /// </summary>
        public List<OuInvoiceDtl> OuInvoiceDtlList { get; set; }
        /// <summary>
        /// 当前收费病人信息
        /// </summary>
        public Custom.uspHisOuPatientQry CurrentPatient { get; set; }
        /// <summary>
        /// 收费支付方式
        /// </summary>
        public List<OuInvoicePay> OuInvoicePayList { get; set; }
        /// <summary>
        /// 收费发票分类信息
        /// </summary>
        public List<Custom.uspOuInvoiceInvItemGoupSumQry> AssortmentSumList { get; set; }
        /// <summary>
        ///会员消费记录
        /// </summary>
        public List<VipReckoningCharge> VipReckoningChargeList { get; set; }
        /// <summary>
        /// 推荐人非会员的积分列表集合
        /// </summary>
        public List<BsPatient> BsPatientSaveList { get; set; }
        /// <summary>
        /// 推荐人属于会员的积分列表集合
        /// </summary>
        public List<VipIntegral> VipIntegralSaveList { get; set; }
        /// <summary>
        /// 会员转换为钱
        /// </summary>
        public double VipScoreToMoney { get; set; }

        /// <summary>
        /// 诊所ID
        /// </summary>
        public String LocationId { get; set; }

        /// <summary>
        /// 实时减库存
        /// </summary>
        public bool RealTimeReduction { get; set; }

        /// <summary>
        /// 实时减库存 明显
        /// </summary>
        public List<OuRecipeDtl> OuRecipeDtlList { get; set; }

        /// <summary>
        /// 处方
        /// </summary>
        public List<OuRecipe> ouRecipeList { get; set; }
    }
}
