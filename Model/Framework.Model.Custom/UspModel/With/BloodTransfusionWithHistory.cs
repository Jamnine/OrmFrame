using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.With
{
    [Serializable]
    public class BloodTransfusionWithHistory
    {
        //[DataMember]
        public IList<CustomTree> LstCustomTree { get; set; }

        //[DataMember]
        public string LastHospId { get; set; }
    }
}
