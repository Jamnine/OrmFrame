using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspUserLocationDoctorId : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 3, IsRequired = false)]
        public virtual Int32? IsCheck { get; set; }
    }
}
