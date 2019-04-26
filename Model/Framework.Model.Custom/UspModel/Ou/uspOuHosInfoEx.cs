using NLite.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 挂号预约查询（扩展类）
    /// </summary>
    [Serializable]
    public class uspOuHosInfoEx
    {
        public uspOuHosInfoEx()
        {

        }

        //扩展变量
        private string _cardNo;
        private string _mzRegID;
        private string _patID;
        private string _doctorID;
        private string _doctorName;
        private string _patientName;
        private string _bookingTel;
        private string _sex;
        private string _ageString;
        private string _cnBookingPurpose;
        private string _nurseID;
        private string _nurseName;
        private double _currentArrears;
        private bool _isPreReg;
        private bool _isCharge;
        private bool _isInArrears;
        private bool _isWebBinding;
        private string _comments;
        private int _patientStatus;
        private int _bookedPatientStatus;
        private string _operID;
        private string _operName;
        private DateTime _operTime;
        private DateTime _regTime;
        private DateTime _confirmRegTime;
        private string _timeBegin;
        private string _timeEnd;
        private bool _isReturnVisit;
        private bool _isHideIllness;
        private string _adiviseID;
        private string _adiviseName;
        private string _diagRoomId;
        private string _diagRoomName;
        private int _patNo;
        private bool _isVoice;
        private string _healthCounselorId;
        private string _content;
        private string _longTime;
        private bool _isActive;


        #region 扩展属性

        /// <summary>
        /// 病人卡号
        /// </summary>
        public string CardNo
        {
            get
            {
                return this._cardNo;
            }
            set
            {
                this._cardNo = value;
            }
        }

        /// <summary>
        /// 病人序号
        /// </summary>
        public int PatNo
        {
            get
            {
                return this._patNo;
            }
            set
            {
                this._patNo = value;
            }
        }

        /// <summary>
        /// 就诊ID
        /// </summary>
        public string MzRegID
        {
            get
            {
                return this._mzRegID;
            }
            set
            {
                this._mzRegID = value;
            }
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID
        {
            get
            {
                return this._patID;
            }
            set
            {
                this._patID = value;
            }
        }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorID
        {
            get
            {
                return this._doctorID;
            }
            set
            {
                this._doctorID = value;

            }
        }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName
        {
            get
            {
                return this._doctorName;
            }
            set
            {
                this._doctorName = value;

            }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName
        {
            get
            {
                return this._patientName;
            }
            set
            {
                this._patientName = value;

            }
        }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string BookingTel
        {
            get
            {
                return this._bookingTel;
            }
            set
            {
                this._bookingTel = value;

            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get
            {
                return this._sex;
            }
            set
            {
                this._sex = value;

            }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        public string AgeString
        {
            get
            {
                return this._ageString;
            }
            set
            {
                this._ageString = value;

            }
        }

        /// <summary>
        /// 就诊目的
        /// </summary>
        public string CnBookingPurpose
        {
            get
            {
                return this._cnBookingPurpose;
            }
            set
            {
                this._cnBookingPurpose = value;

            }
        }

        /// <summary>
        /// 护士ID
        /// </summary>
        public string NurseID
        {
            get
            {
                return this._nurseID;
            }
            set
            {
                this._nurseID = value;

            }
        }

        /// <summary>
        /// 护士名称
        /// </summary>
        public string NurseName
        {
            get
            {
                return this._nurseName;
            }
            set
            {
                this._nurseName = value;

            }
        }

        /// <summary>
        /// 健康顾问ID
        /// </summary>
        public string AdiviseID
        {
            get
            {
                return this._adiviseID;
            }
            set
            {
                this._adiviseID = value;

            }
        }

        /// <summary>
        /// 健康顾问名称
        /// </summary>
        public string AdiviseName
        {
            get
            {
                return this._adiviseName;
            }
            set
            {
                this._adiviseName = value;

            }
        }

        /// <summary>
        /// 欠费金额
        /// </summary>
        public double CurrentArrears
        {
            get
            {
                return this._currentArrears;
            }
            set
            {
                this._currentArrears = value;

            }
        }

        /// <summary>
        /// 是否预约
        /// </summary>
        public bool IsPreReg
        {
            get
            {
                return this._isPreReg;
            }
            set
            {
                this._isPreReg = value;

            }
        }

        /// <summary>
        /// 是否收费
        /// </summary>
        public bool IsCharge
        {
            get
            {
                return this._isCharge;
            }
            set
            {
                this._isCharge = value;

            }
        }

        /// <summary>
        /// 是否欠费
        /// </summary>
        public bool IsInArrears
        {
            get
            {
                return this._isInArrears;
            }
            set
            {
                this._isInArrears = value;

            }
        }
        

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments
        {
            get
            {
                return this._comments;
            }
            set
            {
                this._comments = value;

            }
        }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

        /// <summary>
        /// 0候诊 1预约 2复诊 3已收费 4已诊 
        /// </summary>
        public int PatientStatus
        {
            get
            {
                return this._patientStatus;
            }
            set
            {
                this._patientStatus = value;

            }
        }

        /// <summary>
        /// 预约病人当前状态 ： 0 默认 1 到达 2过期  3预约
        /// </summary>
        public int BookedPatientStatus
        {
            get
            {
                return this._bookedPatientStatus;
            }
            set
            {
                this._bookedPatientStatus = value; 
            }
        }

        /// <summary>
        /// 预约确认日期（最小值时为未确认）
        /// </summary>
        public DateTime ConfirmRegTime
        {
            get
            {
                return this._confirmRegTime;
            }
            set
            {
                this._confirmRegTime = value;
            }
        }

        /// <summary>
        /// 预约(挂号)时间
        /// </summary>
        public DateTime RegTime
        {
            get
            {
                return this._regTime;
            }
            set
            {
                this._regTime = value;
            }
        }

        /// <summary>
        /// 开始时段
        /// </summary>
        public string TimeBegin
        {
            get
            {
                return this._timeBegin;
            }
            set
            {
                this._timeBegin = value;

            }
        }

        /// <summary>
        /// 结束时段
        /// </summary>
        public string TimeEnd
        {
            get
            {
                return this._timeEnd;
            }
            set
            {
                this._timeEnd = value;

            }
        }

        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OperID
        {
            get
            {
                return this._operID;
            }
            set
            {
                this._operID = value;

            }
        }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OperName
        {
            get
            {
                return this._operName;
            }
            set
            {
                this._operName = value;

            }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get
            {
                return this._operTime;
            }
            set
            {
                this._operTime = value;

            }
        }

        /// <summary>
        /// 是否微信关注
        /// </summary>
        public bool IsWebBinding
        {
            get
            {
                return this._isWebBinding;
            }
            set
            {
                this._isWebBinding = value;

            }
        }

        /// <summary>
        /// 是否复诊
        /// </summary>
        public bool IsReturnVisit
        {
            get
            {
                return this._isReturnVisit;
            }
            set
            {
                this._isReturnVisit = value;

            }
        }

        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return this._isHideIllness; }
            set { this._isHideIllness = value; }
        }//_diagRoomId
        /// <summary>
        /// 诊室ID
        /// </summary>
        public string DiagRoomId
        {
            get { return this._diagRoomId; }
            set { this._diagRoomId = value; }
        }
        /// <summary>
        /// 诊室名称
        /// </summary>
        public string DiagRoomName
        {
            get { return this._diagRoomName; }
            set { this._diagRoomName = value; }
        }
        /// <summary>
        /// 是否被叫号
        /// </summary>
        public bool IsVoice
        {
            get { return _isVoice; }
            set { _isVoice = value; }
        }

        /// <summary>
        /// 我的日程内容
        /// </summary>
        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
            }
        }

        /// <summary>
        /// 我的日程ID
        /// </summary>
        public string HealthCounselorId
        {
            get
            {
                return _healthCounselorId;
            }

            set
            {
                _healthCounselorId = value;
            }
        }

        /// <summary>
        /// 时间段
        /// </summary>
        public string LongTime
        {
            get { return this._longTime; }
            set { this._longTime = value; }
        }

        public DateTime QueryTime { get; set; }

        public int QuerySpanSeconds { get; set; }
        #endregion
    }
}
