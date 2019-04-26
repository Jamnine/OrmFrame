using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 采购计划列表
    /// </summary>
    [Serializable]
    #region class of Model:QSBillInfoQry
    
    public class QSBillInfoQry : BaseModel
    {
         
        private string _billId;
        private string _billNo = String.Empty;
        private string _houseId;
        private string _applyTime;
        private string _valideTime;
        private string _applyIdea = String.Empty;
        private string _applyHander = String.Empty;
        private string _operId;
        private string _operTime;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _totalPrice;
        private double _totalRetail; 
        private int _proAreaId;
        private string _manuId;
        private string _passNo = String.Empty;
        private double _saleNum;
        private string _f1 = String.Empty;
        private DateTime _orderByTime; //排序时间
        private double _underLineKc;
        private double _uperLineKc;
        /// <summary>
        /// 采购计划列表
        /// </summary>
        public QSBillInfoQry()
        {
        }


        #region Public Properties

        /// <summary>
        /// 采购ID
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
        /// 药库ID
        /// </summary>
        public string  HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }

        /// <summary>
        /// 申请时间
        /// </summary>
        public string ApplyTime
        {
            get { return _applyTime; }
            set { _applyTime = value; }
        }

        /// <summary>
        /// 有效期至.
        /// </summary>
        public string ValideTime
        {
            get { return _valideTime; }
            set { _valideTime = value; }
        }

        /// <summary>
        /// 申请意见.
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
        /// 操作人ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
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
        /// 采购数
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
        /// 单位名称
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
        /// 采购金额
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
       /// 销售数量
       /// </summary>
        public double SaleNum
        {
            get { return _saleNum; }
            set { _saleNum = value; }
        }

        /// <summary>
        /// 库存警报下限
        /// </summary>
        public double UnderLineKc
        {
            get { return _underLineKc; }
            set { _underLineKc = value; }
        }


        /// <summary>
        /// 排序时间
        /// </summary>
        public DateTime OrderByTime
        {
            get { return _orderByTime; }
            set { _orderByTime = value; }
        }
        /// <summary>
        /// 库存警报上限.
        /// </summary>
        public double UperLineKc
        {
            get { return _uperLineKc; }
            set { _uperLineKc = value; }
        }

        
        /// <summary>
        /// 生产商ID
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
        }
      
       
        #endregion
    }
    #endregion
}







