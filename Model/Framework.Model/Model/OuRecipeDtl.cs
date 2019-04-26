

using System;
using System.Text.RegularExpressions;
namespace Orm.Model
{
    /// <summary>
    /// 门诊处方明细 - 实体类
    /// </summary>
    [Serializable]
    public partial class OuRecipeDtl : BaseModel
    {
        private int _frequencyCount; //频率数量
        
        private string _recipeId;  //处方ID

        private int _listNum;  //序号

        private string _itemId;  //项目

        private int _groupNum;  //组号

        private double _dosage;  //用量

        private string _unitTakeId;  //使用单位

        private string _frequencyId;  //频率

        private string _usageId;  //用法

        private int _days;  //天数

        private double _totality;  //总量

        private string _unitDiagId;  //门诊单位

        private bool _isAttach;  //是否执行isNoAttach

        private bool _isOtherFee;  //是否附加项目

        private string _xDRpId;  //协定处方Id,BsXdRp.Id

        private string _memo;  //备注

        private bool _isCharged;  //是否已结帐

        private bool _isCancel;  //是否作废

        private DateTime _cancelTime;  //取消时间

        private string _cancelOperId;  //取消人ID

        private bool _isPrint;  //护士是否已经审核

        private DateTime _printTime;  //审核时间

        private string _printOperId;  //审核人

        private bool _isPrepared;  //是否准备

        private string _prepareTime;  //准备时间

        private string _prepareOperId;  //准备人ID

        private bool _isIssue;  //是否发药

        private DateTime _issueTime;  //发药时间

        private string _issueOperId;  //发药人

        private bool _isToBack;  //医生是否确认退药

        private bool _isBack;  //是否已退？

        private bool _isDoctorInput;  //是否已医生录入？

        private int _recNum;  //处方张号

        private DateTime _recipeTime;  //处方日期

        private string _locationId;  //关联到LOCATION表

        private string _doctorId;  //关联到DOCTOR表

        private int _allPageNo;  //

        private int _pageNo;  //

        private string _cureDtlId;  //BP治疗方案明细ID对应表BsBPCureDtl

        private bool _isBP;  //是否BP

        private string _bPReason;  //BP理由

        private string _ybType;  //医保类别

        private string _invoNo;  //收费发票号

        private bool _isAutoCharged;  //是否自动收

        private bool _isForCharge;  //是否从门诊收费调用录入

        private string _applyId;  //检查申请单Id

        private double _price;  //单价

        private string _tempStr;  //代码临时使用

        private double _discountAoumt;  //折扣金额

        private double _childPrice;  //儿童价格

        private double _discountPrice;  //折扣价格

        private bool _isAuthed;  //已经封存，不可改删

        private double _oldDiscDiag;  //行心云:原优惠（%）

        private string _addMemo;  //行心云:附加费备注

        private string _dripRates;  //行心云:滴速

        private string _skinTestCondition;  //行心云:皮试情况

        private DateTime _planExecuteTime;  //行心云:计划执行时间

        private DateTime _completeTime;  //行心云:完成时间

        private double _discDiag;  //行心云:优惠（%）

        private string _patTypeName;  //行心云:病人类别名称

        private int _samlingType;  //行心云: 

        private string _execOperID;  //行心云:执行人

        private bool _isShow;  //行心云:是否显示套餐

        private bool _isVipDeduction;  //行心云:是否会员消费扣减项目

        private bool _isUsageItem;  //行心云:是否用法附加项目

        private DateTime _chargeDtime;  //收费时间

        private string _sourceName;

        private string _labID;   // 检验标本iD

        private string _operId;

        private string _backCancelOperId;
        private DateTime _backCancelTime;

        private string _cookType;

        private string _recipeNum; //处方号

        private int _chargeCount;
         
        private bool _aka185;      //是否限制用药

        private bool _isYbItems;   //是否医保项目

        /// <summary>
        /// 是否限制用药
        /// </summary>
        public bool AKA185
        {
            get { return _aka185; }
            set
            {
                _aka185 = value;
            }
        }

        /// <summary>
        /// 是否限制用药
        /// </summary>
        public bool IsYbItems
        {
            get { return _isYbItems; }
            set
            {
                _isYbItems = value;
            }
        }

        private string _joinExecOperID;
        /// <summary>
        /// 参与执行人ID
        /// </summary>
        public string JoinExecOperID
        {
            get { return _joinExecOperID; }
            set { _joinExecOperID = value; }
        }


