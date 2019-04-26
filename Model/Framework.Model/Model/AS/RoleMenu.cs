using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class RoleMenu : Basics
    {
        public int RoleId { get; set; }

        public int MenuId { get; set; }

        public int OperId { get; set; }
    }
}
