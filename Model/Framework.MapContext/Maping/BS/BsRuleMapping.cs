using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
	/// 限额 - 实体类
	/// </summary>
    public partial class BsRuleMapping : ClassMap<BsRule>
    {
        /// <summary>
        /// 限额 - 实体类
        /// </summary>
        public BsRuleMapping()
        {
            this.TableName("BsRule").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Code).ColumnName("CODE");
            this.Column(p => p.DiagnosisBasetarget).ColumnName("DIAGNOSISBASETARGET");
            this.Column(p => p.DiagnosisRoyalty).ColumnName("DIAGNOSISROYALTY");
            this.Column(p => p.DiagnosisTndtArget).ColumnName("DIAGNOSISSTANDTARGET");
            this.Column(p => p.DocLevID).ColumnName("DOCLEVID");
            this.Column(p => p.DrugfeeBasetArget).ColumnName("DRUGFEEBASETARGET");
            this.Column(p => p.DrugfeeRoyalty).ColumnName("DRUGFEEROYALTY");
            this.Column(p => p.DrugfeeStandArget).ColumnName("DRUGFEESTANDTARGET");
            this.Column(p => p.ExdrugfeeBasetArget).ColumnName("EXDRUGFEEBASETARGET");
            this.Column(p => p.ExdrugfeeRoyalty).ColumnName("EXDRUGFEEROYALTY");
            this.Column(p => p.ExdrugfeeStandtArget).ColumnName("EXDRUGFEESTANDTARGET");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.Remark).ColumnName("REMARK");
            this.Column(p => p.RoyaltyLevel).ColumnName("ROYALTYLEVEL");
            this.Column(p => p.TreatmentBasetArget).ColumnName("TREATMENTBASETARGET");
            this.Column(p => p.TreatmentRoyalty).ColumnName("TREATMENTROYALTY");
            this.Column(p => p.TreatmentStandardtArget).ColumnName("TREATMENTSTANDARDTARGET");
            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
