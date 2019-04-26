using ELinq.Mapping.Fluent;  
using ELinq;  
using Orm;  
using Orm.Model;  
  
namespace Orm.MapContext  
{   
    /// <summary>  
    /// TjPackageDtl.  Mapping  
    /// </summary>  
    public partial class TjPackageDtlMapping: ClassMap<TjPackageDtl>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TjPackageDtlMapping()  
        {  
            this.TableName("TJPACKAGEDTL").Schema("orm");  
            this.Column(p => p.TjPackageID).ColumnName("TjPackageID");  
            this.Column(p => p.TjItemCode).ColumnName("TjItemCode");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

