using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 牙科收费明细
    /// </summary>
    [Serializable]
    public class UspToothChargeRecipeDtl : BaseModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemID { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitDiag { get; set; }

        /// <summary>
        /// 单位ID
        /// </summary>
        public string UnitDiagID { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public double PriceDiag { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public double Totality { get; set; }

        /// <summary>
        /// 优惠（%）
        /// </summary>
        public double DiscDiag { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        public double AmountDiscount { get; set; }

        /// <summary>
        /// 折后金额
        /// </summary>
        public double AmountPay { get; set; }

        /// <summary>
        /// 处方ID
        /// </summary>
        public string RecipeId { get; set; }

        public string RecipeDtlId { get; set; }

        /// <summary>
        /// 用法
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// 用法ID
        /// </summary>
        public string UsageId { get; set; }

        /// <summary>
        /// 是否已结账
        /// </summary>
        public bool IsCharged { get; set; }

        private bool _isChecked = true;
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsChecked
        {
            get { return _isChecked; }
            set { _isChecked = value; }
        }


        private string _operId;
        /// <summary>
        ///操作人
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }

        /// <summary>
        /// 是否清理
        /// </summary>
        public bool IsDisposal { get; set; }
        /// <summary>
        /// 套餐主表ID
        /// </summary>
        public string Xdrpid { get; set; }
        public string Spec { get; set; }
        public string INVONO { get; set; }
        public string FrequencyId { get; set; }
        public string Frequency { get; set; }
        public bool IsOtherFee { get; set; }
        public bool IsPatExecute { get; set; }
        public int ChargeCount { get; set; }
        public DateTime InputTime { get; set; }
        public bool IsOper { get; set; }
        public bool IsVipDeduction { get; set; }
    }
}
