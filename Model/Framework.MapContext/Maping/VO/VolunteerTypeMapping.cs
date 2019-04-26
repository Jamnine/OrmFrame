using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping.VO
{
    /// <summary>
    /// 
    /// </summary>
    public class VolunteerTypeMapping : ClassMap<VolunteerType>
    {
        /// <summary>
        /// 
        /// </summary>
        public VolunteerTypeMapping()
        {
            this.TableName("VOLUNTEERTYPE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Isactive).ColumnName("ISACTIVE");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
