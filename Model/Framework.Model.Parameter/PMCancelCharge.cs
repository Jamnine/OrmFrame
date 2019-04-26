using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model.InterFace;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 作废单据信息使用
    /// </summary>
    [Serializable]
    public class PMCancelCharge
    {
        /// <summary>
        /// 作废单据信息
        /// </summary>
        public OuInvoice OuInvoiceInfo { get; set; }

        /// <summary>
        /// 取消人
        /// </summary>
        public string CancelOperID { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        public int HospitalID { get; set; }
        /// <summary>
        /// 诊所ID
        /// </summary>
        public string LocationID { get; set; }

        /// <summary>
        /// 取消备注
        /// </summary>
        public string CancelMemo { get; set; }

        /// <summary>
        /// 实时减库存
        /// </summary>
        public bool RealTimeReduction { get; set; }

        /// <summary>
        /// 部分作废
        /// </summary>
        public List<DeleteItem> DeleteItemInfo { get; set; }
    }
}
