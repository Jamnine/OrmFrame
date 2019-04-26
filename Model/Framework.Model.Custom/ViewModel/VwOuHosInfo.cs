using System;

namespace Orm.Model
{
    [Serializable]
    public class VwOuHosInfo:BaseModel 
    {
        public VwOuHosInfo() { }

        //public int ID {get; set;}                                
        public string MzRegNo {get; set;}
        public string PatientName { get; set; }
        public int PatId { get; set; }
        public string CardNo { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age {get; set;}
        public string BabyMonth { get; set; }
        public DateTime RegTime { get; set; }
        public string RegLocation { get; set; }
        public int IsPriority { get; set; }
        public int RegTypeId { get; set; }
        public string AgeString { get; set; }
        public string RegTypeName { get; set; }
        public int DoctorId { get; set; }
        public int RegDept { get; set; }
        public string LocationName { get; set; }
        public int DiagnDept { get; set; }
        public int IsCancel { get; set; }
        public string DoctorName { get; set; }
        public int PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public int TallyTypeId { get; set; }

        public string TallyTypeName { get; set; }
        public int TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public bool IsGf { get; set; }
        public bool IsYb { get; set; }
        public string GetTallyType { get; set; }
        public string GetTallyTypeName { get; set; }
        public double ArrearAmount { get; set; }
        public int IsInPatient { get; set; }
        public bool IsInputByRegMan { get; set; }
        public bool IsOuChargeInput { get; set; }

        public bool IsLocationSee { get; set; }
        public bool IsDiagnosed { get; set; }

        public string DiagStatus { get; set; }

        public string Mobile { get; set; }
        public int HospitalID { get; set; }
        public int TimeSpanId { get; set; }

        public int LineOrder { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public int WorkTypeId { get; set; }
        public string MedicareNo { get; set; }
        public string Residence { get; set; }
        public string IllDesc { get; set; }

        public string OperCode { get; set; } 
        
        
        
    }
}
