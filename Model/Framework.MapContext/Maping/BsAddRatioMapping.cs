using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.Model;

namespace Orm.MapContext.Maping
{
   public partial class BsAddRatioMapping : ClassMap<BsAddRatio>
    {
        public BsAddRatioMapping()
        {
            this.TableName("BSADDRATIO").Schema("orm");

            this.Column(p => p.Code).ColumnName("CODE");

            this.Column(p => p.Name).ColumnName("NAME");

            this.Column(p => p.AddRatio).ColumnName("ADDRATIO");

            this.Column(p => p.WbCode).ColumnName("WBCODE");

            this.Column(p => p.PyCode).ColumnName("PYCODE");

            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
