

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class RpdgroadgroupMapping: ClassMap<Rpdgroadgroup>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public RpdgroadgroupMapping()
		{
			this.TableName("RPDGROADGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CureTypeName).ColumnName("CURETYPENAME");
			  
			this.Column(p =>p.DayName1).ColumnName("DAYNAME1");
			  
			this.Column(p =>p.dayName2).ColumnName("DAYNAME2");
			  
			this.Column(p =>p.MenuName2).ColumnName("MENUNAME2");
			  
			this.Column(p =>p.DayName3).ColumnName("DAYNAME3");
			  
			this.Column(p =>p.MenuName3).ColumnName("MENUNAME3");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

