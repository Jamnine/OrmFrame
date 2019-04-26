using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInBalanceDtlByInvoId : BaseModel
    {
        public virtual Int32 ID { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual String Code { get; set; }

        public virtual string HospId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual DateTime RegOperTime { get; set; }

        public virtual string RegOperId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string AdviceId { get; set; }

        public virtual Int32 LsMarkType { get; set; }

        public virtual double Totality { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual string UnitId { get; set; }

        public virtual Boolean IsPay { get; set; }

        public virtual double DiscIn { get; set; }

        public virtual double DiscSelf { get; set; }

        public virtual double Amount { get; set; }

        public virtual double AmountFact { get; set; }

        public virtual double AmountSelf { get; set; }

        public virtual double AmountTally { get; set; }

        public virtual string InvoId { get; set; }

        public virtual Int32 LsPerform { get; set; }

        public virtual Boolean IsModiDisc { get; set; }

        public virtual string LimitGroupId { get; set; }

        public virtual double LimitFee { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string ExecOperId { get; set; }

        public virtual string ExecLocId { get; set; }

        public virtual string InvItemId { get; set; }

        public virtual string FeeId { get; set; }

        public virtual string FeeHsId { get; set; }

        public virtual Int32 LsReportType { get; set; }

        public virtual String Memo { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string OperId { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual string CancelId { get; set; }

        public virtual Boolean IsManual { get; set; }

        public virtual String RegOperDate { get; set; }

        public virtual Int32 LsGfType { get; set; }

        public virtual double AmountPay { get; set; }

        public virtual string MainDoctorId { get; set; }

        public virtual String BsInvInItemName { get; set; }

        public virtual String RegDate { get; set; }

        public virtual String BsZyFeetyName { get; set; }

        public virtual Boolean IsBedFee { get; set; }

        public virtual string MainDoctorId1 { get; set; }

        public virtual String RegDate1 { get; set; }

        public virtual Boolean IsYbCharged { get; set; }

        public virtual String NotAuthMemo { get; set; }

        public virtual double DiscountAoumt { get; set; }

        public virtual double DiscountPrice { get; set; }

        public virtual double ChildPrice { get; set; }
    }
}
