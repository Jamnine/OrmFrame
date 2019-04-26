

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 需要设置报表打印的rpt - 实体类
	/// </summary>
	public partial class GblFieldDescMapping: ClassMap<GblFieldDesc>
	{   
		/// <summary>
		/// 需要设置报表打印的rpt - 实体类
		/// </summary>
		public GblFieldDescMapping()
		{
			this.TableName("GBLFIELDDESC").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TableName).ColumnName("TABLENAME");
			  
			this.Column(p =>p.FieldName).ColumnName("FIELDNAME");
			  
			this.Column(p =>p.Description).ColumnName("DESCRIPTION");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.GroupName).ColumnName("GROUPNAME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

