using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel.Usp
{
    [Serializable]
    public class UspCkLabByOpertimeAndLsStatus4
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String LabNum { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual string PatId { get; set; }
        
       // [DataMember(Order = 4, IsRequired = true)]
        public virtual Int16 LsStatus { get; set; }

        //[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime? OperTime { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual string LabId { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //[DataMember(Order = 8, IsRequired = false)]
        public virtual Boolean? IsPass { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual Boolean IsCancel { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual Boolean IsPriority { get; set; }

        //[DataMember(Order = 11, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual Int16 LsSource { get; set; }

        //[DataMember(Order = 13, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 14, IsRequired = false)]
        public virtual string HospId { get; set; }

        //[DataMember(Order = 15, IsRequired = false)]
        public virtual string MzRegId { get; set; }

        //[DataMember(Order = 16, IsRequired = true)]
        public virtual String Sex { get; set; }

        //[DataMember(Order = 17, IsRequired = false)]
        public virtual string MachineID { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual String SexName { get; set; }

        //[DataMember(Order = 19, IsRequired = false)]
        public virtual string ReportOperId { get; set; }

        //[DataMember(Order = 20, IsRequired = false)]
        public virtual DateTime? BirthDate { get; set; }

        //[DataMember(Order = 21, IsRequired = false)]
        public virtual Int32? Age { get; set; }

        //[DataMember(Order = 22, IsRequired = false)]
        public virtual Int32? AgeMonth { get; set; }

        //[DataMember(Order = 23, IsRequired = true)]
        public virtual String PatientNameModi { get; set; }

        //[DataMember(Order = 24, IsRequired = false)]
        public virtual Int32? SampleNo { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual String TestName { get; set; }

        //[DataMember(Order = 26, IsRequired = false)]
        public virtual Boolean? IsPrint { get; set; }
    }
}
