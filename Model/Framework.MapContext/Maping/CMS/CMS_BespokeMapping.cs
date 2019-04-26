using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping.CMS
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_BespokeMapping : ClassMap<CMS_Bespoke>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_BespokeMapping()
        {
            this.TableName("CMS_BESPOKE").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Sex).ColumnName("SEX");
            this.Column(p => p.Phone).ColumnName("PHONE");
            this.Column(p => p.BespokeTime).ColumnName("BESPOKETIME");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.UserNote).ColumnName("USERNOTE");
            this.Column(p => p.StateCode).ColumnName("STATECODE");
            this.Column(p => p.FansId).ColumnName("FANSID");
            this.Column(p => p.AdminNote).ColumnName("ADMINNOTE");
            
            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
