

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用户角色 - 实体类
	/// </summary>
	public partial class BsUserRoleMapping: ClassMap<BsUserRole>
	{   
		/// <summary>
		/// 用户角色 - 实体类
		/// </summary>
		public BsUserRoleMapping()
		{
			this.TableName("BSUSERROLE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.RoleId).ColumnName("ROLEID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.LimitDate).ColumnName("LIMITDATE");
			  
			this.Column(p =>p.ModioperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.Moditime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

