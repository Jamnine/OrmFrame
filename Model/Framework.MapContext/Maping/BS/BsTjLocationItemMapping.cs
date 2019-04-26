using ELinq.Mapping.Fluent;  
using Orm.Model;  
  
namespace Orm.MapContext  
{
    /// <summary>  
    ///  体检科室对应项目
    /// </summary> 
    public partial class BsTjLocationItemMapping: ClassMap<BsTjLocationItem>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public BsTjLocationItemMapping()  
        {

            this.Column(p => p.GUID).ColumnName("GUID");
            this.TableName("BSTJLOCATIONITEM").Schema("orm");  
            this.Column(p => p.TjLocationID).ColumnName("TjLocationID");  
            this.Column(p => p.TjItemCode).ColumnName("TjItemCode");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

