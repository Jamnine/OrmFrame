using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///BP治疗方案说明
    /// </summary>
    public partial class BsIllMapping : ClassMap<BsIll>
    {
        /// <summary>
        /// BP治疗方案说明
        /// </summary>
        public BsIllMapping()
        {
            this.TableName("BsIll").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Detail).ColumnName("Detail");
            this.Column(p =>p.Name).ColumnName("Name");
            this.Column(p =>p.Orderby).ColumnName("Orderby");
            this.Column(p =>p.PatientGroup).ColumnName("PatientGroup");
            this.Column(p =>p.Treatment).ColumnName("Treatment");
            this.Column(p =>p.TreatOrderby).ColumnName("TreatOrderby");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


