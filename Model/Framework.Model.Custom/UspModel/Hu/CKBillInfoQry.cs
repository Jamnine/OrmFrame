using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 物品出库详情
    /// </summary>
    [Serializable]
    #region class of Model:CKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a CKBillInfo.
    /// </summary>
    public class CKBillInfoQry : BaseModel
    {
         
        private string _billNo = String.Empty;
        private string _houseId;
        private string _roomId;
        private string _applyId;
        private string _operId;
        private DateTime _operTime;
        private string _outMemo = String.Empty;
        private bool _yFSign;
        private string _yFOperId;
        private DateTime _yFOperTime;
        private bool _isSign;
        private DateTime _signTime;
        private DateTime _limitDate;
        private string _signOperId;
        private string _applyNo = String.Empty;
        private string  _billId;
        private string _inBatchId;
        public string _inBatchNo = String.Empty;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private string _unitName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private double _deltaAmount;
        private double _deltaPrice;
        private string _pNo = String.Empty;
        private bool _isSelect;
        private bool _isStockNum;
        private double _stockNum;

        /// <summary>
        /// 物品出库详情
        /// </summary>
        public CKBillInfoQry()
        {
        }

        /// <summary>
        /// 流水号
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }

        #region Public Properties
        /// <summary>
        /// 单据ID
        /// </summary>
            public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
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
        /// 库存目标诊所
        /// </summary>
        public string RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }

        /// <summary>
        /// 药房领药申请单ID
        /// </summary>
        public string ApplyId
        {
            get { return _applyId; }
            set { _applyId = value; }
        }

        /// <summary>
        /// 制表人ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
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
        /// 出库备注
        /// </summary>
        public string OutMemo
        {
            get { return _outMemo; }
            set { _outMemo = value; }
        }

        /// <summary>
        /// 药房确认标志
        /// </summary>
        public bool YFSign
        {
            get { return _yFSign; }
            set { _yFSign = value; }
        }

        /// <summary>
        /// 出库人
        /// </summary>
        public string YFOperId
        {
            get { return _yFOperId; }
            set { _yFOperId = value; }
        }
        /// <summary>
        /// 出库时间
        /// </summary>
        public DateTime YFOperTime
        {
            get { return _yFOperTime; }
            set { _yFOperTime = value; }
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
        /// 审核日期
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
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
        /// 审核人
        /// </summary>
        public string SignOperId
        {
            get { return _signOperId; }
            set { _signOperId = value; }
        }
        /// <summary>
        /// 申请单号
        /// </summary>
        public string ApplyNo
        {
            get { return _applyNo; }
            set { _applyNo = value; }
        }

        /// <summary>
        /// 出库ID
        /// </summary>
        public string  BillId
        {
            get { return _billId; }
            set { _billId = value; }
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
        /// 零售价
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
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
        /// 物品编号
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
        /// 生产商名称
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
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

        public double DeltaAmount
        {
            get { return _deltaAmount; }
            set { _deltaAmount = value; }
        }

        public double DeltaPrice
        {
            get { return _deltaPrice; }
            set { _deltaPrice = value; }
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
        /// 是否选中
        /// </summary>
        public bool IsSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }

        /// <summary>
        /// 区分从领药申请单调出是库存是否足够.
        /// </summary>
        public bool IsStockNum
        {
            get { return _isStockNum; }
            set { _isStockNum = value; }
        }
        /// <summary>
        /// 库存
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
        }
        #endregion
    }
    #endregion
}







