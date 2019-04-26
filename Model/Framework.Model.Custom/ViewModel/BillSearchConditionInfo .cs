using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 日志查询条件对象
    /// </summary>
    [Serializable]
    public class BillSearchConditionInfo 
    {
        /// <summary>
        /// 仓库ID 
        /// </summary>
        public string HouseId {get;set;}
        /// <summary>
        /// 项目(物品)
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// 出入库单号
        /// </summary>
        public string BillNo { get;set;}
        /// <summary>
        /// 出入库类别
        /// </summary>
        public int LsActType { get; set; }
        public string Type { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime HappenTimeBegin { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime HappenTimeEnd { get; set; }

        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsSign { get; set; }

    }
}
