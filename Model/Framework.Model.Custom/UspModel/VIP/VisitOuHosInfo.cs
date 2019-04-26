using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.VIP
{
    [Serializable]
    public class VisitOuHosInfo : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual string PatId { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual String CardNo { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual String Sex { get; set; }

        //[DataMember(Order = 7, IsRequired = false)]
        public virtual DateTime BirthDate { get; set; }

        //[DataMember(Order = 8, IsRequired = false)]
        public virtual int Age { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual Int32 BabyMonth { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual String AgeString { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual Boolean RegLocation { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual Boolean IsPriority { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual string RegTypeId { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual String RegTypeName { get; set; }

        //[DataMember(Order = 16, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 17, IsRequired = true)]
        public virtual string RegDept { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //[DataMember(Order = 19, IsRequired = false)]
        public virtual string DiagnDept { get; set; }

        //[DataMember(Order = 20, IsRequired = false)]
        public virtual Boolean IsCancel { get; set; }

        //[DataMember(Order = 21, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //[DataMember(Order = 22, IsRequired = true)]
        public virtual string PatTypeId { get; set; }

        //[DataMember(Order = 23, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        //[DataMember(Order = 24, IsRequired = true)]
        public virtual string TallyTypeId { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual String TallyTypeName { get; set; }

        //[DataMember(Order = 26, IsRequired = true)]
        public virtual string TallyGroupId { get; set; }

        //[DataMember(Order = 27, IsRequired = true)]
        public virtual String TallyGroupName { get; set; }

        //[DataMember(Order = 28, IsRequired = true)]
        public virtual Boolean IsGf { get; set; }

        //[DataMember(Order = 29, IsRequired = true)]
        public virtual Boolean IsYb { get; set; }

        //[DataMember(Order = 30, IsRequired = true)]
        public virtual String GetTallyType { get; set; }

        //[DataMember(Order = 31, IsRequired = true)]
        public virtual String GetTallyTypeName { get; set; }

        //[DataMember(Order = 32, IsRequired = true)]
        public virtual double ArrearAmount { get; set; }

        //[DataMember(Order = 33, IsRequired = true)]
        public virtual Boolean IsInPatient { get; set; }

        //[DataMember(Order = 34, IsRequired = false)]
        public virtual Boolean IsRegistration { get; set; }

        //[DataMember(Order = 35, IsRequired = true)]
        public virtual String Diagnose { get; set; }

        //[DataMember(Order = 36, IsRequired = true)]
        public virtual String YbSeqNo { get; set; }

        //[DataMember(Order = 37, IsRequired = false)]
        public virtual Boolean IsOuChargeInput { get; set; }

        //[DataMember(Order = 38, IsRequired = false)]
        public virtual Boolean IsLocationSee { get; set; }

        //[DataMember(Order = 39, IsRequired = false)]
        public virtual Boolean IsLocationDiagSee { get; set; }

        //[DataMember(Order = 40, IsRequired = false)]
        public virtual Boolean IsDiagnosed { get; set; }

        //[DataMember(Order = 41, IsRequired = true)]
        public virtual String DiagStatus { get; set; }

        //[DataMember(Order = 42, IsRequired = true)]
        public virtual String Mobile { get; set; }

        //[DataMember(Order = 43, IsRequired = false)]
        public virtual Int32 HospitalId { get; set; }

        //[DataMember(Order = 44, IsRequired = false)]
        public virtual string TimeSpanId { get; set; }

        //[DataMember(Order = 45, IsRequired = true)]
        public virtual Int32 LineOrder { get; set; }

        //[DataMember(Order = 46, IsRequired = false)]
        public virtual double Height { get; set; }

        //[DataMember(Order = 47, IsRequired = false)]
        public virtual double Weight { get; set; }

        //[DataMember(Order = 48, IsRequired = false)]
        public virtual string WorktypeId { get; set; }

        //[DataMember(Order = 49, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        //[DataMember(Order = 50, IsRequired = false)]
        public virtual string SpecialityId { get; set; }

        //[DataMember(Order = 51, IsRequired = true)]
        public virtual Boolean IsPreReg { get; set; }
    }
}
