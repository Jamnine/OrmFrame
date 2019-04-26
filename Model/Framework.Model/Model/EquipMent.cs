

using System;
namespace Orm.Model
{
    /// <summary>
    /// 设备表 - 实体类
    /// </summary>
    [Serializable]
    public partial class EquipMent : BaseModel
    {

        private string _name;  //设备名字

        private string _pyCode;  //拼音码

        private string _wbCode;  //五笔码

        private int _orderBy;  //显示顺序

        private string _spec;  //规格

        private string _eqType;  //型号

        private string _seriesNo;  //主机系列号

        private string _brand;  //品牌

        private string _countryId;  //国别

        private string _manuId;  //生产商

        private string _compId;  //采购公司

        private string _repairBy;  //维修单位

        private DateTime _buyDate;  //购置日期

        private DateTime _startDate;  //启用日期

        private int _limitYears;  //折旧年限

        private int _lsQuaClass;  //质量等级：1-一级；2-二级；3-三级；4-四级

        private int _lsEqClass;  //设备等级：1-A级;2-B级;3-C级

        private string _lotNo;  //出厂编号

        private string _storeIn;  //存放地点

        private int _lsEqStatus;  //设备状态：1-完好；2-基本完好；3-故障；4-报废

        private double _monthDisc;  //月折旧额

        private int _lsMoneyFrom;  //经费来源：1-设备费;2-科研;3-基金;4-事业费;5-自筹;6-集资;7-合资;8-贷款;9-借款;10-赠送;11-其它

        private double _moneyGiven;  //下拨经费

        private double _moneySelf;  //自筹经费

        private int _underLine;  //最小工作量

        private string _unitId;  //工作量单位

        private int _costPercent;  //成本消耗比

        private int _alarmLine;  //警戒收入

        private bool _isCalProfit;  //是否效益分析

        private string _attachment;  //附件

        private string _useArea;  //用途

        private string _useMemo;  //详细用途

        private string _memo;  //备注

        private int _iconIndex;  //

        private int _lsEqType;  //设备类别：1-医疗设备;2-专用设备;3-通用设备;4-电子产品及通讯设备;5-电器设备;6-器仪表计量标准

        private string _groupSubId;  //子组

        private string _copyId;  //

        private string _voucherNo;  //发票号

        private string _produceArea;  //产地

        private string _inBatchNo;  //

        private string _mnrgLocId;  //所属科室引用表BSLOCATION.GUID

        private string _useLocId;  //使用科室引用表BSLOCATION.GUID

        private DateTime _inActiveTime;  //报废时间

        private string _inActiveReason;  //报废原因

        private string _inActiveOperId;  //报废操作者引用表BSUSER.GUID

        private string _manger;  //管理员

        private double _price;  //单价

        private int _howMany;  //数量

        private double _amount;  //投资总额

        private string _code;

        public EquipMent() { }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 设备名字
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 五笔码
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
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
        /// 型号
        /// </summary>
        public string EqType
        {
            get { return _eqType; }
            set { _eqType = value; }
        }

        /// <summary>
        /// 主机系列号
        /// </summary>
        public string SeriesNo
        {
            get { return _seriesNo; }
            set { _seriesNo = value; }
        }

        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// 国别
        /// </summary>
        public string CountryId
        {
            get { return _countryId; }
            set { _countryId = value; }
        }

        /// <summary>
        /// 生产商
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
        }

