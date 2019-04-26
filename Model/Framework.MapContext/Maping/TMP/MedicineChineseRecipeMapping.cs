using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
     public class MedicineChineseRecipeMapping : ClassMap<MedicineChineseRecipe>
    {
        public MedicineChineseRecipeMapping()
        {
            this.TableName("MedicineChineseRecipe").Schema("orm");
            this.Column(p => p.LsFire).ColumnName("LsFire");
            this.Column(p => p.DecoctNum).ColumnName("DecoctNum");
            this.Column(p => p.CookMinute).ColumnName("CookMinute");
            this.Column(p => p.BeforeWater).ColumnName("BeforeWater");
            this.Column(p => p.AfterWater).ColumnName("AfterWater");
            this.Column(p => p.FrequencyId).ColumnName("FrequencyId");
            this.Column(p => p.UsageId).ColumnName("UsageId");
            this.Column(p => p.LsCookSelf).ColumnName("LsCookSelf");
            this.Column(p => p.TmpRecipeEmrID).ColumnName("TmpRecipeEmrID");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
