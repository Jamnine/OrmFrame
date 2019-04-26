using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsScaleTitleAdminMapping : ClassMap<AsScaleTitleAdmin>  
    {
        public AsScaleTitleAdminMapping()
        {
            this.TableName("AsScaleTitleAdmin").Schema("orm");
            this.Column(p => p.AssessmentId).ColumnName("ASSESSMENTID");
            this.Column(p => p.TitleId).ColumnName("TITLEID");
            this.Column(p => p.CheckedItemId).ColumnName("CHECKEDITEMID");
            this.Column(p => p.TitleAnsr).ColumnName("TITLEANSR");

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
