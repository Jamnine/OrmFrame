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
    public class CMS_SlideMapping:ClassMap<CMS_Slide>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_SlideMapping()
        {
            this.TableName("SLIDE").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.ImagePath).ColumnName("IMAGEPATH");
            this.Column(p => p.ToTop).ColumnName("TOTOP");
            this.Column(p => p.TypeId).ColumnName("TYPEID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