        /// <summary>
        /// 采购公司
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }

        /// <summary>
        /// 维修单位
        /// </summary>
        public string RepairBy
        {
            get { return _repairBy; }
            set { _repairBy = value; }
        }

        /// <summary>
        /// 购置日期
        /// </summary>
        public DateTime BuyDate
        {
            get { return _buyDate; }
            set { _buyDate = value; }
        }

        /// <summary>
        /// 启用日期
        /// </summary>
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        /// <summary>
        /// 折旧年限
        /// </summary>
        public int LimitYears
        {
            get { return _limitYears; }
            set { _limitYears = value; }
        }

        /// <summary>
        /// 质量等级：1-一级；2-二级；3-三级；4-四级
        /// </summary>
        public int LsQuaClass
        {
            get { return _lsQuaClass; }
            set { _lsQuaClass = value; }
        }

        /// <summary>
        /// 设备等级：1-A级;2-B级;3-C级
        /// </summary>
        public int LsEqClass
        {
            get { return _lsEqClass; }
            set { _lsEqClass = value; }
        }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string LotNo
        {
            get { return _lotNo; }
            set { _lotNo = value; }
        }

        /// <summary>
        /// 存放地点
        /// </summary>
        public string StoreIn
        {
            get { return _storeIn; }
            set { _storeIn = value; }
        }

        /// <summary>
        /// 设备状态：1-完好；2-基本完好；3-故障；4-报废
        /// </summary>
        public int LsEqStatus
        {
            get { return _lsEqStatus; }
            set { _lsEqStatus = value; }
        }

        /// <summary>
        /// 月折旧额
        /// </summary>
        public double MonthDisc
        {
            get { return _monthDisc; }
            set { _monthDisc = value; }
        }

        /// <summary>
        /// 经费来源：1-设备费;2-科研;3-基金;4-事业费;5-自筹;6-集资;7-合资;8-贷款;9-借款;10-赠送;11-其它
        /// </summary>
        public int LsMoneyFrom
        {
            get { return _lsMoneyFrom; }
            set { _lsMoneyFrom = value; }
        }

        /// <summary>
        /// 下拨经费
        /// </summary>
        public double MoneyGiven
        {
            get { return _moneyGiven; }
            set { _moneyGiven = value; }
        }

        /// <summary>
        /// 自筹经费
        /// </summary>
        public double MoneySelf
        {
            get { return _moneySelf; }
            set { _moneySelf = value; }
        }

        /// <summary>
        /// 最小工作量
        /// </summary>
        public int UnderLine
        {
            get { return _underLine; }
            set { _underLine = value; }
        }

        /// <summary>
        /// 工作量单位
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        /// <summary>
        /// 成本消耗比
        /// </summary>
        public int CostPercent
        {
            get { return _costPercent; }
            set { _costPercent = value; }
        }

        /// <summary>
        /// 警戒收入
        /// </summary>
        public int AlarmLine
        {
            get { return _alarmLine; }
            set { _alarmLine = value; }
        }

        /// <summary>
        /// 是否效益分析
        /// </summary>
        public bool IsCalProfit
        {
            get { return _isCalProfit; }
            set { _isCalProfit = value; }
        }

        /// <summary>
        /// 附件
        /// </summary>
        public string Attachment
        {
            get { return _attachment; }
            set { _attachment = value; }
        }

        /// <summary>
        /// 用途
        /// </summary>
        public string UseArea
        {
            get { return _useArea; }
            set { _useArea = value; }
        }

        /// <summary>
        /// 详细用途
        /// </summary>
        public string UseMemo
        {
            get { return _useMemo; }
            set { _useMemo = value; }
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
        /// 
        /// </summary>
        public int IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
        }

        /// <summary>
        /// 设备类别：1-医疗设备;2-专用设备;3-通用设备;4-电子产品及通讯设备;5-电器设备;6-器仪表计量标准
        /// </summary>
        public int LsEqType
        {
            get { return _lsEqType; }
            set { _lsEqType = value; }
        }

        /// <summary>
        /// 子组
        /// </summary>
        public string GroupSubId
        {
            get { return _groupSubId; }
            set { _groupSubId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CopyId
        {
            get { return _copyId; }
            set { _copyId = value; }
        }

        /// <summary>
        /// 发票号
        /// </summary>
        public string VoucherNo
        {
            get { return _voucherNo; }
            set { _voucherNo = value; }
        }

        /// <summary>
        /// 产地
        /// </summary>
        public string ProduceArea
        {
            get { return _produceArea; }
            set { _produceArea = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }

        /// <summary>
        /// 所属科室引用表BSLOCATION.GUID
        /// </summary>
        public string MnrgLocId
        {
            get { return _mnrgLocId; }
            set { _mnrgLocId = value; }
        }

        /// <summary>
        /// 使用科室引用表BSLOCATION.GUID
        /// </summary>
        public string UseLocId
        {
            get { return _useLocId; }
            set { _useLocId = value; }
        }

        /// <summary>
        /// 报废时间
        /// </summary>
        public DateTime InActiveTime
        {
            get { return _inActiveTime; }
            set { _inActiveTime = value; }
        }

        /// <summary>
        /// 报废原因
        /// </summary>
        public string InActiveReason
        {
            get { return _inActiveReason; }
            set { _inActiveReason = value; }
        }

        /// <summary>
        /// 报废操作者引用表BSUSER.GUID
        /// </summary>
        public string InActiveOperId
        {
            get { return _inActiveOperId; }
            set { _inActiveOperId = value; }
        }

        /// <summary>
        /// 管理员
        /// </summary>
        public string Manger
        {
            get { return _manger; }
            set { _manger = value; }
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
        /// 数量
        /// </summary>
        public int HowMany
        {
            get { return _howMany; }
            set { _howMany = value; }
        }

        /// <summary>
        /// 投资总额
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

    }
}


