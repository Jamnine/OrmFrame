

using System;
namespace Orm.Model
{
    /// <summary>
    /// 门诊病人挂号信息表 - 实体类
    /// </summary>
    [Serializable]
    public partial class OuHosInfo : BaseModel
    {
        private string _mzRegNo;  //门诊流水号

        private DateTime _regTime;  //挂号时ZjSummary间

        private string _patId;  //病人ID，对应于Patient的Pat_Id

        private string _cardNo;  //卡号

        private string _name;  //病人姓名

        private string _sex;  //性别

        private bool _isBaby;  //是否婴儿

        private int _ageDay;  //年龄日，用于婴儿

        private double _height;  //身高

        private double _weight;  //体重

        private string _patTypeId;  //病人类别

        private string _medicareNo;  //医疗证号/医保号

        private string _regTypeId;  //挂号类别

        private bool _isPriority;  //优先：1-优先；0-普通

        private bool _isElder;  //是否老人优先

        private int _lineOrder;  //排名

        private double _regFee;  //挂号费

        private double _zyFee;  //病历工本费

        private double _diagnoFee;  //诊金

        private double _otherFee1;  //其他费用1

        private double _otherFee2;  //其他费用2

        private double _paySel;  //记账诊金的自付比例

        private double _tallyDiag;  //记账诊金

        private double _factGet;  //挂号自付费用

        private string _regDept;  //挂号科室

        private string _diagnDept ="";  //接诊科室

        private string _doctorId;  //医生代码

        private string _roomNo;  //房间号

        private bool _isFreeDiag;  //是否免诊金

        private bool _isFreeReg;  //是否免挂号费

        private bool _isInPatient;  //是否住院病人

        private bool _isPreReg;  //是否为预约号（0不是，1是）

        private DateTime _operTime;  //挂号发生的时间

        private string _operId;  //挂号员

        private bool _isCancel;  //是否注销

        private DateTime _cancelTime;  //退号时间

        private string _cancelOperId;  //退号操作员

        private string _cancelMemo;  //退号备注

        private string _timeSpanId;  //班次ID

        private string _regDate;  //

        private int _age;  //年龄岁

        private string _ageString;  //年龄描述

        private string _contactPhone;  //联系电话

        private string _linkmanName;  //联系人

        private DateTime _tallyTime;  //结账时间

        private DateTime _cancelTallyTime;  //作废结账时间

        private string _timeSpanSubId;  //预约时段

        private string _diagRoomId;  //诊室对应BsDiagRoom.id

        private string _callDoctorId;  //叫号医生

        private int _callOrder;  //叫号顺序

        private bool _isFirstCheck;  //是否首诊

        private bool _isGoodRecipe;  //健康教育处方

        private string _goodRecipe;  //健康教育处方

        private bool _isRegist;  //

        private string _diagnose;  //诊断

        private string _preRegRegWay;  //预约挂号方式

        private bool _isRegister;  //是否报到

        private bool _isRegistration;  //是否临挂

        private string _ybSeqNo;  //医保流水号

        private bool _isTransfer;  //是否已经转诊

        private string _interfaceNo;  //体检单号;接口号，做接口时保存第三方唯一标识

        private bool _isAuthed;  //已经封存，不可改删

        private bool _isVoice;  //行心云:是否被叫号

        private string _adviserID;  //行心云:健康顾问

        private DateTime _zjOperTime;  //行心云:总检时间

        private bool _isTj;  //行心云:是否体检

        private string _zjDoctorID;  //行心云:总检医生

        private DateTime _hideOperTime;  //行心云:隐藏时间

        private string _hideOperID;  //行心云:隐藏操作人ID

        private bool _isHide;  //行心云: 是否屏蔽

        private string _wbCode;  //行心云:五笔码

        private string _pyCode;  //行心云:拼音码

        private string _visitContent;  //行心云:复诊内容

        private string _lastOuHosInfoId;  //行心云:上次就诊ID

        private string _nurseID;  //行心云:护士ID

        private bool _isCharge;  //行心云:是否已费

        private double _isNotify;  //行心云:是否短信通知（用于预约）

        private string _introducer;  //行心云:介绍人

        private string _bHOSName;  //行心云:机器名

        private string _diagPosition;  //行心云:牙床号

        private int _adviserStatus;  //行心云:健康顾问状态:1:已预约 2:已到达 3:已就诊 4:已收费 5:已发药 6:本次治疗已结束

        private string _consultID;  //行心云:咨询师id

