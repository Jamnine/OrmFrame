using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 健康量表评估信息
    /// </summary>
    [Serializable]
    public class AssessmentHealthScale : Basics
    {
        /// <summary>
        /// 评估ID
        /// </summary>
        public int AssessmentId { get; set; }

        /// <summary>
        /// 量表标题主ID
        /// </summary>
        public int AsScaleId { get; set; }

        /// <summary>
        /// 题目ID
        /// </summary>
        public int AsScaleTitleId { get; set; }

        /// <summary>
        /// 得分
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        public int OperatorId { get; set; }

        /// <summary>
        /// 填表人ID
        /// </summary>
        public int FillingPersonId { get; set; }

        /// <summary>
        /// 填表时间
        /// </summary>
        public DateTime FillDate { get; set; }

        /// <summary>
        /// 病人ID
        /// </summary>
        public int PatId { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastTime { get; set; }
    }
}
