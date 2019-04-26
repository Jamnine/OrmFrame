using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;
using Orm.Model.EnumDefine;

namespace Orm.Model.Custom
{
    [Serializable]
    public class UspInadvicelongCache : BaseModel
    {
        private DateTime _adviceTime;
        private string _doctorId = string.Empty;
        private string _locationId = string.Empty;
        private string _hospId = string.Empty;
        private int _groupNum = 1;
        private string _itemId = string.Empty;
        private string _name = String.Empty;
        private string _spec = String.Empty;
        private string _formId = string.Empty;
        private double _priceIn = 0.0;
        private double _dosage = 0.0;
        private string _unitTakeId = string.Empty;
        private string _frequencyId = string.Empty;
        private string _usageId = string.Empty;
        private double _totality;
        private double _amount;
        private string _unitInId = string.Empty;
        private bool _isAttach;
        private bool _isSelf;
        private int _lsSpecialUsage;
        private int _lsExecLoc;
        private DateTime _skinTime;
        private bool _isSkin;
        private string _skinTest = String.Empty;
        private string _operId = string.Empty;
        private DateTime _operTime;
        private bool _isPrinted;
        private bool _isChk;
        private DateTime _chkOperTime;
        private string _chkOperId = string.Empty;
        private bool _isEnd;
        private DateTime _endOperTime;
        private string _endOperId = string.Empty;
        private string _endDoctorId = string.Empty;
        private bool _isAuth;
        private DateTime _authOperTime;
        private string _authOperId = string.Empty;
        private string _memo = " ";

        private string _limitTotalZy = String.Empty;
        private string _colours = String.Empty;
        private string _ybType = String.Empty;
        private bool _isOtherFee;
        private int _lsRpType;
        private bool _isInject;
        private int _sn;
        private int _firstDay;
        private int _lastDay;
        private string _execLocId = string.Empty;
        private string _oriAdviceId = string.Empty;
        private string _isNoDrug = String.Empty;
        private string _isRpForbId = String.Empty;
        private string _code = String.Empty;
        private bool _isAst;
        private int _refusal;
        private string _execDoctorId = string.Empty;
        private bool _isYbxj;
        private double _discountPrice;
        private double _childPrice;

