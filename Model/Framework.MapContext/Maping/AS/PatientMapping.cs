using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class PatientMapping : ClassMap<Patient>   
    {
        public PatientMapping()
        {
            this.TableName("Patient").Schema("orm");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Sex).ColumnName("SEX");
            this.Column(p => p.Birthday).ColumnName("BIRTHDAY");
            this.Column(p => p.Phone).ColumnName("PHONE");
            this.Column(p => p.IDCard).ColumnName("IDCARD");
            this.Column(p => p.Address).ColumnName("ADDRESS");
            this.Column(p => p.HedicalInsurance).ColumnName("HEDICALINSURANCE");
            this.Column(p => p.DPUID).ColumnName("DPUID");
            this.Column(p => p.ApplicantUId).ColumnName("APPLICANTUID");
            this.Column(p => p.Available).ColumnName("AVAILABLE");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
