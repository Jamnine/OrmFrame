using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    public class UspWorkLoadkz
    {
        public virtual String DoctorName { get; set; }

        public virtual Int32 TOTALITY { get; set; }

        public virtual Int32 TjTOTALITY { get; set; }

        public virtual Int32 Cardnum { get; set; }

    }
}
