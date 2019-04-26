using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsScale_backMapping : ClassMap<AsScale_back>
    {
        public AsScale_backMapping()
        {
            this.TableName("AsScale_back").Schema("orm");
            this.Column(p => p.CityId).ColumnName("CITYID");
            this.Column(p => p.CreateTime).ColumnName("CREATETIME");
            this.Column(p => p.Descr).ColumnName("DESCR");
            this.Column(p => p.DistrictId).ColumnName("DISTRICTID");
            this.Column(p => p.EndTime).ColumnName("ENDTIME");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.ProvinceId).ColumnName("PROVINCEID");
            this.Column(p => p.StartTime).ColumnName("STARTTIME");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
