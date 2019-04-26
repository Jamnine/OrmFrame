

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 窗口权限设置 - 实体类
	/// </summary>
	public partial class GblModuleMapping: ClassMap<GblModule>
	{   
		/// <summary>
		/// 窗口权限设置 - 实体类
		/// </summary>
		public GblModuleMapping()
		{
			this.TableName("GBLMODULE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.FunctionID).ColumnName("FUNCTIONID");
			  
			this.Column(p =>p.MenuId).ColumnName("MENUID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.HisType).ColumnName("HisType");




            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

