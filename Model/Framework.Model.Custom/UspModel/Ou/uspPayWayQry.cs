using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 支付方式
    /// </summary>
    [Serializable]
    public class uspPayWayQry : BaseModel
    {
        /// <summary>
        /// 优惠活动
        /// </summary>
        public string ScaleID { get; set; }
        /// <summary>
        /// 整单折扣
        /// </summary>
        public string DiscountNum { get; set; }
        /// <summary>
        /// 上次欠款
        /// </summary>
        public double PrevArrears { get; set; }
        /// <summary>
        /// 本次费用
        /// </summary>
        public double CurrentCharge { get; set; }
        /// <summary>
        /// 合计应收
        /// </summary>
        public double TotalCharge { get; set; }
        /// <summary>
        /// 优惠后金额
        /// </summary>
        public double DiscountCharge { get; set; }
        /// <summary>
        /// 本次实收
        /// </summary>
        public string ActualCharge { get; set; }
        /// <summary>
        /// 本次欠款
        /// </summary>
        public double CurrentArrears { get; set; }
        /// <summary>
        /// 找回
        /// </summary>
        public double BackCharge { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoNo { get; set; }

        /// <summary>
        /// 是否保存
        /// </summary>
        public bool IsSave { get; set; }
        /// <summary>
        /// 收费医生id
        /// </summary>
        public string ChargeDoctorId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatId { get; set; }

        /// <summary>
        /// 修改收费时间
        /// </summary>
        public DateTime ModifyTime { get; set; }

        /// <summary>
        /// 欠款分类
        /// </summary>
        public string ArrearsTypeId { get; set; }

    }
}
