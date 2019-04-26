

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病人信息表 - 实体类
	/// </summary>
	public partial class BsPatientMapping: ClassMap<BsPatient>
	{   
		/// <summary>
		/// 病人信息表 - 实体类
		/// </summary>
		public BsPatientMapping()
		{
			this.TableName("BSPATIENT").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.InPatNo).ColumnName("INPATNO");
			  
			this.Column(p =>p.CardNo).ColumnName("CARDNO");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Sex).ColumnName("SEX");
			  
			this.Column(p =>p.BirthDate).ColumnName("BIRTHDATE");
			  
			this.Column(p =>p.LsMarriage).ColumnName("LSMARRIAGE");
			  
			this.Column(p =>p.BloodGroup).ColumnName("BLOODGROUP");
			  
			this.Column(p =>p.XNo).ColumnName("XNO");
			  
			this.Column(p =>p.NationId).ColumnName("NATIONID");
			  
			this.Column(p =>p.CountryId).ColumnName("COUNTRYID");
			  
			this.Column(p =>p.ProvinceId).ColumnName("PROVINCEID");
			  
			this.Column(p =>p.RegionId).ColumnName("REGIONID");
			  
			this.Column(p =>p.AreaId).ColumnName("AREAID");
			  
			this.Column(p =>p.Native).ColumnName("NATIVE");
			  
			this.Column(p =>p.Residence).ColumnName("RESIDENCE");
			  
			this.Column(p =>p.IsOversea).ColumnName("ISOVERSEA");
			  
			this.Column(p =>p.PassTime).ColumnName("PASSTIME");
			  
			this.Column(p =>p.Company).ColumnName("COMPANY");
			  
			this.Column(p =>p.Occupation).ColumnName("OCCUPATION");
			  
			this.Column(p =>p.Mobile).ColumnName("MOBILE");
			  
			this.Column(p =>p.Email).ColumnName("EMAIL");
			  
			this.Column(p =>p.Phone).ColumnName("PHONE");
			  
			this.Column(p =>p.WorktypeId).ColumnName("WORKTYPEID");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.CertificateId).ColumnName("CERTIFICATEID");
			  
			this.Column(p =>p.Sensitive).ColumnName("SENSITIVE");
			  
			this.Column(p =>p.IdCardNo).ColumnName("IDCARDNO");
			  
			this.Column(p =>p.IsBaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.MotherPatId).ColumnName("MOTHERPATID");
			  
			this.Column(p =>p.MedicareNo).ColumnName("MEDICARENO");
			  
			this.Column(p =>p.AccountNo).ColumnName("ACCOUNTNO");
			  
			this.Column(p =>p.PhoneWork).ColumnName("PHONEWORK");
			  
			this.Column(p =>p.AddressWork).ColumnName("ADDRESSWORK");
			  
			this.Column(p =>p.PostCodeWork).ColumnName("POSTCODEWORK");
			  
			this.Column(p =>p.AreaCodeWork).ColumnName("AREACODEWORK");
			  
			this.Column(p =>p.PhoneHome).ColumnName("PHONEHOME");
			  
			this.Column(p =>p.AddressHome).ColumnName("ADDRESSHOME");
			  
			this.Column(p =>p.PostCodeHome).ColumnName("POSTCODEHOME");
			  
			this.Column(p =>p.AreaCodeHome).ColumnName("AREACODEHOME");
			  
			this.Column(p =>p.LinkmanName).ColumnName("LINKMANNAME");
			  
			this.Column(p =>p.RelationId).ColumnName("RELATIONID");
			  
			this.Column(p =>p.LinkmanPost).ColumnName("LINKMANPOST");
			  
			this.Column(p =>p.LinkmanArea).ColumnName("LINKMANAREA");
			  
			this.Column(p =>p.LinkmanAddress).ColumnName("LINKMANADDRESS");
			  
			this.Column(p =>p.LinkmanPhone).ColumnName("LINKMANPHONE");
			  
			this.Column(p =>p.FamilyId).ColumnName("FAMILYID");
			  
			this.Column(p =>p.isHouseMaster).ColumnName("ISHOUSEMASTER");
			  
			this.Column(p =>p.RelaMasterId).ColumnName("RELAMASTERID");
			  
			this.Column(p =>p.LsCensus).ColumnName("LSCENSUS");
			  
			this.Column(p =>p.CommitteeId).ColumnName("COMMITTEEID");
			  
			this.Column(p =>p.PoliceStationId).ColumnName("POLICESTATIONID");
			  
			this.Column(p =>p.LevelId).ColumnName("LEVELID");
			  
			this.Column(p =>p.Height).ColumnName("HEIGHT");
			  
			this.Column(p =>p.Weight).ColumnName("WEIGHT");
			  
			this.Column(p =>p.Circumference).ColumnName("CIRCUMFERENCE");
			  
			this.Column(p =>p.Waistline).ColumnName("WAISTLINE");
			  
			this.Column(p =>p.Sternline).ColumnName("STERNLINE");
			  
			this.Column(p =>p.LsSport).ColumnName("LSSPORT");
			  
			this.Column(p =>p.LsSportTime).ColumnName("LSSPORTTIME");
			  
			this.Column(p =>p.LsSportType).ColumnName("LSSPORTTYPE");
			  
			this.Column(p =>p.LsBitHabit).ColumnName("LSBITHABIT");
			  
			this.Column(p =>p.SleepHour).ColumnName("SLEEPHOUR");
			  
			this.Column(p =>p.LsSleepTrouble).ColumnName("LSSLEEPTROUBLE");
			  
			this.Column(p =>p.SmokeHistory).ColumnName("SMOKEHISTORY");
			  
			this.Column(p =>p.DrinkHistory).ColumnName("DRINKHISTORY");
			  
			this.Column(p =>p.OtherHabit).ColumnName("OTHERHABIT");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.InActiveReason).ColumnName("INACTIVEREASON");
			  
			this.Column(p =>p.InActiveTime).ColumnName("INACTIVETIME");
			  
			this.Column(p =>p.InActiveOperID).ColumnName("INACTIVEOPERID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.PhotoFolder).ColumnName("PHOTOFOLDER");
			  
			this.Column(p =>p.RoadId).ColumnName("ROADID");
			  
			this.Column(p =>p.PersonHistory).ColumnName("PERSONHISTORY");
			  
			this.Column(p =>p.Password).ColumnName("PASSWORD");
			  
			this.Column(p =>p.HealthCardNo).ColumnName("HEALTHCARDNO");
			  
			this.Column(p =>p.AgeStr).ColumnName("AGESTR");
			  
			this.Column(p =>p.Age).ColumnName("AGE");
			  
			this.Column(p =>p.InterfaceNo).ColumnName("INTERFACENO");
			  
			this.Column(p =>p.FromHospitalID).ColumnName("FROMHospitalID");
			  
			this.Column(p =>p.AgeDay).ColumnName("AGEDAY");
			  
			this.Column(p =>p.AgeMonth).ColumnName("AGEMONTH");
			  
			this.Column(p =>p.RhnegAtive).ColumnName("RHNEGATIVE");
			  
			this.Column(p =>p.Children).ColumnName("CHILDREN");
			  
			this.Column(p =>p.Siblings).ColumnName("SIBLINGS");
			  
			this.Column(p =>p.Mother).ColumnName("MOTHER");

            this.Column(p => p.KitchenExhaust).ColumnName("KITCHENEXHAUST");

            this.Column(p => p.Toilet).ColumnName("TOILET");

            this.Column(p => p.IsFixedPoint).ColumnName("ISFIXEDPOINT");
			  
			this.Column(p =>p.Father).ColumnName("FATHER");
			  
			this.Column(p =>p.Disability).ColumnName("DISABILITY");
			  
			this.Column(p =>p.Livestock).ColumnName("LIVESTOCK");
			  
			this.Column(p =>p.DrinkingWater).ColumnName("DRINKINGWATER");
			  
			this.Column(p =>p.FuelType).ColumnName("FUELTYPE");
			  
			this.Column(p =>p.Genetic).ColumnName("GENETIC");
			  
			this.Column(p =>p.ExPosure).ColumnName("EXPOSURE");
			  
			this.Column(p =>p.IsResidents).ColumnName("ISRESIDENTS");
			  
			this.Column(p =>p.IsSpecial).ColumnName("ISSPECIAL");
			  
			this.Column(p =>p.ArchivePath).ColumnName("ARCHIVEPATH");
			  
			this.Column(p =>p.AdviserID).ColumnName("ADVISERID");
			  
			this.Column(p =>p.IntroducerPatID).ColumnName("INTRODUCERPATID");
			  
			this.Column(p =>p.FamilyHistory).ColumnName("FAMILYHISTORY");
			  
			this.Column(p =>p.IsHideIllness).ColumnName("ISHIDEILLNESS");
			  
			this.Column(p =>p.EndMenstruationTime).ColumnName("ENDMENSTRUATIONTIME");
			  
			this.Column(p =>p.GivingIntegral).ColumnName("GIVINGINTEGRAL");
			  
			this.Column(p =>p.VipLevelId).ColumnName("VIPLEVELID");
			  
			this.Column(p =>p.VipScore).ColumnName("VIPSCORE");
			  
			this.Column(p =>p.HideOperTime).ColumnName("HIDEOPERTIME");
			  
			this.Column(p =>p.HideOperID).ColumnName("HIDEOPERID");
			  
			this.Column(p =>p.IsHide).ColumnName("ISHIDE");
			  
			this.Column(p =>p.BPValue).ColumnName("BPVALUE");
			  
			this.Column(p =>p.Comments).ColumnName("COMMENTS");
			  
			this.Column(p =>p.PatientSource).ColumnName("PATIENTSOURCE");
			  
			this.Column(p =>p.WeChatNo).ColumnName("WECHATNO");
			  
			this.Column(p =>p.Hobby).ColumnName("HOBBY");
			  
			this.Column(p =>p.FamilyBackGround).ColumnName("FAMILYBACKGROUND");
			  
			this.Column(p =>p.WebUserCode).ColumnName("WEBUSERCODE");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.IsWebBinding).ColumnName("ISWEBBINDING");
			  
			this.Column(p =>p.HealthCondition).ColumnName("HEALTHCONDITION");
			  
			this.Column(p =>p.School).ColumnName("SCHOOL");
			  
			this.Column(p =>p.IndroducerUserid).ColumnName("INDRODUCERUSERID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.DoctorId).ColumnName("DOCTORID");

            this.Column(p => p.HisType).ColumnName("HisType");

            this.Column(p => p.IsVip).ColumnName("IsVip");

            this.Column(p => p.IDCardType).ColumnName("IDCARDTYPE");

            this.Column(p => p.RefErral).ColumnName("RefErral");

            this.Column(p => p.HospitalizationTimes).ColumnName("HOSPITALIZATIONTIMES");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

