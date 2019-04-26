

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院病人信息表 - 实体类
	/// </summary>
	public partial class InHosInfoMapping: ClassMap<InHosInfo>
	{
        /// <summary>
        /// 住院病人信息表 - 实体类
        /// </summary>
        public InHosInfoMapping()
        {
            this.TableName("INHOSINFO").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.HospNo).ColumnName("HOSPNO");

            this.Column(p => p.PatID).ColumnName("PATID");

            this.Column(p => p.InPatNo).ColumnName("INPATNO");

            this.Column(p => p.CardNo).ColumnName("CARDNO");

            this.Column(p => p.Name).ColumnName("NAME");

            this.Column(p => p.Sex).ColumnName("SEX");

            this.Column(p => p.NTime).ColumnName("NTIME");

            this.Column(p => p.InTime).ColumnName("INTIME");

            this.Column(p => p.OutTime).ColumnName("OUTTIME");

            this.Column(p => p.LsMarriage).ColumnName("LSMARRIAGE");

            this.Column(p => p.BloodGroup).ColumnName("BLOODGROUP");

            this.Column(p => p.XNo).ColumnName("XNO");

            this.Column(p => p.CountryId).ColumnName("COUNTRYID");

            this.Column(p => p.Residence).ColumnName("RESIDENCE");

            this.Column(p => p.City).ColumnName("CITY");

            this.Column(p => p.Province).ColumnName("PROVINCE");

            this.Column(p => p.IsOversea).ColumnName("ISOVERSEA");

            this.Column(p => p.PassTime).ColumnName("PASSTIME");

            this.Column(p => p.IdCardNo).ColumnName("IDCARDNO");

            this.Column(p => p.Company).ColumnName("COMPANY");

            this.Column(p => p.Occupation).ColumnName("OCCUPATION");

            this.Column(p => p.WorktypeId).ColumnName("WORKTYPEID");

            this.Column(p => p.PatTypeId).ColumnName("PATTYPEID");

            this.Column(p => p.CertificateId).ColumnName("CERTIFICATEID");

            this.Column(p => p.LsInType).ColumnName("LSINTYPE");

            this.Column(p => p.LsInWay).ColumnName("LSINWAY");

            this.Column(p => p.LsInIllness).ColumnName("LSINILLNESS");

            this.Column(p => p.DocMz).ColumnName("DOCMZ");

            this.Column(p => p.DoctorId).ColumnName("DOCTORID");

            this.Column(p => p.LocIn).ColumnName("LOCIN");

            this.Column(p => p.LocationId).ColumnName("LOCATIONID");

            this.Column(p => p.BedId).ColumnName("BEDID");

            this.Column(p => p.OutBedName).ColumnName("OUTBEDNAME");

            this.Column(p => p.IsYbMt).ColumnName("ISYBMT");

            this.Column(p => p.YbRegNo).ColumnName("YBREGNO");

            this.Column(p => p.ArrearAmount).ColumnName("ARREARAMOUNT");

            this.Column(p => p.IsBaby).ColumnName("ISBABY");

            this.Column(p => p.AgeDay).ColumnName("AGEDAY");

            this.Column(p => p.Height).ColumnName("HEIGHT");

            this.Column(p => p.Weight).ColumnName("WEIGHT");

            this.Column(p => p.PhoneHome).ColumnName("PHONEHOME");

            this.Column(p => p.AddressHome).ColumnName("ADDRESSHOME");

            this.Column(p => p.PostCodeHome).ColumnName("POSTCODEHOME");

            this.Column(p => p.AreaCodeHome).ColumnName("AREACODEHOME");

            this.Column(p => p.PhoneWork).ColumnName("PHONEWORK");

            this.Column(p => p.AddressWork).ColumnName("ADDRESSWORK");

            this.Column(p => p.PostCodeWork).ColumnName("POSTCODEWORK");

            this.Column(p => p.AreaCodeWork).ColumnName("AREACODEWORK");

            this.Column(p => p.LinkmanName).ColumnName("LINKMANNAME");

            this.Column(p => p.RelationId).ColumnName("RELATIONID");

            this.Column(p => p.LinkmanPhone).ColumnName("LINKMANPHONE");

            this.Column(p => p.LinkmanAddress).ColumnName("LINKMANADDRESS");

            this.Column(p => p.LinkmanPost).ColumnName("LINKMANPOST");

            this.Column(p => p.LinkmanArea).ColumnName("LINKMANAREA");

            this.Column(p => p.LsInStatus).ColumnName("LSINSTATUS");

            this.Column(p => p.LeaveTime).ColumnName("LEAVETIME");

            this.Column(p => p.Status).ColumnName("STATUS");

            this.Column(p => p.OperTime).ColumnName("OPERTIME");

            this.Column(p => p.OperID).ColumnName("OPERID");

            this.Column(p => p.IsEndChg).ColumnName("ISENDCHG");

            this.Column(p => p.EndChgOperID).ColumnName("ENDCHGOPERID");

            this.Column(p => p.EndchgoperTime).ColumnName("ENDCHGOPERTIME");

            this.Column(p => p.Memo).ColumnName("MEMO");

            this.Column(p => p.MotherHospId).ColumnName("MOTHERHOSPID");

            this.Column(p => p.FromHospitalId).ColumnName("FROMHOSPITALID");

            this.Column(p => p.MzRegId).ColumnName("MZREGID");

            this.Column(p => p.LocOut).ColumnName("LOCOUT");

            this.Column(p => p.TipsNurse).ColumnName("TIPSNURSE");

            this.Column(p => p.TipsBalance).ColumnName("TIPSBALANCE");

            this.Column(p => p.TipsOther).ColumnName("TIPSOTHER");

            this.Column(p => p.OtherRoles).ColumnName("OTHERROLES");

            this.Column(p => p.IsIllegal).ColumnName("ISILLEGAL");

            this.Column(p => p.UnLines).ColumnName("UNLINES");

            this.Column(p => p.Scale).ColumnName("SCALE");

            this.Column(p => p.FromHospital).ColumnName("FROMHOSPITAL");

            this.Column(p => p.Number1).ColumnName("NUMBER1");

            this.Column(p => p.Number3).ColumnName("NUMBER3");

            this.Column(p => p.Number4).ColumnName("NUMBER4");

            this.Column(p => p.YBBZCode).ColumnName("YBBZCODE");

            this.Column(p => p.AmountAuth).ColumnName("AMOUNTAUTH");

            this.Column(p => p.Author).ColumnName("AUTHOR");

            this.Column(p => p.AgeStr).ColumnName("AGESTR");

            this.Column(p => p.Age).ColumnName("AGE");

            this.Column(p => p.IllDesc).ColumnName("ILLDESC");

            this.Column(p => p.YbPatType).ColumnName("YBPATTYPE");

            this.Column(p => p.NewBabyId).ColumnName("NEWBABYID");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalID).ColumnName("HOSPITALID");




            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }  
}           
 

