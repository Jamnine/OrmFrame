﻿using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class RoleMenuMapping : ClassMap<RoleMenu>   
    {
        public RoleMenuMapping()
        {
            this.TableName("RoleMenu").Schema("orm");
            this.Column(p => p.RoleId).ColumnName("ROLEID");
            this.Column(p => p.MenuId).ColumnName("MENUID");
            this.Column(p => p.OperId).ColumnName("OPERID");

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
