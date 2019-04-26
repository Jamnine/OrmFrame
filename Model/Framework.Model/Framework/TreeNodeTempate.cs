using System;
using System.Collections.Generic; 

namespace Orm.Framework.Model
{
    /// <summary>
    /// 树状模板
    /// </summary>
    [Serializable]
    public class TreeNodeTempate
    {
        public TreeNodeTempate()
        {
            TreeNodeDtl = new List<TreeNodeTempate>();
        }

        /// <summary>
        /// 节点登记
        /// </summary>
        public int NodeLv { get; set; }

        /// <summary>
        /// 数据自身ID
        /// </summary>
        public string GUID { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 自定义字段 1级 套餐数 2级 3级 总金额
        /// </summary>
        public string Custom { get; set; }

        /// <summary>
        /// 节点选择
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// 子节点 
        /// </summary>
        public List<TreeNodeTempate> TreeNodeDtl { get; set; }
    }
}
