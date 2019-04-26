using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class ChineseRecipeDtlMapping : ClassMap<ChineseRecipeDtl>
    {
        public ChineseRecipeDtlMapping()
        {
            this.TableName("ChineseRecipeDtl").Schema("orm");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.ItemID).ColumnName("ItemID");
            this.Column(p => p.Dosage).ColumnName("Dosage");
            this.Column(p => p.Memo).ColumnName("Memo");
            this.Column(p => p.UnitTakeId).ColumnName("UnitTakeId");
            this.Column(p => p.CookTypeName).ColumnName("ChineseHerbChin");
            this.Column(p => p.RecipeId).ColumnName("RecipeId");
            this.Column(p => p.CookType).ColumnName("CookType");
            this.Column(p => p.TmpRecipeEmrId).ColumnName("TmpRecipeEmrId");
            this.Column(p => p.PriceDiag).ColumnName("PriceDiag");
            this.Column(p => p.UnitDiagID).ColumnName("UnitDiagID");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
