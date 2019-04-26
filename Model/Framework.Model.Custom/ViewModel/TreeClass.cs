using System.Collections.ObjectModel;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 树状类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeClass<T>
    {
        /// <summary>
        /// 键
        /// </summary>
        public T Key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public Collection<TreeClass<T>> Value { get; set; }

    }

}
