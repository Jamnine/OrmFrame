using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 诊断意见表
    /// </summary>
    public class OuDiagnosisMapping : ClassMap<OuDiagnosis>
    {
        public OuDiagnosisMapping()
        {
            this.TableName("OuDiagnosis").Schema("orm");
            this.Column(p => p.MedicalRecordId).ColumnName("MedicalRecordId");
            this.Column(p => p.TJSuggestionId).ColumnName("TJSuggestionId");
            this.Column(p => p.DiseaseName).ColumnName("DiseaseName");
            this.Column(p => p.DiseaseCode).ColumnName("DiseaseCode");

             
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);  
        }
    }
}
