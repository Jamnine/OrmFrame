using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    [Serializable]
    public class PrimaryKeyConfig
    {
        /// <summary>
        /// 主生成器URL。
        /// </summary>
        public string MasterKeyCreterUrl { get; set; }

        /// <summary>
        /// 从生成器URL。
        /// </summary>
        public string WingmanKeyCreterUrl { get; set; }
    }
}
