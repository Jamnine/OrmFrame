using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RmUnderLineMapping : ClassMap<RmUnderLine>
    {
        /// <summary>
        /// 
        /// </summary>
        public RmUnderLineMapping()
        {
            this.TableName("RMUNDERLINE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.UnderLine).ColumnName("UNDERLINE");

            this.Column(p => p.UperLine).ColumnName("UPERLINE");

            this.Column(p => p.Normal).ColumnName("NORMAL");

            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.IsStop).ColumnName("ISSTOP");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.RoomId).ColumnName("ROOMID");

            this.Column(p => p.ItemId).ColumnName("ITEMID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
