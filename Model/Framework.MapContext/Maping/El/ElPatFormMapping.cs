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
    public class ElPatFormMapping : ClassMap<ElPatForm>
    {
        /// <summary>
        /// 
        /// </summary>
        public ElPatFormMapping()
        {
            this.TableName("ELPATFORM").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HOSPITALID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.Memo).ColumnName("MEMO");
            this.Column(p => p.PatId).ColumnName("PATID");
            this.Column(p => p.PatMenuId).ColumnName("PATMENUID");
            this.Column(p => p.RecId).ColumnName("RECID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.OperID).ColumnName("OPERID");
            this.Column(p => p.IsAuth).ColumnName("ISAUTH");
            this.Column(p => p.AuthTime).ColumnName("AUTHTIME");
            this.Column(p => p.RejectReason).ColumnName("REJECTREASON");
            this.Column(p => p.InActiveReason).ColumnName("INACTIVEREASON");
            this.Column(p => p.InActiveTime).ColumnName("INACTIVETIME");
            this.Column(p => p.InActiveOperID).ColumnName("INACTIVEOPERID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
