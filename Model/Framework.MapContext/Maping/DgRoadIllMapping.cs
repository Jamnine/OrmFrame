

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgRoadIllMapping: ClassMap<DgRoadIll>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgRoadIllMapping()
		{
			this.TableName("DGROADILL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.IllId).ColumnName("ILLID");
			  
			this.Column(p =>p.RoadId).ColumnName("ROADID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IllDesc).ColumnName("ILLDESC");
			  
			this.Column(p =>p.ZyZx).ColumnName("ZYZX");
			  
			this.Column(p =>p.ZyZxIcdId).ColumnName("ZYZXICDID");
			  
			this.Column(p =>p.IcdId).ColumnName("ICDID");
			  
			this.Column(p =>p.IllDescZy).ColumnName("ILLDESCZY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

