using ELinq.Mapping.Fluent;  
using ELinq;  
using Orm;  
using Orm.Model;  
  
namespace Orm.MapContext  
{   
    /// <summary>  
    /// AdEmr.  Mapping  
    /// </summary>  
    public partial class AdEmrVisitsMapping : ClassMap<AdEmrVisits>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public AdEmrVisitsMapping()  
        {
            this.TableName("AdEmrVisits").Schema("orm");
            this.Column(p => p.InquiryFunction).ColumnName("InquiryFunction");
            this.Column(p => p.HosId).ColumnName("HosId");
            this.Column(p => p.DietitianVisits).ColumnName("DietitianVisits");
            this.Column(p => p.SportsVisits).ColumnName("SportsVisits");
            this.Column(p => p.PsychologicalVisits).ColumnName("PsychologicalVisits");
            this.Column(p => p.TCMvisits).ColumnName("TCMvisits");
            this.Column(p => p.OtherVisits).ColumnName("OtherVisits");
             
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

