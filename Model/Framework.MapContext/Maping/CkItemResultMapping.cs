

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验结果选择 - 实体类
	/// </summary>
	public partial class CkItemResultMapping: ClassMap<CkItemResult>
	{   
		/// <summary>
		/// 检验结果选择 - 实体类
		/// </summary>
		public CkItemResultMapping()
		{
			this.TableName("CKITEMRESULT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.Result).ColumnName("RESULT");
			  
			this.Column(p =>p.IsBold).ColumnName("ISBOLD");
			  
			this.Column(p =>p.IsPass).ColumnName("ISPASS");
			  
			this.Column(p =>p.Summary).ColumnName("SUMMARY");
			  
			this.Column(p =>p.DoctorAdvice).ColumnName("DOCTORADVICE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

