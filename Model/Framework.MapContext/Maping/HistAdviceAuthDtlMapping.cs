

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 历史医嘱查对表 - 实体类
	/// </summary>
	public partial class HistAdviceAuthDtlMapping: ClassMap<HistAdviceAuthDtl>
	{   
		/// <summary>
		/// 历史医嘱查对表 - 实体类
		/// </summary>
		public HistAdviceAuthDtlMapping()
		{
			this.TableName("HISTADVICEAUTHDTL").Schema("orm");
			  
			this.Column(p =>p.InSertTime).ColumnName("INSERTTIME");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LsMarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.AdviceTime).ColumnName("ADVICETIME");
			  
			this.Column(p =>p.AdviceId).ColumnName("ADVICEID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.FormId).ColumnName("FORMID");
			  
			this.Column(p =>p.PriceIn).ColumnName("PRICEIN");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.ToTalityAll).ColumnName("TOTALITYALL");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.UnitInId).ColumnName("UNITINID");
			  
			this.Column(p =>p.IsAttach).ColumnName("ISATTACH");
			  
			this.Column(p =>p.IsSelf).ColumnName("ISSELF");
			  
			this.Column(p =>p.LsSpecialUsage).ColumnName("LSSPECIALUSAGE");
			  
			this.Column(p =>p.LsExecLoc).ColumnName("LSEXECLOC");
			  
			this.Column(p =>p.SkinTime).ColumnName("SKINTIME");
			  
			this.Column(p =>p.IsSkin).ColumnName("ISSKIN");
			  
			this.Column(p =>p.SkinTest).ColumnName("SKINTEST");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsPrinted).ColumnName("ISPRINTED");
			  
			this.Column(p =>p.IsChk).ColumnName("ISCHK");
			  
			this.Column(p =>p.ChkOperTime).ColumnName("CHKOPERTIME");
			  
			this.Column(p =>p.ChkOperID).ColumnName("CHKOPERID");
			  
			this.Column(p =>p.IsEnd).ColumnName("ISEND");
			  
			this.Column(p =>p.EndOperTime).ColumnName("ENDOPERTIME");
			  
			this.Column(p =>p.EndOperID).ColumnName("ENDOPERID");
			  
			this.Column(p =>p.EndDoctorID).ColumnName("ENDDOCTORID");
			  
			this.Column(p =>p.IsAuth).ColumnName("ISAUTH");
			  
			this.Column(p =>p.AuthOperTime).ColumnName("AUTHOPERTIME");
			  
			this.Column(p =>p.AuthOperId).ColumnName("AUTHOPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsOtherFee).ColumnName("ISOTHERFEE");
			  
			this.Column(p =>p.IsBeforeops).ColumnName("ISBEFOREOPS");
			  
			this.Column(p =>p.LsRpType).ColumnName("LSRPTYPE");
			  
			this.Column(p =>p.IsInject).ColumnName("ISINJECT");
			  
			this.Column(p =>p.FirstDay).ColumnName("FIRSTDAY");
			  
			this.Column(p =>p.LastDay).ColumnName("LASTDAY");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.OriAdviceId).ColumnName("ORIADVICEID");
			  
			this.Column(p =>p.InfeeCheck).ColumnName("INFEECHECK");
			  
			this.Column(p =>p.Adcolor).ColumnName("ADCOLOR");
			  
			this.Column(p =>p.IsManual).ColumnName("ISMANUAL");
			  
			this.Column(p =>p.IsArrearage).ColumnName("ISARREARAGE");
			  
			this.Column(p =>p.IsTodayIn).ColumnName("ISTODAYIN");
			  
			this.Column(p =>p.DrugReqId1).ColumnName("DRUGREQID1");
			  
			this.Column(p =>p.DrugReqId2).ColumnName("DRUGREQID2");
			  
			this.Column(p =>p.DetailId1).ColumnName("DETAILID1");
			  
			this.Column(p =>p.DetailId2).ColumnName("DETAILID2");
			  
			this.Column(p =>p.AdviceName).ColumnName("ADVICENAME");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Spec).ColumnName("SPEC");
			  
			this.Column(p =>p.ExecuteId).ColumnName("EXECUTEID");
			  
			this.Column(p =>p.ExecuteId2).ColumnName("EXECUTEID2");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.ExecDoctorId).ColumnName("EXECDOCTORID");
			  
			this.Column(p =>p.IsYbxj).ColumnName("ISYBXJ");
			  
			this.Column(p =>p.IsAutoMatic).ColumnName("ISAUTOMATIC");
			  
			this.Column(p =>p.YBType).ColumnName("YBTYPE");
			  
			this.Column(p =>p.IsPriority).ColumnName("ISPRIORITY");
			  
			this.Column(p =>p.TempStr).ColumnName("TEMPSTR");
			  
			this.Column(p =>p.Colours).ColumnName("COLOURS");
			  
			this.Column(p =>p.UsageItemId).ColumnName("USAGEITEMID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

