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
    public class CMS_WeiChat_SyncLogMapping: ClassMap<CMS_WeiChat_SyncLog>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_WeiChat_SyncLogMapping()
        {
            this.TableName("CMS_ANSWER").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Type).ColumnName("TYPE");
            this.Column(p => p.TenantId).ColumnName("TENANTID");
            this.Column(p => p.IsUserSync).ColumnName("ISUSERSYNC");
            this.Column(p => p.CreateBy).ColumnName("CREATEBY");
            this.Column(p => p.CreateTime).ColumnName("CREATETIME");
            this.Column(p => p.Message).ColumnName("MESSAGE");
            this.Column(p => p.Success).ColumnName("SUCCESS");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
