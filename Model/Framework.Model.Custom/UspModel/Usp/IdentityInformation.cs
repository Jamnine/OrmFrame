using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    public class IdentityInformation
    {
        public int Age { set; get; }
        public int Month { set; get; }
        public int Day { set; get; }
        public int Hours { set; get; }
        public int Minutes { set; get; }
        public bool IsBabay { set; get; }

        public bool IsElder { set; get; }
        public bool Sex { set; get; }//true 女 false 男
        public bool Error { set; get; } //发生 传入日期大于当前日期 或者日期格式不对时

    }
}
