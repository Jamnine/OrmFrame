using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public partial class UspOuRecipeDtlForOuInvoiceDtl
    {
        public virtual string TempStr { get; set; }
        public virtual Boolean IsOnlyUseOne { get; set; }
    }
}
