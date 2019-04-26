﻿using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 住院发票分类 
    /// </summary>
    public partial class BsInvInItemMapping:ClassMap<BsInvInItem>
    {
        /// <summary>
        /// 住院发票分类 
        /// </summary>
        public BsInvInItemMapping()
        {
            this.TableName("BsInvInItem").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Code).ColumnName("CODE");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.HisType).ColumnName("HisType");
            this.Column(p => p.InsertTime).ColumnName("InsertTime");
            this.Column(p => p.WbCode).ColumnName("WBCODE");
            this.Column(p => p.PyCode).ColumnName("PYCODE");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.GroupName).ColumnName("GROUPNAME");
            this.Column(p => p.GroupOrderBy).ColumnName("GROUPORDERBY");
            this.Column(p => p.IsAlone).ColumnName("ISALONE");
            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
