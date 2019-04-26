using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsOldFoolMapping : ClassMap<AsOldFool>
    {
        public AsOldFoolMapping()
        {
            this.TableName("AsOldFool").Schema("orm");
            this.Column(p => p.AssessmentId).ColumnName("ASSESSMENTID");
            this.Column(p => p.CognitionId).ColumnName("COGNITIONID");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");
            this.Column(p => p.ObstacleId).ColumnName("OBSTACLEID");
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
