using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsScaleTitleGroup : Basics
    {
        public int AsScaleId { get; set; }

        public string GroupName { get; set; }

        public int OrderBy { get; set; }

        public int FGroupId { get; set; }
    }
}
