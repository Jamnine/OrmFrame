

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 历史门诊处方明细 - 实体类
	/// </summary>
	public partial class HistOuRecipeDtlMapping: ClassMap<HistOuRecipeDtl>
	{   
		/// <summary>
		/// 历史门诊处方明细 - 实体类
		/// </summary>
		public HistOuRecipeDtlMapping()
		{
			this.TableName("HISTOURECIPEDTL").Schema("orm");
			  
			this.Column(p =>p.InSertTime).ColumnName("INSERTTIME");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RecipeId).ColumnName("RECIPEID");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.UnitDiagId).ColumnName("UNITDIAGID");
			  
			this.Column(p =>p.IsAttach).ColumnName("ISATTACH");
			  
			this.Column(p =>p.IsOtherFee).ColumnName("ISOTHERFEE");
			  
			this.Column(p =>p.XDRpId).ColumnName("XDRPID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsCharged).ColumnName("ISCHARGED");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelTime).ColumnName("CANCELTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.PrintTime).ColumnName("PRINTTIME");
			  
			this.Column(p =>p.PrintOperId).ColumnName("PRINTOPERID");
			  
			this.Column(p =>p.IsPrepared).ColumnName("ISPREPARED");
			  
			this.Column(p =>p.PrepareTime).ColumnName("PREPARETIME");
			  
			this.Column(p =>p.PrepareOperId).ColumnName("PREPAREOPERID");
			  
			this.Column(p =>p.IsIssue).ColumnName("ISISSUE");
			  
			this.Column(p =>p.IssueTime).ColumnName("ISSUETIME");
			  
			this.Column(p =>p.IssueOperId).ColumnName("ISSUEOPERID");
			  
			this.Column(p =>p.IsToBack).ColumnName("ISTOBACK");
			  
			this.Column(p =>p.IsBack).ColumnName("ISBACK");
			  
			this.Column(p =>p.IsDoctorInput).ColumnName("ISDOCTORINPUT");
			  
			this.Column(p =>p.RecNum).ColumnName("RECNUM");
			  
			this.Column(p =>p.RecipeTime).ColumnName("RECIPETIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.AllPageNo).ColumnName("ALLPAGENO");
			  
			this.Column(p =>p.PageNo).ColumnName("PAGENO");
			  
			this.Column(p =>p.CureDtlId).ColumnName("CUREDTLID");
			  
			this.Column(p =>p.IsBP).ColumnName("ISBP");
			  
			this.Column(p =>p.BPReason).ColumnName("BPREASON");
			  
			this.Column(p =>p.YbType).ColumnName("YBTYPE");
			  
			this.Column(p =>p.InvoNo).ColumnName("INVONO");
			  
			this.Column(p =>p.IsAutoCharged).ColumnName("ISAUTOCHARGED");
			  
			this.Column(p =>p.IsForCharge).ColumnName("ISFORCHARGE");
			  
			this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.TempStr).ColumnName("TEMPSTR");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

