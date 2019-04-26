using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 健康量表评估表头信息
    /// </summary>
    [Serializable]
    public class AssessHeaderInfo : Basics
    {
        /// <summary>
        /// 评估ID
        /// </summary>
        public int AssessmentId { get; set; }

        /// <summary>
        /// 病人ID
        /// </summary>
        public int PatId { get; set; }

        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName { get; set; }

        /// <summary>
        /// 科室ID
        /// </summary>
        public string LocationId { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 住院号
        /// </summary>
        public string HospitalizationNo { get; set; }

        /// <summary>
        /// 床号
        /// </summary>
        public string BedNo { get; set; }

        /// <summary>
        /// 主诉
        /// </summary>
        public string ChiefComplaint { get; set; }

        /// <summary>
        /// 诊断
        /// </summary>
        public string Diagnosis { get; set; }
    }
}
