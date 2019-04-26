using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class ApplicantMapping : ClassMap<Applicant>
    {
        public ApplicantMapping() {
            this.TableName("Applicant").Schema("orm");
            this.Column(p => p.Address).ColumnName("ADDRESS");
            this.Column(p => p.AddTime).ColumnName("ADDTIME");
            this.Column(p => p.Available).ColumnName("AVAILABLE");
            this.Column(p => p.DefaultPatientUId).ColumnName("DEFAULTPATIENTUID");
            this.Column(p => p.DPUID).ColumnName("DPUID");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Password).ColumnName("PASSWORD");
            this.Column(p => p.Phone).ColumnName("PHONE");
            this.Column(p => p.Sex).ColumnName("SEX");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
