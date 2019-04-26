

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检小结 - 实体类
	/// </summary>
	public partial class CkSummaryMapping: ClassMap<CkSummary>
	{   
		/// <summary>
		/// 体检小结 - 实体类
		/// </summary>
		public CkSummaryMapping()
		{
			this.TableName("CKSUMMARY").Schema("orm");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.TjLocationID).ColumnName("TJLOCATIONID");
			  
			this.Column(p =>p.Summary).ColumnName("SUMMARY");
			  
			this.Column(p =>p.Suggestion).ColumnName("SUGGESTION");
			  
			this.Column(p =>p.IsOver).ColumnName("ISOVER");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.PatID).ColumnName("PATID");
			  
			this.Column(p =>p.CAnalysis).ColumnName("CANALYSIS");
			  
			this.Column(p =>p.Conclusion).ColumnName("CONCLUSION");
			  
			this.Column(p =>p.Programme).ColumnName("PROGRAMME");
			  
			this.Column(p =>p.TestIllustration).ColumnName("TESTILLUSTRATION");
			  
			this.Column(p =>p.ResultDetermine).ColumnName("RESULTDETERMINE");
			  
			this.Column(p =>p.RAnalysis).ColumnName("RANALYSIS");
			  
			this.Column(p =>p.CommonProblem).ColumnName("COMMONPROBLEM");
			  
			this.Column(p =>p.SaveTime).ColumnName("SAVETIME");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

