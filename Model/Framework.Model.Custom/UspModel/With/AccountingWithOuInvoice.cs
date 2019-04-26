using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class AccountingWithOuInvoice
    {
        public UspOuInvoiceDtl InfoOuInvoiceDtl { get; set; }

        public IList<UspOuInvoiceDtl> lstUspOuInvoiceDtl { get; set; }

        public IList<UspOuCkeckItem> lstUspOuCkeckItem { get; set; }

        public IList<UspOuCkeckItemCompany> lstUspOuCkeckItemCompanyDto { get; set; }

        public IList<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlForOuInvoiceDtlDto { get; set; }

        public IList<BsLabSourceItem> lstSourceItem { get; set; }

        public virtual string SameItemId { get; set; }

        public virtual bool isTj { get; set; }
    }
}
