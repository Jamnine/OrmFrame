using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInvoiceFeetyGoupSum : BaseModel
    {
        public virtual Int32 ID { get; set; }
        
        public virtual String Name { get; set; }
        
        public virtual string FeeId { get; set; }
        
        public virtual double Amount { get; set; }
        
        public virtual double AmountFact { get; set; }
        
        public virtual double AmountSelf { get; set; }
        
        public virtual double AmountTally { get; set; }
        
        public virtual double AmountPay { get; set; }
        
        public virtual double AmountJZ { get; set; }
        
        public virtual double AmountZF { get; set; }
        
        public virtual double AmountYH { get; set; }
        
        public virtual double MzAmount { get; set; }
    }
}
