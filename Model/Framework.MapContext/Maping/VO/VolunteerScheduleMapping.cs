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
    public class VolunteerScheduleMapping : ClassMap<VolunteerSchedule>
    {
        /// <summary>
        /// 
        /// </summary>
        public VolunteerScheduleMapping()
        {
            this.TableName("VolunteerSchedule").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Userid).ColumnName("Userid");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.TypeID).ColumnName("TypeID");
            this.Column(p => p.LocationID).ColumnName("LocationID");
            this.Column(p => p.Isbookdinner).ColumnName("Isbookdinner");
            this.Column(p => p.VolunTime).ColumnName("VolunTime");
            this.Column(p => p.Memo).ColumnName("Memo");
            this.Column(p => p.BeginTime).ColumnName("BeginTime");
            this.Column(p => p.EndTime).ColumnName("EndTime");
            this.Column(p => p.OperID).ColumnName("OperID");
            this.Column(p => p.State).ColumnName("State");
            this.Column(p => p.AuditoperID).ColumnName("AuditoperID");
            this.Column(p => p.AuditTime).ColumnName("AuditTime");
            this.Column(p => p.Content).ColumnName("Content");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
