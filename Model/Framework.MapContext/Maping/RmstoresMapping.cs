using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 实体类
    /// </summary>
   public partial class RmstoresMapping:ClassMap<Rmstores>
    {
        /// <summary>
        /// 实体类
        /// </summary>
        public RmstoresMapping()
        {
            this.TableName("RMSTORES").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.InBatchNo).ColumnName("INBATCHNO");

            this.Column(p => p.PNo).ColumnName("PNO");

            this.Column(p => p.StockPrice).ColumnName("STOCKPRICE");

            this.Column(p => p.RetailPrice).ColumnName("RETAILPRICE");

            this.Column(p => p.StockNum).ColumnName("STOCKNUM");

            this.Column(p => p.InstoreNum).ColumnName("INSTORENUM");

            this.Column(p => p.StoreDate).ColumnName("STOREDATE");

            this.Column(p => p.ProduceDate).ColumnName("PRODUCEDATE");

            this.Column(p => p.LimitDate).ColumnName("LIMITDATE");

            this.Column(p => p.IsBalance).ColumnName("ISBALANCE");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.CompId).ColumnName("COMPID");

            this.Column(p => p.RoomId).ColumnName("ROOMID");

            this.Column(p => p.UnitId).ColumnName("UNITID");

            this.Column(p => p.ItemId).ColumnName("ITEMID");

            this.Column(p => p.HuStoresId).ColumnName("HUSTORESID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
