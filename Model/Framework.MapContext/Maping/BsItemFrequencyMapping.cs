using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 实体类
    /// </summary>
    public partial class BsItemFrequencyMapping : ClassMap<BsItemFrequency>
    {
        /// <summary>
        /// 实体类
        /// </summary>
        public BsItemFrequencyMapping()
        {
            this.TableName("BSITEMFREQUENCY").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.ItemId).ColumnName("ITEMID");

            this.Column(p => p.FrequencyId).ColumnName("FREQUENCYID");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
