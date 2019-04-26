using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class MenuMapping: ClassMap<Menu>  
    {
        public MenuMapping()
        {
            this.TableName("Menu").Schema("orm");
            this.Column(p => p.ParentId).ColumnName("PARENTID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Url).ColumnName("URL");
            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

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
