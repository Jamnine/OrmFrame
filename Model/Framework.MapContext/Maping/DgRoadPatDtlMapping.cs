

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgRoadPatDtlMapping: ClassMap<DgRoadPatDtl>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgRoadPatDtlMapping()
		{
			this.TableName("DGROADPATDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RoadPatId).ColumnName("ROADPATID");
			  
			this.Column(p =>p.RoadDtlId).ColumnName("ROADDTLID");
			  
			this.Column(p =>p.DayGroupId).ColumnName("DAYGROUPID");
			  
			this.Column(p =>p.CureId).ColumnName("CUREID");
			  
			this.Column(p =>p.DrugId).ColumnName("DRUGID");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.NurseId).ColumnName("NURSEID");
			  
			this.Column(p =>p.LsAdvType).ColumnName("LSADVTYPE");
			  
			this.Column(p =>p.LsCureType).ColumnName("LSCURETYPE");
			  
			this.Column(p =>p.CataLogId).ColumnName("CATALOGID");
			  
			this.Column(p =>p.DosAge).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.FeeTotality).ColumnName("FEETOTALITY");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.IsDelete).ColumnName("ISDELETE");
			  
			this.Column(p =>p.IsChange).ColumnName("ISCHANGE");
			  
			this.Column(p =>p.Reason).ColumnName("REASON");
			  
			this.Column(p =>p.AdviceId).ColumnName("ADVICEID");
			  
			this.Column(p =>p.LsmarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.RoadTime).ColumnName("ROADTIME");
			  
			this.Column(p =>p.AddAdviceMemo).ColumnName("ADDADVICEMEMO");
			  
			this.Column(p =>p.UpAdviceMemo).ColumnName("UPADVICEMEMO");
			  
			this.Column(p =>p.UnAdviceMemo).ColumnName("UNADVICEMEMO");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.LisSource).ColumnName("LISSOURCE");
			  
			this.Column(p =>p.LisBody).ColumnName("LISBODY");
			  
			this.Column(p =>p.AdviceTime).ColumnName("ADVICETIME");
			  
			this.Column(p =>p.IsAddAdvice).ColumnName("ISADDADVICE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

