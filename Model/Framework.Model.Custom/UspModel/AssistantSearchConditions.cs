using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    /// <summary>
    /// 医生助理筛选条件
    /// </summary>
    [Serializable]
    public class AssistantSearchConditions
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 收费方式
        /// </summary>
        public string ChargeModeId { get; set; }
        /// <summary>
        /// 诊所id
        /// </summary>
        public string LocationId { get; set; }
        /// <summary>
        /// 医生助理id
        /// </summary>
        public string AssistantId { get; set; }
        public string LocationName { get; set; }
        public AssistantSearchConditions()
        {
            BeginTime = DateTime.Now.Date;
            EndTime = DateTime.Now.Date;
        }
    }
}
