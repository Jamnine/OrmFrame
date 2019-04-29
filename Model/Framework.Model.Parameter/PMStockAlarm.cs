using System;

namespace Orm.Model.Parameter
{

    /// <summary>
    /// 组合盘点查询信息
    /// </summary>
    [Serializable]
    public class PMStockAlarm
    {
        /// <summary>
        /// 药房ID
        /// </summary>
        public string HouseId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 组合项目大类ID
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool OnlyShowAlarmed { get; set; }

    }
}
