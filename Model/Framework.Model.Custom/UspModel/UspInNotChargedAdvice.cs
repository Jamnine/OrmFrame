using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInNotChargedAdvice
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual string HospId { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual double Totality { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual string DetailId { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual string ExecLocationId { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual double PriceIn { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual string ReqOperId { get; set; }

        //[DataMember(Order = 11, IsRequired = false)]
        public virtual Int32? LsMarkType { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual Int32? SelectCollumn { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual string GroupNum { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual double Dosage { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual string UnitTakeId { get; set; }

        //[DataMember(Order = 16, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        //[DataMember(Order = 17, IsRequired = false)]
        public virtual string UsageId { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual string UnitInId { get; set; }

        //[DataMember(Order = 19, IsRequired = false)]
        public virtual Boolean? IsAttach { get; set; }

        //[DataMember(Order = 20, IsRequired = false)]
        public virtual Int32? LsExecLoc { get; set; }

        //[DataMember(Order = 21, IsRequired = true)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 22, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 23, IsRequired = false)]
        public virtual Boolean? IsOtherFee { get; set; }

        //[DataMember(Order = 24, IsRequired = true)]
        public virtual DateTime AdviceTime { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 26, IsRequired = true)]
        public virtual String Spec { get; set; }

        //[DataMember(Order = 27, IsRequired = false)]
        public virtual Int32? LsRpType { get; set; }

        //[DataMember(Order = 28, IsRequired = false)]
        public virtual double? Amount { get; set; }

        public virtual String GUID { get; set; }
    }
}
