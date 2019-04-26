using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class OuTreatmentRecordMapping : ClassMap<OuTreatmentRecord>
    {
        public OuTreatmentRecordMapping()
        {
            this.TableName("OuTreatmentRecord").Schema("orm");
            this.Column(p => p.Diagnosis).ColumnName("Diagnosis");
            this.Column(p => p.Treatment).ColumnName("Treatment");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.PatID).ColumnName("PatID");
            this.Column(p => p.MzRegId).ColumnName("MzRegId");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.DocLevType).ColumnName("DOCLEVTYPE");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);  
        }
    }
}
