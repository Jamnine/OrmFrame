using System;

namespace Orm.Model
{

    /// <summary>
    /// 体检计划 数据库不存在此表
    /// </summary>
    [Serializable]
    public class TjPlan : BaseModel
    {
        /// <summary>
        /// 编码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }
}
