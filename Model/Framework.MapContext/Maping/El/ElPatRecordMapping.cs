using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 
    /// </summary>
    public class ElPatRecordMapping : ClassMap<ElPatRecord>
    {
        /// <summary>
        /// 
        /// </summary>
        public ElPatRecordMapping()
        {
            this.TableName("ELPATRECORD").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalID).ColumnName("HospitalID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.Memo).ColumnName("MEMO");
            this.Column(p => p.LsType).ColumnName("LSTYPE");
            this.Column(p => p.OperID).ColumnName("OPERID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.RecNo).ColumnName("RECNO");
            this.Column(p => p.GroupId).ColumnName("GROUPID");
            this.Column(p => p.PatId).ColumnName("PATID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
