

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用户权限 - 实体类
	/// </summary>
	public partial class BsUserModuleMapping: ClassMap<BsUserModule>
	{   
		/// <summary>
		/// 用户权限 - 实体类
		/// </summary>
		public BsUserModuleMapping()
		{
			this.TableName("BSUSERMODULE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.ModuleId).ColumnName("MODULEID");

            this.Column(p => p.ModiTime).ColumnName("MODITIME");

            this.Column(p => p.ModiOperId).ColumnName("MODIOPERID");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

