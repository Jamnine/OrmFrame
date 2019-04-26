using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspGetBlood:BaseModel
    {
        public virtual Int32 ID { get; set; }
        
        public virtual String SerialNo { get; set; }
        
        public virtual String BloodGroup { get; set; }
        
        public virtual String RHD { get; set; }
        
        public virtual DateTime ExpireDate { get; set; }
        
        public virtual DateTime CollectDate { get; set; }
        
        public virtual double Vollume { get; set; }
        
        public virtual DateTime DiscardTime { get; set; }
        
        public virtual String InPatNo { get; set; }
        
        public virtual String BedName { get; set; }
        
        public virtual String PatientName { get; set; }
        
        public virtual String PatTypeName { get; set; }
        
        public virtual string LabId { get; set; }
        
        public virtual String Unit { get; set; }
        
        public virtual String BloodTypeName { get; set; }
    }
}
