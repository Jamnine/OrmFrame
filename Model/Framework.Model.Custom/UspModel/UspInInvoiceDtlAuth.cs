using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInInvoiceDtlAuth
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String Spec { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual String Code { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual string HospId { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual DateTime RegOperTime { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual string RegOperId { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual string AdviceId { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual double Totality { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual int LsMarkType { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual double PriceIn { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual string UnitId { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual Boolean IsPay { get; set; }

        //[DataMember(Order = 16, IsRequired = true)]
        public virtual double DiscSelf { get; set; }

        //[DataMember(Order = 17, IsRequired = true)]
        public virtual double DiscIn { get; set; }

        //[DataMember(Order = 18, IsRequired = false)]
        public virtual double? Amount { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual double AmountFact { get; set; }

        //[DataMember(Order = 20, IsRequired = true)]
        public virtual double AmountSelf { get; set; }

        //[DataMember(Order = 21, IsRequired = true)]
        public virtual double AmountTally { get; set; }

        //[DataMember(Order = 22, IsRequired = true)]
        public virtual double AmountPay { get; set; }

        //[DataMember(Order = 23, IsRequired = false)]
        public virtual string InvoId { get; set; }

        //[DataMember(Order = 24, IsRequired = true)]
        public virtual int LsPerform { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual Boolean IsModiDisc { get; set; }

        //[DataMember(Order = 26, IsRequired = false)]
        public virtual string LimitGroupId { get; set; }

        //[DataMember(Order = 27, IsRequired = false)]
        public virtual double? LimitFee { get; set; }

        //[DataMember(Order = 28, IsRequired = true)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 29, IsRequired = true)]
        public virtual string ExecOperId { get; set; }

        //[DataMember(Order = 30, IsRequired = true)]
        public virtual string ExecLocId { get; set; }

        //[DataMember(Order = 31, IsRequired = true)]
        public virtual string InvItemId { get; set; }

        //[DataMember(Order = 32, IsRequired = true)]
        public virtual string FeeId { get; set; }

        //[DataMember(Order = 33, IsRequired = false)]
        public virtual string FeeHsId { get; set; }

        //[DataMember(Order = 34, IsRequired = true)]
        public virtual Boolean IsCancel { get; set; }

        //[DataMember(Order = 35, IsRequired = true)]
        public virtual Boolean IsManual { get; set; }

        //[DataMember(Order = 36, IsRequired = false)]
        public virtual string CancelId { get; set; }

        //[DataMember(Order = 37, IsRequired = false)]
        public virtual int LsReportType { get; set; }

        //[DataMember(Order = 38, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 39, IsRequired = true)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 40, IsRequired = true)]
        public virtual string OperId { get; set; }

        //[DataMember(Order = 41, IsRequired = true)]
        public virtual String AdviceName { get; set; }

        //[DataMember(Order = 42, IsRequired = true)]
        public virtual String RegOperDate { get; set; }

        //[DataMember(Order = 43, IsRequired = true)]
        public virtual String HostName { get; set; }

        //[DataMember(Order = 44, IsRequired = false)]
        public virtual string GroupItemId { get; set; }

        //[DataMember(Order = 45, IsRequired = false)]
        public virtual string XDRpId { get; set; }

        //[DataMember(Order = 46, IsRequired = true)]
        public virtual String AdviceName1 { get; set; }

        //[DataMember(Order = 47, IsRequired = false)]
        public virtual int LsRpType { get; set; }

        //[DataMember(Order = 48, IsRequired = false)]
        public virtual int GroupNum { get; set; }

        //[DataMember(Order = 49, IsRequired = true)]
        public virtual String RegDate { get; set; }

        //[DataMember(Order = 50, IsRequired = true)]
        public virtual String TempStr { get; set; }

        //[DataMember(Order = 51, IsRequired = false)]
        public virtual Boolean? IsAutoCharged { get; set; }

        //[DataMember(Order = 52, IsRequired = false)]
        public virtual Boolean? IsYbCharged { get; set; }

        //[DataMember(Order = 53, IsRequired = true)]
        public virtual String NotAuthMemo { get; set; }

        //[DataMember(Order = 54, IsRequired = false)]
        public virtual Boolean? IsIssued { get; set; }

        //[DataMember(Order = 55, IsRequired = true)]
        public virtual String ReservedField { get; set; }

        //[DataMember(Order = 56, IsRequired = false)]
        public virtual double? DiscountAoumt { get; set; }

        //[DataMember(Order = 57, IsRequired = false)]
        public virtual double? DiscountPrice { get; set; }

        //[DataMember(Order = 58, IsRequired = false)]
        public virtual double? ChildPrice { get; set; }
    }
}
