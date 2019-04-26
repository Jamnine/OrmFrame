using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.El
{
    /// <summary>
    /// 
    /// </summary>
    public class ElBaseTableDtlMapping : ClassMap<ElBaseTableDtl>
    {
        /// <summary>
        /// 
        /// </summary>
        public ElBaseTableDtlMapping()
        {
            this.TableName("ELBASETABLEDTL").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Code).ColumnName("CODE");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.Memo).ColumnName("MEMO");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.BaseTableId).ColumnName("BASETABLEID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
