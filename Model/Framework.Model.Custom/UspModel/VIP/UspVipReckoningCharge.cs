using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.VIP
{
    [Serializable]
    public class UspVipReckoningCharge:BaseModel
    { 
         
        public virtual string VipCardId { get; set; }
         
        public virtual string ItemId { get; set; }
         
        public virtual int TotalCount { get; set; }
         
        public virtual int ConsumeCount { get; set; }
         
        public virtual DateTime LastChargeTime { get; set; }
         
        public virtual double DiscountPrice { get; set; }
         
        public virtual Boolean IsDiscount { get; set; }
         
        public virtual Boolean IsActive { get; set; }
         
        public virtual String Comments { get; set; }
         
        public virtual Boolean IsAuthed { get; set; }
         
        public virtual String ItemName { get; set; }
         
        public virtual double PriceDiag { get; set; }
         
        public virtual int SurplusCount { get; set; }
    }
}
