using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 实体类
    /// </summary>
    public partial class BsItemAttachMapping : ClassMap<BsItemAttach>
    {
        /// <summary>
        ///  实体类
        /// </summary>
        public BsItemAttachMapping()
        {
            this.TableName("BSITEMATTACH").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.ItemId1).ColumnName("ITEMID1");

            this.Column(p => p.ItemId2).ColumnName("ITEMID2");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.Totality).ColumnName("TOTALITY");

            this.Column(p => p.LsUseArea).ColumnName("LSUSEAREA");

            this.Column(p => p.LocationId).ColumnName("LOCATIONID");

            this.Column(p => p.Amount).ColumnName("AMOUNT");

            this.Column(p => p.LsChageType).ColumnName("LSCHAGETYPE");

            this.Column(p => p.ItemId3).ColumnName("ITEMID3"); 

            this.Column(p => p.DiscountAoumt).ColumnName("DISCOUNTAOUMT"); 

            this.Column(p => p.HospitalId).ColumnName("HospitalID"); 

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
