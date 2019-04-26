using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInAdviceReqBack
    {
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual String BedName { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual Int32 GroupNum { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual Int32 LsMarkType { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual string RoomId { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual double Dosage { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual String Spec { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual DateTime ForDate { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual Boolean IsBack { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual double  Totality { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual Int32 ListNum { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual string RequestId { get; set; }

        //[DataMember(Order = 16, IsRequired = true)]
        public virtual string HospId { get; set; }

        //[DataMember(Order = 17, IsRequired = true)]
        public virtual Boolean IsIssued { get; set; }

        //[DataMember(Order = 18, IsRequired = false)]
        public virtual double BackTotality { get; set; }

        //[DataMember(Order = 19, IsRequired = false)]
        public virtual Boolean IsBackReq { get; set; }

        //[DataMember(Order = 20, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //[DataMember(Order = 21, IsRequired = true)]
        public virtual String ItemCode { get; set; }

        //[DataMember(Order = 22, IsRequired = false)]
        public virtual double PriceIn { get; set; }

        //[DataMember(Order = 23, IsRequired = true)]
        public virtual String ReqLocationName { get; set; }

        //[DataMember(Order = 24, IsRequired = true)]
        public virtual string ReqLocationId { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual DateTime ReqTime { get; set; }

        //[DataMember(Order = 26, IsRequired = true)]
        public virtual String HospNo { get; set; }

        //[DataMember(Order = 27, IsRequired = false)]
        public virtual DateTime ConfirmOperTime { get; set; }

        //[DataMember(Order = 28, IsRequired = true)]
        public virtual String UnitReq { get; set; }

        //[DataMember(Order = 29, IsRequired = false)]
        public virtual string ReqBackId { get; set; }

        //[DataMember(Order = 30, IsRequired = false)]
        public virtual double ReqBackTotality { get; set; }

        //[DataMember(Order = 31, IsRequired = false)]
        public virtual double Amount { get; set; }

        //[DataMember(Order = 32, IsRequired = true)]
        public virtual String RoomName { get; set; }

        //[DataMember(Order = 33, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //[DataMember(Order = 34, IsRequired = true)]
        public virtual String UnitInName { get; set; }

        //[DataMember(Order = 35, IsRequired = true)]
        public virtual String ReqOperName { get; set; }

        //[DataMember(Order = 36, IsRequired = false)]
        public virtual double ReqTotality { get; set; }

        //[DataMember(Order = 37, IsRequired = true)]
        public virtual string AdviceId { get; set; }

        //[DataMember(Order = 38, IsRequired = false)]
        public virtual string ExecuteId { get; set; }

        //[DataMember(Order = 39, IsRequired = true)]
        public virtual DateTime AdviceTime { get; set; }

        //[DataMember(Order = 40, IsRequired = false)]
        public virtual DateTime DrugDates { get; set; }

        //[DataMember(Order = 41, IsRequired = false)]
        public virtual double SendTotality { get; set; }

        //[DataMember(Order = 42, IsRequired = false)]
        public virtual double HasSend { get; set; }

        //[DataMember(Order = 43, IsRequired = false)]
        public virtual Boolean Refusal { get; set; }

        //[DataMember(Order = 44, IsRequired = false)]
        public virtual string DetailId { get; set; }

        //[DataMember(Order = 45, IsRequired = true)]
        public virtual String UsageMemo { get; set; }

        //[DataMember(Order = 46, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 47, IsRequired = false)]
        public virtual Boolean isprint { get; set; }

        //[DataMember(Order = 48, IsRequired = false)]
        public virtual string formid { get; set; }

        //[DataMember(Order = 41, IsRequired = false)]
        public virtual double SenDtotality { get; set; }

        //[DataMember(Order = 46, IsRequired = true)]
        public virtual String memo { get; set; }
    }
}
