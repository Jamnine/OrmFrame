using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 体检疾病情况 
    /// </summary>
    public partial class TjDiseaseMapping: ClassMap<TjDisease>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TjDiseaseMapping()  
        {  
            this.TableName("TJDISEASE").Schema("orm");  
            this.Column(p => p.MzRegId).ColumnName("MzRegId");  
            this.Column(p => p.SID).ColumnName("SID");  
            this.Column(p => p.TjLocationID).ColumnName("TjLocationID");
            this.Column(p => p.PatID).ColumnName("PatID");
            this.Column(p => p.Flag).ColumnName("Flag");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

