using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.El
{
    /// <summary>
    /// 
    /// </summary>
    public class ElPatFormValueMapping : ClassMap<ElPatFormValue>
    {
        /// <summary>
        /// 
        /// </summary>
        public ElPatFormValueMapping()
        {
            this.TableName("ELPATFORMVALUE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalID).ColumnName("HospitalID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.Id).ColumnName("ID");
            this.Column(p => p.PatFormId).ColumnName("PATFORMID");
            this.Column(p => p.ElId).ColumnName("ELID");
            this.Column(p => p.ElValue).ColumnName("ELVALUE");
            this.Column(p => p.LsType).ColumnName("LSTYPE");
            this.Column(p => p.ClassId).ColumnName("CLASSID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
