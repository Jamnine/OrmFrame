using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 微信端返回检验报告参数类
    /// </summary>
    [Serializable]
     public class PMInspectionReport
    {
        /// <summary>
        /// 体检项目记录id
        /// </summary>
        public string TjItemRecordId { get; set; }
        /// <summary>
        /// 处方明细id
        /// </summary>
        public string RecipeDtlId { get; set; }
        /// <summary>
        /// 项目id
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// 病人卡号（档案编号）
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime CompleteTime { get; set; }

    }
}
