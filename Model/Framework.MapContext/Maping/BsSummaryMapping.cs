
using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
    /// <summary>
    /// 评估-小结 - 实体类
    /// </summary>
    public partial class BsSummaryMapping : ClassMap<BsSummary>
    {
        /// <summary>
        /// 评估-小结 - 实体类
        /// </summary>
        public BsSummaryMapping()
        {
            this.TableName("BSSUMMARY").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID"); 

            this.Column(p => p.Summary).ColumnName("SUMMARY");

            this.Column(p => p.XmlId).ColumnName("XMLID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}