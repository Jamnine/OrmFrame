using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspGetTipsToNurse
    {
        public virtual string GUID { get; set; }

        public virtual String HearType { get; set; }

        public virtual String BedName { get; set; }

        public virtual String patientName { get; set; }

        public virtual String InPatNo { get; set; }
    }
}
