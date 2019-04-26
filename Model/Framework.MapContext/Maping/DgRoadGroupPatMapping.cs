

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgRoadGroupPatMapping: ClassMap<DgRoadGroupPat>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgRoadGroupPatMapping()
		{
			this.TableName("DGROADGROUPPAT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RoadId).ColumnName("ROADID");
			  
			this.Column(p =>p.DayGroupId).ColumnName("DAYGROUPID");
			  
			this.Column(p =>p.DgBsGroupId).ColumnName("DGBSGROUPID");
			  
			this.Column(p =>p.DgRoadGroupId).ColumnName("DGROADGROUPID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.LsAdvType).ColumnName("LSADVTYPE");
			  
			this.Column(p =>p.LsCureType).ColumnName("LSCURETYPE");
			  
			this.Column(p =>p.CataLogId).ColumnName("CATALOGID");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.IsNeed).ColumnName("ISNEED");
			  
			this.Column(p =>p.IsReason).ColumnName("ISREASON");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.RoadDtlName).ColumnName("ROADDTLNAME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

