using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 项目其他出库
    /// </summary>
    [Serializable]
    #region class of Model:SLBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a SLBillInfo.
    /// </summary>
    public class SLBillInfoQry : BaseModel
    {
         
        private string _inBatchId;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _reason = String.Empty;
        private string _billId;
        private string _billNo = String.Empty;
        private string _houseId;
        private DateTime _operTime;
        private string _operId;
        private string _memo = String.Empty;
        private bool _isSign;
        private DateTime _signTime;
        private string _signOperId;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private string _PNo = String.Empty;
        private double _totalPrice;
        private double _totalRetail;

        /// <summary>
        /// 项目其他出库
        /// </summary>
        public SLBillInfoQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// .药品批次ID
        /// </summary>
        public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
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
        /// 单位ID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }
        /// <summary>
        /// 药品数量.
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
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
        /// 报损原因
        /// </summary>
        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
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
        /// 单据号
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// 仓库ID
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
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
        /// 操作人ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// 备注.
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        /// <summary>
        /// 是否已审核：0:未审核,1:已审核.
        /// </summary>
        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
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
        /// 单位名
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// 项目编码
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }
        /// <summary>
        /// 项目名称
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
        /// 制药公司名称
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }
        /// <summary>
        ///批号
        /// </summary>
        public string PNo
        {
            get { return _PNo; }
            set { _PNo = value; }
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
        /// 总金额
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        #endregion
    }
    #endregion
}







