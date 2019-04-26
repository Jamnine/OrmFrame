using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.El
{
    /// <summary>
    /// 表名称集合表
    /// </summary>
    class ElBaseTableMapping : ClassMap<ElBaseTable>
    {
        public ElBaseTableMapping()
        {
            this.TableName("ELBASETABLE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Code).ColumnName("CODE");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalID).ColumnName("HospitalID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
