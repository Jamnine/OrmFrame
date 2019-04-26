using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspCkPatientInfo : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual string PatId { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String LabNum { get; set; }

        //[DataMember(Order = 4, IsRequired = false)]
        public virtual string MzRegId { get; set; }

        //[DataMember(Order = 5, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String RefLocation { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual Int32 LsSource { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual string HospId { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual String Diagnose { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual Boolean IsPriority { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual String ReportMemo { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual String TechMemo { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual String OtherMemo { get; set; }

        //[DataMember(Order = 15, IsRequired = false)]
        public virtual string SourceId { get; set; }

        //[DataMember(Order = 16, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //[DataMember(Order = 17, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual String Sex { get; set; }

        //[DataMember(Order = 20, IsRequired = false)]
        public virtual DateTime BirthDate { get; set; }

        //[DataMember(Order = 21, IsRequired = true)]
        public virtual String BloodGroup { get; set; }

        //[DataMember(Order = 22, IsRequired = true)]
        public virtual String Age { get; set; }

        //[DataMember(Order = 23, IsRequired = false)]
        public virtual string FlowNum { get; set; }

        //[DataMember(Order = 24, IsRequired = true)]
        public virtual String BedName { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual String HospNo { get; set; }

        //[DataMember(Order = 26, IsRequired = true)]
        public virtual string PatID1 { get; set; }

        //[DataMember(Order = 27, IsRequired = true)]
        public virtual Int32 LsStatus { get; set; }

        //[DataMember(Order = 28, IsRequired = false)]
        public virtual string TestTypeId { get; set; }

        //[DataMember(Order = 29, IsRequired = false)]
        public virtual string AuthOperId { get; set; }
    }
}
