using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人（就诊、基本）信息详情
    /// </summary>
    [Serializable]
    public class uspHisOuPatientQry : BaseModel
    {
        private string _mzRegNo = String.Empty;
        private string _idCardNo = String.Empty;
        private string _patientName = String.Empty;
        private string _patId;
        private string _cardNo = String.Empty;
        private string _sex = String.Empty;
        private DateTime _birthDate;
        private int _age;
        private DateTime _regTime;
        private string _regTypeId;
        private string _regTypeName = String.Empty;
        private string _nurseId;
        private string _doctorId;
        private string _regDept;
        private string _locationName = String.Empty;
        private string _diagnDept;
        private bool _isCancel;
        private string _doctorCode = String.Empty;
        private string _locationCode = String.Empty;
        private string _doctorName = String.Empty;
        private string _patTypeId;
        private string _patTypeName = String.Empty;
        private string _tallyTypeId;
        private string _tallyTypeName = String.Empty;
        private string _tallyGroupName = String.Empty;
        private string _getTallyType = String.Empty;
        private string _getTallyTypeName = String.Empty;
        private double _arrearAmount;
        private string _mobile = String.Empty;
        private string _hosId;
        private string _timeSpanId;
        private string _medicareNo = String.Empty;
        private string _MzRegNoOri = String.Empty;
        private string _ageString = String.Empty;
        private string _bookingpurpose;
        private string _comments = string.Empty;
        private DateTime _lastSeeTime;
        private string _pyCode = " ";
        private string _wbCode = " ";
        private string _arrearsTypeId;
        private string _ArrearsTypeName;
        private double _prevArrears;
        private DateTime _checkTime;
        private string _tallyCancelOperName;
        private DateTime _endMenstruationTime;
        private bool _isHideIllness = false;
        private double _accountAmount;
        private string _habit = string.Empty;
        private string _familyHistory = string.Empty;
        private int _adviserStatus = 0;
        private string _nationId;
        private bool _isBaby;
        private int _ageMonth;
        private int _ageDay;
        private double _weight;
        private double _height;
        private int _rowCount;
        private bool _isDiadnosis;
        private string _refErral;
        private string _phoneHome;

        private string _hospitalizationTimes;

        /// <summary>
        /// 最近住院次数，转诊病人
        /// </summary>
        public string HospitalizationTimes
        {
            get { return _hospitalizationTimes; }
            set { _hospitalizationTimes = value; }
        }

        public string PhoneHome
        {
            get { return this._phoneHome; }
            set { this._phoneHome = value; }
        }
        public string RefErral
        {
            get { return this._refErral; }
            set { this._refErral = value; }
        }
        public int Rowcount
        {
            get { return this._rowCount; }
            set { this._rowCount = value; }
        }

        public double _thePrice;
        private string _consultID;
        public uspHisOuPatientQry()
        {
        }
        /// <summary>
        /// 配送地址
        /// </summary>
        public string DistributionAddress { get; set; }
        /// <summary>
        /// 配送时段
        /// </summary>
        public string DistributionPeriod { get; set; }
        /// <summary>
        /// 0 现场取药，1 配送
        /// </summary>
        public int IsTakeMedicine { get; set; }
        private int _isWaitUser;
        public int IsWaitUser { get { return this._isWaitUser; } set { this._isWaitUser = value; } }
        #region Public Properties

        /// <summary>
        /// 就诊目的（编码，格式如1|2|3）
        /// </summary>
        public string BookingPurpose
        {
            get
            {
                return this._bookingpurpose;
            }
            set
            {
                this._bookingpurpose = value;
            }
        }

        /// <summary>
        /// 诊所编码
        /// </summary>
        public string LocationCode
        {
            get { return this._locationCode; }
            set { this._locationCode = value; }
        }

        /// <summary>  
        ///   上一次接诊时间
        /// </summary>  
        public DateTime LastSeeTime
        {
            get { return this._lastSeeTime; }
            set { this._lastSeeTime = value; }
        }

        /// <summary>
        /// 医生编号
        /// </summary>
        public string DoctorCode
        {
            get { return this._doctorCode; }
            set { this._doctorCode = value; }
        }

        /// <summary>
        /// 就诊目的内容
        /// </summary>
        public string CnBookingPurpose
        {
            get;
            set;
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
        /// 门诊流水号

        /// </summary>
        public string MzRegNo
        {
            get {
                return _mzRegNo;
            }
            set {
                _mzRegNo = value;
            }
        }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo
        {
            get { return _idCardNo; }
            set { _idCardNo = value; }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }
        /// <summary>
        /// 病人ID
        /// </summary>
        public string  PatId
        {
            get { return _patId; }
            set { _patId = value; }
        }

        /// <summary>
        /// 病人卡号 
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
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
        /// 出生日期
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        /// <summary>
        /// 年龄字符串
        /// </summary>
        public string AgeString
        {
            get { return _ageString; }
            set { _ageString = value; }
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
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
        /// 挂号类别ID
        /// </summary>
        public string RegTypeId
        {
            get { return _regTypeId; }
            set { _regTypeId = value; }
        }
        /// <summary>
        /// 挂号类别
        /// </summary>
        public string RegTypeName
        {
            get { return _regTypeName; }
            set { _regTypeName = value; }
        }
        /// <summary>
        /// 就诊医生ID
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 挂号可是
        /// </summary>
        public string RegDept
        {
            get { return _regDept; }
            set { _regDept = value; }
        }
        /// <summary>
        /// 诊所
        /// </summary>
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }
        /// <summary>
        /// 接诊科室。外键，引用BsLocation.GUID 
        /// </summary>
        public string DiagnDept
        {
            get { return _diagnDept; }
            set { _diagnDept = value; }
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
        /// 医生名称
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }

        /// <summary>
        /// 病人类别ID 
        /// </summary>
        public string PatTypeId
        {
            get { return _patTypeId; }
            set { _patTypeId = value; }
        }

        /// <summary>
        /// 病人类别
        /// </summary>
        public string PatTypeName
        {
            get { return _patTypeName; }
            set { _patTypeName = value; }
        }

        /// <summary>
        /// 记帐方式ID
        /// </summary>
        public string TallyTypeId
        {
            get { return _tallyTypeId; }
            set { _tallyTypeId = value; }
        }

        /// <summary>
        /// 欠费多少就限制录入费用
        /// </summary>
        public double ArrearAmount
        {
            get { return _arrearAmount; }
            set { _arrearAmount = value; }
        }


        /// <summary>
        /// F1是否挂号处录入 
        /// </summary>
        public bool ISInputBYRegMAN
        { get; set; }


        /// <summary>
        /// 手机号码 
        /// </summary>
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }


        /// <summary>
        /// 就诊id 
        /// </summary>
        public string HosId
        {
            get { return _hosId; }
            set { _hosId = value; }
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
        /// 医疗证号/医保号 
        /// </summary>
        public string MedicareNo
        {
            get { return _medicareNo; }
            set { _medicareNo = value; }
        }

        /// <summary>
        /// 叫号排名 
        /// </summary>
        public int Callorder { get; set; }

        /// <summary>
        /// 是否为预约号（0不是，1是） 
        /// </summary>
        public bool IsPreReg { get; set; }
        public DateTime PreRegTime { get; set; }
        /// <summary>
        /// 发票ID
        /// </summary>
        public string InvoceID { get; set; }
        /// <summary>
        /// 发票编号
        /// </summary>
        public string InvoceNo { get; set; }

        /// <summary>
        /// 处方权(是否医生)
        /// </summary>
        public bool IsRecipe { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 欠款
        /// </summary>
        public double CurrentArrears { get; set; }
        /// <summary>
        /// 发票时间
        /// </summary>
        public DateTime InvoTime { get; set; }

        /// <summary>
        /// 发票时间
        /// </summary>
        public string _InvoTime { get; set; }
        /// <summary>
        /// 收款人
        /// </summary>
        public string InvoOperName { get; set; }

        /// <summary>
        /// 护士名称
        /// </summary>
        public string NurseName { get; set; }

        /// <summary>
        /// 护士ID
        /// </summary>
        public string NurseId
        {
            get { return _nurseId; }
            set { _nurseId = value; }
        }

        /// <summary>
        /// 诊断类别：1-初诊；2-复诊
        /// </summary>
        public bool IsReturnVisit { get; set; }

        /// <summary>
        /// 复诊内容
        /// </summary>
        public string VisitContent { get; set; }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string PyCode
        {
            get
            {
                return this._pyCode;
            }
            set
            {
                this._pyCode = value;
            }
        }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string WbCode
        {
            get
            {
                return this._wbCode;
            }
            set
            {
                this._wbCode = value;
            }
        }

        /// <summary>
        /// 诊断类别：1-初诊；2-复诊;3-疑诊；4-急性发作
        /// </summary>
        public int PatientStatus { get; set; }

        /// <summary>
        /// 是否欠费
        /// </summary>
        public bool IsInArrears { get; set; }

        /// <summary>
        /// 既往史
        /// </summary>
        public string PersonHistory { get; set; }

        /// <summary>
        /// 是否收费
        /// </summary>
        public bool IsCharge { get; set; }

        /// <summary>
        /// 预约开始时间
        /// </summary>
        public string BeginTime { get; set; }

        /// <summary>
        /// 预约结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 预约挂号时间段
        /// </summary>
        public string TimeSpanSubName { get; set; }

        /// <summary>
        /// 预约病人当前状态 ： 0 默认 1 到达 2过期
        /// </summary>
        public int BookedPatientStatus { get; set; }

        /// <summary>
        /// 牙位号
        /// </summary>
        public string DiagPosition { get; set; }
        /// <summary>
        /// 就诊次数
        /// </summary>
        public string DiagTimes { get; set; }

        /// <summary>
        /// 本次费用
        /// </summary>
        public double CurrentPay { get; set; }
        /// <summary>
        /// 实收费用
        /// </summary>
        public double FactPay { get; set; }

        /// <summary>
        /// 就诊时段
        /// </summary>
        public string TimeQuantum { get; set; }

        /// <summary>
        /// 欠费类别Name
        /// </summary>
        public string ArrearsTypeName
        {
            get
            {
                return this._ArrearsTypeName;
            }
            set
            {
                this._ArrearsTypeName = value;
            }
        }

        /// <summary>
        /// 欠费类别id
        /// </summary>
        public string ArrearsTypeId
        {
            get
            {
                return this._arrearsTypeId;
            }
            set
            {
                this._arrearsTypeId = value;
            }
        }

        /// <summary>
        /// 上次欠款 
        /// </summary>
        public double PrevArrears
        {
            get
            {
                return this._prevArrears;
            }
            set
            {
                this._prevArrears = value;
            }
        }

        /// <summary>
        /// 是否会员
        /// </summary>
        public bool IsVip { get; set; }

        /// <summary>
        /// 会员折扣
        /// </summary>
        public double VipDiscount { get; set; }

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VipCardNo
        {
            get;
            set;
        }
        /// <summary>
        /// 会员ID
        /// </summary>
        public string VipCardID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 病情记录
        /// </summary>
        public string Pathography
        {
            get;
            set;
        }
        /// <summary>
        /// 治疗建议ID
        /// </summary>
        public string TreatmentAdvise
        {
            get;
            set;
        }

        private string _sensitive;
        /// <summary>
        /// 过敏史
        /// </summary>
        public string Sensitive
        {
            get
            {
                return this._sensitive;
            }
            set
            {
                this._sensitive = value;
            }
        }

        /// <summary>
        /// 是否完成完成总检
        /// </summary>
        public bool IsTjOver { get; set; }

        /// <summary>
        /// 开了体检项目
        /// </summary>
        public bool IsTj { get; set; }

        /// <summary>
        /// 开了理疗项目
        /// </summary>
        public bool IsLL { get; set; }
        /// <summary>
        /// 是否使用会员价
        /// </summary>
        public bool IsVIPPrice { get; set; }

        #endregion

        /// <summary>
        /// 医生助理
        /// </summary>
        public string DoctorAssistant { get; set; }

        /// <summary>
        /// 主诉 
        /// </summary>
        public string MainInform { get; set; }

        public string PatDespcription { get; set; }
        public string Memo { get; set; }

        /// <summary>  
        ///   结账时间
        /// </summary>  
        public DateTime CheckTime
        {
            get { return this._checkTime; }
            set { this._checkTime = value; }
        }
        /// <summary>
        /// 结账人
        /// </summary>
        public string TallyCancelOperName
        {
            get
            {
                return this._tallyCancelOperName;
            }
            set
            {
                this._tallyCancelOperName = value;
            }
        }

        /// <summary>
        /// 末次月经
        /// </summary>
        public DateTime EndMenstruationTime
        {
            get
            {
                return this._endMenstruationTime == DateTime.MinValue ? DateTime.Now : this._endMenstruationTime;
            }
            set
            {
                this._endMenstruationTime = value;
            }
        }

        /// <summary>
        /// 序号
        /// </summary>
        public int SortNo { get; set; }

        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return this._isHideIllness; }
            set { this._isHideIllness = value; }
        }

        /// <summary>
        /// 记账金额
        /// </summary>
        public double AccountAmount
        {
            get
            {
                return this._accountAmount;
            }
            set
            {
                this._accountAmount = value;
            }
        }
        /// <summary>
        /// 个人史
        /// </summary>
        public string Habit
        {
            get { return this._habit; }
            set { this._habit = value; }
        }

        /// <summary>
        /// 家族史
        /// </summary>
        public string FamilyHistory
        {
            get { return this._familyHistory; }
            set { this._familyHistory = value; }
        }
        /// <summary>
        /// 健康顾问状态: 1:已预约 2:已到达 3:已就诊 4:已收费 5:已发药 6:本次治疗已结束
        /// </summary>
        public int AdviserStatus
        {
            get { return this._adviserStatus; }
            set { this._adviserStatus = value; }
        }
        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsVerify { get; set; }
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsChoose { get; set; }

        /// <summary>
        /// 民族ID
        /// </summary>
        public string NationId
        {
            get
            {
                return _nationId;
            }

            set
            {
                _nationId = value;
            }
        }

        /// <summary>
        /// 家庭地址
        /// </summary>
        public string AddressHome { get; set; }

        /// <summary>
        /// 是否婴儿
        /// </summary>
        public bool IsBaby
        {
            get
            {
                return _isBaby;
            }

            set
            {
                _isBaby = value;
            }
        }

        /// <summary>
        /// 年龄月份
        /// </summary>
        public int AgeMonth
        {
            get
            {
                return _ageMonth;
            }

            set
            {
                _ageMonth = value;
            }
        }

        /// <summary>
        /// 年龄天数
        /// </summary>
        public int AgeDay
        {
            get
            {
                return _ageDay;
            }

            set
            {
                _ageDay = value;
            }
        }

        /// <summary>
        /// 挂号流水号
        /// </summary>
        public string Ghregno { get; set; }

        /// <summary>
        /// 医保挂号流水号
        /// </summary>
        public string YBMzRegid { get; set; }

        /// <summary>
        /// 单据流水号
        /// </summary>
        public string DJRegid { get; set; }

        /// <summary>
        /// 医保金额
        /// </summary>
        public double MedicalAmount { get; set; }
        /// <summary>
        /// 挂号费用
        /// </summary>
        public double RegFee { get; set; }
        /// <summary>
        /// 所属科室ID
        /// </summary>
        public string DepartmentID { get; set; }
        public int RegionId { get; set; }
        #region 昆山
        /// <summary>
        /// 是否结合网络
        /// </summary>
        public bool IsWebBinding { get; set; }
        /// <summary>
        /// 今日总费用
        /// </summary>
        public double AmoutFactPay { get; set; }
        
        /// <summary>
        /// 划价金额
        /// </summary>
        public double PatPricereCord { get; set; }

        public string ConsultDocName { get; set; }
        /// <summary>
        /// 划价记录ID
        /// </summary>
        public int patPricereCordId { get; set; }

        /// <summary>
        /// 划价金额
        /// </summary>
        public double ThePrice
        {
            get { return this._thePrice; }
            set { this._thePrice = value; }
        }
        /// <summary>
        /// 咨询师id
        /// 就是助理id
        /// </summary>
        public string ConsultID
        {
            get { return _consultID; }
            set { _consultID = value; }
        }
        /// <summary>
        /// 咨询师姓名
        /// </summary>
        public string ConsultName { get; set; }
        #endregion

        #region 薄厚
        /// <summary>
        /// 重量
        /// </summary>
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        /// <summary>
        /// 高度
        /// </summary>
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public bool IsClose { get; set; }
        public int HospitalId { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsLocationDiagSee { get; set; }
        public bool IsPriority { get; set; }
        public int LineOrder { get; set; }
        public string RegLocation { get; set; }
        public string SpecialityId { get; set; }
        public bool Istally { get; set; }
        public string ConsultDetail { get; set; }

        public bool IsDiadnosis { get; set; }

        

        #endregion

        /// <summary>
        /// 专家ID
        /// </summary>
        public int SpecialistID { get; set; }
        private bool _isNurseId = false;
        public bool u_IsNurseId
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(NurseId))
                {
                    _isNurseId = true;
                }
                else
                {
                    _isNurseId = false;
                }
                return _isNurseId;
            }
            set { _isNurseId = value; }
        }
    }
}







