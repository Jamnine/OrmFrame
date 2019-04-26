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
    public class CMS_SiteLInkMapping: ClassMap<CMS_SiteLInk>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_SiteLInkMapping()
        {
            this.TableName("CMS_SITELINK").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Url).ColumnName("URL");
            this.Column(p => p.LogoImg).ColumnName("LOGOIMG");
            this.Column(p => p.Time).ColumnName("TIME");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
