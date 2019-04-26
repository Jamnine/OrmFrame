using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///ÆÀ¹À±í
    /// </summary>
    public partial class AssessmentMapping : ClassMap<Assessment>
    {
        /// <summary>
        /// ÆÀ¹À±í
        /// </summary>
        public AssessmentMapping()
        {
            this.TableName("ASSESSMENT").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Name).ColumnName("AssessmentName");
            this.Column(p => p.Orderby).ColumnName("Orderby");
            this.Column(p => p.PyCode).ColumnName("PYCODE");
            this.Column(p => p.WbCode).ColumnName("WBCODE");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


