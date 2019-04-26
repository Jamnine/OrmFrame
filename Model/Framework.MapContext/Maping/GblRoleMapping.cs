

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 角色 - 实体类
	/// </summary>
	public partial class GblRoleMapping: ClassMap<GblRole>
	{   
		/// <summary>
		/// 角色 - 实体类
		/// </summary>
		public GblRoleMapping()
		{
			this.TableName("GBLROLE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.GroupName).ColumnName("GROUPNAME");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.HisType).ColumnName("HisType");




            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

