using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AssessmentHuLiMapping : ClassMap<AssessmentHuLi>  
    {
        public AssessmentHuLiMapping()
        {
            this.TableName("Assessment").Schema("orm");
            this.Column(p => p.AssessmentApplyId).ColumnName("ASSESSMENTAPPLYID");
            this.Column(p => p.FormHolderTime).ColumnName("FORMHOLDERTIME");
            this.Column(p => p.FormHolderId).ColumnName("FORMHOLDERID");
            this.Column(p => p.AsScaleId).ColumnName("ASSCALEID");
            this.Column(p => p.AssessmentValidUntil).ColumnName("ASSESSMENTVALIDUNTIL");
            this.Column(p => p.ToTakeCareTime).ColumnName("TOTAKECARETIME");
            this.Column(p => p.AssessmentFraction).ColumnName("ASSESSMENTFRACTION");
            this.Column(p => p.AssessmentGrade).ColumnName("ASSESSMENTGRADE");
            this.Column(p => p.AssessmentResult).ColumnName("ASSESSMENTRESULT");
            this.Column(p => p.AuditId).ColumnName("AUDITID");
            this.Column(p => p.AuditTime).ColumnName("AUDITTIME");
            this.Column(p => p.ReviewReason).ColumnName("REVIEWREASON");
            this.Column(p => p.ReviewTime).ColumnName("REVIEWTIME");
            this.Column(p => p.CompletionTime).ColumnName("COMPLETIONTIME");
            this.Column(p => p.AdminAuditId).ColumnName("ADMINAUDITID");
            this.Column(p => p.AdminAuditTime).ColumnName("ADMINAUDITTIME");
            this.Column(p => p.AdminReAuditId).ColumnName("ADMINREAUDITID");
            this.Column(p => p.AdminReAuditTime).ColumnName("ADMINREAUDITTIME");
            this.Column(p => p.CheckTime).ColumnName("CHECKTIME");
            this.Column(p => p.IsOldFool).ColumnName("ISOLDFOOL");
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
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
