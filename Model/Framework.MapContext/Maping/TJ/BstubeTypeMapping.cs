using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 容器 
    /// </summary>  
    public partial class BstubeTypeMapping : ClassMap<BstubeType>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public BstubeTypeMapping()
        {
            this.TableName("BstubeType").Schema("orm");
            this.Column(p => p.Code).ColumnName("Code");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.OrderBy).ColumnName("OrderBy");
            this.Column(p => p.PYCode).ColumnName("PYCode");
            this.Column(p => p.WBCode).ColumnName("WBCode");
            this.Column(p => p.IsActive).ColumnName("IsActive");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }  
}