        private string _strTotality;
        /// <summary>
        ///  生鲜数量
        /// </summary>
        public string StrTotality
        {
            get { return _strTotality; }
            set
            {
                _strTotality = value;
                 
            }
        }

        /// <summary>
        /// 退药时间
        /// </summary>
        public DateTime BackCancelTime
        {
            get { return _backCancelTime; }
            set { _backCancelTime = value; }
        }
        /// <summary>
        /// 退药操作人
        /// </summary>
        public string BackCancelOperId
        {
            get { return _backCancelOperId; }
            set { _backCancelOperId = value; }
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
        /// 序号
        /// </summary>
        public int ListNum
        {
            get { return _listNum; }
            set { _listNum = value; }
        }

        /// <summary>
        /// 项目
        /// </summary>
        public string ItemID
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// 组号  id 
        /// </summary>
        public int GroupNum
        {
            get { return _groupNum; }
            set { _groupNum = value; }
        }

        /// <summary>
        /// 用量
        /// </summary>
        public double Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }

        /// <summary>
        /// 使用单位
        /// </summary>
        public string UnitTakeId
        {
            get { return _unitTakeId; }
            set { _unitTakeId = value; }
        }

        /// <summary>
        /// 频率
        /// </summary>
        public string FrequencyId
        {
            get { return _frequencyId; }
            set { _frequencyId = value; }
        }

        /// <summary>
        /// 用法
        /// </summary>
        public string UsageId
        {
            get { return _usageId; }
            set { _usageId = value; }
        }

        /// <summary>
        /// 天数
        /// </summary>
        public int Days
        {
            get { return _days; }
            set { _days = value; }
        }

        /// <summary>
        /// 总量
        /// </summary>
        public double Totality
        {
            get { return _totality; }
            set { _totality = value;
                //StrTotality = _totality.ToString();
            }


        }

        /// <summary>
        /// 门诊单位
        /// </summary>
        public string UnitDiagId
        {
            get { return _unitDiagId; }
            set { _unitDiagId = value; }
        }

        /// <summary>
        /// 是否执行isNoAttach
        /// </summary>
        public bool IsAttach
        {
            get { return _isAttach; }
            set { _isAttach = value; }
        }

        /// <summary>
        /// 是否附加项目
        /// </summary>
        public bool IsOtherFee
        {
            get { return _isOtherFee; }
            set { _isOtherFee = value; }
        }

