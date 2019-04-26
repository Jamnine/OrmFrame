

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 基础表维护对应角色 - 实体类
	/// </summary>
	public partial class BaseTableRoleMapping: ClassMap<BaseTableRole>
	{   
		/// <summary>
		/// 基础表维护对应角色 - 实体类
		/// </summary>
		public BaseTableRoleMapping()
		{
			this.TableName("BASETABLEROLE").Schema("orm");
			  
			this.Column(p =>p.BaseTableId).ColumnName("BASETABLEID");
			  
			this.Column(p =>p.RoleId).ColumnName("ROLEID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.GUID).ColumnName("GUID");

            
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

