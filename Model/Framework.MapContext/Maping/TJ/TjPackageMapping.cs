using ELinq.Mapping.Fluent;  
using ELinq;  
using Orm;  
using Orm.Model;  
  
namespace Orm.MapContext  
{   
    /// <summary>  
    /// TjPackage.  Mapping  
    /// </summary>  
    public partial class TjPackageMapping: ClassMap<TjPackage>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TjPackageMapping()  
        {  
            this.TableName("TJPACKAGE").Schema("orm");  
            this.Column(p => p.Code).ColumnName("Code");  
            this.Column(p => p.ZdyCode).ColumnName("ZdyCode");  
            this.Column(p => p.Name).ColumnName("Name");  
            this.Column(p => p.PackagePrice).ColumnName("PackagePrice");  
            this.Column(p => p.Sex).ColumnName("Sex");  
            this.Column(p => p.UseRangeId).ColumnName("UseRange");  
            this.Column(p => p.Comments).ColumnName("Comments");  
            this.Column(p => p.PyCode).ColumnName("PyCode");  
            this.Column(p => p.WbCode).ColumnName("WbCode");  
            this.Column(p => p.ModiTime).ColumnName("ModiTime");  
            this.Column(p => p.ModiOperId).ColumnName("ModiOperId");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");  
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.ModiOperName).ColumnName("ModiOperName");
            this.Column(p => p.VIPAmount).ColumnName("VIPAmount");
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

