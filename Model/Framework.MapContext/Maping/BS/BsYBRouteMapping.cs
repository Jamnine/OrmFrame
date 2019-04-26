using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{

    /// <summary>
    /// 连接对应医保规则
    /// </summary>
    public class BsYBRouteMapping : ClassMap<BsYBRoute>
    {
        public BsYBRouteMapping()
        {
            this.TableName("BsYBRoute").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.YBInterfaceName).ColumnName("YBInterfaceName");
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
            this.Column(p => p.YbType).ColumnName("YbType");
            this.Column(p => p.YbCenterCode).ColumnName("YbCenterCode");
            this.Column(p => p.YbHospitalServer).ColumnName("YbHospitalServer");
            this.Column(p => p.YbHosptailCode).ColumnName("YbHosptailCode");
            this.Column(p => p.YBInterfaceName).ColumnName("YBInterfaceName");
            this.Column(p => p.IsUpLoadCode).ColumnName("IsUpLoadCode");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.OperID).ColumnName("OperID");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
