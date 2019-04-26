using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 实体类
    /// </summary>
    public partial class BsItemItemMapping : ClassMap<BsItemItem>
    {
        /// <summary>
        ///  实体类
        /// </summary>
        public BsItemItemMapping()
        {
            this.TableName("BSITEMITEM").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.ItemId1).ColumnName("ITEMID1");

            this.Column(p => p.ItemId2).ColumnName("ITEMID2");

            this.Column(p => p.IsReject).ColumnName("ISREJECT");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
