using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    /// <summary>
    /// 
    /// </summary>
    public class AssessmentHealthScaleMapping : ClassMap<AssessmentHealthScale>
    {
        /// <summary>
        /// 
        /// </summary>
        public AssessmentHealthScaleMapping()
        {
            this.TableName("AssessmentHealthScale").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.AssessmentId).ColumnName("ASSESSMENTID");
            this.Column(p => p.PatId).ColumnName("PATID");
            this.Column(p => p.AsScaleId).ColumnName("ASSCALEID");
            this.Column(p => p.AsScaleTitleId).ColumnName("ASSCALETITLEID");
            this.Column(p => p.OperatorId).ColumnName("OPERATORID");
            this.Column(p => p.FillingPersonId).ColumnName("FILLINGPERSONID");
            this.Column(p => p.FillDate).ColumnName("FILLDATE");
            this.Column(p => p.LastTime).ColumnName("LASTTIME");
            this.Column(p => p.Score).ColumnName("SCORE");
            this.Column(p => p.GUID).ColumnName("GUID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
