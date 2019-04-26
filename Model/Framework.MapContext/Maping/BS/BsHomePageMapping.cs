using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///¼²²¡±í
    /// </summary>
    public partial class BsHomePageMapping : ClassMap<BsHomePage>
    {
        /// <summary>
        ///¼²²¡±í
        /// </summary>
        public BsHomePageMapping()
        {
            this.TableName("BsHomePage").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.OrderNumber).ColumnName("OrderNumber");
            this.Column(p => p.Content).ColumnName("Content");
            this.Column(p => p.Link).ColumnName("Link");
            this.Column(p => p.ParentId).ColumnName("ParentId");
            this.Column(p => p.Abbreviation).ColumnName("Abbreviation");
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


