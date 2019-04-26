using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.VIP
{
    [Serializable]
    public class UspVisitRecordPatient : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual DateTime VisitTime { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual string OperId { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual string OperName { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual Int16 VisitType { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual string VisitTypeName { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual string VisitContent { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual string PatId { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual string CardNo { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual string PatName { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual string SexName { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual string MzRegId { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual string BackContent { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual Int32 VisitStatus { get; set; }

        //[DataMember(Order = 16, IsRequired = true)]
        public virtual string VisitStatusName { get; set; }

        //[DataMember(Order = 17, IsRequired = true)]
        public virtual Int32 AppraiseType { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual string AppraiseTypeName { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 20, IsRequired = true)]
        public virtual string DoctorName { get; set; }
    }
}
