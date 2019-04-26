using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 用户对应的可操作功能集合类
    /// </summary>
    [Serializable]
    public partial class uspWindowOperFunctionQry : BaseModel
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        public string MenuId { get; set; }
        /// <summary>
        /// 操作人id
        /// </summary>
        public string OperId { get; set; }
        /// <summary>
        /// 功能id
        /// </summary>
        public string FunctionId { get; set; }
    }
}

