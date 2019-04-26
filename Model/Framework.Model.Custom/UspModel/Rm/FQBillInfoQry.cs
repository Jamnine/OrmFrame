using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 物品申领列表
    /// </summary>
    [Serializable]
    #region class of Model:FQBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a FQBillInfo.
    /// </summary>
    public class FQBillInfoQry : BaseModel
    {
        private string _itemId;
        private double _drugNum;
        private string _unitId;
        private string _billId;
        private string _billNo = String.Empty;
        private string _houseId;
        private string _roomId;
        private DateTime _operTime;
        private string _operId;
        private bool _isAffirm;
        private DateTime _affirmTime;
        private string _affirmOperid;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _retailPrice;
        private double _totalRetail;
        private string _unitName = String.Empty;
        private string _huTotalSum = String.Empty;
        private string _rmTotalSum = String.Empty;
        private string _batchNo = String.Empty;
        private string _limitDate = String.Empty;

        /// <summary>
        /// 物品申领列表
        /// </summary>
        public FQBillInfoQry()
        {
        }


        #region Public Properties
        /// <summary>
        /// 项目ID
        /// </summary>
            public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// 药房领药申请数量
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// 单位Id 
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
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
        /// 药房ID
        /// </summary>
        public string RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
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
        /// 是否确认
        /// </summary>
        public bool IsAffirm
        {
            get { return _isAffirm; }
            set { _isAffirm = value; }
        }
        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime AffirmTime
        {
            get { return _affirmTime; }
            set { _affirmTime = value; }
        }
        /// <summary>
        /// 确认操作人ID
        /// </summary>
        public string AffirmOperid
        {
            get { return _affirmOperid; }
            set { _affirmOperid = value; }
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
        /// 零售价
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }
        /// <summary>
        /// 零售总额 
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
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
        /// 库存总金额
        /// </summary>
        public string HuTotalSum
        {
            get { return _huTotalSum; }
            set { _huTotalSum = value; }
        }
        /// <summary>
        /// 药房总金额
        /// </summary>
        public string RmTotalSum
        {
            get { return _rmTotalSum; }
            set { _rmTotalSum = value; }
        }
        /// <summary>
        /// 批次号
        /// </summary>
        public string BatchNo
        {
            get { return _batchNo; }
            set { _batchNo = value; }
        }
        /// <summary>
        /// 失期日期
        /// </summary>
        public string LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        #endregion
    }
    #endregion
}







