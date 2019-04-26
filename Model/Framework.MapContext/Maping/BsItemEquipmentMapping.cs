using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
   public partial class BsItemEquipmentMapping:ClassMap<BsItemEquipment>
    {
        public BsItemEquipmentMapping()
        {
            this.TableName("BSITEMEQUIPMENT").Schema("orm");

            this.Column(p => p.LsEqType).ColumnName("LSEQTYPE");

            this.Column(p => p.EqType).ColumnName("EQTYPE");

            this.Column(p => p.SeriesNo).ColumnName("SERIESNO");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.Brand).ColumnName("BRAND");

            this.Column(p => p.LsEqClass).ColumnName("LSEQCLASS");

            this.Column(p => p.UnderLine).ColumnName("UNDERLINE");

            this.Column(p => p.CostPercent).ColumnName("COSTPERCENT");

            this.Column(p => p.AlarmLine).ColumnName("ALARMLINE");

            this.Column(p => p.IsCalProfit).ColumnName("ISCALPROFIT");

            this.Column(p => p.IsMutiTotality).ColumnName("ISMUTITOTALITY");

            this.Column(p => p.UseArea).ColumnName("USEAREA");

            this.Column(p => p.UseMemo).ColumnName("USEMEMO");

            this.Column(p => p.Memo).ColumnName("MEMO");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.EqTypeId).ColumnName("EQTYPEID");

            this.Column(p => p.UnitId).ColumnName("UNITID");

            this.Column(p => p.ItemId).ColumnName("ITEMID");      

            this.Column(p => p.CountryId).ColumnName("COUNTRYID");

            this.Column(p => p.ManuId).ColumnName("MANUID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
