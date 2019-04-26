using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 处方明细
    /// </summary>
    [Serializable]
    public class UspOuRecipeDtl : BaseModel
    {
        /// <summary>
        /// 处方明细
        /// </summary>
        public UspOuRecipeDtl()
        { }

        private string _name = string.Empty;
        private string _code = string.Empty;
        private string _itemID = string.Empty;
        private string _unitDiag = string.Empty;
        private string _unitDiagID = string.Empty;
        private double _priceDiag = 0;
        private double _amount = 0;
        private int _duration = 0;
        private double _totality = 0;
        private double _discDiag = 0;
        private string _recipeId = string.Empty;
        private string _recipeDtlId = string.Empty;
        private int _groupNum = 0;
        private string _memo = string.Empty;
        private string _memoOperID = string.Empty;
        private bool _isOtherFee = false;
        private bool _isDiscounts = false;
        private bool _canModify = true;
        private string _comboName = "非套餐";
        private string _tjLocationID = string.Empty;
        private string _tjLocationName = string.Empty;
        private string _patname = string.Empty;
        private string _sex = string.Empty;
        private string _age = string.Empty;
        private string _vipCardNo = string.Empty;
        private string _vipLevel = string.Empty;
        private DateTime _inputTime = DateTime.MinValue;
        private string _recipeNum = string.Empty;
        private string _frequencyId;
        private string _frequencyName = "";
        private bool _isRed = false;
        private string _usageId;
        private string _usageName;
        private int _days;
        private string _doctorID;

        private string _doctorName;
        private string _cardNo = String.Empty;
        private DateTime _birthDate;
        private string _skinTestCondition = "";
        private string _drugFormId = string.Empty;
        private string _dripRates = "";
        private string _cookType;
        private string _beforeWater;
        private string _afterWater;
        private string _drugFormName = string.Empty;
        private int _samlingType = 1;
        private string _itemTypeName;
        private string _sourceId = string.Empty;
        private string _sourceName = string.Empty;
        private string _addMemo = "";
        private bool _isUsageItem = false;
        private bool _isOper;
        private int _clinicNo;

        private bool _isChecked = false;
        private string _typeTokenCode;
        private int _isShow = 1;
        private string _ageString;
        private int _lsRpType;
        private int _listNum;

private string _cureDtlId;

        private int _pageNo;

        private int _allPageNo;        /// <summary>
        /// 是否bp项目 
        /// </summary>
        public bool IsBP { get; set; }

        /// <summary>
        /// 治疗方案单据号/门诊号
        /// </summary>
        public int ClinicNo
        {
            get { return _clinicNo; }
            set { _clinicNo = value; }
        }
        /// <summary>
        /// 项目类型名称
        /// </summary>
        public string ItemTypeName
        {
            get { return this._itemTypeName; }
            set { this._itemTypeName = value; }
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
        /// 出生日期
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime
        {
            get;
            set;
        }


        /// <summary>
        /// 频率。外键，引用BsFrequency.GUID.
        /// </summary>
        public string FrequencyId
        {
            get { return _frequencyId; }
            set { _frequencyId = value; }
        }
        /// <summary>
        /// 频率名称
        /// </summary>
        public string FrequencyName
        {
            get { return _frequencyName; }
            set { _frequencyName = value; }
        }

        /// <summary>
        /// 用法。外键，引用BsUsage.GUID.
        /// </summary>
        public string UsageId
        {
            get { return _usageId; }
            set { _usageId = value; }
        }
        /// <summary>
        /// 用法名称
        /// </summary>
        public string UsageName
        {
            get { return _usageName; }
            set { _usageName = value; }
        }

        /// <summary>
        /// 天数.
        /// </summary>
        public int Days
        {
            get { return _days; }
            set { _days = value; }
        }
        public int HowMany { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitDiag
        {
            get { return _unitDiag; }
            set { _unitDiag = value; }
        }

        /// <summary>
        /// 单位ID
        /// </summary>
        public string UnitDiagID
        {
            get { return _unitDiagID; }
            set { _unitDiagID = value; }
        }

        /// <summary>
        /// 单价
        /// </summary>
        public double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }

        /// <summary>
        /// 金额
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>
        /// 时长
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        /// <summary>
        /// 数量
        /// </summary>
        public double Totality
        {
            get { return _totality; }
            set { _totality = value; }
        }

        /// <summary>
        /// 优惠（%）
        /// </summary>
        public double DiscDiag
        {
            get { return _discDiag; }
            set { _discDiag = value; }
        }

        /// <summary>
        /// 优惠金额
        /// </summary>
        public double AmountDiscount
        {
            get;
            set;
        }

        /// <summary>
        /// 折后金额
        /// </summary>
        public double AmountPay
        {
            get;
            set;
        }

        /// <summary>
        /// 处方ID
        /// </summary>
        public string RecipeId
        {
            get { return _recipeId; }
            set { _recipeId = value; }
        }

        /// <summary>
        /// 处方明细ID
        /// </summary>
        public string RecipeDtlId
        {
            get { return _recipeDtlId; }
            set { _recipeDtlId = value; }
        }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }

            set
            {
                _isChecked = value;
            }
        }

        /// <summary>
        /// 组号.
        /// </summary>
        public int GroupNum
        {
            get { return _groupNum; }
            set { _groupNum = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 备注操作人
        /// </summary>
        public string MemoOperID
        {
            get { return _memoOperID; }
            set { _memoOperID = value; }
        }
        /// <summary>
        /// 是否附加项目.
        /// </summary>
        public bool IsOtherFee
        {
            get { return _isOtherFee; }
            set { _isOtherFee = value; }
        }

        /// <summary>
        /// 能否打折
        /// </summary>
        public bool IsDiscounts
        {
            get { return _isDiscounts; }
            set { _isDiscounts = value; }
        }

        /// <summary>
        /// 能否修改
        /// </summary>
        public bool CanModify
        {
            get { return _canModify; }
            set { _canModify = value; }
        }

        /// <summary>
        /// 套餐名
        /// </summary>
        public string ComboName
        {
            get { return _comboName; }
            set { _comboName = value; }
        }

        /// <summary>
        /// 体检科室
        /// </summary>
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }
        /// <summary>
        /// 体检科室名称
        /// </summary>
        public string TjLocationName
        {
            get { return this._tjLocationName; }
            set { this._tjLocationName = value; }
        }
        private int _lsRepType;
        /// <summary>
        /// 处方种类：1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药
        /// </summary>
        public int LsRepType
        {
            get
            {
                return this._lsRepType;
            }
            set
            {
                this._lsRepType = value;
            }
        }
        /// <summary>
        /// 是否会员消费扣减项目
        /// </summary>
        public bool IsVipDeduction { get; set; }

        /// <summary>
        /// 会员剩余消费次数
        /// </summary>
        public int VipLeftCount { get; set; }

        /// <summary>
        /// 是否收费
        /// </summary>
        public bool IsCharge
        {
            get;
            set;
        }
        /// <summary>
        /// 会员扣减数量
        /// </summary>
        public int VipDeductionCount { get; set; }

        private string _restTime = "";
        /// <summary>
        /// 挂号时间
        /// </summary>
        public string RestTime
        {
            get { return this._restTime; }
            set { this._restTime = value; }
        }


        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool IsStart
        {
            get;
            set;
        }

        private DateTime _completeTime = DateTime.MinValue;
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime CompleteTime
        {
            get { return this._completeTime; }
            set { this._completeTime = value; }
        }

        /// <summary>
        /// 执行人ID
        /// </summary>
        public string ExecOperID
        {
            get;
            set;
        }
        /// <summary>
        /// 执行人名称
        /// </summary>
        public string ExecOpeName
        {
            get;
            set;
        }

        /// <summary>
        /// 是否执行
        /// </summary>
        public bool IsAttach
        {
            get;
            set;
        }
        /// <summary>
        /// 收费类别ID 5521:西药/中成药 5540:检验检查 5400:中药
        /// </summary>
        public string FeeMzId
        {
            get;
            set;
        }

        /// <summary>
        /// 收费类别ID
        /// </summary>
        public string FeeMzName
        {
            get;
            set;
        }

        /// <summary>
        /// 就诊ID
        /// </summary>
        public string MzRegId
        {
            get;
            set;
        }

        /// <summary>
        /// 原价
        /// </summary>
        public double OldPriceDiag
        {
            get;
            set;
        }
        /// <summary>
        /// 会员价
        /// </summary>
        public double VipPriceDiag
        {
            get;
            set;
        }
        /// <summary>
        /// 处方号
        /// </summary>
        public string RecipeNum
        {
            get { return this._recipeNum; }
            set { this._recipeNum = value; }
        }
        /// <summary>
        /// Pat名称
        /// </summary>
        public string PatName
        {
            get { return _patname; }
            set { _patname = value; }
        }
        /// <summary>
        /// Pat性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// 年龄Pat.sex
        /// </summary>
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VipCardNo
        {
            get { return _vipCardNo; }
            set { _vipCardNo = value; }
        }

        /// <summary>
        /// 会员卡等级
        /// </summary>
        public string VipLevel
        {
            get { return _vipLevel; }
            set { _vipLevel = value; }
        }

        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime InputTime
        {
            get { return this._inputTime; }
            set { this._inputTime = value; }
        }

        private string _phone = string.Empty;
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        private string _unitTakeId;
        /// <summary>
        /// 用量单位ID
        /// </summary>
        public string UnitTakeId
        {
            get
            {
                return this._unitTakeId;
            }
            set
            {
                this._unitTakeId = value;
            }
        }
        private string _unitTakeName;
        /// <summary>
        /// 用量单位
        /// </summary>
        public string UnitTakeName
        {
            get
            {
                return this._unitTakeName;
            }
            set
            {
                this._unitTakeName = value;
            }
        }

        private double _dosage;
        /// <summary>
        /// 用量.
        /// </summary>
        public double Dosage
        {
            get
            {
                return this._dosage;
            }
            set
            {
                this._dosage = value;
                if (_drugFormName == "针剂")
                    _dosage = Math.Truncate(_dosage);
            }
        }

        /// <summary>
        /// 规格
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 开具医生
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
        /// 开具医生ID
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
        /// 超时时间
        /// </summary>
        public DateTime OverTime { get; set; }
        /// <summary>
        /// 体检项目编码ID
        /// </summary>
        public int TjItemCodeID { get; set; }

        /// <summary>
        /// 计划执行时间 
        /// </summary>
        public DateTime PlanExecuteTime { get; set; }
        /// <summary>
        /// 是否客人执行
        /// </summary>
        public bool IsPatExecute { get; set; }

        /// <summary>
        /// 皮试情况
        /// </summary>
        public string SkinTestCondition
        {
            get { return this._skinTestCondition; }
            set { this._skinTestCondition = value; }
        }

        /// <summary>
        /// 剂型ID
        /// </summary>
        public string DrugFormId
        {
            get { return this._drugFormId; }
            set { this._drugFormId = value; }
        }
        /// <summary>
        /// 剂型
        /// </summary>
        public string DrugFormName
        {
            get
            {
                return this._drugFormName;
            }
            set
            {
                this._drugFormName = value;
            }
        }
        /// <summary>
        /// 滴速
        /// </summary>
        public string DripRates
        {
            get { return this._dripRates; }
            set { this._dripRates = value; }
        }

        /// <summary>
        /// 煮前水量
        /// </summary>
        public string BeforeWater
        {
            get { return this._beforeWater; }
            set { this._beforeWater = value; }
        }
        /// <summary>
        /// 煮后水量
        /// </summary>
        public string AfterWater
        {
            get { return this._afterWater; }
            set { this._afterWater = value; }
        }
        /// <summary>
        /// 煎药方式
        /// </summary>
        public string CookType
        {
            get { return this._cookType; }
            set { this._cookType = value; }
        }
        public bool IsRed
        {
            get { return this._isRed; }
            set { this._isRed = value; }
        }

        private string _specimenCode;
        /// <summary>  
        ///  标本号 
        /// </summary>  
        public string SpecimenCode
        {
            get { return this._specimenCode; }
            set { this._specimenCode = value; }
        }

        /// <summary>
        /// 采样方式
        /// </summary>
        public int SamlingType
        {
            get { return this._samlingType; }
            set { this._samlingType = value; }
        }

        /// <summary>  
        /// 标本类型id 
        /// </summary>  
        public string SourceId
        {
            get { return _sourceId; }
            set { _sourceId = value; }
        }

        /// <summary>
        /// 标本类型Name
        /// </summary>
        public string SourceName
        {
            get { return _sourceName; }
            set { _sourceName = value; }
        }

        /// <summary>
        /// 西药附加费备注
        /// </summary>
        public string AddMemo
        {
            get { return this._addMemo; }
            set { this._addMemo = value; }
        }

        /// <summary>
        /// 是否用法附加项目
        /// </summary>
        public bool IsUsageItem
        {
            get { return this._isUsageItem; }
            set { this._isUsageItem = value; }
        }
        /// <summary>
        /// 是否重新保存
        /// </summary>
        public bool IsOper
        {
            get { return this._isOper; }
            set { this._isOper = value; }
        }
        /// <summary>
        /// 原优惠（%）
        /// </summary>
        public double OldDiscDiag { get; set; }



        private bool _isAcquisition;
        /// <summary>
        /// 是否采集
        /// </summary>
        public bool IsAcquisition
        {
            get { return _isAcquisition; }
            set { _isAcquisition = value; }
        }

        private bool _isReceive;
        /// <summary>
        /// 是否接收
        /// </summary>
        public bool IsReceive
        {
            get { return _isReceive; }
            set { _isReceive = value; }
        }


        private DateTime _receiveTime;
        /// <summary>
        /// 接收时间
        /// </summary>
        public DateTime ReceiveTime
        {
            get { return _receiveTime; }
            set { _receiveTime = value; }
        }

        private DateTime _acquisitionTime;
        /// <summary>
        /// 采集时间
        /// </summary>
        public DateTime AcquisitionTime
        {
            get { return _acquisitionTime; }
            set { _acquisitionTime = value; }
        }

        /// <summary>
        /// 套餐标记
        /// </summary>
        public string TypeTokenCode
        {
            get
            {
                return _typeTokenCode;
            }

            set
            {
                _typeTokenCode = value;
            }
        }
        /// <summary>
        /// 是否显示套餐
        /// </summary>
        public int IsShow
        {
            get
            {
                return _isShow;
            }

            set
            {
                _isShow = value;
            }
        }
        /// <summary>
        /// 发票号
        /// </summary>
        public string INVONO { get; set; }

        private int _tjStatus;
        /// <summary>
        /// 检验状态
        /// </summary>
        public int TjStatus
        {
            get
            {
                return _tjStatus;
            }

            set
            {
                _tjStatus = value;
            }
        }
        /// <summary>
        /// 药物禁忌,仅显示使用
        /// </summary>
        public string DrugTaboos { get; set; }

        /// <summary>
        /// 药品说明,仅显示使用
        /// </summary>
        public string DrugInstruction { get; set; }

        /// <summary>
        /// 药品功效,仅显示使用
        /// </summary>
        public string DrugEfficacy { get; set; }

        /// <summary>
        /// 岁数（包含年月日）
        /// </summary>
        public string AgeString
        {
            get { return _ageString; }
            set { _ageString = value; }
        }

        public int LsRpType
        {
            get { return _lsRpType; }
            set { _lsRpType = value; }
        }

        public int ListNum
        {
            get { return _listNum; }
            set { _listNum = value; }
        }

        public string FormId { get; set; }

        public double TotalDosage { get; set; }

        public string UnitDiagId { get; set; }

        public int LsGfType { get; set; }

        public string XDRpId { get; set; }

        public string ApplyId { get; set; }

        public string YbType { get; set; }

        public bool IsCancel { get; set; }
        public DateTime CancelTime { get; set; }
        public string CancelOperId { get; set; }
        public bool IsPrint { get; set; }
        public DateTime PrintTime { get; set; }
        public string PrintOperId { get; set; }
        public bool IsPrepared { get; set; }
        public string PrepareTime { get; set; }
        public string PrepareOperId { get; set; }
        public bool IsIssue { get; set; }
        public DateTime IssueTime { get; set; }
        public string IssueOperId { get; set; }
        public bool IsCharged { get; set; }
        public bool IsToBack { get; set; }
        public bool IsBack { get; set; }
        public bool IsDoctorInput { get; set; }
        public DateTime OperTime { get; set; }
        public int RecNum { get; set; }
        public DateTime RecipeTime { get; set; }
        public string LocationId { get; set; }
        public string DoctorId { get; set; }
        public string invono { get; set; }
        public double Price { get; set; }
        public bool IsForCharge { get; set; }

        public string BPReason { get; set; }

        public string DrugsTypes { get; set; }

        public double AmountRecipe { get; set; }

        public double DiscountAoumt { get; set; }

        public double ChildPrice { get; set; }

        public double DiscountPrice { get; set; }

        public string CureDtlId
        {
            get { return _cureDtlId; }
            set { _cureDtlId = value; }
        }

        #region 爱宝贝
        public double PagePrice { get; set; }

        public bool IsPage { get; set; }

        public int TjPackageID { get; set; }
        #endregion

        #region 昆山
        /// <summary>
        /// 处方ID
        /// </summary>
        public int InvoId { get; set; }
        /// <summary>
        /// 发票ID
        /// </summary>
        public int InvoTmpId { get; set; }

       
        public int PageNo
        {
            get { return _pageNo; }
            set { _pageNo = value; }
        }

        public int AllPageNo
        {
            get { return _allPageNo; }
            set { _allPageNo = value; }
        }
        #endregion
    }
}
