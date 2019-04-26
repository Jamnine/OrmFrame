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
    public class VolunteerFilesMapping : ClassMap<VolunteerFiles>
    {
        /// <summary>
        /// 
        /// </summary>
        public VolunteerFilesMapping()
        {
            this.TableName("VolunteerFiles").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.Route).ColumnName("Route");
            this.Column(p => p.TeerTimeid).ColumnName("TeerTimeid");
            this.Column(p => p.FileSize).ColumnName("FileSize");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
