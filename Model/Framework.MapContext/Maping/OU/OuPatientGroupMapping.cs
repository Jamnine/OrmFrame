using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 病人分组
    /// </summary>
    public partial class OuPatientGroupMapping : ClassMap<OuPatientGroup>
    {
        public OuPatientGroupMapping()
        {
            this.TableName("OuPatientGroup").Schema("orm");

            this.Column(p => p.IllName).ColumnName("IllName");
            this.Column(p => p.OuhosinfoId).ColumnName("OuhosinfoId");
            this.Column(p => p.PatientGroup).ColumnName("PatientGroup");
            this.Column(p => p.XmlId).ColumnName("XmlId");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}



