using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;
using Orm.Model.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_ColumnMapping : ClassMap<CMS_Column>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_ColumnMapping()
        {
            this.TableName("CMS_COLUMN").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.LsImg).ColumnName("LSIMG");
            this.Column(p => p.ImgW).ColumnName("IMGW");
            this.Column(p => p.ImgH).ColumnName("IMGH");
            this.Column(p => p.IsHied).ColumnName("ISHIED");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
