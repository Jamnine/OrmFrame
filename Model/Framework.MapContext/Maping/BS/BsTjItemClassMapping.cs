using ELinq.Mapping.Fluent;  
using ELinq;  
using Orm;  
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///  体检项目类别
    /// </summary> 
    public partial class BsTjItemClassMapping : ClassMap<BsTjItemClass>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public BsTjItemClassMapping()
        {
            this.TableName("BSTJITEMCLASS").Schema("orm");
            this.Column(p => p.Code).ColumnName("Code");
            this.Column(p => p.ZdyCode).ColumnName("ZdyCode");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.TypeId).ColumnName("TypeId");
            this.Column(p => p.PyCode).ColumnName("PyCode");
            this.Column(p => p.WbCode).ColumnName("WbCode");
            this.Column(p => p.ModiTime).ColumnName("ModiTime");
            this.Column(p => p.ModiOperId).ColumnName("ModiOperId");
            this.Column(p => p.OrderBy).ColumnName("OrderBy");
            this.Column(p => p.IsActive).ColumnName("IsActive");

            this.Column(p => p.GUID).ColumnName("GUID");
            //this.Id(T => T.GUID).DbGenerated();
            this.Ignore(p => p.IsModify);
        }

    }



}
  
    

  
  

