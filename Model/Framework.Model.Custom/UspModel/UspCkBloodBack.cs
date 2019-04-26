using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspCkBloodBack : BaseModel
    {
        public virtual Int32 ID { get; set; }
        
        public virtual String RecNo { get; set; }
        
        public virtual DateTime BackTime { get; set; }
        
        public virtual String SerialNo { get; set; }
        
        public virtual String BloodGroup { get; set; }
        
        public virtual string BloodTypeId { get; set; }
        
        public virtual String Account { get; set; }
        
        public virtual DateTime ExpireDate { get; set; }
        
        public virtual double Vollume { get; set; }
        
        public virtual String LabNum { get; set; }
        
        public virtual string LocationId { get; set; }
        
        public virtual DateTime SendTime { get; set; }
        
        public virtual String PatName { get; set; }
        
        public virtual String Sex { get; set; }
        
        public virtual DateTime BirthDate { get; set; }
        
        public virtual String time { get; set; }
    }
}
