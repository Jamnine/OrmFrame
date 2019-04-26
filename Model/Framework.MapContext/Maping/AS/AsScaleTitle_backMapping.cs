using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsScaleTitle_backMapping : ClassMap<AsScaleTitle_back>
    {
        public AsScaleTitle_backMapping()
        {
            this.TableName("AsScaleTitle_back").Schema("orm");
            this.Column(p => p.AsScaleId).ColumnName("ASSCALEID");
            this.Column(p => p.TitleGroupId).ColumnName("TITLEGROUPID");
            this.Column(p => p.Title).ColumnName("TITLE");
            this.Column(p => p.TitleType).ColumnName("TITLETYPE");
            this.Column(p => p.Score).ColumnName("SCORE");
            this.Column(p => p.Required).ColumnName("REQUIRED");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.IsGroupGrade).ColumnName("ISGROUPGRADE");
            this.Column(p => p.IsRestsGroupValid).ColumnName("ISRESTSGROUPVALID");

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
