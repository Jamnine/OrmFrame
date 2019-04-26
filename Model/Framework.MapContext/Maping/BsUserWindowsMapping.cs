

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用户常用菜单 - 实体类
	/// </summary>
	public partial class BsUserWindowsMapping: ClassMap<BsUserWindows>
	{   
		/// <summary>
		/// 用户常用菜单 - 实体类
		/// </summary>
		public BsUserWindowsMapping()
		{
			this.TableName("BSUSERWINDOWS").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.MenuId).ColumnName("MENUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Caption).ColumnName("CAPTION");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

