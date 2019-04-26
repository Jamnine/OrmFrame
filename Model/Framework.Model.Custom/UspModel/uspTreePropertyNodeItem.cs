using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model.Framework;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspTreePropertyNodeItem
    {
        /// <summary>
        /// 数节点
        /// </summary>
        public List<TreePropertyNodeItem> TreePropertyNodeItemList { get; set; }

        /// <summary>
        /// 主组
        /// </summary>
        public List<string> GroupMainList { get; set; }

        /// <summary>
        /// 副组
        /// </summary>
        public List<TmpOuEmr> GroupSubList { get; set; }
        /// <summary>
        /// List<string>
        /// </summary>
        public List<string> GroupSubStringList { get; set; }
    }
}
