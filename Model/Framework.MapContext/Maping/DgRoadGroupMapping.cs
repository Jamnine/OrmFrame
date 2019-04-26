

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgRoadGroupMapping: ClassMap<DgRoadGroup>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgRoadGroupMapping()
		{
			this.TableName("DGROADGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RoadId).ColumnName("ROADID");
			  
			this.Column(p =>p.DayGroupId).ColumnName("DAYGROUPID");
			  
			this.Column(p =>p.DgBsGroupId).ColumnName("DGBSGROUPID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.LsAdvType).ColumnName("LSADVTYPE");
			  
			this.Column(p =>p.LsCuretype).ColumnName("LSCURETYPE");
			  
			this.Column(p =>p.CataLogId).ColumnName("CATALOGID");
			  
			this.Column(p =>p.DayS).ColumnName("DAYS");
			  
			this.Column(p =>p.IsNeed).ColumnName("ISNEED");
			  
			this.Column(p =>p.IsReason).ColumnName("ISREASON");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.RoadGroupOldValue).ColumnName("ROADGROUPOLDVALUE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

