using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspFirstPageFee
    {
        //[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String PsFeeName { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String InterfaceCode1 { get; set; }

        //[DataMember(Order = 4, IsRequired = false)]
        public virtual double Amount { get; set; }
        //
    }
}
