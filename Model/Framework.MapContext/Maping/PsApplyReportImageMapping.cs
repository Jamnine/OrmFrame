

using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class PsApplyReportImageMapping : ClassMap<PsApplyReportImage>
    {
        public PsApplyReportImageMapping()
        {
            this.TableName("PSAPPLYREPORTIMAGE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.IsChecked).ColumnName("ISCHECKED");
            this.Column(p => p.IsModify).ColumnName("ISMODIFY");
            //this.Column(p => p.RedisConditionValus).ColumnName("REDISCONDITIONVALUS");
            //this.Column(p => p.RowStatus).ColumnName("ROWSTATUS");
            this.Column(p => p.RptImage).ColumnName("RPTIMAGE");
            this.Column(p => p.Applyid).ColumnName("APPLYID");
            this.Column(p => p.FileName).ColumnName("FILENAME");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
