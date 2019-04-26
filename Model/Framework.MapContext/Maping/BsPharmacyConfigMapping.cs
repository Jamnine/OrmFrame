using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
    /// <summary>
    /// 药房配置表
    /// </summary>
    public partial class BsPharmacyConfigMapping : ClassMap<BsPharmacyConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public BsPharmacyConfigMapping()
        {
            this.TableName("BSPHARMACYCONFIG").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HospitalId).ColumnName("HOSPITALID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.PharmacyAdss).ColumnName("PHARMACYADSS");
            this.Column(p => p.HosPharmacyId).ColumnName("HOSPHARMACYID");
            this.Column(p => p.PharmacyName).ColumnName("PHARMACYNAME");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.IsDefault).ColumnName("ISDEFAULT");
            this.Column(p => p.PharmacyNo).ColumnName("PHARMACYNO");
            this.Column(p => p.Pharmacytype).ColumnName("Pharmacytype");


            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
