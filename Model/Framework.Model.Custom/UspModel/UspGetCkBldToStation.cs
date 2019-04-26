using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspGetCkBldToStation
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String RecNo { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual string BloodId { get; set; }

        //[DataMember(Order = 4, IsRequired = false)]
        public virtual DateTime BackTime { get; set; }

        //[DataMember(Order = 5, IsRequired = false)]
        public virtual string BackOperId { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual String BackReason { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual String UserName { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 10, IsRequired = false)]
        public virtual string OperId { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual String SerialNo { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual string UserID { get; set; }

        //[DataMember(Order = 13, IsRequired = false)]
        public virtual string BankID { get; set; }
    }
}
