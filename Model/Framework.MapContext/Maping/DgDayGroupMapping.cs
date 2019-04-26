

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgDayGroupMapping: ClassMap<DgDayGroup>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgDayGroupMapping()
		{
			this.TableName("DGDAYGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.DgRoadId).ColumnName("DGROADID");
			  
			this.Column(p =>p.PageNum).ColumnName("PAGENUM");
			  
			this.Column(p =>p.ColumnNum).ColumnName("COLUMNNUM");
			  
			this.Column(p =>p.EedDays).ColumnName("EEDDAYS");
			  
			this.Column(p =>p.LsTimeType).ColumnName("LSTIMETYPE");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

