using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///¼²²¡±í
    /// </summary>
    public partial class BsDisMapping : ClassMap<BsDis>
    {
        /// <summary>
        ///¼²²¡±í
        /// </summary>
        public BsDisMapping()
        {
            this.TableName("BSDIS").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Name).ColumnName("NAME");
            this.Column(p => p.PyCode).ColumnName("PYCODE");
            this.Column(p => p.WbCode).ColumnName("WBCODE");
            this.Column(p => p.Orderby).ColumnName("Orderby");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


