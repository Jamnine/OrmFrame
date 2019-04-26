using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 辐射环评表
    /// </summary>
    public class EqRadEnvironmentMapping : ClassMap<EqRadEnvironment>
    {
        /// <summary>
        ///  - 实体类
        /// </summary>
        public EqRadEnvironmentMapping()
        {
            this.TableName("EQRADENVIRONMENT").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.EquipmentId).ColumnName("EQUIPMENTID");

            this.Column(p => p.Performance).ColumnName("PERFORMANCE");

            this.Column(p => p.Protect).ColumnName("PROTECT");

            this.Column(p => p.EqRadEnvirCon).ColumnName("EQRADENVIRCON");

            this.Column(p => p.BenefitLocId).ColumnName("BENEFITLOCID");

            this.Column(p => p.RecordDate).ColumnName("RECORDDATE");

            this.Column(p => p.Memo).ColumnName("MEMO");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
