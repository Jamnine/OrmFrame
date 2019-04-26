

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class GblNavigationMenuMapping: ClassMap<GblNavigationMenu>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public GblNavigationMenuMapping()
		{
			this.TableName("GBLNAVIGATIONMENU").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Hint).ColumnName("HINT");
			  
			this.Column(p =>p.NavigationId).ColumnName("NAVIGATIONID");
			  
			this.Column(p =>p.MenuId).ColumnName("MENUID");
			  
			this.Column(p =>p.ImageName).ColumnName("IMAGENAME");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.RoleId).ColumnName("ROLEID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

