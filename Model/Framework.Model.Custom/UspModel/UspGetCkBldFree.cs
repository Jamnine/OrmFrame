using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspGetCkBldFree : BaseModel
    {
        public virtual String Memo { get; set; }
        
        public virtual String TransType { get; set; }
        
        public virtual String LocationName { get; set; }
        
        public virtual String PatName { get; set; }
        
        public virtual String UserName { get; set; }
        
        public virtual DateTime OperTime { get; set; }
        
        public virtual string OperId { get; set; }
        
        public virtual Int32 ID { get; set; }
        
        public virtual string HospId { get; set; }
    }
}
