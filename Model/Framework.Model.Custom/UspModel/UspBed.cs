using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class UspBed : BaseModel
    {
        public virtual string BedId { get; set; }
        
        public virtual String Name { get; set; }
        
        public virtual String RoomNo { get; set; }
        
        public virtual string LocationId { get; set; }
        
        public virtual String LocationName { get; set; }
        
        public virtual string ItemId { get; set; }
        
        public virtual string OperID { get; set; }
        
        public virtual double PriceIn { get; set; }
        
        public virtual DateTime InTime { get; set; }
        
        public virtual string SpecialityId { get; set; }
        
        public virtual String InTimeStr { get; set; }
        
        public virtual Boolean IsAdd { get; set; }
        
        public virtual String Memo { get; set; }
        
        public virtual DateTime OperTime { get; set; }
        
        public virtual Int32 OrderBy { get; set; }
        
        public virtual int IconIndex { get; set; }
        
        public virtual Boolean IsActive { get; set; }
        
        public virtual int LsClass { get; set; }
        
        public virtual String BedGroup { get; set; }
        
        public virtual String ItemIdCode1 { get; set; }
        
        public virtual String ItemIdCode2 { get; set; }
        
        public virtual String AddItemCode { get; set; }
        
        public virtual string MatBedId { get; set; }
        
        public virtual string LeaveHospId { get; set; }
        
        public virtual Boolean IsTaked { get; set; }
        
        public virtual int LsBALL { get; set; }
        
        public virtual String Weight { get; set; }
        
        public virtual String LsBALLName { get; set; }
        
        public virtual string HospId { get; set; }
        
        public virtual String HospNo { get; set; }
        
        public virtual string PatID { get; set; }
        
        public virtual String InPatNo { get; set; }
        
        public virtual String PatientName { get; set; }
        
        public virtual Int32 NTime { get; set; }
        
        public virtual int Age { get; set; }
        
        public virtual String Sex { get; set; }
        
        public virtual String SexName { get; set; }
        
        public virtual String AgeString { get; set; }
        
        public virtual Boolean IsBaby { get; set; }
        
        public virtual String CardNo { get; set; }
        
        public virtual Int32 CaptionIcon { get; set; }
        
        public virtual DateTime OutTime { get; set; }
        
        public virtual string MainBedId { get; set; }
        
        public virtual string DoctorId { get; set; }
        
        public virtual String DoctorName { get; set; }
        
        public virtual string LocationIdPat { get; set; }
        
        public virtual String IllDesc { get; set; }
        
        public virtual Boolean IsNewIn { get; set; }
        
        public virtual Boolean IsUrgen { get; set; }
        
        public virtual int LsInIllness { get; set; }
        
        public virtual String LsInStatus { get; set; }
        
        public virtual Boolean IsAddBed { get; set; }
    }
}
