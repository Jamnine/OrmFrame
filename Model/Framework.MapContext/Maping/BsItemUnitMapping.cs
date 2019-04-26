using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 实体类
    /// </summary>
    public partial class BsItemUnitMapping : ClassMap<BsItemUnit>
    {
        /// <summary>
        ///  实体类
        /// </summary>
        public BsItemUnitMapping()
        {
            this.TableName("BSITEMUNIT").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.ItemId).ColumnName("ITEMID");

            this.Column(p => p.UnitId).ColumnName("UNITID");

            this.Column(p => p.IsForYk).ColumnName("ISFORYK");

            this.Column(p => p.IsForYf).ColumnName("ISFORYF");

            this.Column(p => p.IsForRecipe).ColumnName("ISFORRECIPE");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