        /// <summary>
        /// 协定处方Id,BsXdRp.Id
        /// </summary>
        public string XDRpId
        {
            get { return _xDRpId; }
            set { _xDRpId = value; }
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
        /// 是否已结帐
        /// </summary>
        public bool IsCharged
        {
            get { return _isCharged; }
            set { _isCharged = value; }
        }

        /// <summary>
        /// 是否作废
        /// </summary>
        public bool IsCancel
        {
            get { return _isCancel; }
            set { _isCancel = value; }
        }

        /// <summary>
        /// 取消时间
        /// </summary>
        public DateTime CancelTime
        {
            get { return _cancelTime; }
            set { _cancelTime = value; }
        }

        /// <summary>
        /// 取消人ID
        /// </summary>
        public string CancelOperId
        {
            get { return _cancelOperId; }
            set { _cancelOperId = value; }
        }

        /// <summary>
        /// 护士是否已经审核
        /// </summary>
        public bool IsPrint
        {
            get { return _isPrint; }
            set { _isPrint = value; }
        }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime PrintTime
        {
            get { return _printTime; }
            set { _printTime = value; }
        }

        /// <summary>
        /// 审核人
        /// </summary>
        public string PrintOperId
        {
            get { return _printOperId; }
            set { _printOperId = value; }
        }

        /// <summary>
        /// 是否准备
        /// </summary>
        public bool IsPrepared
        {
            get { return _isPrepared; }
            set { _isPrepared = value; }
        }

        /// <summary>
        /// 准备时间
        /// </summary>
        public string PrepareTime
        {
            get { return _prepareTime; }
            set { _prepareTime = value; }
        }

        /// <summary>
        /// 准备人ID
        /// </summary>
        public string PrepareOperId
        {
            get { return _prepareOperId; }
            set { _prepareOperId = value; }
        }

        /// <summary>
        /// 是否发药
        /// </summary>
        public bool IsIssue
        {
            get { return _isIssue; }
            set { _isIssue = value; }
        }

        /// <summary>
        /// 发药时间
        /// </summary>
        public DateTime IssueTime
        {
            get { return _issueTime; }
            set { _issueTime = value; }
        }

        /// <summary>
        /// 发药人
        /// </summary>
        public string IssueOperId
        {
            get { return _issueOperId; }
            set { _issueOperId = value; }
        }

        /// <summary>
        /// 医生是否确认退药
        /// </summary>
        public bool IsToBack
        {
            get { return _isToBack; }
            set { _isToBack = value; }
        }

        /// <summary>
        /// 是否已退？
        /// </summary>
        public bool IsBack
        {
            get { return _isBack; }
            set { _isBack = value; }
        }

        /// <summary>
        /// 是否已医生录入？
        /// </summary>
        public bool IsDoctorInput
        {
            get { return _isDoctorInput; }
            set { _isDoctorInput = value; }
        }

        /// <summary>
        /// 处方张号
        /// </summary>
        public int RecNum
        {
            get { return _recNum; }
            set { _recNum = value; }
        }

        /// <summary>
        /// 处方日期
        /// </summary>
        public DateTime RecipeTime
        {
            get { return _recipeTime; }
            set { _recipeTime = value; }
        }

        /// <summary>
        /// 煎药类型
        /// </summary>
        public string CookType
        {
            get { return _cookType; }
            set { _cookType = value; }
        }

        /// <summary>
        /// 关联到LOCATION表
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 关联到DOCTOR表
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int AllPageNo
        {
            get { return _allPageNo; }
            set { _allPageNo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int PageNo
        {
            get { return _pageNo; }
            set { _pageNo = value; }
        }

        /// <summary>
        /// BP治疗方案明细ID对应表BsBPCureDtl
        /// </summary>
        public string CureDtlId
        {
            get { return _cureDtlId; }
            set { _cureDtlId = value; }
        }

        /// <summary>
        /// 是否BP
        /// </summary>
        public bool IsBP
        {
            get { return _isBP; }
            set { _isBP = value; }
        }

        /// <summary>
        /// BP理由
        /// </summary>
        public string BPReason
        {
            get { return _bPReason; }
            set { _bPReason = value; }
        }

        /// <summary>
        /// 医保类别
        /// </summary>
        public string YbType
        {
            get { return _ybType; }
            set { _ybType = value; }
        }

        /// <summary>
        /// 收费发票号
        /// </summary>
        public string InvoNo
        {
            get { return _invoNo; }
            set { _invoNo = value; }
        }

        /// <summary>
        /// 是否自动收
        /// </summary>
        public bool IsAutoCharged
        {
            get { return _isAutoCharged; }
            set { _isAutoCharged = value; }
        }

        /// <summary>
        /// 是否从门诊收费调用录入
        /// </summary>
        public bool IsForCharge
        {
            get { return _isForCharge; }
            set { _isForCharge = value; }
        }

        /// <summary>
        /// 检查申请单Id
        /// </summary>
        public string ApplyId
        {
            get { return _applyId; }
            set { _applyId = value; }
        }

        /// <summary>
        /// 单价
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// 代码临时使用
        /// </summary>
        public string TempStr
        {
            get { return _tempStr; }
            set { _tempStr = value; }
        }

        /// <summary>
        /// 折扣金额
        /// </summary>
        public double DiscountAoumt
        {
            get { return _discountAoumt; }
            set { _discountAoumt = value; }
        }

        /// <summary>
        /// 儿童价格
        /// </summary>
        public double ChildPrice
        {
            get { return _childPrice; }
            set { _childPrice = value; }
        }

        /// <summary>
        /// 折扣价格
        /// </summary>
        public double DiscountPrice
        {
            get { return _discountPrice; }
            set { _discountPrice = value; }
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
        /// 行心云:原优惠（%）
        /// </summary>
        public double OldDiscDiag
        {
            get { return _oldDiscDiag; }
            set { _oldDiscDiag = value; }
        }

        /// <summary>
        /// 行心云:附加费备注
        /// </summary>
        public string AddMemo
        {
            get { return _addMemo; }
            set { _addMemo = value; }
        }

        /// <summary>
        /// 行心云:滴速
        /// </summary>
        public string DripRates
        {
            get { return _dripRates; }
            set { _dripRates = value; }
        }

        /// <summary>
        /// 行心云:皮试情况
        /// </summary>
        public string SkinTestCondition
        {
            get { return _skinTestCondition; }
            set { _skinTestCondition = value; }
        }

        /// <summary>
        /// 行心云:计划执行时间
        /// </summary>
        public DateTime PlanExecuteTime
        {
            get { return _planExecuteTime; }
            set { _planExecuteTime = value; }
        }

        /// <summary>
        /// 行心云:完成时间
        /// </summary>
        public DateTime CompleteTime
        {
            get { return _completeTime; }
            set { _completeTime = value; }
        }


        /// <summary>
        /// 行心云:优惠（%）
        /// </summary>
        public double DiscDiag
        {
            get { return _discDiag; }
            set { _discDiag = value; }
        }

        /// <summary>
        /// 行心云:病人类别名称
        /// </summary>
        public string PatTypeName
        {
            get { return _patTypeName; }
            set { _patTypeName = value; }
        }

        /// <summary>
        /// 行心云: 护士采集
        /// </summary>
        public int SamlingType
        {
            get { return _samlingType; }
            set { _samlingType = value; }
        }

        /// <summary>
        /// 行心云:执行人
        /// </summary>
        public string ExecOperID
        {
            get { return _execOperID; }
            set { _execOperID = value; }
        }

        /// <summary>
        /// 行心云:是否显示套餐
        /// </summary>
        public bool IsShow
        {
            get { return _isShow; }
            set { _isShow = value; }
        }

        /// <summary>
        /// 行心云:是否会员消费扣减项目
        /// </summary>
        public bool IsVipDeduction
        {
            get { return _isVipDeduction; }
            set { _isVipDeduction = value; }
        }

        /// <summary>
        /// 行心云:是否用法附加项目
        /// </summary>
        public bool IsUsageItem
        {
            get { return _isUsageItem; }
            set { _isUsageItem = value; }
        }

        /// <summary>
        /// 收费时间
        /// </summary>
        public DateTime ChargeDtime
        {
            get { return _chargeDtime; }
            set { _chargeDtime = value; }
        }
        /// <summary>
        /// 检验标本
        /// </summary>
        public string LabId
        {
            get { return _labID; }
            set { _labID = value; }
        }

        /// <summary>
        /// 标本类型Name
        /// </summary>
        public string SourceName
        {
            get { return _sourceName; }
            set { _sourceName = value; }
        }

        private int _ckItemType;
        /// <summary>
        /// 检验组合类型:1.检查项目 2.检验项目
        /// </summary>
        public int CkItemType
        {
            get { return _ckItemType; }
            set { _ckItemType = value; }
        }
        /// <summary>
        /// 第几次收费
        /// </summary>
        public int ChargeCount
        {
            get { return _chargeCount; }
            set { _chargeCount = value; }
        }
          
        public int VipLeftCount { get; set; }
        public string TjPackageID { get; set; }
        public bool IsPage { get; set; }
        public double PagePrice { get; set; }
        public object ItemTypeName { get; set; }

        /// <summary>
        /// 频率数量
        /// </summary>
        public int FrequencyCount
        {
            get { return _frequencyCount; }
            set { _frequencyCount = value; }
        }

        public string OperId
        {
            get { return _operId; }
            set
            {
                _operId = value;
            }
        }

      
        /// <summary>
        /// 处方种类：1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药
        /// </summary>
        public string RecipeNum
        {
            get { return _recipeNum; }
            set { _recipeNum = value; }
        }
        private bool _isFrequencyId = false;
        public bool u_IsFrequencyId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FrequencyId))
                {
                    _isFrequencyId = true;
                }
                else
                {
                    _isFrequencyId = false;
                }
                return _isFrequencyId;
            }
            set { _isFrequencyId = value; }
        }
        private bool _isUnitDiagId = false;
        public bool u_IsUnitDiagId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UnitDiagId))
                {
                    _isUnitDiagId = true;
                }
                else
                {
                    _isUnitDiagId = false;
                }
                return _isUnitDiagId;
            }
            set { _isUnitDiagId = value; }
        }
        private bool _isUnitTakeId = false;
        public bool u_IsUnitTakeId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UnitTakeId))
                {
                    _isUnitTakeId = true;
                }
                else
                {
                    _isUnitTakeId = false;
                }
                return _isUnitTakeId;
            }
            set { _isUnitTakeId = value; }
        }
    }
}


