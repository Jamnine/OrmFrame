

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊病人挂号信息表 - 实体类
	/// </summary>
	public partial class OuHosInfoMapping: ClassMap<OuHosInfo>
	{   
		/// <summary>
		/// 门诊病人挂号信息表 - 实体类
		/// </summary>
		public OuHosInfoMapping()
		{
			this.TableName("OUHOSINFO").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.MzRegNo).ColumnName("MZREGNO");
			  
			this.Column(p =>p.RegTime).ColumnName("REGTIME");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.CardNo).ColumnName("CARDNO");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Sex).ColumnName("SEX");
			  
			this.Column(p =>p.IsBaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.AgeDay).ColumnName("AGEDAY");
			  
			this.Column(p =>p.Height).ColumnName("HEIGHT");
			  
			this.Column(p =>p.Weight).ColumnName("WEIGHT");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.MedicareNo).ColumnName("MEDICARENO");
			  
			this.Column(p =>p.RegTypeId).ColumnName("REGTYPEID");
			  
			this.Column(p =>p.IsPriority).ColumnName("ISPRIORITY");
			  
			this.Column(p =>p.IsElder).ColumnName("ISELDER");
			  
			this.Column(p =>p.LineOrder).ColumnName("LINEORDER");
			  
			this.Column(p =>p.RegFee).ColumnName("REGFEE");
			  
			this.Column(p =>p.ZyFee).ColumnName("ZYFEE");
			  
			this.Column(p =>p.DiagnoFee).ColumnName("DIAGNOFEE");
			  
			this.Column(p =>p.OtherFee1).ColumnName("OTHERFEE1");
			  
			this.Column(p =>p.OtherFee2).ColumnName("OTHERFEE2");
			  
			this.Column(p =>p.PaySel).ColumnName("PAYSEL");
			  
			this.Column(p =>p.TallyDiag).ColumnName("TALLYDIAG");
			  
			this.Column(p =>p.FactGet).ColumnName("FACTGET");
			  
			this.Column(p =>p.RegDept).ColumnName("REGDEPT");
			  
			this.Column(p =>p.DiagnDept).ColumnName("DIAGNDEPT");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.RoomNo).ColumnName("ROOMNO");
			  
			this.Column(p =>p.IsFreeDiag).ColumnName("ISFREEDIAG");
			  
			this.Column(p =>p.IsFreeReg).ColumnName("ISFREEREG");
			  
			this.Column(p =>p.IsInPatient).ColumnName("ISINPATIENT");
			  
			this.Column(p =>p.IsPreReg).ColumnName("ISPREREG");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelTime).ColumnName("CANCELTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.CancelMemo).ColumnName("CANCELMEMO");
			  
			this.Column(p =>p.TimeSpanId).ColumnName("TIMESPANID");
			  
			this.Column(p =>p.RegDate).ColumnName("REGDATE");
			  
			this.Column(p =>p.Age).ColumnName("AGE");
			  
			this.Column(p =>p.AgeString).ColumnName("AGESTRING");
			  
			this.Column(p =>p.ContactPhone).ColumnName("CONTACTPHONE");
			  
			this.Column(p =>p.LinkmanName).ColumnName("LINKMANNAME");
			  
			this.Column(p =>p.TallyTime).ColumnName("TALLYTIME");
			  
			this.Column(p =>p.CancelTallyTime).ColumnName("CANCELTALLYTIME");
			  
			this.Column(p =>p.TimeSpanSubId).ColumnName("TIMESPANSUBID");
			  
			this.Column(p =>p.DiagRoomId).ColumnName("DIAGROOMID");
			  
			this.Column(p =>p.CallDoctorId).ColumnName("CALLDOCTORID");
			  
			this.Column(p =>p.CallOrder).ColumnName("CALLORDER");
			  
			this.Column(p =>p.IsFirstCheck).ColumnName("ISFIRSTCHECK");
			  
			this.Column(p =>p.IsGoodRecipe).ColumnName("ISGOODRECIPE");
			  
			this.Column(p =>p.GoodRecipe).ColumnName("GOODRECIPE");
			  
			this.Column(p =>p.IsRegist).ColumnName("ISREGIST");
			  
			this.Column(p =>p.Diagnose).ColumnName("DIAGNOSE");
			  
			this.Column(p =>p.PreRegRegWay).ColumnName("PREREGREGWAY");
			  
			this.Column(p =>p.IsRegister).ColumnName("ISREGISTER");
			  
			this.Column(p =>p.IsRegistration).ColumnName("ISREGISTRATION");
			  
			this.Column(p =>p.YbSeqNo).ColumnName("YBSEQNO");
			  
			this.Column(p =>p.IsTransfer).ColumnName("ISTRANSFER");
			  
			this.Column(p =>p.InterfaceNo).ColumnName("INTERFACENO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.IsVoice).ColumnName("ISVOICE");
			  
			this.Column(p =>p.AdviserID).ColumnName("ADVISERID");
			  
			this.Column(p =>p.ZjOperTime).ColumnName("ZJOPERTIME");
			  
			this.Column(p =>p.IsTj).ColumnName("ISTJ");
			  
			this.Column(p =>p.ZjDoctorID).ColumnName("ZJDOCTORID");
			  
			this.Column(p =>p.HideOperTime).ColumnName("HIDEOPERTIME");
			  
			this.Column(p =>p.HideOperID).ColumnName("HIDEOPERID");
			  
			this.Column(p =>p.IsHide).ColumnName("ISHIDE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.VisitContent).ColumnName("VISITCONTENT");
			  
			this.Column(p =>p.LastOuHosInfoId).ColumnName("LASTOUHOSINFOID");
			  
			this.Column(p =>p.NurseID).ColumnName("NURSEID");
			  
			this.Column(p =>p.IsCharge).ColumnName("ISCHARGE");
			  
			this.Column(p =>p.IsNotify).ColumnName("ISNOTIFY");
			  
			this.Column(p =>p.Introducer).ColumnName("INTRODUCER");
			  
			this.Column(p =>p.BHOSName).ColumnName("BHOSNAME");
			  
			this.Column(p =>p.DiagPosition).ColumnName("DIAGPOSITION");
			  
			this.Column(p =>p.AdviserStatus).ColumnName("ADVISERSTATUS");
			  
			this.Column(p =>p.ConsultID).ColumnName("CONSULTID");
			  
			this.Column(p =>p.CnBookingPurpose).ColumnName("CNBOOKINGPURPOSE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.ReferralOuHosInfoId).ColumnName("REFERRALOUHOSINFOID");
			  
			this.Column(p =>p.PreventingSuggestion).ColumnName("PREVENTINGSUGGESTION");
			  
			this.Column(p =>p.TotalDiagnosis).ColumnName("TOTALDIAGNOSIS");
			  
			this.Column(p =>p.ZjSummary).ColumnName("ZJSUMMARY");
			  
			this.Column(p =>p.IdCardNo).ColumnName("IDCARDNO");
			  
			this.Column(p =>p.LsDiagType).ColumnName("LSDIAGTYPE");
			  
			this.Column(p =>p.FirstDoctorID).ColumnName("FIRSTDOCTORID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.BookingTel).ColumnName("BOOKINGTEL");

            this.Column(p => p.IsTjOver).ColumnName("IsTjOver");

            this.Column(p => p.HisType).ColumnName("HisType");

            this.Column(p => p.TimeBegin).ColumnName("TimeBegin");

            this.Column(p => p.TimeEnd).ColumnName("TimeEnd");

            this.Column(p => p.DoctorName).ColumnName("DoctorName");

            this.Column(p => p.IsVip).ColumnName("IsVip");

            this.Column(p => p.IsReturnVisit).ColumnName("IsReturnVisit");

            this.Column(p => p.AccompanyingDoctor).ColumnName("AccompanyingDoctor");

            this.Column(p => p.RefErral).ColumnName("RefErral");
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

