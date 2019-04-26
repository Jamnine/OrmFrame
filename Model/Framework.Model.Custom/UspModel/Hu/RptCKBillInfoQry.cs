using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 出库详情 报表
    /// </summary>
    [Serializable]
    #region class of Model:RptCKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptCKBillInfo.
    /// </summary>
    public class RptCKBillInfoQry : BaseModel
    {
         
        private string _billNo = String.Empty;
        private DateTime _operTime;
        private string _outMemo = String.Empty;
        private string _billId;
        private string _inBatchId;
        private string _itemId;
        private double _drugNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _houseName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private string _unitName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private string _pNo = String.Empty;
        private string _roomName = String.Empty;
        private DateTime _signTime;
        private string _signName = String.Empty;
        private string _operName = String.Empty;
        private DateTime _limitDate;
        private string _f1 = String.Empty;
        private string _f2 = String.Empty;
        private string _f3 = String.Empty;
        private string _f4 = String.Empty;

        /// <summary>
        /// 出库详情 报表
        /// </summary>
        public RptCKBillInfoQry()
        {
        }



        #region Public Properties
        /// <summary>
        ///单据ID
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
        /// 描述
        /// </summary>
        public string OutMemo
        {
            get { return _outMemo; }
            set { _outMemo = value; }
        }
        /// <summary>
        /// 出库ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }
      
        /// <summary>
        /// 单据No
        /// </summary>
        public string F2
        {
            get { return _f2; }
            set { _f2 = value; }
        }
       
        /// <summary>
        /// 药品批次ID
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
        /// 药品数量
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
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
        /// 进货(买入)价.
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
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
        /// 项目简称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        /// <summary>
        /// 项目规格
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// 制造商厂名
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// 买入金额
        /// (进货(买入)价.*药品数量)
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        /// <summary>
        /// 零售金额
        /// (零售价*药品数量)
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// 入库批号
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }

        /// <summary>
        /// 诊所名称
        /// </summary>
        public string RoomName
        {
            get { return _roomName; }
            set { _roomName = value; }
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
        /// 审核人
        /// </summary>
        public string SignName
        {
            get { return _signName; }
            set { _signName = value; }
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
        /// 失效日期
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// 药库名(也叫：仓库名)
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }
        /// <summary>
        /// 仓库ID
        /// </summary>
        public string HouseId
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
        /// 库存目标诊所
        /// </summary>
        public string RoomId
        {
            get;
            set;

        }

        /// <summary>
        /// 操作ID
        /// </summary>
        public string OperId
        {
            get;
            set;
        }
        #endregion
    }
    #endregion
}







