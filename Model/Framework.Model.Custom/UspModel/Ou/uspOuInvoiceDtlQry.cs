using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 收费单据明细
    /// </summary>
    [Serializable]
    #region class of Model:uspOuInvoiceDtlQry

    public class uspOuInvoiceDtlQry : BaseModel
    {
        private int _lsGroupType;
        private string _code = String.Empty;
        private string _name = String.Empty;
        private string _spec = String.Empty;
        private int _lsGfType;
        private double _limitTotalMz;
        private string _typeGFXEId;
        private string _invoId;
        private string _itemId;
        private double _totality;
        private string _unitId;
        private double _price;
        private double _discDiag; private bool _isModiDisc;
        private double _discSelf;
        private double _amount; private bool _isIssue;
        private double _amountFact;
        private double _amountSelf;
        private double _amountPay;
        private double _amountTally; private double _amountInsurance;
        private int _lsPerform;
        private string _limitGroupId;
        private double _limitFee;
        private string _execLocId;
        private string _doctorId;
        private string _invItemId;
        private string _feeId; private string _feeHsId;
        private string _xDRpId; private int _lsReportType;
        private string _memo = String.Empty;
        private string _recipeItemId;
        private DateTime _f1;
        private bool _f2;
        private bool _f3;
        private string _f4 = String.Empty;
        private DateTime _invoTime;
        private string _recipeGroupId;
        private string _unitDiagName = String.Empty;
        private string _feeName = String.Empty;
        private string _invMzItemName = String.Empty;
        private string _feeHsMzName = String.Empty;
        private string _doctorName = String.Empty;
        private string _locationName = String.Empty;
        private int _lsAdviceType;
        private int _lsRpType;
        private bool _isDoctorInput;
        private bool _isBack;
        private bool _isToBack;
        private string _prepareTime = String.Empty;
        private bool _isOtherFee;
        private string _recipeGroupIds = String.Empty;
        private bool _isPriority;
        private string _roomId;
        private int _listNum;
        private string _recipeId;
        private int _lsRepType;
        private string _f5 = String.Empty;
        private string _patName = "";
        private string _operName = "";
        private string _sex = string.Empty;
        private string _medicare = string.Empty;
        private string _cookType;
        private string _isnegative;
        private int _days;
        private string _ageString;

        public uspOuInvoiceDtlQry()
        {
        }

        #region Public Properties
        /// <summary>
        /// 正数或负数
        /// </summary>
        public string Isnegative
        {
            get { return _isnegative; }
            set { _isnegative = value; }
        }
        /// <summary>
        /// 项目分类：1-药品；2-治疗；3-物资材料
        /// </summary>
        public int LsGroupType
        {
            get { return _lsGroupType; }
            set { _lsGroupType = value; }
        }
        /// <summary>
        /// 编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        /// <summary>
        /// 是否出现问题
        /// </summary>
        public bool IsIssue
        {
            get { return _isIssue; }
            set { _isIssue = value; }
        }
        /// <summary>
        ///收费项目名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 病人性别：M，F，O.
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        /// <summary>
        /// 规格 
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// 收费类别：1-公费；2-自费；3-按固定自付比例.
        /// </summary>
        public int LsGfType
        {
            get { return _lsGfType; }
            set { _lsGfType = value; }
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
        /// 限制总数量
        /// </summary>
        public double LimitTotalMz
        {
            get { return _limitTotalMz; }
            set { _limitTotalMz = value; }
        }
        /// <summary>
        /// 公费限额类别
        /// </summary>
        public string TypeGFXEId
        {
            get { return _typeGFXEId; }
            set { _typeGFXEId = value; }
        }


        /// <summary>
        /// 发票id
        /// </summary>
        public string InvoId
        {
            get { return _invoId; }
            set { _invoId = value; }
        }
        /// <summary>
        /// 项目id
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
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
        /// 单位id
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }
        /// <summary>
        /// 用法名称,BsUsage
        /// </summary>
        public string UsageName { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = value; }
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
        /// 是否修改自付比例
        /// </summary>
        public bool IsModiDisc
        {
            get { return _isModiDisc; }
            set { _isModiDisc = value; }
        }
        /// <summary>
        /// 自费部分的打折比例
        /// </summary>
        public double DiscSelf
        {
            get { return _discSelf; }
            set { _discSelf = value; }
        }

        /// <summary>
        /// 实收金额
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        /// <summary>
        /// 自付金额，等于(自负金额+自费金额)
        /// </summary>
        public double AmountFact
        {
            get { return _amountFact; }
            set { _amountFact = value; }
        }
        /// <summary>
        /// 自付金额
        /// </summary>
        public double AmountSelf
        {
            get { return _amountSelf; }
            set { _amountSelf = value; }
        }
        /// <summary>
        /// 应交金额
        /// </summary>
        public double AmountPay
        {
            get { return _amountPay; }
            set { _amountPay = value; }
        }
        /// <summary>
        /// 可记帐金额
        /// </summary>
        public double AmountTally
        {
            get { return _amountTally; }
            set { _amountTally = value; }
        }

        /// <summary>
        /// 保险金额
        /// </summary>
        public double AmountInsurance
        {
            get { return _amountInsurance; }
            set { _amountInsurance = value; }
        }

        /// <summary>
        /// 执行类别：1-收费；2-退费.
        /// </summary>
        public int LsPerform
        {
            get { return _lsPerform; }
            set { _lsPerform = value; }
        }

        /// <summary>
        /// 所属门诊限额。外键，引用BsLimitGroup.GUID
        /// </summary>
        public string LimitGroupId
        {
            get { return _limitGroupId; }
            set { _limitGroupId = value; }
        }
        /// <summary>
        /// 门诊限额
        /// </summary>
        public double LimitFee
        {
            get { return _limitFee; }
            set { _limitFee = value; }
        }


        /// <summary>
        /// 执行门诊机构ID
        /// </summary>
        public string ExecLocId
        {
            get { return _execLocId; }
            set { _execLocId = value; }
        }
        /// <summary>
        /// 医生id
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }
        /// <summary>
        /// 发票项目id
        /// </summary>
        public string InvItemId
        {
            get { return _invItemId; }
            set { _invItemId = value; }
        }
        /// <summary>
        /// 门诊收费类别。外键，引用BsMzFeety.GUID.
        /// </summary>
        public string FeeId
        {
            get { return _feeId; }
            set { _feeId = value; }
        }
        /// <summary>
        /// 门诊收费类别ID
        /// </summary>
        public string FeeHsId
        {
            get { return _feeHsId; }
            set { _feeHsId = value; }
        }

        /// <summary>
        /// 协定处方ID
        /// </summary>
        public string XDRpId
        {
            get { return _xDRpId; }
            set { _xDRpId = value; }
        }

        /// <summary>
        /// 报告类型
        /// </summary>
        public int LsReportType
        {
            get { return _lsReportType; }
            set { _lsReportType = value; }
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
        /// 备注1
        /// </summary>
        public string Memo1 { get; set; }
        /// <summary>
        /// 处方项目id
        /// </summary>
        public string RecipeItemId
        {
            get { return _recipeItemId; }
            set { _recipeItemId = value; }
        }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime InputTime
        {
            get { return _f1; }
            set { _f1 = value; }
        }
        /// <summary>
        /// F2
        /// </summary>
        public bool ISMUTITimeS
        {
            get { return _f2; }
            set { _f2 = value; }
        }
        /// <summary>
        /// F3
        /// </summary>
        public bool ISRoomDrug
        {
            get { return _f3; }
            set { _f3 = value; }
        }
        /// <summary>
        ///  F3是否自动收（区分ISRoomDrug）.
        /// </summary>
        public bool IsAutoCharge { get; set; }
        /// <summary>
        /// F4
        /// </summary>
        public string RecipeGroupIds
        {
            get { return _f4; }
            set { _f4 = value; }
        }
        /// <summary>
        /// F4医保名称区分（RECIPEGROUPIDS）
        /// </summary>
        public string YbDesc { get; set; }

        /// <summary>
        /// F4处方号 区分（RECIPEGROUPIDS，YBDESC）
        /// </summary>
        public string RecipeNum { get; set; }

        public string F5
        {
            get { return _f5; }
            set { _f5 = value; }
        }
        /// <summary>
        /// 所属药房
        /// </summary>
        public string RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        /// <summary>
        /// 发票时间。外键，引用Bspatient.GUID
        /// </summary>
        public DateTime InvoTime
        {
            get { return _invoTime; }
            set { _invoTime = value; }
        }
        /// <summary>
        /// 处方分组id
        /// </summary>
        public string RecipeGroupId
        {
            get { return _recipeGroupId; }
            set { _recipeGroupId = value; }
        }
        /// <summary>
        /// 药品单位名称
        /// </summary>
        public string UnitDiagName
        {
            get { return _unitDiagName; }
            set { _unitDiagName = value; }
        }
        /// <summary>
        /// 门诊基础分类.
        /// </summary>
        public string FeeName
        {
            get { return _feeName; }
            set { _feeName = value; }
        }
        /// <summary>
        /// 发票项目.
        /// </summary>
        public string InvMzItemName
        {
            get { return _invMzItemName; }
            set { _invMzItemName = value; }
        }
        /// <summary>
        /// 免费项目
        /// </summary>
        public string FeeHsMzName
        {
            get { return _feeHsMzName; }
            set { _feeHsMzName = value; }
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
        /// 诊所名称
        /// </summary>
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }
        /// <summary>
        /// 通知类型
        /// </summary>
        public int LsAdviceType
        {
            get { return _lsAdviceType; }
            set { _lsAdviceType = value; }
        }
        /// <summary>
        /// 序号
        /// </summary>
        public int ListNum
        {
            get { return _listNum; }
            set { _listNum = value; }
        }
        /// <summary>
        /// 处方id
        /// </summary>
        public string RecipeId
        {
            get { return _recipeId; }
            set { _recipeId = value; }
        }
        /// <summary>
        /// 处方种类：1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药
        /// </summary>
        public int LsRepType
        {
            get { return _lsRepType; }
            set { _lsRepType = value; }
        }
        /// <summary>
        /// 同项目表
        /// </summary>
        public int LsRpType
        {
            get { return _lsRpType; }
            set { _lsRpType = value; }
        }
        /// <summary>
        /// F4是否医生挂号
        /// </summary>
        public bool IsDoctorInput
        {
            get { return _isDoctorInput; }
            set { _isDoctorInput = value; }
        }
        /// <summary>
        /// 是否已退
        /// </summary>
        public bool IsBack
        {
            get { return _isBack; }
            set { _isBack = value; }
        }
        /// <summary>
        /// 是否回访
        /// </summary>
        public bool IsToBack
        {
            get { return _isToBack; }
            set { _isToBack = value; }
        }
        /// <summary>
        /// F1录入时间.
        /// </summary>
        public string PrepareTime
        {
            get { return _prepareTime; }
            set { _prepareTime = value; }
        }
        /// <summary>
        ///  是否附加项目
        /// </summary>
        public bool IsOtherFee
        {
            get { return _isOtherFee; }
            set { _isOtherFee = value; }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get { return _patName; } set { _patName = value; } }
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperName { get { return _operName; } set { _operName = value; } }

        private bool _canChangeAmount = true;
        /// <summary>
        /// 不可修改数量
        /// </summary>
        public bool CanChangeAmount
        {
            get { return _canChangeAmount; }
            set { _canChangeAmount = value; }
        }

        private string _tjLocationID;
        /// <summary>  
        ///  体检科室
        /// </summary>  
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }
        /// <summary>
        /// 医保卡号
        /// </summary>
        public string Medicare
        {
            get { return this._medicare; }
            set { this._medicare = value; }
        }

        /// <summary>
        /// 会员扣减数量
        /// </summary>
        public int VipDeductionCount { get; set; }
        /// <summary>
        /// 费用类别（医保/非医保）
        /// </summary>
        public string FeeType { get; set; }
        /// <summary>
        /// 床位号
        /// </summary>
        public string BedNo { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 临床诊断
        /// </summary>
        public string ClinicalDiagnosis { get; set; }
        /// <summary>
        /// 皮试结果
        /// </summary>
        public string SkinTestResults { get; set; }
        /// <summary>
        /// 审核人ID
        /// </summary>
        public string CheckedOperID { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string CheckedOperName { get; set; }
        /// <summary>
        /// 调配人ID
        /// </summary>
        public string AllocateManID { get; set; }
        /// <summary>
        /// 调配人
        /// </summary>
        public string AllocateManName { get; set; }
        /// <summary>
        /// 发药人
        /// </summary>
        public string MedicineManName { get; set; }
        /// <summary>
        /// 频率，BsFrequency
        /// </summary>
        public string FrequencyName { get; set; }
        /// <summary>
        /// 用量.
        /// </summary>
        public double Dosage { get; set; }
        /// <summary>
        /// 用量单位/中药单位
        /// </summary>
        public string UnitTakeName { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoNo { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 中药名称1
        /// </summary>
        public string Name1 { get; set; }
        /// <summary>
        /// 中药名称2
        /// </summary>
        public string Name2 { get; set; }
        /// <summary>
        /// 中药数量1
        /// </summary>
        public double Totality1 { get; set; }
        /// <summary>
        /// 中药数量2
        /// </summary>
        public double Totality2 { get; set; }
        /// <summary>
        /// 中药单位1
        /// </summary>
        public string UnitTakeName1 { get; set; }
        /// <summary>
        /// 中药单位2
        /// </summary>
        public string UnitTakeName2 { get; set; }

        /// <summary>
        /// 煎药方式
        /// </summary>
        public string CookType
        {
            get { return this._cookType; }
            set { this._cookType = value; }
        }
        /// <summary>
        /// 中药煎药方式
        /// </summary>
        public string CookType1 { get; set; }
        /// <summary>
        /// 是否注销
        /// </summary>
        public bool IsCancel { get; set; }
        /// <summary>
        /// 是否已审核
        /// </summary>
        public bool IsVerify { get; set; }

        /// <summary>  
        ///   诊断
        /// </summary>  
        public string Diagnosis
        {
            get;
            set;
        }


        /// <summary>
        /// 组号.
        /// </summary>
        public int  GroupNum
        {
            get;
            set;
        }
        public string PatId { get; set; }


        /// <summary>
        /// 天数
        /// </summary>
        public int Days
        {
            get { return this._days; }
            set { this._days = value; }
        }

        /// <summary>
        /// 年龄（包含岁、月、天数）
        /// </summary>
        public string AgeString
        {
            get { return this._ageString; }
            set { this._ageString = value; }
        }

        public double AllAmount { get; set; }
        public bool IsUsageItem { get; set; }
        #endregion
    }
    #endregion
}







