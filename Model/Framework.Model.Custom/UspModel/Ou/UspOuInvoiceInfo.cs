using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 收费单据组合
    /// </summary>
     [Serializable]
    public class UspOuInvoiceInfo : BaseModel
    {
        /// <summary>
        /// 支付方式数量
        /// </summary>
        public List<uspPayWayAomunt> LstPayWayAomunt { get; set; }

        /// <summary>
        /// 收费单据组合
        /// </summary>
         public List<uspOuInvoiceQry> LstUspOuInvoice { get; set; }
    }

    /// <summary>
    /// 支付方式数量
    /// </summary>
    [Serializable]
     public class uspPayWayAomunt : BaseModel
     {
        /// <summary>
        /// 支付方式
        /// </summary>
         public string PayWayName { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
         public double Aomunt { get; set; }
     }
}
