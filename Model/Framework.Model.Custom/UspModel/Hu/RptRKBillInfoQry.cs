using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 物品入库列表 报表
    /// </summary>
    [Serializable]
    #region class of Model:RptRKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptRKBillInfo.
    /// </summary>
    public class RptRKBillInfoQry : BaseModel
    {
         
        private string _voucherNo = String.Empty;
        private string _pNo = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private double _drugNum;
        private double _priceHighLine;
        private double _addPercent;
        private string _unitName = String.Empty;
        private double _stockPrice;
        private double _totalPrice;
        private double _retailPrice;
        private double _totalRetail;
        private string _billNo = String.Empty;
        private DateTime _operTime;
        private string _inBatchNo = String.Empty;
        private string _billId;
        private string _companyName = String.Empty;
        private string _houseName = String.Empty;
        private string _operName = String.Empty;
        private string _signName = String.Empty;
        private string _areaName = String.Empty;
        private string _manuId;
        private string _f1 = String.Empty;
        private string _f2 = String.Empty;
        private string _limitDate = String.Empty;
        private string _memo = String.Empty;

        /// <summary>
        /// 物品入库列表 报表
        /// </summary>
        public RptRKBillInfoQry()
        {
        }




        #region Public Properties
        /// <summary>
        /// 发票号.
        /// </summary>
        public string VoucherNo
        {
            get { return _voucherNo; }
            set { _voucherNo = value; }
        }
        /// <summary>
        /// 生产商ID 关联bsmanufacturer
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
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
        /// 物品名称
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
        /// 数量
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// 价格最高上限
        /// </summary>
        public double PriceHighLine
        {
            get { return _priceHighLine; }
            set { _priceHighLine = value; }
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
        ///单位名称
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// 实价.
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }
        /// <summary>
        /// 总金额
        /// (实价*数量)
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
        /// 总金额
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// 单据号.
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// .操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        /// <summary>
        /// 流水号
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }
        /// <summary>
        /// 单据ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }
        /// <summary>
        /// 医药公司名
        /// </summary>
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        /// <summary>
        /// 药库名
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }
        /// <summary>
        /// 制表人
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string SignName
        {
            get { return _signName; }
            set { _signName = value; }
        }
        /// <summary>
        /// 区
        /// </summary>
        public string AreaName
        {
            get { return _areaName; }
            set { _areaName = value; }
        }
        public string F1
        {
            get { return _f1; }
            set { _f1 = value; }
        }
        /// <summary>
        /// 序号
        /// </summary>
        public string F2
        {
            get { return _f2; }
            set { _f2 = value; }
        }
        /// <summary>
        /// 方式备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        /// <summary>
        /// 失效日期
        /// </summary>
        public string LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId
        {
            get;
            set;
        }
        /// <summary>
        /// 单位ID
        /// </summary>
        public string UnitId
        {
            get;
            set;
        }
        /// <summary>
        /// 医药公司Id 
        /// </summary>
        public string CompId
        {
            get;
            set;
        }
        /// <summary>
        ///仓库ID
        /// </summary>
        public string HouseId
        {
            get;
            set;
        }
        /// <summary>
        /// 审核人ID
        /// </summary>
        public string SignOperId
        {
            get;
            set;
        } 
        #endregion
    }
    #endregion
}







