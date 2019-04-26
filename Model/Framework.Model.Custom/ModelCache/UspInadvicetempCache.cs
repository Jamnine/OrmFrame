using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class UspInadvicetempCache : BaseModel
    { 
        private DateTime _adviceTime;
        private string _doctorId;
        private string _code = String.Empty;
        private string _locationId;
        private string _hospId;
        private int _groupNum;
        private string _itemId;
        private double _dosage;
        private string _unitTakeId;
        private string _frequencyId;
        private string _usageId;
        private double _priceIn;
        private double _totality;
        private double _amount;
        private string _unitInId;
        private bool _isUrgent;
        private bool _isAttach;
        private bool _isSelf;
        private int _lsSpecialUsage;
        private int _lsExecLoc;
        private bool _isSkin;
        private DateTime _skinTime;
        private string _skinTest = String.Empty;
        private DateTime _operTime;
        private string _operId;
        private bool _isPrinted;
        private bool _isOtherFee;
        private bool _isChk;
        private DateTime _chkOperTime;
        private string _chkOperId;
        private bool _isAuth;
        private DateTime _authOperTime;
        private string _authOperId;
        private bool _isAuthFee;
        private DateTime _authFeeOperTime;
        private string _authFeeOperId;
        private bool _isCancel;
        private DateTime _cancelOperTime;
        private string _cancelOperId;
        private string _memo = " ";
        private string _ybType = String.Empty;
        private string _adviceTempMemo = String.Empty;
        private string _name = String.Empty;
        private string _spec = String.Empty;
        private string _formId;
        private int _lsRpType;
        private bool _isInject;
        private int _sn;
        private string _applyId;
        private string _execLocId;
        private string _execDoctorId;
        private bool _isYbxj;
        private string _colours = String.Empty;
        private string _limitTotalZy = String.Empty;
        private double _disCountPrice;
        private double _childPrice;
        private string _sourceId;
        private string _opsApplyId;

        #region XyPis
        private int _days;

        /// <summary>  
        /// 天数  
        /// </summary>  
        public int Days
        {
            get { return _days; }
            set { _days = value; }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public UspInadvicetempCache()
        {
        } 
        /// <summary>  
        ///   
        /// </summary>  
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
        public string Code
        {
            get { return _code; }
            set { _code = value; }
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
        public double PriceIn
        {
            get { return _priceIn; }
            set { _priceIn = value; }
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
        public bool IsUrgent
        {
            get { return _isUrgent; }
            set { _isUrgent = value; }
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
        public bool IsSkin
        {
            get { return _isSkin; }
            set { _isSkin = value; }
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
        public string SkinTest
        {
            get { return _skinTest; }
            set { _skinTest = value; }
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
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
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
        public bool IsOtherFee
        {
            get { return _isOtherFee; }
            set { _isOtherFee = value; }
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
        public bool IsAuthFee
        {
            get { return _isAuthFee; }
            set { _isAuthFee = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public DateTime AuthFeeOperTime
        {
            get { return _authFeeOperTime; }
            set { _authFeeOperTime = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string AuthFeeOperId
        {
            get { return _authFeeOperId; }
            set { _authFeeOperId = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public bool IsCancel
        {
            get { return _isCancel; }
            set { _isCancel = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public DateTime CancelOperTime
        {
            get { return _cancelOperTime; }
            set { _cancelOperTime = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string CancelOperId
        {
            get { return _cancelOperId; }
            set { _cancelOperId = value; }
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
        public string YbType
        {
            get { return _ybType; }
            set { _ybType = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string AdviceTempMemo
        {
            get { return _adviceTempMemo; }
            set { _adviceTempMemo = value; }
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
        public string ApplyId
        {
            get { return _applyId; }
            set { _applyId = value; }
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
        public string Colours
        {
            get { return _colours; }
            set { _colours = value; }
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
        public double DisCountPrice
        {
            get { return _disCountPrice; }
            set { _disCountPrice = value; }
        }


        /// <summary>  
        ///   
        /// </summary>  
        public double ChildPrice
        {
            get { return _childPrice; }
            set { _childPrice = value; }
        }

        /// <summary>  
        ///   标本类型ID
        /// </summary>  
        public string SourceId
        {
            get { return _sourceId; }
            set { _sourceId = value; }
        }

        /// <summary>  
        /// 手术申请ID  
        /// </summary>  
        public string OpsApplyId
        {
            get { return _opsApplyId; }
            set { _opsApplyId = value; }
        } 
         
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
       
        private bool _isNotChkOperIdNull = false;

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
        private bool _isChkOperIdNull = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsChkOperIdNull
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ChkOperId))
                {
                    _isChkOperIdNull = true;
                }
                else
                {
                    _isChkOperIdNull = false;
                }
                return _isChkOperIdNull;
            }
            set { _isChkOperIdNull = value; }
        }
        private bool _isNotDoctorID = false;
        private bool _isNotName = false;

        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNotName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    _isNotName = true;
                }
                else
                {
                    _isNotName = false;
                }
                return _isNotName;
            }
            set { _isNotName = value; }
        }
        private bool _isNotApplyIdNull = false;
        public bool u_IsNotApplyIdNull
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(ApplyId))
                {
                    _isNotApplyIdNull = true;
                }
                else
                {
                    _isNotApplyIdNull = false;
                }
                return _isNotApplyIdNull;
            }
            set { _isNotApplyIdNull = value; }
        }
        /// <summary>
        /// 
        /// </summary>
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
        public DateTime Skstringime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Skstringest { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsPrstringed { set; get; }


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
        public string ExeclocId { set; get; }



        ///<summary>
        ///
        ///</summary>
        public DateTime InsertTime { set; get; }


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
        public string ExecDoc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ApplyNo { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int PsapplyType { set; get; }

        private bool _isMinValueChkOperTime = false;//
        public bool u_IsMinValueChkOperTime
        {
            get
            {
                if (ChkOperTime == DateTime.MinValue)
                {
                    _isMinValueChkOperTime = true;
                }
                else
                {
                    _isMinValueChkOperTime = false;
                }
                return _isMinValueChkOperTime;
            }
            set { _isMinValueChkOperTime = value; }
        }

    }
}
