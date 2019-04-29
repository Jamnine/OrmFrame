using System;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 上锁解锁的信息
    /// </summary>
    [Serializable]
    public class PMKeyLockInfo
    {
        /// <summary>
        /// 返回影响的行数
        /// </summary>
        public int ListCount { get; set; }
        /// <summary>
        /// 锁表中的行号
        /// </summary>
        public string LockId { get; set; }
        /// <summary>
        /// 锁定id
        /// </summary>
        public string LockedId { get; set; }
        /// <summary>
        /// 锁定的机器名
        /// </summary>
        public string LockHost { get; set; }
    }
}
