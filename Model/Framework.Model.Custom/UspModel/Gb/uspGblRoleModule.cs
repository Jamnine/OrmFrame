using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 角色权限
    /// </summary>
    [Serializable]
   
    public class uspGblRoleModule
    {
        private string _roleId;
        private string _moduleId;
        
        /// <summary>
        /// 角色ID.
        /// </summary>
        public string RoleId
        {
            get
            {
                return this._roleId;
            }
            set
            {
                this._roleId = value;
            }
        }

        /// <summary>
        /// 对应菜单功能ID.
        /// </summary>
        public string ModuleId
        {
            get
            {
                return this._moduleId;
            }
            set
            {
                this._moduleId = value;
            }
        }

        public List<uspGblRoleModule> AddGblRoleModule { get; set; }
        public List<uspGblRoleModule> DelGblRoleModule { get; set; }
        public List<string> StringList { get; set; }
    }

}
