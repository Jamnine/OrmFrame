using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsScaleTitleItem_back2 : Basics
    {
        public int AsScaleTitleId { get; set; }

        public string ItemName { get; set; }

        public double Score { get; set; }

        public bool AddText { get; set; }
    }
}
