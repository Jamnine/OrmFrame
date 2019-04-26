using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 服务主表
    /// </summary>
    public partial class OuServiceMapping : ClassMap<OuService>
    {
        public OuServiceMapping()
        {
            this.TableName("OuService").Schema("orm");

            this.Column(p => p.CreateDate).ColumnName("CREATEDATE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.OuHosInfoId).ColumnName("MZREGID");
            this.Column(p => p.PatientId).ColumnName("PATID");
            this.Column(p => p.ServiceType).ColumnName("SERVICETYPE");
            this.Column(p => p.UserId).ColumnName("USERID");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);  
        }
    }
}
