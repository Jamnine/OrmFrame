

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgRoadDtlMapping: ClassMap<DgRoadDtl>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgRoadDtlMapping()
		{
			this.TableName("DGROADDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RoadId).ColumnName("ROADID");
			  
			this.Column(p =>p.DayGroupId).ColumnName("DAYGROUPID");
			  
			this.Column(p =>p.CureId).ColumnName("CUREID");
			  
			this.Column(p =>p.DrugId).ColumnName("DRUGID");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.NurseId).ColumnName("NURSEID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Spec).ColumnName("SPEC");
			  
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
			  
			this.Column(p =>p.IsNeed).ColumnName("ISNEED");
			  
			this.Column(p =>p.IsReason).ColumnName("ISREASON");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.PageNum).ColumnName("PAGENUM");
			  
			this.Column(p =>p.LisSource).ColumnName("LISSOURCE");
			  
			this.Column(p =>p.LisBody).ColumnName("LISBODY");
			  
			this.Column(p =>p.RoadGroupId).ColumnName("ROADGROUPID");
			  
			this.Column(p =>p.CountDays).ColumnName("COUNTDAYS");
			  
			this.Column(p =>p.MutexNum).ColumnName("MUTEXNUM");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

