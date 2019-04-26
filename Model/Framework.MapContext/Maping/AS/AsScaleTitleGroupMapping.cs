using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsScaleTitleGroupMapping : ClassMap<AsScaleTitleGroup>  
    {
        public AsScaleTitleGroupMapping()
        {
            this.TableName("AsScaleTitleGroup").Schema("orm");
            this.Column(p => p.AsScaleId).ColumnName("ASSCALEID");
            this.Column(p => p.GroupName).ColumnName("GROUPNAME");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.FGroupId).ColumnName("FGROUPID");

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
