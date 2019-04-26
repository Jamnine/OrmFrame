

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class GblNavigationRoleMapping: ClassMap<GblNavigationRole>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public GblNavigationRoleMapping()
		{
			this.TableName("GBLNAVIGATIONROLE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.NavigationId).ColumnName("NAVIGATIONID");
			  
			this.Column(p =>p.RoleId).ColumnName("ROLEID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

