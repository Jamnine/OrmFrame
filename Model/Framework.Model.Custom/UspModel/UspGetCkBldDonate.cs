using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspGetCkBldDonate:BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = false)]
        public virtual string HospId { get; set; }

        //[DataMember(Order = 3, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual String BloodGroup { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual String RHD { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual string BloodTypeId { get; set; }

        //[DataMember(Order = 7, IsRequired = false)]
        public virtual double Vollume { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual String BloodDonor { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual string MzRegId { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 11, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual string OperId { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual String InPatNo { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual String Sex { get; set; }

        //[DataMember(Order = 16, IsRequired = true)]
        public virtual DateTime InTime { get; set; }

        //[DataMember(Order = 17, IsRequired = false)]
        public virtual DateTime OutTime { get; set; }
    }
}
