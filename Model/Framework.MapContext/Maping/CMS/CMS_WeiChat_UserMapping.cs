using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.Model.CMS;

namespace Orm.MapContext.Maping.CMS
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_WeiChat_UserMapping: ClassMap<CMS_WeiChat_User>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_WeiChat_UserMapping()
        {
            this.TableName("CMS_WEICHAT_USER").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Subscribe).ColumnName("SUBSCRIBE");
            this.Column(p => p.NickName).ColumnName("NICKNAME");
            this.Column(p => p.Sex).ColumnName("SEX");
            this.Column(p => p.City).ColumnName("CITY");
            this.Column(p => p.Country).ColumnName("COUNTRY");
            this.Column(p => p.Province).ColumnName("PROVINCE");
            this.Column(p => p.Language).ColumnName("LANGUAGE");
            this.Column(p => p.HeadImgUrl).ColumnName("HEADIMGURL");
            this.Column(p => p.SubscribeTime).ColumnName("SUBSCRIBETIME");
            this.Column(p => p.UnionId).ColumnName("UNIONID");
            this.Column(p => p.Remark).ColumnName("REMARK");
            this.Column(p => p.GroupId).ColumnName("GROUPID");
            this.Column(p => p.AllowTest).ColumnName("ALLOWTEST");
            this.Column(p => p.TenantId).ColumnName("TENANTID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
