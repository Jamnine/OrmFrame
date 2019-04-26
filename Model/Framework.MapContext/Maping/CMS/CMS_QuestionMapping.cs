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
    public class CMS_QuestionMapping: ClassMap<CMS_Question>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_QuestionMapping()
        {
            this.TableName("CMS_QUESTION").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Time).ColumnName("TIME");
            this.Column(p => p.Title).ColumnName("TITLE");
            this.Column(p => p.Text).ColumnName("TEXT");
            this.Column(p => p.UserName).ColumnName("USERNAME");
            this.Column(p => p.isAdopt).ColumnName("ISADOPT");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
