using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AssessmentTimeSpanMapping: ClassMap<AssessmentTimeSpan>   
    {
        public AssessmentTimeSpanMapping()
        {
            this.TableName("AssessmentTimeSpan").Schema("orm");
            this.Column(p => p.Info).ColumnName("INFO");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.TakeEffectTime).ColumnName("TAKEEFFECTTIME");
            this.Column(p => p.InvalidTime).ColumnName("INVALIDTIME");
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");

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
