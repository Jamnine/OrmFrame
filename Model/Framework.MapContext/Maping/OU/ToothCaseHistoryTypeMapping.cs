using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    public class ToothCaseHistoryTypeMapping : ClassMap<ToothCaseHistoryType>
    {
         /// <summary>
        /// 无参构造方法.
        /// </summary>
       public ToothCaseHistoryTypeMapping()
        {
            this.TableName("TOOTHCASEHISTORYTYPE").Schema("orm");

            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.PyCode).ColumnName("PYCODE");
            this.Column(p => p.WbCode).ColumnName("WBCODE");
            this.Column(p => p.ParentId).ColumnName("PARENTID");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
