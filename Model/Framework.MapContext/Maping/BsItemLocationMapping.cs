
using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 实体类
    /// </summary>
    public partial class BsItemLocationMapping: ClassMap<BsItemLocation>
    {
        /// <summary>
        /// 实体类
        /// </summary>
        public BsItemLocationMapping()
        {
            this.TableName("BSITEMLOCATION").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.LocationId).ColumnName("LOCATIONID");

            this.Column(p => p.ItemId).ColumnName("ITEMID");

            this.Column(p => p.FeeHsMzId).ColumnName("FEEHSMZID");

            this.Column(p => p.FeeHsZyId).ColumnName("FEEHSZYID");

            this.Column(p => p.Dosage).ColumnName("DOSAGE");

            this.Column(p => p.UnitTake).ColumnName("UNITTAKE");

            this.Column(p => p.FrequencyId).ColumnName("FREQUENCYID");

            this.Column(p => p.UsageId).ColumnName("USAGEID");

            this.Column(p => p.IsLocDrug).ColumnName("ISLOCDRUG");

            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.ExecLocId).ColumnName("EXECLOCID");

            this.Column(p => p.IsLocUse).ColumnName("ISLOCUSE");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
