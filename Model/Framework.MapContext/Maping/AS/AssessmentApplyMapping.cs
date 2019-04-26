using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AssessmentApplyMapping: ClassMap<AssessmentApply>  
    {
        public AssessmentApplyMapping()
        {
            this.TableName("AssessmentApply").Schema("orm");
            this.Column(p => p.SerialNumber).ColumnName("SERIALNUMBER");
            this.Column(p => p.UserId).ColumnName("USERID");
            this.Column(p => p.OlderId).ColumnName("OLDERID");
            this.Column(p => p.CreateTime).ColumnName("CREATETIME");
            this.Column(p => p.ApplyVisitDate).ColumnName("APPLYVISITDATE");
            this.Column(p => p.ApplyVisitTimeSpan).ColumnName("APPLYVISITTIMESPAN");
            this.Column(p => p.AuditId).ColumnName("AUDITID");
            this.Column(p => p.AuditTime).ColumnName("AUDITTIME");
            this.Column(p => p.AuditFailure).ColumnName("AUDITFAILURE");
            this.Column(p => p.Status).ColumnName("STATUS");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
