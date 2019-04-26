using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class Menu : Basics
    {
        public int ParentId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int IconIndex { get; set; }

        public bool IsActive { get; set; }

        public int OrderBy { get; set; }
    }
}
