using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 物品入库，物品出库，采购计划，退回厂商，公共单据列表
    /// </summary>
    [Serializable]
    public class BillInfoBase:BaseModel
    {
        /// <summary>
        /// 单据ID
        /// </summary>
        public string BillId { get; set; }
        /// <summary>
        /// 单据状态
        /// </summary>
        public string Stauts { get; set; }
        /// <summary>
        /// 单据创建时间
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 单据备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 单据是否审核 
        /// </summary>
        public bool ISSIGN { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime SIGNTime { get; set; }
        /// <summary>
        /// 审核人ID
        /// </summary>
        public string SIGNOperId { get; set; }

        /// <summary>
        /// 是否接口单据  
        /// </summary>
        public bool IsInterface { get; set; }

        /// <summary>
        /// 审核人ID
        /// </summary>
        public string InterfaceBillNo { get; set; }

    }
}
