

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 角色权限 - 实体类
	/// </summary>
	public partial class GblRoleModuleMapping: ClassMap<GblRoleModule>
	{   
		/// <summary>
		/// 角色权限 - 实体类
		/// </summary>
		public GblRoleModuleMapping()
		{
			this.TableName("GBLROLEMODULE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RoleId).ColumnName("ROLEID");
			  
			this.Column(p =>p.ModuleId).ColumnName("MODULEID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

