using System.Collections.Generic;

namespace Orm.Framework.Common
{
    /// <summary>
    /// 全局字典
    /// </summary>
    public static class GlobalDictionary
    {
        private static Dictionary<string, string> _lockDict;

        /// <summary>
        /// 锁
        /// </summary>
        public static Dictionary<string, string> LockDict
        {
            get { return _lockDict; }
            set { _lockDict = value; }
        }
    }
}
