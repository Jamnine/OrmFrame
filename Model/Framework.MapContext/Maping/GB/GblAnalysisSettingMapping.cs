using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 数据分析设置 - 实体类
    /// </summary>
    public class GblAnalysisSettingMapping:ClassMap<GblAnalysisSetting>
    {
        public GblAnalysisSettingMapping()
        {
            this.TableName("GblAnalysisSetting").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.FileName).ColumnName("FileName");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.ProcName).ColumnName("ProcName");
            this.Column(p => p.ParentID).ColumnName("ParentID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.OrderBy).ColumnName("OrderBy");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
