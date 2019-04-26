using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspBsItemBpIdAndBsBpItemByBpName
    {
        public virtual string EvaluateId { get; set; }

        public virtual String EvaluateName { get; set; }

        public virtual string BPItemId { get; set; }

        public virtual String BpItemName { get; set; }

        public virtual string BPIllId { get; set; }

        public virtual String BPIllName { get; set; }

        public virtual String TYItemName { get; set; }

        public virtual Boolean IsSelect { get; set; }

        public virtual Boolean IsBP { get; set; }

        public virtual string ItemId { get; set; }

        public virtual String ItemCode { get; set; }

        public virtual String ItemName { get; set; }

        public virtual double Price { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual String EngDesc { get; set; }

        public virtual String TYXMName { get; set; }

        public virtual String F4 { get; set; }

        public virtual String TypeName { get; set; }
    }
}
