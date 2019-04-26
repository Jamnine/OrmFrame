

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用户对应电子病历 - 实体类
	/// </summary>
	public partial class BsUserEmrTemplateMapping: ClassMap<BsUserEmrTemplate>
	{   
		/// <summary>
		/// 用户对应电子病历 - 实体类
		/// </summary>
		public BsUserEmrTemplateMapping()
		{
			this.TableName("BSUSEREMRTEMPLATE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.CatalogId).ColumnName("CATALOGID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.TemplateFile).ColumnName("TEMPLATEFILE");
			  
			this.Column(p =>p.IsDefault).ColumnName("ISDEFAULT");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.LsOpenType).ColumnName("LSOPENTYPE");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.TemplateName).ColumnName("TEMPLATENAME");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

