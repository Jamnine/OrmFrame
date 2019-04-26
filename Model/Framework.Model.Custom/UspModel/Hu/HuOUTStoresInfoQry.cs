using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 出库记录
    /// </summary>
    [Serializable]
    #region class of Model:HuOUTStoresInfoQry
    /// <summary>
    /// This object represents the properties and methods of a HuOUTStoresInfo.
    /// </summary>
    public class HuOUTStoresInfoQry : BaseModel
    {
         
        private string _inBatchNo = String.Empty;
        private string _houseId;
        private string _itemId;
        private string _pNo = String.Empty;
        private string _unitId;
        private string _compId;
        private double _stockNum;
        private double _instoreNum;
        private double _stockPrice;
        private double _retailPrice;
        private DateTime _storeDate;
        private DateTime _produceDate;
        private DateTime _limitDate;
        private bool _isBalance;
        private bool _isNewin;
        private bool _isBid;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private string _unitName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;

        /// <summary>
        /// 出库记录
        /// </summary>
        public HuOUTStoresInfoQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// 入库记录(流水号)
        /// </summary>
            public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }
        /// <summary>
        /// 药库ID(仓库ID)
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        /// <summary>
        /// 药品ID
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        /// <summary>
        /// 入库记录批号
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }
        /// <summary>
        /// 入库记录单位ID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }
        /// <summary>
        /// 入库记录医药公司ID
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }
        /// <summary>
        /// 入库记录库存单位数(大单位).
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
        }
        /// <summary>
        /// 入库数量.
        /// </summary>
        public double InstoreNum
        {
            get { return _instoreNum; }
            set { _instoreNum = value; }
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
        ///入库日期
        /// </summary>
        public DateTime StoreDate
        {
            get { return _storeDate; }
            set { _storeDate = value; }
        }
        /// <summary>
        /// 生产日期.
        /// </summary>
        public DateTime ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
        }
        /// <summary>
        /// 失期日期.
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// 结存.
        /// </summary>
        public bool IsBalance
        {
            get { return _isBalance; }
            set { _isBalance = value; }
        }
        /// <summary>
        /// 是否新入库.
        /// </summary>
        public bool IsNewin
        {
            get { return _isNewin; }
            set { _isNewin = value; }
        }
        /// <summary>
        /// 是否招标.
        /// </summary>
        public bool IsBid
        {
            get { return _isBid; }
            set { _isBid = value; }
        }
        /// <summary>
        /// 编码.
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }
        /// <summary>
        /// 简称.
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        /// <summary>
        /// 规格.
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// 生产商名称.
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }
        /// <summary>
        /// 单位.
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// 买入(进货)金额
        /// 进货(买入)价*库存单位数(大单位).
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        /// <summary>
        /// 零售金额
        /// 零售价*库存单位数(大单位).
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







