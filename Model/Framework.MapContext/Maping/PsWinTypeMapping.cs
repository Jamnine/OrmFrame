using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class PsWinTypeMaping : ClassMap<PsWinType>
    {
        public PsWinTypeMaping()
        {
            this.TableName("PSWINTYPE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.IsModify).ColumnName("ISMODIFY");
            this.Column(p => p.Level).ColumnName("LEVEL");
            this.Column(p => p.RedisConditionValus).ColumnName("REDISCONDITIONVALUS");
            this.Column(p => p.RowStatus).ColumnName("ROWSTATUS");
            this.Column(p => p.Width).ColumnName("WIDTH");
            this.Column(p => p.WinType).ColumnName("WINTYPE");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}