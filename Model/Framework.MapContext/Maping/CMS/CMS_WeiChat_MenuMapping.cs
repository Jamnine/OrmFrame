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
    public class CMS_WeiChat_MenuMapping: ClassMap<CMS_WeiChat_Menu>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_WeiChat_MenuMapping()
        {
            this.TableName("CMS_WEICHAT_MENU").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.MenuData).ColumnName("MENUDATA");
            this.Column(p => p.Remark).ColumnName("REMARK");
            this.Column(p => p.IsCurrent).ColumnName("ISCURRENT");
            this.Column(p => p.Result).ColumnName("RESULT");
            this.Column(p => p.UpdateTime).ColumnName("UPDATETIME");
            this.Column(p => p.UpdateBy).ColumnName("UPDATEBY");
            this.Column(p => p.TenantId).ColumnName("TENANTID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
