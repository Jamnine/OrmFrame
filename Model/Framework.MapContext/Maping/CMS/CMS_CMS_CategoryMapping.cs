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
    public class CMS_CMS_CategoryMapping : ClassMap<CMS_CMS_Category>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_CMS_CategoryMapping()
        {
            this.TableName("CMS_CMS_CATEGORY").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.ColumnId).ColumnName("COLUMNID");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.RoomName).ColumnName("ROOMNAME");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
