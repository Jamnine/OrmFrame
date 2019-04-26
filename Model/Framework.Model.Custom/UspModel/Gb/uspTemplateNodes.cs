using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 模板(获取体检套餐的(TreeView)
    /// </summary>
    [Serializable]
    public class uspTemplateNodes
    {

        /// <summary>
        /// 体检项目ID 
        /// </summary>
        public string GUID { get; set; }

        /// <summary>
        /// 上级ID
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        public string GroupMainName { get; set; }

        /// <summary>
        /// 二级项目名称
        /// </summary>
        public string GroupSubName { get; set; }

        /// <summary>
        /// 二级项目ID
        /// </summary>
        public string GroupSubID { get; set; }

        /// <summary>
        /// 是否模板
        /// </summary>
        public bool IsTemplate { get; set; }

        /// <summary>
        /// 子节点
        /// </summary>
        public List<uspTemplateNodes> Children { get; set; }
        public uspTemplateNodes()
        {
            Children = new List<uspTemplateNodes>();
        }
        private bool _isNotGUID = false;
        public bool u_IsNotGUID
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(GUID))
                {
                    _isNotGUID = true;
                }
                else
                {
                    _isNotGUID = false;
                }
                return _isNotGUID;
            }
            set { _isNotGUID = value; }
        }
    }
}
