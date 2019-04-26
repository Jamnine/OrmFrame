

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgRoadChinRicipeDtlMapping: ClassMap<DgRoadChinRicipeDtl>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgRoadChinRicipeDtlMapping()
		{
			this.TableName("DGROADCHINRICIPEDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RoadId).ColumnName("ROADID");
			  
			this.Column(p =>p.DayGroupId).ColumnName("DAYGROUPID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.LsDecoctWay).ColumnName("LSDECOCTWAY");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.RoadGroupId).ColumnName("ROADGROUPID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

