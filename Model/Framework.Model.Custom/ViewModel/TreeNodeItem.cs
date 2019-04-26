using System;
using System.Collections.Generic;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 树形节点类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class TreeNodeItem<T> where T : BaseModel
    {

        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string ParentId { get; set; }
        public bool IsExpanded { get; set; }
        public List<TreeNodeItem<T>> Children { get; set; }

        public string GUID { get; set; }

        public T ItemInfo { get; set; }
        public TreeNodeItem()
        {
            Children = new List<TreeNodeItem<T>>();
            ParentId = "0";
        }

    }
}
