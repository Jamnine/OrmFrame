

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
    /// <summary>
    /// 挂号接口 - 实体类
    /// </summary>
    public partial class BsdocregtypeListMapping : ClassMap<BsdocregtypeList>
    {
        /// <summary>
        /// 挂号接口 - 实体类
        /// </summary>
        public BsdocregtypeListMapping()
        {
            this.TableName("BSDOCREGTYPELIST").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.Locationid).ColumnName("LOCATIONID");

            this.Column(p => p.Regtypeid).ColumnName("REGTYPEID");

            this.Column(p => p.timespanid).ColumnName("TIMESPANID");

            this.Column(p => p.mdinfo).ColumnName("MDINFO");

            this.Column(p => p.tdinfo).ColumnName("TDINFO");

            this.Column(p => p.WdInfo).ColumnName("WDINFO");

            this.Column(p => p.TudInfo).ColumnName("TUDINFO");

            this.Column(p => p.fdinfo).ColumnName("FDINFO");

            this.Column(p => p.Sudinfo).ColumnName("SUDINFO");

            this.Column(p => p.Doctorid).ColumnName("DOCTORID");




            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}


