

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检公式 - 实体类
	/// </summary>
	public partial class CkFormulaMapping: ClassMap<CkFormula>
	{   
		/// <summary>
		/// 体检公式 - 实体类
		/// </summary>
		public CkFormulaMapping()
		{
			this.TableName("CKFORMULA").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.Formula).ColumnName("FORMULA");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

