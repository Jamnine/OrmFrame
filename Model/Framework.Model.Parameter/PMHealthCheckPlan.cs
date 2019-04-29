using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// 健康体检
    /// </summary>
    [Serializable]
    public class PMHealthCheckPlan
    {
        /// <summary>
        /// 基本
        /// </summary>
        public OuHealthCheckBase HealthCheckBase { get; set; }
        /// <summary>
        /// 辅助检查
        /// </summary>
        public OuAuxiliaryCheck AuxiliaryCheck { get; set; }
        /// <summary>
        /// 中医
        /// </summary>
        public OuHealthCheckHit HealthCheckHit { get; set; }
        /// <summary>
        /// 住院史/家庭病床史
        /// </summary>
        public List<OuHospitalization> Hospitalizations { get; set; }
        /// <summary>
        /// 用药情况
        /// </summary>
        public OuHealthCheckUse HealthCheckUse { get; set; }
        /// <summary>
        /// 主要用药
        /// </summary>
        public List<OuUseDrug> UseDrugs { get; set; }
        /// <summary>
        /// 预防接种史
        /// </summary>
        public List<OuAntiHistory> AntiHistories { get; set; }
    }
}
