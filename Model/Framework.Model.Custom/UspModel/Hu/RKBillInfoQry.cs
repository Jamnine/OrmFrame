using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 物品入库列表
    /// </summary>
    [Serializable]
    #region class of Model:RKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RKBillInfo.
    /// </summary>
    public class RKBillInfoQry : BaseModel
    {
         
        private string _voucherNo = String.Empty;
        private string _pNo = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _drugNum;
        private string _unitName = String.Empty;
        private double _stockPrice;
        private double _totalPrice;
        private double _retailPrice;
        private double _totalRetail;
        private double _deltaAmount;
        private DateTime _produceDate =DateTime.Now.Date;
        private DateTime _limitDate = DateTime.Now.AddYears(1).Date;
        private string _billNo = String.Empty;
        private DateTime _operTime;
        private DateTime _signTime;
        private bool _isSign;
        private string _inBatchNo = String.Empty;
        private string _billId;
        private string _itemId;
        private string _unitId;
        private string _houseId;
        private string _compId;
        private string _operId;
        private string _signOperId;
        private double _addPercent;
        private string _passNo = String.Empty;
        private string _proAreaName = String.Empty;
        private int _proAreaId;
        private string _manuId;
        private double _priceHighLine;
        private string _f1 = String.Empty;   //有疑问

        private string _regNo = String.Empty;
        private string _importUnit = String.Empty;
        private string _reportNo = String.Empty;
        private string _makeinArea = String.Empty;
        private bool _isSelect;
        private string _barCode = "";
        private int _tYear = 0;
        private int _tMonth = 0;

        /// <summary>
        /// 物品入库列表
        /// </summary>
        public RKBillInfoQry()
        {
        }


        #region Public Properties

        /// <summary>
        /// 注册证号
        /// </summary>
        public string RegNo
        {
            get { return _regNo; }
            set { _regNo = value; }
        }

        /// <summary>
        /// 进口检验单位
        /// </summary>
        public string ImportUnit
        {
            get { return _importUnit; }
            set { _importUnit = value; }
        }

        /// <summary>
        /// 报告书号
        /// </summary>
        public string ReportNo
        {
            get { return _reportNo; }
            set { _reportNo = value; }
        }

        /// <summary>
        /// 生产地
        /// </summary>
        public string MakeinArea
        {
            get { return _makeinArea; }
            set { _makeinArea = value; }
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
        /// 批号
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }

        /// <summary>
        /// 编码
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        /// <summary>
        /// 简称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
        /// 生产商名称
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }

        /// <summary>
        /// 数量
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        /// <summary>
        /// 实价
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }

         /// <summary>
         /// 买入金额
         /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        /// <summary>
        /// 零售价
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        /// <summary>
        /// 零售金额
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }

        /// <summary>
        /// 盈利总金额
        /// </summary>
        public double DeltaAmount
        {
            get { return _deltaAmount; }
            set { _deltaAmount = value; }
        }

        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
        }

        /// <summary>
        /// 失效日期
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }

        /// <summary>
        /// 单据号
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
         

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }

        /// <summary>
        /// 是否已审核：0:未审核,1:已审核
        /// </summary>
        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
        }

        /// <summary>
        /// 药品批次ID
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }

        /// <summary>
        /// 入库单ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// 使用单位（小单位）
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        /// <summary>
        /// 药库ID
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }

        /// <summary>
        /// 医药公司ID
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }

        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 审核人Id 
        /// </summary>
        public string SignOperId
        {
            get { return _signOperId; }
            set { _signOperId = value; }
        }
        /// <summary>
        /// 加成率
        /// </summary>
        public double AddPercent
        {
            get { return _addPercent; }
            set { _addPercent = value; }
        }
        /// <summary>
        /// 价格最高指标
        /// </summary>
        public double PriceHighLine
        {
            get { return _priceHighLine; }
            set { _priceHighLine = value; }
        }

        /// <summary>
        /// 批准文号
        /// </summary>
        public string PassNo
        {
            get { return _passNo; }
            set { _passNo = value; }
        }
        /// <summary>
        /// 地区名
        /// </summary>
        public string ProAreaName
        {
            get { return _proAreaName; }
            set { _proAreaName = value; }
        }

        /// <summary>
        /// 地区ID
        /// </summary>
        public int ProAreaId
        {
            get { return _proAreaId; }
            set { _proAreaId = value; }
        }
    

        /// <summary>
        /// 生产商ID
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
        }
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }

        /// <summary>
        /// 条形码
        /// </summary>
        public string BarCode
        {
            get { return _barCode; }
            set { _barCode = value; }
        }

        /// <summary>
        ///有限期-月 
        /// </summary>
        public int TMonth
        {
            get { return _tMonth; }
            set { _tMonth = value; }
        }

        /// <summary>
        /// 有限期-年
        /// </summary>
        public int TYear
        {
            get { return _tYear; }
            set { _tYear = value; }
        }
        #endregion
    }
    #endregion
}







