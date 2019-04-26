using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Framework
{
    [Serializable]
    /// <summary>
    /// 节点类
    /// </summary>
    public class TreePropertyNodeItem
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisPlayName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public string GUID { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 是否展开
        /// </summary>
        public bool IsExpanded { get; set; }

        /// <summary>
        /// 1为个人，2诊所
        /// </summary>
        public int LsOpenType { get; set; }

        /// <summary>
        /// 子节点
        /// </summary>
        public List<TreePropertyNodeItem> Children { get; set; }

        /// <summary>
        /// 选项信息
        /// </summary>
        public TmpRecipeEmr TmpRecipeEmrInfo { get; set; }

        /// <summary>
        /// 病历模板表
        /// </summary>
        public TmpOuEmr TmpOuEmrInfo { get; set; }

        /// <summary>
        /// 属性节点选项
        /// </summary>
        public TreePropertyNodeItem()
        {
            Children = new List<TreePropertyNodeItem>();
            ParentId = "0";
        }
    }
}
