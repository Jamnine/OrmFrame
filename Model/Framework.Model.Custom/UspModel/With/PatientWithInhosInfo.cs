using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class PatientWithInhosInfo
    {
        public BsPatient Patient { get; set; }

        public InHosInfo InHosInfos { get; set; }

        public BsBed BedByMom { get; set; }
    }
}
