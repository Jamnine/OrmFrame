using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///检查附加收费分组表
    /// </summary>
    public partial class BsJCGroupMapping: ClassMap<BsJCGroup>
    {
        /// <summary>
        /// 检查附加收费分组表
        /// </summary>
        public BsJCGroupMapping()
        {
            this.TableName("BSJCGROUP").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Code).ColumnName("CODE");
            this.Column(p =>p.Name).ColumnName("NAME");
            this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p =>p.ModiTime).ColumnName("MODITIME");
            this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
            this.Column(p =>p.YBCode).ColumnName("YBCODE");
            this.Column(p =>p.UpCode).ColumnName("UPCODE");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


