

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验仪器结果明细表 - 实体类
	/// </summary>
	public partial class CkMachineResultDtlMapping: ClassMap<CkMachineResultDtl>
	{   
		/// <summary>
		/// 检验仪器结果明细表 - 实体类
		/// </summary>
		public CkMachineResultDtlMapping()
		{
			this.TableName("CKMACHINERESULTDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ResultID).ColumnName("RESULTID");
			  
			this.Column(p =>p.TestID).ColumnName("TESTID");
			  
			this.Column(p =>p.Result).ColumnName("RESULT");
			  
			this.Column(p =>p.bench).ColumnName("BENCH");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

