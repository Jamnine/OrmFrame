using System;

namespace Orm.Model
{
    /// <summary>
    /// 视图名称
    /// </summary>
    [Serializable]
    public class ViewName
    {
        /// <summary>
        /// ID
        /// </summary>
        public string  ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///顺序
        /// </summary>
        public string OrderBy { get; set; }
    }
}
