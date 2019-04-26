

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云：方案表 - 实体类
	/// </summary>
	public partial class CkPlanMapping: ClassMap<CkPlan>
	{   
		/// <summary>
		/// 行心云：方案表 - 实体类
		/// </summary>
		public CkPlanMapping()
		{
			this.TableName("CKPLAN").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

