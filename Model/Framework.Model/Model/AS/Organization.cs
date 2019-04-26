using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class Organization : Basics
    {
        public int Name { get; set; }

        public bool IsActive { get; set; }
    }
}
