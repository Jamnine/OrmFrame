using System;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 牙齿病历
    /// </summary>
    [Serializable]
    public class IdToothCaseHistory : BaseModel
    {

        /// <summary>
        /// 牙齿历史(门诊挂号)
        /// </summary>
        public OuHosInfo ToothHistory { get; set; }

        /// <summary>
        /// 病历模板
        /// </summary>
        public TmpOuEmr TmpOuEmrinfo { get; set; }
    }
}
