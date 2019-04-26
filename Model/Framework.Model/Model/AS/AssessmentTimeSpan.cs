using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AssessmentTimeSpan : Basics
    {
        public string Info { get; set; }

        public bool IsActive { get; set; }

        public int OrderBy { get; set; }

        public DateTime TakeEffectTime { get; set; }

        public DateTime InvalidTime { get; set; }

        public int OperId { get; set; }

        public DateTime OperTime { get; set; }
    }
}
