using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class GetBsitemInfo:BaseModel
    {
        public string UnitDiag { get; set; }
        public string Name { get; set; }
        public string ManufActurerMc { get; set; }

        public string Code;
        public double PriceDiag { get; set; }
        public string ItemTypeID { get; set; }
    }
}
