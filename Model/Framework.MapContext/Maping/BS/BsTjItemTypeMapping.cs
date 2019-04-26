using ELinq.Mapping.Fluent;  
using Orm.Model;  
  
namespace Orm.MapContext  
{
    /// <summary>  
    ///体检项目类别
    /// </summary>  
    public partial class BsTjItemTypeMapping: ClassMap<BsTjItemType>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public BsTjItemTypeMapping()
        {  
            this.Column(p => p.GUID).ColumnName("GUID");
            this.TableName("BSTJITEMTYPE").Schema("orm");  
            this.Column(p => p.Name).ColumnName("Name");  
            this.Column(p => p.PyCode).ColumnName("PyCode");  
            this.Column(p => p.WbCode).ColumnName("WbCode");  
            this.Column(p => p.ModiTime).ColumnName("ModiTime");  
            this.Column(p => p.ModiOperId).ColumnName("ModiOperId");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");  
            this.Column(p => p.IsActive).ColumnName("IsActive");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

