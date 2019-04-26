using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 住院治疗情况
    /// </summary>
    public class OuHospitalizationMapping:ClassMap<OuHospitalization>
    {
        public OuHospitalizationMapping()
        {
            this.TableName("OuHospitalization").Schema("orm");

            this.Column(p => p.HealthCheckHitId).ColumnName("HealthCheckHitId");//中医ID
            this.Column(p => p.EnterlDate).ColumnName("EnterlDate");//开始时间
            this.Column(p => p.LeaveDate).ColumnName("LeaveDate");//结束时间
            this.Column(p => p.Remarks).ColumnName("Remarks");//备注,
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
            this.Column(p => p.MzRegId).ColumnName("MzRegId");
            this.Column(p => p.HospitalizationType).ColumnName("HospitalizationType");//类型

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
