

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 系统基本表维护配置 - 实体类
	/// </summary>
	public partial class GblBaseTableItemMapping: ClassMap<GblBaseTableItem>
	{   
		/// <summary>
		/// 系统基本表维护配置 - 实体类
		/// </summary>
		public GblBaseTableItemMapping()
		{
			this.TableName("GBLBASETABLEITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.BaseTable).ColumnName("BASETABLE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.BLLClassName).ColumnName("BLLCLASSNAME");
			  
			this.Column(p =>p.ModelClassName).ColumnName("MODELCLASSNAME");
			  
			this.Column(p =>p.ConfigType).ColumnName("CONFIGTYPE");
			  
			this.Column(p =>p.IsTable).ColumnName("ISTABLE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.RoleId).ColumnName("ROLEID");
			  
			this.Column(p =>p.OrderField).ColumnName("ORDERFIELD");
			  
			this.Column(p =>p.IsToWmr).ColumnName("ISTOWMR");
			  
			this.Column(p =>p.ServieName).ColumnName("SERVIENAME");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");




            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

