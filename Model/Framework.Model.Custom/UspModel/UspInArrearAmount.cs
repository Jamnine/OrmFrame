using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInArrearAmount : BaseModel
    {
        public virtual Int32 ID { get; set; }

        public virtual string HospId { get; set; }

        public virtual String InPatNo { get; set; }

        public virtual String PatientName { get; set; }

        public virtual Int32 NTime { get; set; }

        public virtual Int32 Age { get; set; }

        public virtual String SexName { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual double ArrearAmount { get; set; }

        public virtual String Memo { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string OperID { get; set; }

        public virtual String AuthMan { get; set; }

        public virtual String LocationName { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual String UserName { get; set; }

        public virtual string OperId1 { get; set; }

        public virtual DateTime ExpireDate { get; set; }

        public virtual Int32 ExpireHours { get; set; }

        public virtual Boolean IsMax { get; set; }
    }
}
