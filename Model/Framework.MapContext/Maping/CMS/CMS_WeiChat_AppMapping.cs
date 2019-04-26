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
    public class CMS_WeiChat_AppMapping: ClassMap<CMS_WeiChat_App>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_WeiChat_AppMapping()
        {
            this.TableName("CMS_WEICHAT_APP").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.AppId).ColumnName("APPID");
            this.Column(p => p.AppSecret).ColumnName("APPSECRET");
            this.Column(p => p.WeiXinAccount).ColumnName("WEIXINACCOUNT");
            this.Column(p => p.CopyrightInformation).ColumnName("COPYRIGHTINFORMATION");
            this.Column(p => p.CustomerInformation).ColumnName("CUSTOMERINFORMATION");
            this.Column(p => p.Token).ColumnName("TOKEN");
            this.Column(p => p.CreateBy).ColumnName("CREATBY");
            this.Column(p => p.CreateTime).ColumnName("CREATETIME");
            this.Column(p => p.UpdateBy).ColumnName("UPDATEBY");
            this.Column(p => p.UpdateTime).ColumnName("UPDATETIME");
            this.Column(p => p.WeChatAppType).ColumnName("WECHATAPPTYPE");
            this.Column(p => p.MchId).ColumnName("MCHID");
            this.Column(p => p.Paykey).ColumnName("PAYKEY");
            this.Column(p => p.SSLCERT_PATH).ColumnName("SSLCERT_PATH");
            this.Column(p => p.SSLCERT_PASSWORD).ColumnName("SSLCERT_PASSWORD");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
