using ELinq.Mapping.Fluent;  
using Orm.Model;  
  
namespace Orm.MapContext
{   /// <summary>  
    ///  体检组合项目
    /// </summary> 
    public partial class BsTjGroupMapping: ClassMap<BsTjGroup>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public BsTjGroupMapping()  
        {  
            this.TableName("BSTJGROUP").Schema("orm");  
            this.Column(p => p.GroupItemCode).ColumnName("GroupItemCode");  
            this.Column(p => p.TjItemCode).ColumnName("TjItemCode");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");
            this.Column(p => p.ItemName).ColumnName("ItemName");

            this.Column(p => p.GUID).ColumnName("GUID");
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

