

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验报表格式表 - 实体类
	/// </summary>
	public partial class CKReportDefineMapping: ClassMap<CKReportDefine>
	{   
		/// <summary>
		/// 检验报表格式表 - 实体类
		/// </summary>
		public CKReportDefineMapping()
		{
			this.TableName("CKREPORTDEFINE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.TestTypeID).ColumnName("TESTTYPEID");
			  
			this.Column(p =>p.ReportContent).ColumnName("REPORTCONTENT");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

