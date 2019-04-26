using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 节点类
    /// </summary>
    [Serializable]
    public class PropertyNodeItem
    {
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string ParentId { get; set; }
        public bool IsExpanded { get; set; }

        /// <summary>
        /// 1为个人，2为诊所，3为共公
        /// </summary>
        public int LsOpenType { get; set; }
        public List<PropertyNodeItem> ChildrenList { get; set; }

        public string RootParentId { get; set; }

        public TmpOuEmr ItemInfo { get; set; }
        public PropertyNodeItem()
        {
            ChildrenList = new List<PropertyNodeItem>();
            ParentId = "0";
        }
    }
}
