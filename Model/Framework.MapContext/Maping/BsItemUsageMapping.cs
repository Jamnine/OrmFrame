using ELinq.Mapping.Fluent;
using Orm.Model;


namespace Orm.MapContext.Maping
{
    /// <summary>
    ///
    /// </summary>
    public partial class BsItemUsageMapping : ClassMap<BsItemUsage>
    {
        /// <summary>
        ///
        /// </summary>
        public BsItemUsageMapping()
        {
            this.TableName("BSITEMUSAGE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.ItemId).ColumnName("ITEMID");

            this.Column(p => p.UsageId).ColumnName("USAGEID");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