        private string _cnBookingPurpose;  //行心云: 就诊目的中文（格式如：洁牙，拔牙，种植）

        private string _memo;  //行心云:备注

        private string _referralOuHosInfoId;  //行心云:转诊Id  就是上次就诊的ID

        private string _preventingSuggestion;  //行心云:防治建议

        private string _totalDiagnosis;  //行心云:体检诊断

        private string _zjSummary;  //行心云:总检小结

        private string _idCardNo;  //身份证

        private bool _lsDiagType;  //诊断类别：1-初诊；2-复诊;3-疑诊；4-急性发作

        private string _firstDoctorID;  //首诊医生，就是当天第一个看病的医生

        private string _specialistID;  //专家ID

        private int _HospitalID;  //

        private int _hisType;//HisType 产品类型：0 共享 1 His 2 行心云 3养老1 2 3表示某种系统独有

        private string _doctorName; //医生名称

        public bool isVip;

        private bool _isReturnVisit;  //是否复诊：0 初诊 1复诊

        private string _accompanyingDoctor; //陪诊人

        private string _refErral;
        /// <summary>
        /// 转诊相关标志信息
        /// </summary>
        public string RefErral
        {
            get { return _refErral; }
            set { _refErral = value; }
        }
        /// <summary>
        /// 陪诊人
        /// </summary>
        public string AccompanyingDoctor
        {
            get { return _accompanyingDoctor; }
            set { _accompanyingDoctor = value; }
        }
        /// <summary>
        /// 是否复诊：0 初诊 1复诊
        /// </summary> 
        public bool IsReturnVisit
        {
            get { return _isReturnVisit; }
            set { _isReturnVisit = value; }
        } 
        /// <summary>
        /// 是否会员
        /// </summary>

        public bool IsVip
        {
            get { return isVip; }
            set { isVip = value; }
        }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }

        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegNo
        {
            get { return _mzRegNo; }
            set { _mzRegNo = value; }
        }

        /// <summary>
        /// 挂号时间
        /// </summary>
        public DateTime RegTime
        {
            get { return _regTime; }
            set { _regTime = value; }
        }

        /// <summary>
        /// 
        /// 病人ID，对应于Patient的Pat_Id
        /// </summary>
        public string PatId
        {
            get { return _patId; }
            set { _patId = value; }
        }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// 是否婴儿
        /// </summary>
        public bool IsBaby
        {
            get { return _isBaby; }
            set { _isBaby = value; }
        }

        /// <summary>
        /// 年龄日，用于婴儿
        /// </summary>
        public int AgeDay
        {
            get { return _ageDay; }
            set { _ageDay = value; }
        }

        /// <summary>
        /// 身高
        /// </summary>
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// 体重
        /// </summary>
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        /// <summary>
        /// 病人类别
        /// </summary>
        public string PatTypeId
        {
            get { return _patTypeId; }
            set { _patTypeId = value; }
        }

        /// <summary>
        /// 医疗证号/医保号
        /// </summary>
        public string MedicareNo
        {
            get { return _medicareNo; }
            set { _medicareNo = value; }
        }

        /// <summary>
        /// 挂号类别
        /// </summary>
        public string RegTypeId
        {
            get { return _regTypeId; }
            set { _regTypeId = value; }
        }

        /// <summary>
        /// 优先：1-优先；0-普通
        /// </summary>
        public bool IsPriority
        {
            get { return _isPriority; }
            set { _isPriority = value; }
        }

        /// <summary>
        /// 是否老人优先
        /// </summary>
        public bool IsElder
        {
            get { return _isElder; }
            set { _isElder = value; }
        }

        /// <summary>
        /// 排名
        /// </summary>
        public int LineOrder
        {
            get { return _lineOrder; }
            set { _lineOrder = value; }
        }

        /// <summary>
        /// 挂号费
        /// </summary>
        public double RegFee
        {
            get { return _regFee; }
            set { _regFee = value; }
        }

        /// <summary>
        /// 病历工本费
        /// </summary>
        public double ZyFee
        {
            get { return _zyFee; }
            set { _zyFee = value; }
        }

        /// <summary>
        /// 诊金
        /// </summary>
        public double DiagnoFee
        {
            get { return _diagnoFee; }
            set { _diagnoFee = value; }
        }

        /// <summary>
        /// 其他费用1
        /// </summary>
        public double OtherFee1
        {
            get { return _otherFee1; }
            set { _otherFee1 = value; }
        }

        /// <summary>
        /// 其他费用2
        /// </summary>
        public double OtherFee2
        {
            get { return _otherFee2; }
            set { _otherFee2 = value; }
        }

