using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsExpertGroup : Basics
    {
        public int Assessmentd { get; set; }

        public int AdminId { get; set; }

        public bool IsMajor { get; set; }

        public short Stage { get; set; }

        public DateTime AuditTime { get; set; }

        public short Status { get; set; }
    }
}
