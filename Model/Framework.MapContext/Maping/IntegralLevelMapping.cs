

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:积分等级表 - 实体类
	/// </summary>
	public partial class IntegralLevelMapping: ClassMap<IntegralLevel>
	{   
		/// <summary>
		/// 行心云:积分等级表 - 实体类
		/// </summary>
		public IntegralLevelMapping()
		{
			this.TableName("INTEGRALLEVEL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.ProporTion).ColumnName("PROPORTION");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

