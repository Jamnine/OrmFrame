using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYHis.Model.Custom
{
    [Serializable]
    public class uspDispensingWorkload
    {
        public String fyname { get; set; }
        public String ItemName { get; set; }
        public String UnitName { get; set; }
        public String Spec { get; set; }
        public decimal TOTALITY { get; set; }
        public decimal AMOUNT { get; set; }

    }
}
