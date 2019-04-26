using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspPatCardFee : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = false)]
        public virtual Int32 ID { get; set; }

        //[DataMember(Order = 2, IsRequired = false)]
        public virtual string PatId { get; set; }

        //[DataMember(Order = 3, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 4, IsRequired = false)]
        public virtual string OperId { get; set; }

        //[DataMember(Order = 5, IsRequired = false)]
        public virtual double Amount { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual string PayWayId { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String Memo { get; set; }
    }
}
