using ELinq.Mapping.Fluent;

using Orm.Framework.Model;

namespace Orm.Framework.MapContext
{
    /// <summary>
    ///
    /// </summary>
    public partial class BillNoEntityMapping : ClassMap<BillNoEntity>
    {
        /// <summary>
        /// 无参构造方法.
        /// 
        /// </summary>
        public BillNoEntityMapping()
        {
            this.TableName("BILLNOENTITY").Schema("orm");
            this.Id(p => p.BillNoCode).ColumnName("BILLNOCODE");
            this.Column(p => p.BillNoName).ColumnName("BILLNONAME");
            this.Column(p => p.BillNoType).ColumnName("BILLNOTYPE");
            this.Column(p => p.Rreq).ColumnName("RREQ");
            this.Column(p => p.Rule).ColumnName("RULE");
            this.Column(p => p.IsRnd).ColumnName("ISRND");
            this.Column(p => p.IsContinuation).ColumnName("ISCONTINUATION");
            this.Column(p => p.LastNum).ColumnName("LASTNUM");
            this.Column(p => p.LastModifyTime).ColumnName("LASTMODIFYTIME");
            this.Column(p => p.ModuleCode).ColumnName("MODULECODE");
            //this.Column(p => p.GUID).ColumnName("GUID");
        }
    }
}