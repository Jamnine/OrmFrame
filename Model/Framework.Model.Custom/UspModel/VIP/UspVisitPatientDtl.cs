using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.VIP
{
    [Serializable]
    public class UspVisitPatientDtl : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual string CardNo { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual string PatientName { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual string LinkmanName { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual string LinkmanPhone { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual string Company { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual string PhoneWork { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual string Sex { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual string AgeString { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual DateTime BirthDate { get; set; }

        //[DataMember(Order = 11, IsRequired = false)]
        public virtual string Mobile { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 13, IsRequired = false)]
        public virtual string VipCardNo { get; set; }

        //[DataMember(Order = 14, IsRequired = false)]
        public virtual string VipLevelId { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual string PersonHistory { get; set; }

        //[DataMember(Order = 16, IsRequired = false)]
        public virtual string LevelName { get; set; }

        //[DataMember(Order = 17, IsRequired = true)]
        public virtual Int32 LsMarriage { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual string Phone { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual string AddressHome { get; set; }

        //[DataMember(Order = 20, IsRequired = true)]
        public virtual string IdCardNo { get; set; }

        //[DataMember(Order = 21, IsRequired = false)]
        public virtual string IdCardNoType { get; set; }

        //[DataMember(Order = 22, IsRequired = true)]
        public virtual string Sensitive { get; set; }
    }
}
