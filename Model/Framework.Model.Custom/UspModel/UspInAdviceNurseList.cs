using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    public class UspInAdviceNurseList
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual DateTime AdviceTime { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String Code { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual string HospId { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual Int32 GroupNum { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual double Dosage { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual string UnitTakeId { get; set; }

        //[DataMember(Order = 10, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        //[DataMember(Order = 11, IsRequired = false)]
        public virtual string UsageId { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual double PriceIn { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual double Totality { get; set; }

        //[DataMember(Order = 14, IsRequired = false)]
        public virtual double? Amount { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual string UnitInId { get; set; }

        //[DataMember(Order = 16, IsRequired = false)]
        public virtual int IsUrgent { get; set; }

        //[DataMember(Order = 17, IsRequired = false)]
        public virtual int LsExecLoc { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual string OperID { get; set; }

        //[DataMember(Order = 20, IsRequired = true)]
        public virtual Boolean IsAuth { get; set; }

        //[DataMember(Order = 21, IsRequired = false)]
        public virtual DateTime AuthOperTime { get; set; }

        //[DataMember(Order = 22, IsRequired = false)]
        public virtual string AuthOperID { get; set; }

        //[DataMember(Order = 23, IsRequired = true)]
        public virtual Boolean IsLong { get; set; }

        //[DataMember(Order = 24, IsRequired = false)]
        public virtual Int32? IsAuthFee { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual Boolean IsCancel { get; set; }

        //[DataMember(Order = 26, IsRequired = false)]
        public virtual DateTime? CancelOperTime { get; set; }

        //[DataMember(Order = 27, IsRequired = false)]
        public virtual string CancelOperID { get; set; }

        //[DataMember(Order = 28, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 29, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 30, IsRequired = true)]
        public virtual String Spec { get; set; }

        //[DataMember(Order = 31, IsRequired = false)]
        public virtual string FormId { get; set; }

        //[DataMember(Order = 32, IsRequired = false)]
        public virtual int LsRpType { get; set; }

        //[DataMember(Order = 33, IsRequired = false)]
        public virtual Boolean? IsInject { get; set; }

        //[DataMember(Order = 34, IsRequired = false)]
        public virtual Boolean? IsYbxj { get; set; }

        //[DataMember(Order = 35, IsRequired = true)]
        public virtual String YbType { get; set; }

        //[DataMember(Order = 36, IsRequired = true)]
        public virtual String Colours { get; set; }

        //[DataMember(Order = 37, IsRequired = false)]
        public virtual string ApplyId { get; set; }

        //[DataMember(Order = 38, IsRequired = true)]
        public virtual String LimitTotalZy { get; set; }
    }
}
