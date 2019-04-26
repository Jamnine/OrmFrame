using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspInInvoiceDtl : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual String Code { get; set; }

        public virtual string HospId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual DateTime RegOperTime { get; set; }

        public virtual string RegOperId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string AdviceId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int16 LsMarkType { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual string UnitId { get; set; }

        public virtual Boolean IsPay { get; set; }

        public virtual double DiscSelf { get; set; }

        public virtual double DiscIn { get; set; }

        public virtual double Amount { get; set; }

        public virtual double AmountFact { get; set; }

        public virtual double AmountSelf { get; set; }

        public virtual double AmountTally { get; set; }

        public virtual double AmountPay { get; set; }

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

        public virtual Boolean IsCancel { get; set; }

        public virtual Boolean IsManual { get; set; }

        public virtual string CancelId { get; set; }

        public virtual Int32 LsReportType { get; set; }

        public virtual String Memo { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string OperId { get; set; }

        public virtual String AdviceName { get; set; }

        public virtual String RegOperDate { get; set; }

        public virtual String HostName { get; set; }

        public virtual string GroupItemId { get; set; }

        public virtual string XDRpId { get; set; }

        public virtual String AdviceName1 { get; set; }

        public virtual String ReservedField { get; set; }

        public virtual Boolean IsAutoCharged { get; set; }

        public virtual bool IsCheck { get; set; }

        public virtual string CheckOperId { get; set; }

        public virtual DateTime CheckTime { get; set; }

        public virtual string UserCode { get; set; }
    }
}
