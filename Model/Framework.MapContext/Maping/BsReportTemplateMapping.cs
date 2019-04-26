

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 打印模板设置 - 实体类
	/// </summary>
	public partial class BsReportTemplateMapping: ClassMap<BsReportTemplate>
	{   
		/// <summary>
		/// 打印模板设置 - 实体类
		/// </summary>
		public BsReportTemplateMapping()
		{
			this.TableName("BSREPORTTEMPLATE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.FileName).ColumnName("FILENAME");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.TemplateType).ColumnName("TEMPLATETYPE");
			  
			this.Column(p =>p.InsertTime).ColumnName("INSERTTIME");

            this.Id(t => t.GUID);

            this.Ignore(p => p.IsModify);
		}      
	}  
}           
 

