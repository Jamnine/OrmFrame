using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{   /// <summary>
    /// 叫号系统 - 实体拓展类
    /// </summary>
    public partial class QuerySystem : BaseModel
    {

        private int _unix;

        public int Unix
        {
            get { return _unix; }
            set { _unix = value; }
        }

    }
}
