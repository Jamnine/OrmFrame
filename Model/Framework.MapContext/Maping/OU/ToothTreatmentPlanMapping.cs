using ELinq.Mapping.Fluent;  
using ELinq;  
using Orm;  
using Orm.Model;  
  
namespace Orm.MapContext  
{   
    /// <summary>  
    /// ToothTreatmentPlan.  Mapping  
    /// </summary>  
    public partial class ToothTreatmentPlanMapping: ClassMap<ToothTreatmentPlan>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public ToothTreatmentPlanMapping()  
        {  
            this.TableName("TOOTHTREATMENTPLAN").Schema("orm");  
            this.Column(p => p.RecordId).ColumnName("RECORDID");  
            this.Column(p => p.TreatmentPlan).ColumnName("TREATMENTPLAN");  
            this.Column(p => p.P1).ColumnName("P1");  
            this.Column(p => p.P2).ColumnName("P2");  
            this.Column(p => p.P3).ColumnName("P3");  
            this.Column(p => p.P4).ColumnName("P4");  
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

