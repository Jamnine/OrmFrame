

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 系统菜单对应参数 - 实体类
	/// </summary>
	public partial class GblMenuSetMapping: ClassMap<GblMenuSet>
	{   
		/// <summary>
		/// 系统菜单对应参数 - 实体类
		/// </summary>
		public GblMenuSetMapping()
		{
			this.TableName("GBLMENUSET").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MenuId).ColumnName("MENUID");
			  
			this.Column(p =>p.SettingId).ColumnName("SETTINGID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

