using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    public class BsSymptomMapping :ClassMap<BsSymptom>
    {
        /// <summary>
        /// 症状
        /// </summary>
        public BsSymptomMapping()
        {
            this.TableName("BsSymptom").Schema("orm");

            this.Column(p => p.Code).ColumnName("code");
            this.Column(p => p.Name).ColumnName("name");
            this.Column(p => p.IsActive).ColumnName("isActive");
            this.Column(p => p.OperId).ColumnName("operId");
            this.Column(p => p.OperLastTime).ColumnName("operLastTime");

            this.Column(p => p.GUID).ColumnName("GUID");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
