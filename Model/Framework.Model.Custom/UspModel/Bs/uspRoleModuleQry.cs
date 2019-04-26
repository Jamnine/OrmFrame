using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 角色权限相关信息类
    /// </summary>
    [Serializable]
    public class uspRoleModuleQry
    {
        private bool _isChecked;
        private bool _isModify;
        private bool _rawIsChecked;
        /// <summary>
        /// ID
        /// </summary>
        public   string ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 父ID
        /// </summary>
        public string ParentID { get; set; }
        /// <summary>
        /// 指示或设置是否选中状态
        /// </summary>
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_rawIsChecked == value)
                {
                    _isModify = false;
                }
                else
                {
                    _isModify = true;
                }
                _isChecked = value;
            }
        }
        /// <summary>
        /// 指示或设置原始选中状态
        /// </summary>
        public bool RawIsChecked
        {
            get { return _rawIsChecked; }
            set
            {
                _rawIsChecked = value;
            }
        }
        /// <summary>
        /// 指示或设置目前状态是否与原始状态不同
        /// </summary>
        public bool IsModify { get { return _isModify; } set { _isModify = value; } }
        /// <summary>
        ///  操作说明书网址
        /// </summary>
        public string HelpAddress { get; set; }
        /// <summary>
        /// 菜单id
        /// </summary>
        public string MenuId { get; set; }
        /// <summary>
        /// 权限id
        /// </summary>
        public string ModuleID { get; set; }
        /// <summary>
        /// 角色权限id
        /// </summary>
        public string RoleModuleID { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        public int Order { get; set; }
    }
}

