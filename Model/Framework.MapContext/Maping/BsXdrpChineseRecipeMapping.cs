using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    /// <summary>
    /// 处方中药用法Mapping
    /// </summary>
    public class BsXdrpChineseRecipeMapping : ClassMap<BsXdrpChineseRecipe>
    {
        public BsXdrpChineseRecipeMapping()
        {
            this.TableName("BSXDRPCHINESERECIPE").Schema("orm");
            this.Column(p => p.LsFire).ColumnName("LsFire");
            this.Column(p => p.DecoctNum).ColumnName("DecoctNum");
            this.Column(p => p.CookMinute).ColumnName("CookMinute");
            this.Column(p => p.BeforeWater).ColumnName("BeforeWater");
            this.Column(p => p.AfterWater).ColumnName("AfterWater");
            this.Column(p => p.FrequencyId).ColumnName("FrequencyId");
            this.Column(p => p.UsageId).ColumnName("UsageId");
            this.Column(p => p.LsCookSelf).ColumnName("LsCookSelf");
            this.Column(p => p.TmpRecipeEmrID).ColumnName("TmpRecipeEmrID");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");



            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
