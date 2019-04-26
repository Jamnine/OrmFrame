using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspCkBldReimb : BaseModel
    {
        public virtual Int32 ID { get; set; }
        
        public virtual string HospId { get; set; }
        
        public virtual string LocationId { get; set; }
        
        public virtual String BloodGroup { get; set; }
        
        public virtual String RHD { get; set; }
        
        public virtual string BloodTypeId { get; set; }
        
        public virtual double Vollume { get; set; }
        
        public virtual String Memo { get; set; }
        
        public virtual DateTime OperTime { get; set; }
        
        public virtual string OperId { get; set; }
        
        public virtual String Sex { get; set; }
        
        public virtual String Name { get; set; }
        
        public virtual string HospId1 { get; set; }
        
        public virtual String InPatNo { get; set; }
        
        public virtual String HospNo { get; set; }
    }
}
