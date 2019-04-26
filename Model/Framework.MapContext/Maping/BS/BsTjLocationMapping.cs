using ELinq.Mapping.Fluent;  
using Orm.Model;  
  
namespace Orm.MapContext  
{   
    /// <summary>  
    /// BsTjLocation.  Mapping  
    /// </summary>  
    public partial class BsTjLocationMapping: ClassMap<BsTjLocation>  
    {  
         /// <summary>  
         ///  体检科室
         /// </summary> 
        public BsTjLocationMapping()  
        {

            this.Column(p => p.GUID).ColumnName("GUID");
            this.TableName("BSTJLOCATION").Schema("orm");  
            this.Column(p => p.Name).ColumnName("Name");  
            this.Column(p => p.PyCode).ColumnName("PyCode");  
            this.Column(p => p.WbCode).ColumnName("WbCode");  
            this.Column(p => p.ModiTime).ColumnName("ModiTime");  
            this.Column(p => p.ModiOperId).ColumnName("ModiOperId");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");  
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.LocationType).ColumnName("LocationType");
            this.Column(p => p.IsAutoSummary).ColumnName("IsAutoSummary");
            this.Column(p => p.GuideTips).ColumnName("GuideTips");  
            
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

