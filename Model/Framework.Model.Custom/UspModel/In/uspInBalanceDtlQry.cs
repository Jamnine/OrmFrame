using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    #region class of Model:uspInBalanceDtlNotPayQry
    /// <summary>
    /// This object represents the properties and methods of a uspInBalanceDtlNotPay.
    /// </summary>
    public class uspInBalanceDtlQry : BaseModel
    {
         
        private string _name = String.Empty;
        private string _spec = String.Empty;
        private string _code = String.Empty;
        private string _hospId;
        private string _itemId;
        private DateTime _regOperTime;
        private string _regOperId;
        private string _locationId;
        private string _adviceId;
        private int _lsMarkType;
        private double _totality;
        private double _priceIn;
        private string _unitId;
        private bool _isPay;
        private double _discIn;
        private double _discSelf;
        private double _amount;
        private double _amountFact;
        private double _amountSelf;
        private double _amountTally;
        private double _amountInsurance;
        
        private string _invoId;
        private int _lsPerform;
        private bool _isModiDisc;
        private string _limitGroupId;
        private double _limitFee;
        private string _doctorId;
        private string _execOperId;
        private string _execLocId;
        private string _invItemId;
        private string _feeId;
        private string _feeHsId;
        private int _lsReportType;
        private string _memo = String.Empty;
        private DateTime _operTime;
        private string _operId;
        private string _f1 = String.Empty;
        private string _f2 = String.Empty;
        private string _f3 = String.Empty;
        private string _f4 = String.Empty;
        private string _f5 = String.Empty;
        private string _f6 = String.Empty;
        private string _f7 = String.Empty;
        private bool _isCancel;
        private int _cancelId;
        private bool _isManual;
        private string _regOperDate = String.Empty;
        private int _lsGfType;
        private double _amountPay;
        private string _bsInvInItemName = String.Empty;
        private string _bsZyFeetyName = String.Empty;
        private bool _isBedFee;
        private string _regDate = String.Empty;

        public uspInBalanceDtlQry()
        {
        }



        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string HospId
        {
            get { return _hospId; }
            set { _hospId = value; }
        }

        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public DateTime RegOperTime
        {
            get { return _regOperTime; }
            set { _regOperTime = value; }
        }

        public string RegOperId
        {
            get { return _regOperId; }
            set { _regOperId = value; }
        }

        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        public string AdviceId
        {
            get { return _adviceId; }
            set { _adviceId = value; }
        }

        public int LsMarkType
        {
            get { return _lsMarkType; }
            set { _lsMarkType = value; }
        }

        public double Totality
        {
            get { return _totality; }
            set { _totality = value; }
        }

        public double PriceIn
        {
            get { return _priceIn; }
            set { _priceIn = value; }
        }

        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        public bool IsPay
        {
            get { return _isPay; }
            set { _isPay = value; }
        }

        public double DiscIn
        {
            get { return _discIn; }
            set { _discIn = value; }
        }

        public double DiscSelf
        {
            get { return _discSelf; }
            set { _discSelf = value; }
        }

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public double AmountFact
        {
            get { return _amountFact; }
            set { _amountFact = value; }
        }

        public double AmountSelf
        {
            get { return _amountSelf; }
            set { _amountSelf = value; }
        }

        public double AmountTally
        {
            get { return _amountTally; }
            set { _amountTally = value; }
        }
        public double AmountInsurance
        {
            get { return _amountInsurance; }
            set { _amountInsurance = value; }
        }        

        public string InvoId
        {
            get { return _invoId; }
            set { _invoId = value; }
        }

        public int LsPerform
        {
            get { return _lsPerform; }
            set { _lsPerform = value; }
        }

        public bool IsModiDisc
        {
            get { return _isModiDisc; }
            set { _isModiDisc = value; }
        }

        public string LimitGroupId
        {
            get { return _limitGroupId; }
            set { _limitGroupId = value; }
        }

        public double LimitFee
        {
            get { return _limitFee; }
            set { _limitFee = value; }
        }

        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        public string ExecOperId
        {
            get { return _execOperId; }
            set { _execOperId = value; }
        }

        public string ExecLocId
        {
            get { return _execLocId; }
            set { _execLocId = value; }
        }

        public string InvItemId
        {
            get { return _invItemId; }
            set { _invItemId = value; }
        }

        public string FeeId
        {
            get { return _feeId; }
            set { _feeId = value; }
        }

        public string FeeHsId
        {
            get { return _feeHsId; }
            set { _feeHsId = value; }
        }

        public int LsReportType
        {
            get { return _lsReportType; }
            set { _lsReportType = value; }
        }

        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        public string F1
        {
            get { return _f1; }
            set { _f1 = value; }
        }

        public string F2
        {
            get { return _f2; }
            set { _f2 = value; }
        }

        public string F3
        {
            get { return _f3; }
            set { _f3 = value; }
        }

        public string F4
        {
            get { return _f4; }
            set { _f4 = value; }
        }
        public string F5
        {
            get { return _f5; }
            set { _f5 = value; }
        }
        public string F6
        {
            get { return _f6; }
            set { _f6 = value; }
        }
        public string F7
        {
            get { return _f7; }
            set { _f7 = value; }
        }
        public string RegDate
        {
            get { return _regDate; }
            set { _regDate = value; }
        }
        public bool IsCancel
        {
            get { return _isCancel; }
            set { _isCancel = value; }
        }

        public int CancelId
        {
            get { return _cancelId; }
            set { _cancelId = value; }
        }

        public bool IsManual
        {
            get { return _isManual; }
            set { _isManual = value; }
        }

        public string RegOperDate
        {
            get { return _regOperDate; }
            set { _regOperDate = value; }
        }

        public int LsGfType
        {
            get { return _lsGfType; }
            set { _lsGfType = value; }
        }

        public double AmountPay
        {
            get { return _amountPay; }
            set { _amountPay = value; }
        }

        public string BsInvInItemName
        {
            get { return _bsInvInItemName; }
            set { _bsInvInItemName = value; }
        }

        public string BsZyFeetyName
        {
            get { return _bsZyFeetyName; }
            set { _bsZyFeetyName = value; }
        }

        public bool IsBedFee
        {
            get { return _isBedFee; }
            set { _isBedFee = value; }
        }
        #endregion
    }
    #endregion
}




