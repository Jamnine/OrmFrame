using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    public class BssigningDoctorIYWTMapping : ClassMap<BssigningDoctorIYWT>
    {
        public BssigningDoctorIYWTMapping()
        {
            this.TableName("BSSIGNINGDOCTORIYWT").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Login_id).ColumnName("LOGINID");
            this.Column(p => p.DoctorId).ColumnName("DOCTORID");
            this.Column(p => p.IsCancel).ColumnName("ISCANCEL");
            this.Column(p => p.HospitalId).ColumnName("HOSPITALID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
