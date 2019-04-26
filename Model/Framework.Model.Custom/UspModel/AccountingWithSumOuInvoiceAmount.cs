using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class AccountingWithSumOuInvoiceAmount
    {
        public virtual string UserId { get; set; }

        public virtual string MzRegId { get; set; }

        public virtual string PatName { get; set; }

    }
}
