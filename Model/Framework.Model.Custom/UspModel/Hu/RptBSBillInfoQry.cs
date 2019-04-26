using System;

namespace Orm.Model.Custom
{
    /// <summary>
    ///  打印物品报损
    /// </summary>
    [Serializable]
    #region class of Model:RptBSBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptBSBillInfo.
    /// </summary>
    public class RptBSBillInfoQry : BaseModel
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
        private DateTime _operTime;
        private string _memo = String.Empty;
        private string _unitName = String.Empty;
        private string _dRUGS_ID = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private string _pNo = String.Empty;
        private DateTime _limitDate;
        private string _houseName = String.Empty;
        private string _operName = String.Empty;
        private string _bsItemId;

        /// <summary>
        ///  打印物品报损
        /// </summary>
        public RptBSBillInfoQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// 领药批次ID.
        /// </summary>
        public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }
        /// <summary>
        /// /项目ID
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
        /// 数量
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// 买入价
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
        /// 报损原因.
        /// </summary>
        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }
        /// <summary>
        /// 报损出库ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }
        /// <summary>
        /// 报损出库单号
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
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
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
        public string DRUGS_ID
        {
            get { return _dRUGS_ID; }
            set { _dRUGS_ID = value; }
        }
        /// <summary>
        /// 项目名
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
        /// <summary>
        /// 批号
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
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
        /// 仓库名称
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }
        /// <summary>
        /// 项目ID
        /// </summary>
        public string BsItemId
        {
            get { return _bsItemId; }
            set { _bsItemId = value; }
        }
        #endregion
    }
    #endregion
}







