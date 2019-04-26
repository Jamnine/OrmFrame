using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class AccountingWithOuInvoiceRelation
    {
        public List<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlForOuInvoiceDtl { set; get; }


        public List<SelectHisItem> lstSelectRecipe { set; get; }

        public List<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlForOuInvoiceDtlRemove { set; get; }

        public List<UspOuInvoiceDtl> lstUspOuInvoiceDtlDto { set; get; }

        public List<UspOuInvoiceDtl> lstSelfDrug { set; get; }

        public UspOuInvoiceDtl infoUspOuInvoiceDtl { set; get; }

        public OuInvoice infoOuInvoice { set; get; }

        public BsDoctor infoDoctor { set; get; }
        public bool isDoctorInput { set; get; }

        public int ubsExecLocId { set; get; }

        public bool isJm { set; get; }
    }
}
