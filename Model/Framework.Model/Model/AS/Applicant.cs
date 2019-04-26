using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class Applicant : Basics
    {
        public string Name { get; set; }

        public short Sex { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string DefaultPatientUId { get; set; }

        public string DPUID { get; set; }

        public DateTime AddTime { get; set; }

        public bool Available { get; set; }
    }
}
