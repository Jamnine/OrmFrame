using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{ 
    /// <summary>
    /// 数据分析查询条件设置 - 实体类
    /// </summary>
    public class GblAnalysisQuerySettingMapping : ClassMap<GblAnalysisQuerySetting>
    {
        public GblAnalysisQuerySettingMapping()
        {
            this.TableName("GblAnalysisQuerySetting").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.KeyName).ColumnName("KeyName");
            this.Column(p => p.SettingID).ColumnName("SettingID");
            this.Column(p => p.SetValue).ColumnName("SetValue");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.ParmName).ColumnName("ParmName");
            this.Column(p => p.ParameterType).ColumnName("ParameterType");        
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
