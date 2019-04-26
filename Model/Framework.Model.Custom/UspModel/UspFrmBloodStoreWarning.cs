using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspFrmBloodStoreWarning:BaseModel
    {
        public virtual Int32 ID { get; set; }

        public virtual string DiscardOperID { get; set; }

        public virtual DateTime DiscardTime { get; set; }
        
        public virtual String DiscardReason { get; set; }
        
        public virtual String Unit { get; set; }
        
        public virtual Int32 LimitDays { get; set; }
        
        public virtual String BackMemo { get; set; }
        
        public virtual string BackOperId { get; set; }
        
        public virtual DateTime BackDate { get; set; }
        
        public virtual Int32 LsStatus { get; set; }
        
        public virtual double Price { get; set; }
        
        public virtual String CollectMan { get; set; }
        
        public virtual DateTime CollectDate { get; set; }
        
        public virtual String OfferMan { get; set; }
        
        public virtual DateTime ExpireDate { get; set; }
        
        public virtual String Account { get; set; }
        
        public virtual Int32 LsSource { get; set; }
        
        public virtual string RecieveOperId { get; set; }
        
        public virtual DateTime RecieveDate { get; set; }
        
        public virtual String RHD { get; set; }
        
        public virtual String BloodGroup { get; set; }
        
        public virtual string BloodTypeId { get; set; }
        
        public virtual String SerialNo { get; set; }
        
        public virtual Int32 ID1 { get; set; }
        
        public virtual double UnderLineKc { get; set; }
        
        public virtual double Vollume { get; set; }
    }
}
