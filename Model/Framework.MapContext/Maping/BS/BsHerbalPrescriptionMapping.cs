using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 中药处方(辩证治疗/名家名医)
    /// </summary>
    public partial class BsHerbalPrescriptionMapping : ClassMap<BsHerbalPrescription>
    {
        /// <summary>
        /// 中药处方(辩证治疗/名家名医)
        /// </summary>
        public BsHerbalPrescriptionMapping()
        {
            this.TableName("BsHerbalPrescription").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.AddAndSubtract).ColumnName("AddAndSubtract");
            this.Column(p =>p.Author).ColumnName("Author");
            this.Column(p =>p.AuthorIntro).ColumnName("AuthorIntro");
            this.Column(p =>p.Experience).ColumnName("Experience");
            this.Column(p =>p.Explain).ColumnName("Explain");
            this.Column(p =>p.IllName).ColumnName("IllName");
            this.Column(p =>p.Prescription).ColumnName("Prescription");
            this.Column(p =>p.PrescriptionType).ColumnName("PrescriptionType");
            this.Column(p =>p.Therapy).ColumnName("Therapy");
            this.Column(p =>p.TypeOfSyndrome).ColumnName("TypeOfSyndrome");
            this.Column(p =>p.Orderby).ColumnName("Orderby");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


