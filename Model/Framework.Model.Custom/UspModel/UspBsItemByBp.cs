using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspBsItemByBp
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual bool IsSelect { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual BsItem BsItem { get; set; }

    }
}
