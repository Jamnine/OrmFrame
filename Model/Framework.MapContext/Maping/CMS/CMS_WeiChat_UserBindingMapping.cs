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
    public class CMS_WeiChat_UserBindingMapping : ClassMap<CMS_WeiChat_UserBinding>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_WeiChat_UserBindingMapping()
        {
            this.TableName("CMS_WEICHAT_USERBINDING").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.OpenId).ColumnName("OPENID");
            this.Column(p => p.PatName).ColumnName("PATNAME");
            this.Column(p => p.Mobile).ColumnName("MOBILE");
            this.Column(p => p.TenantId).ColumnName("TENANTID");
            this.Column(p => p.UserCode).ColumnName("USERCODE");
            this.Column(p => p.OperIdCard).ColumnName("OPERIDCARD");
            this.Column(p => p.Sex).ColumnName("SEX");
            this.Column(p => p.BirthDate).ColumnName("BIRTHDATE");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
