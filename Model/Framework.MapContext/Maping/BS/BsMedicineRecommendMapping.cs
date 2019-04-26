using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 中药推荐表映射
    /// </summary>
    public partial class BsMedicineRecommendMapping : ClassMap<BsMedicineRecommend>
    {
        /// <summary>
        /// 中药推荐表映射
        /// </summary>
        public BsMedicineRecommendMapping()
        {
            this.TableName("BsMedicineRecommend").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.IllName).ColumnName("IllName");
            this.Column(p =>p.Indication).ColumnName("Indication");
            this.Column(p =>p.ItemName).ColumnName("ItemName");
            this.Column(p =>p.LocationID).ColumnName("LocationID");
            this.Column(p =>p.PatientGroup).ColumnName("PatientGroup");
            this.Column(p =>p.References).ColumnName("References");
            this.Column(p =>p.BsManufacturerID).ColumnName("BsManufacturerID");
            this.Column(p =>p.Spec).ColumnName("Spec");
            this.Column(p =>p.Phone).ColumnName("Phone");
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


