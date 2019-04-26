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
    public class CMS_WeiChat_MessagesTemplateMapping: ClassMap<CMS_WeiChat_MessagesTemplate>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_WeiChat_MessagesTemplateMapping()
        {
            this.TableName("CMS_WEICHAT_MESSAGESTEMPLATE").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.TemplateNo).ColumnName("TEMPLATENO");
            this.Column(p => p.ShortNo).ColumnName("SHORTNO");
            this.Column(p => p.Title).ColumnName("TITLE");
            this.Column(p => p.OneIndustry).ColumnName("ONEINDUSTRY");
            this.Column(p => p.TwoIndustry).ColumnName("TWOINDUSTRY");
            this.Column(p => p.Content).ColumnName("CONTENT");
            this.Column(p => p.Demo).ColumnName("DEMO");
            this.Column(p => p.AllowTest).ColumnName("ALLOWTEST");
            this.Column(p => p.CreateTime).ColumnName("CREATETIME");
            this.Column(p => p.UpdateTime).ColumnName("UPDATETIME");
            this.Column(p => p.CreateBy).ColumnName("CREATEBY");
            this.Column(p => p.UpdateBy).ColumnName("UPDATEBY");
            this.Column(p => p.TenantId).ColumnName("TENANTID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
