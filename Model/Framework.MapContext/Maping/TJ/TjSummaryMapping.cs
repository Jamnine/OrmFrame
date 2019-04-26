using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 体检小结 
    /// </summary>  
    public partial class TjSummaryMapping: ClassMap<TjSummary>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TjSummaryMapping()  
        {  
            this.TableName("TJSUMMARY").Schema("orm");  
            this.Column(p => p.MzRegId).ColumnName("MzRegId");  
            this.Column(p => p.DoctorId).ColumnName("DoctorId");  
            this.Column(p => p.TjLocationID).ColumnName("TjLocationID");  
            this.Column(p => p.Summary).ColumnName("Summary");  
            this.Column(p => p.Suggestion).ColumnName("Suggestion");  
            this.Column(p => p.IsOver).ColumnName("IsOver");  
            this.Column(p => p.OperId).ColumnName("OperId");  
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.PatID).ColumnName("PatID");
            this.Column(p => p.CAnalysis).ColumnName("CANALYSIS");
            this.Column(p => p.Conclusion).ColumnName("CONCLUSION");
            this.Column(p => p.Programme).ColumnName("PROGRAMME");
            this.Column(p => p.TestIllustration).ColumnName("TESTILLUSTRATION");
            this.Column(p => p.ResultDetermine).ColumnName("RESULTDETERMINE");
            this.Column(p => p.RAnalysis).ColumnName("RANALYSIS");
            this.Column(p => p.CommonProblem).ColumnName("COMMONPROBLEM");
            this.Column(p => p.SaveTime).ColumnName("SaveTime");
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

