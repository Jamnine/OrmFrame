using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspEquipExpireDateWarning
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual String guId { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String FileName { get; set; }

        //[DataMember(Order = 3, IsRequired = false)]
        public virtual DateTime UploadDate { get; set; }

        //[DataMember(Order = 4, IsRequired = false)]
        public virtual DateTime ExpirationDate { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual double Price { get; set; }

        //[DataMember(Order = 7, IsRequired = false)]
        public virtual DateTime BuyDate { get; set; }

        //[DataMember(Order = 8, IsRequired = false)]
        public virtual DateTime StartDate { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual Int32 LsQuaClass { get; set; }

        //[DataMember(Order = 10, IsRequired = false)]
        public virtual Int32 LsEqClass { get; set; }
    }
}
