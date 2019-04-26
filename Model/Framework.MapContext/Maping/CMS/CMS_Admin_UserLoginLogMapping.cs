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
    public class CMS_Admin_UserLoginLogMapping: ClassMap<CMS_Admin_UserLoginLog>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_Admin_UserLoginLogMapping()
        {
            this.TableName("CMS_ADMIN_USERLOGINLOG").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.AdminUId).ColumnName("ADMINUID");
            this.Column(p => p.Time).ColumnName("TIME");
            this.Column(p => p.Ip).ColumnName("IP");

            this.Id(t => t.ID);this.Ignore(p => p.IsModify);
        }
    }
}
