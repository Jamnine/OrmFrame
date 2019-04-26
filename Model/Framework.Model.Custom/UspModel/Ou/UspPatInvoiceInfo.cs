using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{

    /// <summary>
    /// 病人收费情况
    /// </summary>
    [Serializable]
    public class UspPatInvoiceInfo : BaseModel
    {
        /// <summary>
        /// 发票ID
        /// </summary>
        public string InvoId { get; set; }
        /// <summary>
        /// 病人Id
        /// </summary>
        public string PatientId { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string AgeString { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 就诊目的BOOKINGPURPOSE
        /// </summary>
        public string BookingPurpose { get; set; }
        /// <summary>
        /// 发票登记时间
        /// </summary>
        public DateTime InvoiceOperTime { get; set; }

        /// <summary>
        /// 应交金额
        /// </summary>
        public double AmountPay { get; set; }

        /// <summary>
        /// 个人缴费金额 PAYSELF
        /// </summary>
        public double PaySelf { get; set; }

        /// <summary>
        /// 应结算金额（总金额） BEPRICE
        /// </summary>
        public double BePrice { get; set; }
        
        /// <summary>
        /// 发票号 INVONO
        /// </summary>
        public string InvoNo { get; set; }

        /// <summary>
        /// 收费人
        /// </summary>
        public string OperName { get; set; }

        /// <summary>
        /// 本次实收 CURRENTARREARS
        /// </summary>
        public double CurrentArrears { get; set; }

        public bool IsCancel { get; set; }

        /// <summary>
        /// 打折前
        /// </summary>
        public double DiscountFront { get; set; }

        public string DortorName { get; set; }

        /// <summary>
        /// 整单折扣
        /// </summary>
        public double DiscountNum { get; set; }
        /// <summary>
        /// 收费备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 就诊时间
        /// </summary>
        public DateTime RegTime { get; set; }

    }
}
