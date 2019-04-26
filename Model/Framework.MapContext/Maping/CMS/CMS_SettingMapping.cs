using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping.CMS
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_SettingMapping : ClassMap<CMS_Setting>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_SettingMapping()
        {
            this.TableName("CMS_SETTING").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Val).ColumnName("VAL");
            this.Column(p => p.ValType).ColumnName("VALTYPE");
            this.Column(p => p.Descr).ColumnName("DESCR");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            
            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
