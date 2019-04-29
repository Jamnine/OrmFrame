using Orm.Model.Custom;
using System;
using System.Collections.Generic;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 收费信息集合
    /// </summary>
    [Serializable]
    public class PMFindInvoiceByInvoNo
    {
        /// <summary>
        /// 病人（就诊、基本）信息详情
        /// </summary>
        public Custom.uspHisOuPatientQry Hosinfo { get; set; }

        /// <summary>
        /// 收费单据详细
        /// </summary>
        public List<Custom.uspOuInvoiceDtlQry> LstUspOuInvoiceDtl { get; set; }

        /// <summary>
        /// 收费单据
        /// </summary>
        public OuInvoice Invoice { get; set; }

        /// <summary>
        /// 收费发票分类信息
        /// </summary> 
        public List<Custom.uspOuInvoiceInvItemGoupSumQry> NewInvItemGoupSumList { get; set; }
        public List<uspOuInvoiceInvItemGoupSumQry> InvItemGoupSumList { get; set; }
        public List<uspOuInvoiceDtlQry> UspOuInvoiceDtlList { get; set; }
    }
}
