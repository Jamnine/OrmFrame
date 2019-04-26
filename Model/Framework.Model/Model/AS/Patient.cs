using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class Patient : Basics
    {
        public string Name { get; set; }

        public short Sex { get; set; }

        public DateTime Birthday { get; set; }

        public string Phone { get; set; }

        public string IDCard { get; set; }
        
        public string Address { get; set; }
        
        public string HedicalInsurance { get; set; }

        public string DPUID { get; set; }

        public string ApplicantUId { get; set; }

        public bool Available { get; set; }

    }
}
