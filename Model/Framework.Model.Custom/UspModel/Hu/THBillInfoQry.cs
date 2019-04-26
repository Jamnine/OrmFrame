using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 退回厂商物品列表
    /// </summary>
    [Serializable]
    #region class of Model:THBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a THBillInfo.
    /// </summary>
    public class THBillInfoQry : BaseModel
    {
         
        private string _inBatchId;
        private string _inBatchNo = String.Empty;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _memo = String.Empty;
        private string _voucherNo = String.Empty;
        private bool _isMargin;
        private string _billId;
        private string _billNo = String.Empty;
        private string _houseId;
        private string _compId;
        private DateTime _operTime;
        private string _operId;
        private bool _isSign;
        private DateTime _signTime;
        private string _signOperId;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private double _deltaAmount;
        private string _PNo = String.Empty;
        public DateTime LimitDate { get; set; }
        public double StockNum { get; set; }

        /// <summary>
        /// 退回厂商物品信息
        /// </summary>
        public THBillInfoQry()
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
        /// 总金额
        /// </summary>
        public double DeltaAmount
        {
            get { return _deltaAmount; }
            set { _deltaAmount = value; }
        }
        /// <summary>
        /// 单据号
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
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
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 发票号
        /// </summary>
        public string VoucherNo
        {
            get { return _voucherNo; }
            set { _voucherNo = value; }
        }

        /// <summary>
        /// 补差价退货
        /// </summary>
        public bool IsMargin
        {
            get { return _isMargin; }
            set { _isMargin = value; }
        }
        /// <summary>
        /// 退货出库ID
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
        /// 医药公司ID
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
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
        /// 制表人ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
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
        /// 审核人ID
        /// </summary>
        public string SignOperId
        {
            get { return _signOperId; }
            set { _signOperId = value; }
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
        /// 厂商
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
        /// 零售金额
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
            get { return _PNo; }
            set { _PNo = value; }
        }
        #endregion
    }
    #endregion
}