        /// <summary>
        /// 
        /// </summary>
        public UspInadvicelongCache() { }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AdviceTime
        {
            get { return _adviceTime; }
            set { _adviceTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAst
        {
            get { return _isAst; }
            set { _isAst = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string HospId
        {
            get { return _hospId; }
            set { _hospId = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        public int GroupNum
        {
            get { return _groupNum; }
            set { _groupNum = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FormId
        {
            get { return _formId; }
            set { _formId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double PriceIn
        {
            get { return _priceIn; }
            set { _priceIn = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string UnitTakeId
        {
            get { return _unitTakeId; }
            set { _unitTakeId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FrequencyId
        {
            get { return _frequencyId; }
            set { _frequencyId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string UsageId
        {
            get { return _usageId; }
            set { _usageId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Totality
        {
            get { return _totality; }
            set { _totality = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string UnitInId
        {
            get { return _unitInId; }
            set { _unitInId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAttach
        {
            get { return _isAttach; }
            set { _isAttach = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSelf
        {
            get { return _isSelf; }
            set { _isSelf = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LsSpecialUsage
        {
            get { return _lsSpecialUsage; }
            set { _lsSpecialUsage = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LsExecLoc
        {
            get { return _lsExecLoc; }
            set { _lsExecLoc = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime SkinTime
        {
            get { return _skinTime; }
            set { _skinTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSkin
        {
            get { return _isSkin; }
            set { _isSkin = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SkinTest
        {
            get { return _skinTest; }
            set { _skinTest = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsPrinted
        {
            get { return _isPrinted; }
            set { _isPrinted = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsChk
        {
            get { return _isChk; }
            set { _isChk = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ChkOperTime
        {
            get { return _chkOperTime; }
            set { _chkOperTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ChkOperId
        {
            get { return _chkOperId; }
            set { _chkOperId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsEnd
        {
            get { return _isEnd; }
            set { _isEnd = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime EndOperTime
        {
            get { return _endOperTime; }
            set { _endOperTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string EndOperId
        {
            get { return _endOperId; }
            set { _endOperId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string EndDoctorId
        {
            get { return _endDoctorId; }
            set { _endDoctorId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAuth
        {
            get { return _isAuth; }
            set { _isAuth = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AuthOperTime
        {
            get { return _authOperTime; }
            set { _authOperTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AuthOperId
        {
            get { return _authOperId; }
            set { _authOperId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string LimitTotalZy
        {
            get { return _limitTotalZy; }
            set { _limitTotalZy = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Colours
        {
            get { return _colours; }
            set { _colours = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string YbType
        {
            get { return _ybType; }
            set { _ybType = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsOtherFee
        {
            get { return _isOtherFee; }
            set { _isOtherFee = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LsRpType
        {
            get { return _lsRpType; }
            set { _lsRpType = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsInject
        {
            get { return _isInject; }
            set { _isInject = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Sn
        {
            get { return _sn; }
            set { _sn = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int FirstDay
        {
            get { return _firstDay; }
            set { _firstDay = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LastDay
        {
            get { return _lastDay; }
            set { _lastDay = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ExecLocId
        {
            get { return _execLocId; }
            set { _execLocId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string OriAdviceId
        {
            get { return _oriAdviceId; }
            set { _oriAdviceId = value; }
        }

        /// <summary>
        /// 是否没有库存
        /// </summary>
        public string IsNoDrug
        {
            get { return _isNoDrug; }
            set { _isNoDrug = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string IsRpForbId
        {
            get { return _isRpForbId; }
            set { _isRpForbId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Refusal
        {
            get { return _refusal; }
            set { _refusal = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ExecDoctorId
        {
            get { return _execDoctorId; }
            set { _execDoctorId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsYbxj
        {
            get { return _isYbxj; }
            set { _isYbxj = value; }
        }


        /// <summary>  
        ///   
        /// </summary>  
        public double DiscountPrice
        {
            get { return _discountPrice; }
            set { _discountPrice = value; }
        }


        /// <summary>  
        ///   
        /// </summary>  
        public double ChildPrice
        {
            get { return _childPrice; }
            set { _childPrice = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string PatName { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string AgeStr { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string InpatNo { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Sex { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool Isurgent { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsAuthfee { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime AuthfeeOperTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsCancel { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime CancelOperTime { set; get; }

        ///<summary>
        ///
        ///</summary>
        public string AdviceTempMemo { set; get; }

        ///<summary>
        ///
        ///</summary>
        public double DisCountPrice { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsDelete { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsAuthed { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string AuthfeeOperId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string CancelOperId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ExeclocId { set; get; }

        ///<summary>
        ///
        ///</summary>
        public string ApplyId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string InsertTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string HospitalName { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Frequency { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string UnitTake { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string LocName { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string UsageName { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ItemName { set; get; }

        ///<summary>
        ///
        ///</summary>
        public string DocName { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Unitin { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string OperName { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ChkOper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string AuthOper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string FeeOper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string CancelName { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Execloc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Execdoc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ApplyNo { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int PsapplyType { set; get; }

        ///<summary>
        ///
        ///</summary>
        public string SpecialityId { set; get; }

        private bool _isItemId = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsItemId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ItemId))
                {
                    _isItemId = true;
                }
                else
                {
                    _isItemId = false;
                }
                return _isItemId;
            }
            set { _isItemId = value; }
        }
        private bool _isLsRpType = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsLsRpType
        {
            get
            {
                if (LsRpType > 3)
                {
                    _isLsRpType = true;
                }
                else
                {
                    _isLsRpType = false;
                }
                return _isLsRpType;
            }
            set { _isLsRpType = value; }
        }

        /// <summary>
        /// 
        /// </summary>

        private bool _isNotGUID = false;
          
        private bool _isGUID = false;
         
        private bool _isName = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name))
                {
                    _isName = true;
                }
                return _isName;
            }
            set { _isName = value; }
        }

        private bool _isFrequencyId = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsFrequencyId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FrequencyId))
                {
                    _isFrequencyId = true;
                }
                return _isFrequencyId;
            }
            set { _isFrequencyId = value; }
        }
        private bool _isNotFrequencyId = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNotFrequencyId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FrequencyId))
                {
                    _isNotFrequencyId = true;
                }
                else
                {
                    _isNotFrequencyId = false;
                }
                return _isNotFrequencyId;
            }
            set { _isNotFrequencyId = value; }
        }
        private bool _isNotItemId = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNotItemId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(ItemId))
                {
                    _isNotItemId = true;
                }
                else
                {
                    _isNotItemId = false;
                }
                return _isNotItemId;
            }
            set { _isNotItemId = value; }
        }


        private bool _isChkOperId = false;//

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsChkOperId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ChkOperId))
                    _isChkOperId = true;
                return _isChkOperId;
            }
            set { _isChkOperId = value; }
        }
        private bool _isNotChkOperIdNull = false;//

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNotChkOperIdNull
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(ChkOperId))
                {
                    _isNotChkOperIdNull = true;
                }
                else
                {
                    _isNotChkOperIdNull = false;
                }
                return _isNotChkOperIdNull;
            }
            set { _isNotChkOperIdNull = value; }
        }

        private bool _isCenterMedicineHouse = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsCenterMedicineHouse
        {
            get
            {
                if (LsExecLoc == (int)EnumExecLoc.CenterMedicineHouse)
                {
                    _isCenterMedicineHouse = true;
                }
                else
                {
                    _isCenterMedicineHouse = false;
                }
                return _isCenterMedicineHouse;
            }
            set { _isCenterMedicineHouse = value; }
        }

        public bool _isFSelf = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsSelf
        {
            get
            {
                if (LsExecLoc == (int)EnumExecLoc.Self)
                {
                    _isFSelf = true;
                }
                return _isFSelf;
            }
            set { _isFSelf = value; }
        }
        private bool _isNotOneself = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNotOneself
        {
            get
            {
                if (LsExecLoc != (int)EnumExecLoc.Self)
                {
                    _isNotOneself = true;
                }
                return _isNotOneself;
            }
            set { _isNotOneself = value; }
        }
    }
}
