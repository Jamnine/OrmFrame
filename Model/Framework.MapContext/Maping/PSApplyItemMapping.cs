
using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class PSApplyItemMapping : ClassMap<PSApplyItem>
    {
        public PSApplyItemMapping()
        {
            this.TableName("PSAPPLYITEM").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.IsCancel).ColumnName("ISCANCEL");
            this.Column(p => p.IsModify).ColumnName("ISMODIFY");
            this.Column(p => p.ItemId).ColumnName("ITEMID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.PsApplyId).ColumnName("PSAPPLYID");
            this.Column(p => p.RedisConditionValus).ColumnName("REDISCONDITIONVALUS");
            this.Column(p => p.RowStatus).ColumnName("ROWSTATUS");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
    
}
