using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInHosInfoById : BaseModel
    {
        public virtual Int32 ID { get; set; }
        
        public virtual String HospNo { get; set; }
        
        public virtual String InPatNo { get; set; }
        
        public virtual String CardNo { get; set; }
        
        public virtual String Name { get; set; }
        
        public virtual String Sex { get; set; }
        
        public virtual DateTime BirthDate { get; set; }
        
        public virtual Int32 LsMarriage { get; set; }
        
        public virtual String BloodGroup { get; set; }
        
        public virtual DateTime InTime { get; set; }
        
        public virtual Int32 NTime { get; set; }
        
        public virtual String XNo { get; set; }
        
        public virtual string CountryId { get; set; }
        
        public virtual String Residence { get; set; }
        
        public virtual String City { get; set; }
        
        public virtual String Province { get; set; }
        
        public virtual Boolean IsOversea { get; set; }
        
        public virtual DateTime PassTime { get; set; }
        
        public virtual String IdCardNo { get; set; }
        
        public virtual String Company { get; set; }
        
        public virtual String Occupation { get; set; }
        
        public virtual string WorktypeId { get; set; }
        
        public virtual string PatTypeId { get; set; }
        
        public virtual string CertificateId { get; set; }
        
        public virtual Int32 LsInType { get; set; }
        
        public virtual string LsInWay { get; set; }
        
        public virtual Int32 LsInIllness { get; set; }
        
        public virtual string DocMz { get; set; }
        
        public virtual string DoctorId { get; set; }
        
        public virtual string LocIn { get; set; }
        
        public virtual string LocationId { get; set; }
        
        public virtual string BedId { get; set; }
        
        public virtual Boolean IsYbMt { get; set; }
        
        public virtual String YbRegNo { get; set; }
        
        public virtual double ArrearAmount { get; set; }
        
        public virtual Boolean IsBaby { get; set; }
        
        public virtual Int32 AgeDay { get; set; }
        
        public virtual double Height { get; set; }
        
        public virtual double Weight { get; set; }
        
        public virtual String PhoneHome { get; set; }
        
        public virtual String AddressHome { get; set; }
        
        public virtual String PostCodeHome { get; set; }
        
        public virtual String AreaCodeHome { get; set; }
        
        public virtual String PhoneWork { get; set; }
        
        public virtual String AddressWork { get; set; }
        
        public virtual String PostCodeWork { get; set; }
        
        public virtual String AreaCodeWork { get; set; }
        
        public virtual String LinkmanName { get; set; }
        
        public virtual string RelationId { get; set; }
        
        public virtual String LinkmanPhone { get; set; }
        
        public virtual String LinkmanAddress { get; set; }
        
        public virtual String LinkmanPost { get; set; }
        
        public virtual String LinkmanArea { get; set; }
        
        public virtual Int32 LsInStatus { get; set; }
        
        public virtual String Status { get; set; }
        
        public virtual DateTime OperTime { get; set; }
        
        public virtual string OperID { get; set; }
        
        public virtual String MedicareNo { get; set; }
        
        public virtual String AccountNo { get; set; }
        
        public virtual string RegionId { get; set; }
        
        public virtual string AreaId { get; set; }
        
        public virtual String Native { get; set; }
        
        public virtual String Mobile { get; set; }
        
        public virtual String Email { get; set; }
        
        public virtual String Phone { get; set; }
        
        public virtual Int32 Circumference { get; set; }
        
        public virtual Int32 Waistline { get; set; }
        
        public virtual Int32 Sternline { get; set; }
        
        public virtual string PatID { get; set; }
        
        public virtual DateTime OutTime { get; set; }
        
        public virtual Boolean IsEndChg { get; set; }
        
        public virtual string EndChgOperID { get; set; }
        
        public virtual DateTime EndchgoperTime { get; set; }
        
        public virtual String AgeStr { get; set; }
        
        public virtual Int32 Age { get; set; }
        
        public virtual String IllDesc { get; set; }
        
        public virtual String Memo { get; set; }
        
        public virtual String YbPatType { get; set; }
        
        public virtual string NationId { get; set; }
        
        public virtual string ProvinceId { get; set; }
        
        public virtual String Sensitive { get; set; }
        
        public virtual string FamilyId { get; set; }
        
        public virtual Boolean isHouseMaster { get; set; }
        
        public virtual string RelaMasterId { get; set; }
        
        public virtual Int32 LsCensus { get; set; }
        
        public virtual string CommitteeId { get; set; }
        
        public virtual string PoliceStationId { get; set; }
        
        public virtual string LevelId { get; set; }
        
        public virtual Int32 LsSport { get; set; }
        
        public virtual Int32 LsSportTime { get; set; }
        
        public virtual Int32 LsSportType { get; set; }
        
        public virtual Int32 LsBitHabit { get; set; }
        
        public virtual Int32 SleepHour { get; set; }
        
        public virtual Int32 LsSleepTrouble { get; set; }
        
        public virtual String SmokeHistory { get; set; }
        
        public virtual String DrinkHistory { get; set; }
        
        public virtual String OtherHabit { get; set; }
        
        public virtual Boolean IsActive { get; set; }
        
        public virtual String InActiveReason { get; set; }
        
        public virtual DateTime InActiveTime { get; set; }
        
        public virtual string InActiveOperID { get; set; }
        
        public virtual Int32 IconIndex { get; set; }
        
        public virtual string FromHospitalId { get; set; }
        
        public virtual string MzRegId { get; set; }
        
        public virtual Boolean IsIllegal { get; set; }
        
        public virtual Int32 NUMBER1 { get; set; }
        
        public virtual Int32 NUMBER2 { get; set; }
        
        public virtual Int32 NUMBER3 { get; set; }
        
        public virtual Int32 NUMBER4 { get; set; }
        
        public virtual String YBBZCode { get; set; }
        
        public virtual Int32 LsYbDiff { get; set; }
    }
}
