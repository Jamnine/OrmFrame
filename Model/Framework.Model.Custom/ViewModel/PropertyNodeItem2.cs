using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class PropertyNodeItem2
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 是否展开
        /// </summary>
        public bool IsExpanded { get; set; }

        /// <summary>
        /// 1为个人，2为诊所，3为共公
        /// </summary>
        public int LsOpenType { get; set; }

        /// <summary>
        /// 子节点
        /// </summary>
        public List<PropertyNodeItem2> ChildrenList { get; set; }

        /// <summary>
        /// 选项信息
        /// </summary>
        public TmpRecipeEmr ItemInfo { get; set; }

        /// <summary>
        /// 属性节点选项
        /// </summary>
        public PropertyNodeItem2()
        {
            ChildrenList = new List<PropertyNodeItem2>();
            ParentId = "0";
        }
    }
}
