using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping.TJ
{
    /// <summary>
    /// 体检项目接口
    /// </summary>
    public class TjItemInterfaceMapping : ClassMap<TjItemInterface>
    {
        public TjItemInterfaceMapping()
        {
            this.TableName("TjItemInterface").Schema("orm");

            this.Column(p => p.ItemInterface).ColumnName("ItemInterface");
            this.Column(p => p.TjItemCode).ColumnName("TjItemCode");
            this.Column(p => p.Plan).ColumnName("Plan");
            this.Column(p => p.NumberInterface).ColumnName("NumberInterface");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
