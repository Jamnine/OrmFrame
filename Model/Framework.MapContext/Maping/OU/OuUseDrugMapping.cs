using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping.OU
{
    /// <summary>
    /// 主要用药
    /// </summary>
    public class OuUseDrugMapping:ClassMap<OuUseDrug>
    {
        public OuUseDrugMapping()
        {
            this.TableName("OuUseDrug").Schema("orm");

            this.Column(p => p.HealthCheckUseId).ColumnName("HealthCheckUseId");
            this.Column(p => p.DrugName).ColumnName("DrugName");//药品名称
            this.Column(p => p.Usage).ColumnName("Usage");//用法
            this.Column(p => p.Consumption).ColumnName("Consumption");//用量
            this.Column(p => p.UsageTime).ColumnName("UsageTime");//用药时间
            this.Column(p => p.UsageType).ColumnName("UsageType");//服药依从性

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
