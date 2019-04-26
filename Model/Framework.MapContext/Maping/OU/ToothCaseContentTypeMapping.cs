using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    public class ToothCaseContentTypeMapping : ClassMap<ToothCaseContentType>
    {
         /// <summary>
        /// 无参构造方法.
        /// </summary>
        public ToothCaseContentTypeMapping()
        {
            this.TableName("TOOTHCASECONTENTTYPE").Schema("orm");

            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.TypeName).ColumnName("TYPENAME");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
