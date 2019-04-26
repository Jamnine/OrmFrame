using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class Role : Basics
    {
        public string Name { get; set; }

        public string Descr { get; set; }

        public bool IsActive { get; set; }

        public int OrderBy { get; set; }

        public DateTime OperTime { get; set; }

        public int OperId { get; set; }
    }
}
