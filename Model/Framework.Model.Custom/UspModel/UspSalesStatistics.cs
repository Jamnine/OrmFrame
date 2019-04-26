using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    public class UspSalesStatistics
    {
        public String HospitalName { get; set; }
        public String DoctorName { get; set; }
        public decimal sx { get; set; }
        public decimal xy { get; set; }
        public decimal ZY { get; set; }
    }
}
