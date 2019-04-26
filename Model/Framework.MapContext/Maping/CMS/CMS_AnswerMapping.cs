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
    public class CMS_AnswerMapping: ClassMap<CMS_Answer>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_AnswerMapping()
        {
            this.TableName("CMS_ANSWER").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.DoctorId).ColumnName("DOCTORID");
            this.Column(p => p.Time).ColumnName("TIME");
            this.Column(p => p.Text).ColumnName("TEXT");
            this.Column(p => p.QuestionId).ColumnName("QUESTIONID");

            this.Id(t => t.ID);this.Ignore(p=>p.IsModify);
        }
    }
}
