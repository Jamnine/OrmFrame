using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///
    /// </summary>
    public partial class BsOrderTypeMapping: ClassMap<BsOrderType>
    {        
        /// <summary>
        /// 无参构造方法.
        /// </summary>
        public BsOrderTypeMapping()
        {
            this.TableName("BsOrderType").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            //this.Column(p => p.Price).ColumnName("Price");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.Code).ColumnName("Code");
            this.Column(p => p.OrderBy).ColumnName("OrderBy");
            this.Column(p => p.PYCode).ColumnName("PYCode");
            this.Column(p => p.WBCode).ColumnName("WBCode");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.ModiOperId).ColumnName("ModiOperId");
            this.Column(p => p.ModiTime).ColumnName("ModiTime");

            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


