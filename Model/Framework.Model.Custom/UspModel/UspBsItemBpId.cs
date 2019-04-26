using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspBsItemBpId : BaseModel
    {
        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String HISItemName { get; set; }

        public virtual String BPItemName { get; set; }

        public virtual string FeeMzId { get; set; }

        public virtual String PyCode { get; set; }

        public virtual String WbCode { get; set; }
    }
}
