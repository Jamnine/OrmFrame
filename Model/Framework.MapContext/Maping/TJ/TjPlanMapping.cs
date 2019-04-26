using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping.TJ
{
    /// <summary>
    /// 体检计划表
    /// </summary>
    public class TjPlanMapping : ClassMap<TjPlan>
    {
        public TjPlanMapping()
        {
            this.TableName("TjPlan").Schema("orm");

            this.Column(p => p.Code).ColumnName("Code");
            this.Column(p => p.Name).ColumnName("Name");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
