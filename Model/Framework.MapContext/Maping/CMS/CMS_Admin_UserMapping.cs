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
    public class CMS_Admin_UserMapping: ClassMap<CMS_Admin_User>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_Admin_UserMapping()
        {
            this.TableName("CMS_ADMIN_USER").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.UserName).ColumnName("USERNAME");
            this.Column(p => p.UserPwd).ColumnName("USERPWD");

            this.Id(t => t.ID);this.Ignore(p => p.IsModify);
        }
    }
}