        /// <summary>
        /// 记账诊金的自付比例
        /// </summary>
        public double PaySel
        {
            get { return _paySel; }
            set { _paySel = value; }
        }

        /// <summary>
        /// 记账诊金
        /// </summary>
        public double TallyDiag
        {
            get { return _tallyDiag; }
            set { _tallyDiag = value; }
        }

        /// <summary>
        /// 挂号自付费用
        /// </summary>
        public double FactGet
        {
            get { return _factGet; }
            set { _factGet = value; }
        }

        /// <summary>
        /// 挂号科室
        /// </summary>
        public string RegDept
        {
            get { return _regDept; }
            set { _regDept = value; }
        }

        /// <summary>
        /// 接诊科室   科室iD
        /// </summary>
        public string DiagnDept
        {
            get { return _diagnDept; }
            set { _diagnDept = value; }
        }

        /// <summary>
        /// 医生代码
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 房间号
        /// </summary>
        public string RoomNo
        {
            get { return _roomNo; }
            set { _roomNo = value; }
        }

        /// <summary>
        /// 是否免诊金
        /// </summary>
        public bool IsFreeDiag
        {
            get { return _isFreeDiag; }
            set { _isFreeDiag = value; }
        }

        /// <summary>
        /// 是否免挂号费
        /// </summary>
        public bool IsFreeReg
        {
            get { return _isFreeReg; }
            set { _isFreeReg = value; }
        }

        /// <summary>
        /// 是否住院病人
        /// </summary>
        public bool IsInPatient
        {
            get { return _isInPatient; }
            set { _isInPatient = value; }
        }

        /// <summary>
        /// 是否为预约号（0不是，1是）
        /// </summary>
        public bool IsPreReg
        {
            get { return _isPreReg; }
            set { _isPreReg = value; }
        }

        /// <summary>
        /// 挂号发生的时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 挂号员
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 是否注销
        /// </summary>
        public bool IsCancel
        {
            get { return _isCancel; }
            set { _isCancel = value; }
        }

        /// <summary>
        /// 退号时间
        /// </summary>
        public DateTime CancelTime
        {
            get { return _cancelTime; }
            set { _cancelTime = value; }
        }

        /// <summary>
        /// 退号操作员
        /// </summary>
        public string CancelOperId
        {
            get { return _cancelOperId; }
            set { _cancelOperId = value; }
        }

        /// <summary>
        /// 退号备注
        /// </summary>
        public string CancelMemo
        {
            get { return _cancelMemo; }
            set { _cancelMemo = value; }
        }

        /// <summary>
        /// 班次ID
        /// </summary>
        public string TimeSpanId
        {
            get { return _timeSpanId; }
            set { _timeSpanId = value; }
        }

        /// <summary>
        /// 注册时间
        /// </summary>
        public string RegDate
        {
            get { return _regDate; }
            set { _regDate = value; }
        }

