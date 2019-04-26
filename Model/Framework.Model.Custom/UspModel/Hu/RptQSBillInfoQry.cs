using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 报表 采购计划列表
    /// </summary>
    [Serializable]
    #region class of Model:RptQSBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptQSBillInfo.
    /// </summary>
    public class RptQSBillInfoQry : BaseModel
    {
         
        private string _billId;
        private string _billNo = String.Empty;
        private DateTime _applyTime;
        private DateTime _valideTime;
        private string _applyIdea = String.Empty;
        private string _applyHander = String.Empty;
        private DateTime _operTime;
        private string  _unitId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private double _stockNum;
        private string _houseName = String.Empty;
        private string _userName = String.Empty;
        private string _companyName = String.Empty;
        private string _manufacturerName = String.Empty;
        private DateTime _orderByTime; //排序时间

        /// <summary>
        /// 报表 采购计划列表
        /// </summary>
        public RptQSBillInfoQry()
        {
        }


        #region Public Properties
        /// <summary>
        /// 采购计划表ID
        /// </summary>
         public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// 采购单据号
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime ApplyTime
        {
            get { return _applyTime; }
            set { _applyTime = value; }
        }
        /// <summary>
        /// 有效期至
        /// </summary>
        public DateTime ValideTime
        {
            get { return _valideTime; }
            set { _valideTime = value; }
        }
        /// <summary>
        /// 申请意见
        /// </summary>
        public string ApplyIdea
        {
            get { return _applyIdea; }
            set { _applyIdea = value; }
        }
  
        /// <summary>
        /// 申请人
        /// </summary>
        public string ApplyHander
        {
            get { return _applyHander; }
            set { _applyHander = value; }
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
        /// 单位ID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        /// <summary>
        /// 采购数量
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// 采购价
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
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
        /// 单位名
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
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
        /// 项目简称
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
        /// 采购金额
        /// (采购价*采购数量)
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        /// <summary>
        /// 零售金额
        /// (零售价*采购数量)
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// 库存单位数(大单位)
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
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
        /// 用户名称
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        /// <summary>
        /// 医药公司名称
        /// </summary>
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        /// <summary>
        /// 制造商厂名
        /// </summary>
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { _manufacturerName = value; }
        }
        /// <summary>
        /// 医药公司ID
        /// </summary>
        public int CompId
        {
            get;
            set; 
        }
        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId { get ; set; }

        /// <summary>
        /// 仓库ID
        /// </summary>
        public int HouseId
        {
            get;
            set;
        }
        /// <summary>
        /// 操作人ID
        /// </summary>
        public int OperId
        {
            get;
            set;
        }
        /// <summary>
        /// 排序时间
        /// </summary>
        public DateTime OrderByTime
        {
            get { return _orderByTime; }
            set { _orderByTime = value; }
        }
        #endregion
    }
    #endregion
}







