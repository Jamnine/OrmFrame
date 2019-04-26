using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
   public class UspInhosinfoCache:BaseModel
    {
        public String HospNo { get; set; }

        public String InPatNo { get; set; }

        public String CardNo { get; set; }

        public String Name { get; set; }

        public String Sex { get; set; }

        public String NTime { get; set; }

        public DateTime InTime { get; set; }

        public DateTime OutTime { get; set; }

        public String LsMarriage { get; set; }

        public String BloodGroup { get; set; }

        public String XNo { get; set; }

        public String Residence { get; set; }

        public String City { get; set; }

        public String Province { get; set; }

        public Boolean IsOversea { get; set; }

        public DateTime PassTime { get; set; }

        public String IdCardNo { get; set; }

        public String Company { get; set; }

        public String Occupation { get; set; }

        public String LsInType { get; set; }

        public String LsInWay { get; set; }

        public String LsInIllness { get; set; }

        public String DocMz { get; set; }

        public String LocIn { get; set; }

        public String OutBedName { get; set; }

        public Boolean IsYbmt { get; set; }

        public String YbRegNo { get; set; }

        public double ArrearAmount { get; set; }

        public Boolean IsBaby { get; set; }

        public Int32 AgeDay { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public String PhoneHome { get; set; }

        public String AddressHome { get; set; }

        public String PostCodeHome { get; set; }

        public String AreaCodeHome { get; set; }

        public String Phonework { get; set; }

        public String Addresswork { get; set; }

        public String Postcodework { get; set; }

        public String Areacodework { get; set; }

        public String LinkmanName { get; set; }

        public String Linkmanphone { get; set; }

        public String Linkmanaddress { get; set; }

        public String Linkmanpost { get; set; }

        public String Linkmanarea { get; set; }

        public String LsInStatusName { get; set; }

        public Int32 LsInStatus { get; set; }

        public DateTime Leavetime { get; set; }

        public DateTime OperTime { get; set; }

        public Boolean Isendchg { get; set; }

        public DateTime Endchgopertime { get; set; }

        public String Memoe { get; set; }

        public String Locout { get; set; }

        public String Tipsnurse { get; set; }

        public String Tipsbalance { get; set; }

        public String Tipsother { get; set; }

        public String Otherroles { get; set; }

        public Boolean Isillegal { get; set; }

        public double Unlines { get; set; }

        public double Scale { get; set; }

        public String fromhospital { get; set; }

        public Int32 Number1 { get; set; }

        public Int32 Number2 { get; set; }

        public Int32 Number3 { get; set; }

        public Int32 Number4 { get; set; }

        public String Ybbzcode { get; set; }

        public Boolean Amountauth { get; set; }

        public String Author { get; set; }

        public String Agestr { get; set; }

        public Int32 Age { get; set; }

        public String illdesc { get; set; }

        public String Ybpattype { get; set; }

        public Boolean Isauthed { get; set; }

        public String Relationid { get; set; }

        public String Certificateid { get; set; }

        public String Worktypeid { get; set; }

        public String PatID { get; set; }

        public String Mzregid { get; set; }

        public String MotherHospId { get; set; }

        public String PatTypeId { get; set; }

        public String Fromhospitalid { get; set; }

        public String Bedid { get; set; }

        public String Countryid { get; set; }

        public String DoctorId { get; set; }

        public String LocationId { get; set; }

        public String Operid { get; set; }

        public String Endchgoperid { get; set; }

        public String Newbabyid { get; set; }

        public String Inserttime { get; set; }

        public String PatTypeName { get; set; }

        public String TallyTypeName { get; set; }

        public String TallyGroupName { get; set; }

        public String GetTallyType { get; set; }

        public Boolean IsGf { get; set; }

        public Boolean IsYb { get; set; }

        public Boolean GetTallyTypeName { get; set; }

        public String LocationName { get; set; }

        public String Bsbed { get; set; }

        public String BedName { get; set; }

        public String ProvinceName { get; set; }

        public String LsinwayLoc { get; set; }

        public String LinkmanareaDoc { get; set; }

        public String RelationName { get; set; }

        public String HospitailName { get; set; }

        public String CertificateName { get; set; }

        public String FromhospitalName { get; set; }

        public String OperName { get; set; }

        public String CountryName { get; set; }

        //增加
        public String MedicareNo { get; set; }

        public DateTime BirthDate { get; set; }

        public String DoctorName { get; set; }

        public String AgeString { get; set; }
        public String TallyGroupId { get; set; }
        public String Sensitive { get; set; }
        public String DoctorCode { get; set; }
        public String TallyTypeId { get; set; }
        public Boolean Subsidies { get; set; }
        public string WorkTypeName { get; set; }
        public bool u_IsNotLeaveHospital { get; set; }
        public bool u_IsNotOutTimeMinValue { get; set; }
        public bool u_IsWaitOutHospital { get; set; }
        public bool u_IsNotWaitForLeaveHospital { get; set; }
        public bool u_IsLeaveHospital { get; set; }
        public bool u_IsNotWaitOutHospital { get; set; }
        public bool u_IsOutHospital { get; set; }
        public bool u_IsNotWaitInHospital { get; set; }
        public bool u_IsWaitForLeaveHospital { get; set; }
        public bool u_IsLeave { get; set; }
        public bool u_IsOutTimeMinValue { get; set; }
        public bool u_IsOutTimeGreaterMinValue { get; set; }
        public bool u_IsGreaterEqualLeaveHospital { get; set; }
        public bool u_IsNotInTimeMinValue { get; set; }
        public bool u_IsInTime { get; set; }
        public bool u_IsWaitForHospital { get; set; }
        public bool u_IsInHospital { get; set; }
        public bool u_IsTallyGroupId { get; set; }
        public bool u_IsNotInHospital { get; set; }
        public bool u_IsBirthDateMinValue { get; set; }
    }
}
