

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:EMR文件列表 - 实体类
	/// </summary>
	public partial class EmrTemplateMapping: ClassMap<EmrTemplate>
	{   
		/// <summary>
		/// 行心云:EMR文件列表 - 实体类
		/// </summary>
		public EmrTemplateMapping()
		{
			this.TableName("EMRTEMPLATE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.FileName).ColumnName("FILENAME");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.ParentId).ColumnName("PARENTID");
			this.Column(p =>p.HisType).ColumnName("HisType");
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

