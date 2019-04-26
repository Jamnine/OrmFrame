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
    public class CMS_EnquireMapping : ClassMap<CMS_Enquire>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_EnquireMapping()
        {
            this.TableName("CMS_BSDOCTOR").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Sex).ColumnName("SEX");
            this.Column(p => p.Phone).ColumnName("PHONE");
            this.Column(p => p.EMail).ColumnName("EMAIL");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.HandleTime).ColumnName("HANDLETIME");
            this.Column(p => p.HandleAdminId).ColumnName("HANDLEADMINID");
            this.Column(p => p.EnquireNote).ColumnName("ENQUIRENOTE");
            this.Column(p => p.AdminNote).ColumnName("ADMINNOTE");
            this.Column(p => p.StateCode).ColumnName("STATECODE");
            this.Column(p => p.FansId).ColumnName("FANSID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
