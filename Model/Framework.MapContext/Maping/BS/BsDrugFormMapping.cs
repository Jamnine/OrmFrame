using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///剂型类别表
    /// </summary>
    public partial class BsDrugFormMapping: ClassMap<BsDrugForm>
    {
        /// <summary>
        ///剂型类别表
        /// </summary>
        public BsDrugFormMapping()
        {
            this.TableName("BSDRUGFORM").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Code).ColumnName("CODE");
            this.Column(p =>p.Name).ColumnName("NAME");
            this.Column(p =>p.IsReject).ColumnName("ISREJECT");
            this.Column(p =>p.IsSave).ColumnName("ISSAVE");
            this.Column(p =>p.WbCode).ColumnName("WBCODE");
            this.Column(p =>p.PyCode).ColumnName("PYCODE");
            this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
            this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
            this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p =>p.ISONETotality).ColumnName("ISONETOTALITY");
            this.Column(p =>p.ModiTime).ColumnName("MODITIME");
            this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
            this.Column(p =>p.YBCode).ColumnName("YBCODE");
            this.Column(p =>p.UpCode).ColumnName("UPCODE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.IsPecial).ColumnName("ISPECIAL");
            this.Column(p => p.IsTOForm).ColumnName("ISTOFORM");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


