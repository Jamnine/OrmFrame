

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云：复诊目的 - 实体类
	/// </summary>
	public partial class BsObjectiveMapping: ClassMap<BsObjective>
	{   
		/// <summary>
		/// 行心云：复诊目的 - 实体类
		/// </summary>
		public BsObjectiveMapping()
		{
			this.TableName("BSOBJECTIVE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.InfoContent).ColumnName("INFOCONTENT");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

