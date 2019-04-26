

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检诊断建议 - 实体类
	/// </summary>
	public partial class CkSuggestionMapping: ClassMap<CkSuggestion>
	{   
		/// <summary>
		/// 体检诊断建议 - 实体类
		/// </summary>
		public CkSuggestionMapping()
		{
			this.TableName("CKSUGGESTION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.DiseaseCode).ColumnName("DISEASECODE");
			  
			this.Column(p =>p.TestTypeId).ColumnName("TESTTYPEID");
			  
			this.Column(p =>p.Suggestion).ColumnName("SUGGESTION");
			  
			this.Column(p =>p.Flag).ColumnName("FLAG");
			  
			this.Column(p =>p.IsCommonDisease).ColumnName("ISCOMMONDISEASE");
			  
			this.Column(p =>p.IsImportantDisease).ColumnName("ISIMPORTANTDISEASE");
			  
			this.Column(p =>p.IsNotify).ColumnName("ISNOTIFY");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.PresentHistory).ColumnName("PRESENTHISTORY");
			  
			this.Column(p =>p.Complaint).ColumnName("COMPLAINT");
			  
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

