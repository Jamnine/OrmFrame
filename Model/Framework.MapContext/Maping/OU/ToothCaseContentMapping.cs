using System;
using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    public class ToothCaseContentMapping : ClassMap<ToothCaseContent>
    {
        /// <summary>
        /// 无参构造方法.
        /// </summary>
        public ToothCaseContentMapping()
        {
            this.TableName("TOOTHCASECONTENT").Schema("orm");

            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.PyCode).ColumnName("PYCODE");
            this.Column(p => p.WbCode).ColumnName("WBCODE");
            this.Column(p => p.ParentId).ColumnName("PARENTID");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.TypeID).ColumnName("TYPEID");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
