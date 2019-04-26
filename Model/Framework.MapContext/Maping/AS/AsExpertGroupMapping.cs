using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsExpertGroupMapping : ClassMap<AsExpertGroup>
    {
        public AsExpertGroupMapping()
        {
            this.TableName("AsExpertGroup").Schema("orm");
            this.Column(p => p.AdminId).ColumnName("ADMINID");
            this.Column(p => p.Assessmentd).ColumnName("ASSESSMENTD");
            this.Column(p => p.AuditTime).ColumnName("AUDITTIME");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsMajor).ColumnName("ISMAJOR");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");
            this.Column(p => p.Stage).ColumnName("STAGE");
            this.Column(p => p.Status).ColumnName("STATUS");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
