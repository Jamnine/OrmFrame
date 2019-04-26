using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspBsUserLocationLogin
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String Code { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual int HospitalId { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual int LsInOut { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual Boolean IsForwomen { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String PhoneCode { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual double MedicineRatio { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual int OrderBy { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual Boolean IsActive { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual int IconIndex { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual string SpecialityId { get; set; }

        //[DataMember(Order = 13, IsRequired = false)]
        public virtual int BedSum { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual String BaSysCode { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual String Director { get; set; }

        //[DataMember(Order = 16, IsRequired = false)]
        public virtual string DeptTypeId { get; set; }

        //[DataMember(Order = 17, IsRequired = false)]
        public virtual Boolean IsCostApp { get; set; }

        //[DataMember(Order = 18, IsRequired = false)]
        public virtual int AppLevel { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual String PyCode { get; set; }

        //[DataMember(Order = 20, IsRequired = true)]
        public virtual String WbCode { get; set; }

        //[DataMember(Order = 21, IsRequired = false)]
        public virtual int Area { get; set; }

        //[DataMember(Order = 22, IsRequired = false)]
        public virtual string OuRoomId { get; set; }

        //[DataMember(Order = 23, IsRequired = false)]
        public virtual string InRoomId { get; set; }

        //[DataMember(Order = 24, IsRequired = false)]
        public virtual Boolean IsPriceSub { get; set; }

        //[DataMember(Order = 25, IsRequired = false)]
        public virtual Boolean IsClinical { get; set; }

        //[DataMember(Order = 26, IsRequired = false)]
        public virtual Boolean IsChinLocation { get; set; }

        //[DataMember(Order = 27, IsRequired = false)]
        public virtual Boolean IsRegLocation { get; set; }

        //[DataMember(Order = 28, IsRequired = false)]
        public virtual Boolean IsAllLocation { get; set; }

        //[DataMember(Order = 29, IsRequired = true)]
        public virtual String FrozenYearMonth { get; set; }
    }
}
