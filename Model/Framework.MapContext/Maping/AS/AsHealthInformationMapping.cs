using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsHealthInformationMapping : ClassMap<AsHealthInformation>
    {
        public AsHealthInformationMapping()
        {
            this.TableName("AsHealthInformation").Schema("orm");
            this.Column(p => p.ApplyPurpose).ColumnName("APPLYPURPOSE");
            this.Column(p => p.AssessmentId).ColumnName("ASSESSMENTID");
            this.Column(p => p.AuxiliaryTools).ColumnName("AUXILIARYTOOLS");
            this.Column(p => p.AuxiliaryToolsOthe).ColumnName("AUXILIARYTOOLSOTHE");
            this.Column(p => p.BasicJudgment).ColumnName("BASICJUDGMENT");
            this.Column(p => p.ChronicDisease).ColumnName("CHRONICDISEASE");
            this.Column(p => p.ChronicDiseaseOther).ColumnName("CHRONICDISEASEOTHER");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");
            this.Column(p => p.Supplement).ColumnName("SUPPLEMENT");
            this.Column(p => p.TreatmentCondition).ColumnName("TREATMENTCONDITION");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
