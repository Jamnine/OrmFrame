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
    public class AssessHeaderInfoMapping : ClassMap<AssessHeaderInfo>
    {
        /// <summary>
        /// 
        /// </summary>
        public AssessHeaderInfoMapping()
        {
            this.TableName("AssessHeaderInfo").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.AssessmentId).ColumnName("ASSESSMENTID");
            this.Column(p => p.PatId).ColumnName("PATID");
            this.Column(p => p.PatName).ColumnName("PATNAME");
            this.Column(p => p.LocationId).ColumnName("LOCATIONID");

            this.Column(p => p.Age).ColumnName("AGE");
            this.Column(p => p.HospitalizationNo).ColumnName("HOSPITALIZATIONNO");
            this.Column(p => p.BedNo).ColumnName("BEDNO");
            this.Column(p => p.ChiefComplaint).ColumnName("CHIEFCOMPLAINT");
            this.Column(p => p.Diagnosis).ColumnName("DIAGNOSIS");
            this.Column(p => p.GUID).ColumnName("GUID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
