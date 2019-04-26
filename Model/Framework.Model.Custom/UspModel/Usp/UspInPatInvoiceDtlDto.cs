using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInPatInvoiceDtl 
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string guId { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String InPatNo { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual String BsBedName { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual double? PriceIn { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual String InvInItemName { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual int OrderBy { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual String Code { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual DateTime FromDate { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual DateTime? ToDate { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual String UnitName { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual double Totality { get; set; }

        //[DataMember(Order = 16, IsRequired = true)]
        public virtual double AmountPay { get; set; }

        //[DataMember(Order = 17, IsRequired = false)]
        public virtual double? Amount { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual String ExcLocation { get; set; }
    }
}
