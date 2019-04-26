using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    public class OuMedicalRecordMapping : ClassMap<OuMedicalRecord>
    {
        public OuMedicalRecordMapping()
        {
            this.TableName("OuMedicalRecord").Schema("orm");
            this.Column(p => p.MzRegId).ColumnName("MzRegId");
            this.Column(p => p.OnsetDate).ColumnName("OnsetDate");
            this.Column(p => p.MainInform).ColumnName("MainInform");
            this.Column(p => p.Pathography).ColumnName("Pathography");
            this.Column(p => p.PhysicalExam).ColumnName("PhysicalExam");
            this.Column(p => p.OtherCheck).ColumnName("OtherCheck");
            this.Column(p => p.TreatmentAdvise).ColumnName("TreatmentAdvise");
            this.Column(p => p.Comments).ColumnName("Comments");

             
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);  
        }
    }
}