        /// <summary>
        /// 年龄岁
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// 年龄描述
        /// </summary>
        public string AgeString
        {
            get { return _ageString; }
            set { _ageString = value; }
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactPhone
        {
            get { return _contactPhone; }
            set { _contactPhone = value; }
        }

        /// <summary>
        /// 联系人
        /// </summary>
        public string LinkmanName
        {
            get { return _linkmanName; }
            set { _linkmanName = value; }
        }

        /// <summary>
        /// 结账时间
        /// </summary>
        public DateTime TallyTime
        {
            get { return _tallyTime; }
            set { _tallyTime = value; }
        }

        /// <summary>
        /// 作废结账时间
        /// </summary>
        public DateTime CancelTallyTime
        {
            get { return _cancelTallyTime; }
            set { _cancelTallyTime = value; }
        }

        /// <summary>
        /// 预约时段
        /// </summary>
        public string TimeSpanSubId
        {
            get { return _timeSpanSubId; }
            set { _timeSpanSubId = value; }
        }

        /// <summary>
        /// 诊室对应BsDiagRoom.id
        /// </summary>
        public string DiagRoomId
        {
            get { return _diagRoomId; }
            set { _diagRoomId = value; }
        }

        /// <summary>
        /// 叫号医生
        /// </summary>
        public string CallDoctorId
        {
            get { return _callDoctorId; }
            set { _callDoctorId = value; }
        }

        /// <summary>
        /// 叫号顺序
        /// </summary>
        public int CallOrder
        {
            get { return _callOrder; }
            set { _callOrder = value; }
        }

        /// <summary>
        /// 是否首诊
        /// </summary>
        public bool IsFirstCheck
        {
            get { return _isFirstCheck; }
            set { _isFirstCheck = value; }
        }

        /// <summary>
        /// 健康教育处方
        /// </summary>
        public bool IsGoodRecipe
        {
            get { return _isGoodRecipe; }
            set { _isGoodRecipe = value; }
        }

        /// <summary>
        /// 健康教育处方
        /// </summary>
        public string GoodRecipe
        {
            get { return _goodRecipe; }
            set { _goodRecipe = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsRegist
        {
            get { return _isRegist; }
            set { _isRegist = value; }
        }

        /// <summary>
        /// 诊断
        /// </summary>
        public string Diagnose
        {
            get { return _diagnose; }
            set { _diagnose = value; }
        }

        /// <summary>
        /// 预约挂号方式
        /// </summary>
        public string PreRegRegWay
        {
            get { return _preRegRegWay; }
            set { _preRegRegWay = value; }
        }

        /// <summary>
        /// 是否报到
        /// </summary>
        public bool IsRegister
        {
            get { return _isRegister; }
            set { _isRegister = value; }
        }

        /// <summary>
        /// 是否临挂
        /// </summary>
        public bool IsRegistration
        {
            get { return _isRegistration; }
            set { _isRegistration = value; }
        }

        /// <summary>
        /// 医保流水号
        /// </summary>
        public string YbSeqNo
        {
            get { return _ybSeqNo; }
            set { _ybSeqNo = value; }
        }

        /// <summary>
        /// 是否已经转诊
        /// </summary>
        public bool IsTransfer
        {
            get { return _isTransfer; }
            set { _isTransfer = value; }
        }

        /// <summary>
        /// 体检单号;接口号，做接口时保存第三方唯一标识
        /// </summary>
        public string InterfaceNo
        {
            get { return _interfaceNo; }
            set { _interfaceNo = value; }
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        /// <summary>
        /// 行心云:是否被叫号
        /// </summary>
        public bool IsVoice
        {
            get { return _isVoice; }
            set { _isVoice = value; }
        }

        /// <summary>
        /// 行心云:健康顾问
        /// </summary>
        public string AdviserID
        {
            get { return _adviserID; }
            set { _adviserID = value; }
        }

        /// <summary>
        /// 行心云:总检时间
        /// </summary>
        public DateTime ZjOperTime
        {
            get { return _zjOperTime; }
            set { _zjOperTime = value; }
        }

        /// <summary>
        /// 行心云:是否体检
        /// </summary>
        public bool IsTj
        {
            get { return _isTj; }
            set { _isTj = value; }
        }

        /// <summary>
        /// 行心云:总检医生
        /// </summary>
        public string ZjDoctorID
        {
            get { return _zjDoctorID; }
            set { _zjDoctorID = value; }
        }

        /// <summary>
        /// 行心云:隐藏时间
        /// </summary>
        public DateTime HideOperTime
        {
            get { return _hideOperTime; }
            set { _hideOperTime = value; }
        }

        /// <summary>
        /// 行心云:隐藏操作人ID
        /// </summary>
        public string HideOperID
        {
            get { return _hideOperID; }
            set { _hideOperID = value; }
        }

        /// <summary>
        /// 行心云: 是否屏蔽
        /// </summary>
        public bool IsHide
        {
            get { return _isHide; }
            set { _isHide = value; }
        }

        /// <summary>
        /// 行心云:五笔码
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        /// <summary>
        /// 行心云:拼音码
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 行心云:复诊内容
        /// </summary>
        public string VisitContent
        {
            get { return _visitContent; }
            set { _visitContent = value; }
        }

        /// <summary>
        /// 行心云:上次就诊ID
        /// </summary>
        public string LastOuHosInfoId
        {
            get { return _lastOuHosInfoId; }
            set { _lastOuHosInfoId = value; }
        }

        /// <summary>
        /// 行心云:护士ID
        /// </summary>
        public string NurseID
        {
            get { return _nurseID; }
            set { _nurseID = value; }
        }

        /// <summary>
        /// 行心云:是否已费
        /// </summary>
        public bool IsCharge
        {
            get { return _isCharge; }
            set { _isCharge = value; }
        }

        /// <summary>
        /// 行心云:是否短信通知（用于预约）
        /// </summary>
        public double IsNotify
        {
            get { return _isNotify; }
            set { _isNotify = value; }
        }

        /// <summary>
        /// 行心云:介绍人
        /// </summary>
        public string Introducer
        {
            get { return _introducer; }
            set { _introducer = value; }
        }

        /// <summary>
        /// 行心云:机器名
        /// </summary>
        public string BHOSName
        {
            get { return _bHOSName; }
            set { _bHOSName = value; }
        }

        /// <summary>
        /// 行心云:牙床号
        /// </summary>
        public string DiagPosition
        {
            get { return _diagPosition; }
            set { _diagPosition = value; }
        }

        /// <summary>
        /// 行心云:健康顾问状态:1:已预约 2:已到达 3:已就诊 4:已收费 5:已发药 6:本次治疗已结束
        /// </summary>
        public int AdviserStatus
        {
            get { return _adviserStatus; }
            set { _adviserStatus = value; }
        }

        /// <summary>
        /// 行心云:咨询师id
        /// </summary>
        public string ConsultID
        {
            get { return _consultID; }
            set { _consultID = value; }
        }

        /// <summary>
        /// 行心云: 就诊目的中文（格式如：洁牙，拔牙，种植）
        /// </summary>
        public string CnBookingPurpose
        {
            get { return _cnBookingPurpose; }
            set { _cnBookingPurpose = value; }
        }

        /// <summary>
        /// 行心云:备注 Memo Comments
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 行心云:转诊Id  就是上次就诊的ID
        /// </summary>
        public string ReferralOuHosInfoId
        {
            get { return _referralOuHosInfoId; }
            set { _referralOuHosInfoId = value; }
        }

        /// <summary>
        /// 行心云:防治建议
        /// </summary>
        public string PreventingSuggestion
        {
            get { return _preventingSuggestion; }
            set { _preventingSuggestion = value; }
        }

        /// <summary>
        /// 行心云:体检诊断
        /// </summary>
        public string TotalDiagnosis
        {
            get { return _totalDiagnosis; }
            set { _totalDiagnosis = value; }
        }

        /// <summary>
        /// 行心云:总检小结
        /// </summary>
        public string ZjSummary
        {
            get { return _zjSummary; }
            set { _zjSummary = value; }
        }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IdCardNo
        {
            get { return _idCardNo; }
            set { _idCardNo = value; }
        }

        /// <summary>
        /// 诊断类别：1-初诊；2-复诊;
        /// </summary>
        public bool LsDiagType
        {
            get { return _lsDiagType; }
            set { _lsDiagType = value; }
        }

        /// <summary>
        /// 首诊医生，就是当天第一个看病的医生
        /// </summary>
        public string FirstDoctorID
        {
            get { return _firstDoctorID; }
            set { _firstDoctorID = value; }
        }


        /// <summary>
        /// 指导专家ID.引用BsSpecialist.GUID
        /// </summary>
        public string SpecialistID
        {
            get { return _specialistID; }
            set { this._specialistID = value; }
        }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string BookingTel { get; set; }
        public bool IsTjOver { get; set; }      /// <summary>
                                                /// HisType 产品类型：0 共享 1 His 2 行心云 3养老1 2 3表示某种系统独有
                                                /// </summary>
        public int HisType
        {
            get
            {
                return this._hisType;
            }
            set
            {
                this._hisType = value;
            }
        }
        private  bool _isBookingTel = false;
        public  bool u_IsBookingTel
        {
            get
            {
                if (string.IsNullOrWhiteSpace(BookingTel))
                {
                    _isBookingTel = true;
                }
                else
                {
                    _isBookingTel = false;
                }
                return _isBookingTel;
            }
            set { _isBookingTel = value; }
        }
        private bool _isBookingTelNull = false;
        public bool u_IsBookingTelNull
        {
            get
            {
                if (BookingTel == null)
                {
                    _isBookingTelNull = true;
                }
                else
                {
                    _isBookingTelNull = false;
                }
                return _isBookingTelNull;
            }
            set { _isBookingTelNull = value; }
        }
        private bool _isDoctorId = false;
        public bool u_IsDoctorId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(DoctorId))
                {
                    _isDoctorId = true;
                }
                else
                {
                    _isDoctorId = false;
                }
                return _isDoctorId;
            }
            set { _isDoctorId = value; }
        }
        private bool _isNotDoctorId = false;
        public bool u_IsNotDoctorId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(DoctorId))
                {
                    _isNotDoctorId = true;
                }
                else
                {
                    _isNotDoctorId = false;
                }
                return _isNotDoctorId;
            }
            set { _isNotDoctorId = value; }
        }
    }
}


