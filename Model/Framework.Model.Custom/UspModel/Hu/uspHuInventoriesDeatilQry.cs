using System;

namespace Orm.Model.Custom
{
    /// <summary>
    ///库存盘点列表
    /// </summary>
    [Serializable]
    #region class of Model:uspHuInventoriesDeatilQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuInventoriesDeatil.
    /// </summary>
    public class uspHuInventoriesDeatilQry : BaseModel
    {
         
        private string _inBatchId;
        private string _itemId;
        private string _compId;
        private string _groupId;
        private string _compName;
        private string _unitId;
        private string _unitName;
        private double _balanceNum;
        private double _stcokNum;
        private double _instoreNum;
        private double _checkNum;
        private double _pkNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _compare = String.Empty;
        private bool _isBalance;
        private double _retailPricePk;
        private double _stockPricePk;
        private double _retailPriceCheck;
        private double _stockPriceCheck;
        private double _retailPriceStcok;
        private double _stockPriceStcok;
        private string _state = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _pNo = String.Empty;
        private string _isGSJ = String.Empty;
        private int _formId;
        private string _billId;
        private bool _isAdjust;
        private double _buyIn;
        private double _backIn;
        private double _otherIn;
        private double _deptOut;
        private double _backOut;
        private double _saleOut;
        private double _loseOut;
        private double _adjustAmouUp;
        private double _adjustAmouDn;
        private DateTime _limitDate;
        private bool _isOnlyForSys;
        /// <summary>
        ///库存盘点列表
        /// </summary>
        public uspHuInventoriesDeatilQry()
        {
        }



        #region Public Properties

        /// <summary>
        /// 药品批次ID
        /// </summary>
            public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }

        /// <summary>
        /// 失期日期
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
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
        /// 医药公司ID.
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }
        /// <summary>
        /// 主组。外键，引用BsGroup.GUID.
        /// </summary>
        public string GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }

        /// <summary>
        /// 医药公司名称.
        /// </summary>
        public string CompName
        {
            get { return _compName; }
            set { _compName = value; }
        }

        /// <summary>
        /// 单位ID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
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
        /// 结存数量
        /// </summary>
        public double BalanceNum
        {
            get { return _balanceNum; }
            set { _balanceNum = value; }
        }
        /// <summary>
        /// 库存数量
        /// </summary>
        public double StcokNum
        {
            get { return _stcokNum; }
            set { _stcokNum = value; }
        }
        /// <summary>
        /// 入库数量
        /// </summary>
        public double InstoreNum
        {
            get { return _instoreNum; }
            set { _instoreNum = value; }
        }
        /// <summary>
        /// 盘点数量
        /// </summary>
        public double CheckNum
        {
            get { return _checkNum; }
            set { _checkNum = value; }
        }
        /// <summary>
        /// 盘亏数量
        /// </summary>
        public double PkNum
        {
            get { return _pkNum; }
            set { _pkNum = value; }
        }

        /// <summary>
        /// 进货(买入)价.
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }
        /// <summary>
        /// 零售价.
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        /// <summary>
        /// 比较
        /// </summary>
        public string Compare
        {
            get { return _compare; }
            set { _compare = value; }
        }
        /// <summary>
        /// 是否结存
        /// </summary>
        public bool IsBalance
        {
            get { return _isBalance; }
            set { _isBalance = value; }
        }

        /// <summary>
        /// 零售亏损金额
        /// (零售价*（盘点数量-库存数量）)
        /// </summary>
        public double RetailPricePk
        {
            get { return _retailPricePk; }
            set { _retailPricePk = value; }
        }
        /// <summary>
        /// 买入价格盘亏
        /// (买入（进货）价*（盘点数量-库存数量）)
        /// </summary>
        public double StockPricePk
        {
            get { return _stockPricePk; }
            set { _stockPricePk = value; }
        }

        /// <summary>
        /// 核实金额
        /// (零售价*盘点数量)
        /// </summary>
        public double RetailPriceCheck
        {
            get { return _retailPriceCheck; }
            set { _retailPriceCheck = value; }
        }

        /// <summary>
        /// 进货金额
        /// (买入（进货）价*盘点数量
        /// </summary>
        public double StockPriceCheck
        {
            get { return _stockPriceCheck; }
            set { _stockPriceCheck = value; }
        }

        /// <summary>
        /// 零售金额（售货金额）
        /// (零售价*库存数量)
        /// </summary>
        public double RetailPriceStcok
        {
            get { return _retailPriceStcok; }
            set { _retailPriceStcok = value; }
        }

        /// <summary>
        /// 进货金额
        /// (买入（进货）价*库存数量)
        /// </summary>
        public double StockPriceStcok
        {
            get { return _stockPriceStcok; }
            set { _stockPriceStcok = value; }
        }

        /// <summary>
        /// 状态
        /// (盘盈，正常，盈亏)
        /// </summary>
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        /// 编码
        /// (项目编码)
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        /// <summary>
        /// 简称(指：项目)
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
        /// 批号
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }

        
        /// <summary>
        /// 剂型ID
        /// </summary>
        public int FormId
        {
            get { return _formId; }
            set { _formId = value; }
        }

        /// <summary>
        /// 盘点主表ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// 价格是否调整过
        /// </summary>
        public bool IsAdjust
        {
            get { return _isAdjust; }
            set { _isAdjust = value; }
        }

        /// <summary>
        /// 自购入库
        /// </summary>
        public double BuyIn
        {
            get { return _buyIn; }
            set { _buyIn = value; }
        }

        /// <summary>
        /// 药房退药
        /// </summary>
        public double BackIn
        {
            get { return _backIn; }
            set { _backIn = value; }
        }

        /// <summary>
        /// 其它入库
        /// </summary>
        public double OtherIn
        {
            get { return _otherIn; }
            set { _otherIn = value; }
        }
        /// <summary>
        /// 药库发药
        /// </summary>
        public double DeptOut
        {
            get { return _deptOut; }
            set { _deptOut = value; }
        }
        /// <summary>
        /// 退药出库
        /// </summary>
        public double BackOut
        {
            get { return _backOut; }
            set { _backOut = value; }
        }
        /// <summary>
        /// 其他出库
        /// </summary>
        public double SaleOut
        {
            get { return _saleOut; }
            set { _saleOut = value; }
        }
        /// <summary>
        /// 报损出库
        /// </summary>
        public double LoseOut
        {
            get { return _loseOut; }
            set { _loseOut = value; }
        }
        /// <summary>
        /// 下调幅度
        /// </summary>
        public double AdjustAmouUp
        {
            get { return _adjustAmouUp; }
            set { _adjustAmouUp = value; }
        }
        /// <summary>
        /// 上调幅度
        /// </summary>
        public double AdjustAmouDn
        {
            get { return _adjustAmouDn; }
            set { _adjustAmouDn = value; }
        }
        #endregion
        /// <summary>
        /// 是否库存
        /// </summary>
        public bool IsOnlyForSys
        {
            get { return _isOnlyForSys; }
            set { _isOnlyForSys = value; }
        }

        private string _code = string.Empty;
        /// <summary>
        /// 编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private DateTime _checkTime;
        /// <summary>
        /// 盘点时间
        /// </summary>
        public DateTime CheckTime
        {
            get { return _checkTime; }
            set { _checkTime = value; }
        }


        private double _stcokNumDeep;
        /// <summary>
        /// 账面数量
        /// </summary>
        public double StcokNumDeep
        {
            get { return _stcokNumDeep; }
            set { _stcokNumDeep = value; }
        }
    }
    #endregion
}







