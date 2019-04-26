using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{

    /// <summary>
    /// 检验检查项目Mapping
    /// </summary>
    public partial class BsIllnessMapping : ClassMap<BsIllness>
    {
        /// <summary>
        /// 检验检查项目Mapping
        /// </summary>
        public BsIllnessMapping()
        {
            this.TableName("Bsillness").Schema("orm");

            this.Column(p => p.Code).ColumnName("Code");
            this.Column(p => p.WbCode).ColumnName("Wbcode");
            this.Column(p => p.PyCode).ColumnName("PyCode");
            this.Column(p => p.OtherCode).ColumnName("OtherCode");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.OtherDesc).ColumnName("OtherDesc");
            this.Column(p => p.GroupMain).ColumnName("GroupMain");
            this.Column(p => p.GroupSub).ColumnName("GroupSub");
            this.Column(p => p.GroupSSub).ColumnName("GroupSsub");
            this.Column(p => p.BelongIcd).ColumnName("BelongIcd");
            this.Column(p => p.IsSum).ColumnName("IsSum");
            this.Column(p => p.FeeHigh).ColumnName("FeeHigh");
            this.Column(p => p.DayHigh).ColumnName("DayHigh");
            this.Column(p => p.OrderBy).ColumnName("OrderBy");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.IconIndex).ColumnName("IconIndex");
            this.Column(p => p.IsInfectious).ColumnName("IsInfectious");
            this.Column(p => p.IsGoodRecipeIllNess).ColumnName("IsGoodRecipeIllness");
            this.Column(p => p.ReportType).ColumnName("ReportType");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             

            
            this.SequenceId(t => t.GUID).SequenceName("Bsillness_ID_SEQ");
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
