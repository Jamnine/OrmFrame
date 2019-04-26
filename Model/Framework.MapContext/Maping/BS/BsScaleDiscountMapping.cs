using ELinq.Mapping.Fluent;  
using Orm.Model;  
  
namespace Orm.MapContext  
{
    /// <summary>  
    ///活动折扣表
    /// </summary>  
    public partial class BsScaleDiscountMapping: ClassMap<BsScaleDiscount>  
    {
        /// <summary>  
        ///活动折扣表
        /// </summary>  
        public BsScaleDiscountMapping()  
        {  
            this.TableName("BSSCALEDISCOUNT").Schema("orm");  
            this.Column(p => p.Code).ColumnName("CODE");  
            this.Column(p => p.Name).ColumnName("NAME");  
            this.Column(p => p.ScaleType).ColumnName("SCALETYPE");  
            this.Column(p => p.PyCode).ColumnName("PYCODE");  
            this.Column(p => p.WbCode).ColumnName("WBCODE");  
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");  
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.GUID).ColumnName("GUID");
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

