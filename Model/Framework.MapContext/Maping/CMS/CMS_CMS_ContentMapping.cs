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
    public class CMS_CMS_ContentMapping:ClassMap<CMS_CMS_Content>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_CMS_ContentMapping()
        {
            this.TableName("CMS_BSDEPARTMENT").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.ColumnId).ColumnName("COLUMNID");
            this.Column(p => p.Title).ColumnName("TITLE");
            this.Column(p => p.Keywords).ColumnName("KEYWORDS");
            this.Column(p => p.Description).ColumnName("DESCRIPTION");
            this.Column(p => p.Time).ColumnName("TIME");
            this.Column(p => p.ContentText).ColumnName("CONTENTTEXT");
            this.Column(p => p.Img).ColumnName("IMG");
            this.Column(p => p.Orderby).ColumnName("ORDERBY");
            this.Column(p => p.TopOrderby).ColumnName("TOPORDERBY");
            this.Column(p => p.StateCode).ColumnName("STATECODE");
            this.Column(p => p.IsRelease).ColumnName("ISRELEASE");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
