using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 出入库记录
    /// </summary>
    [Serializable]
    #region class of Model:uspHustoresDtailQry
    /// <summary>
    /// This object represents the properties and methods of a uspHustoresDtail.
    /// </summary>
    public class uspHustoresDtailQry : BaseModel
    {
         
        private string _itemId;
        private string _inBatchNo = String.Empty;
        private string _pNo = String.Empty;
        private string _unitId;
        private string _unitName = String.Empty;
        private double _stockNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _storeDate;
        private string _produceDate;
        private string _limitDate;
        private double _retailTotal;
        private double _priceTotal;
        private double _priceDiag;
        private string _spec = String.Empty;

        /// <summary>
        /// 出入库记录
        /// </summary>
        public uspHustoresDtailQry()
        {
        }




        #region Public Properties
        /// <summary>
        ///项目ID
        /// </summary>
            public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
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
        /// 批号
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
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
        /// 单位名
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
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
        /// 买入价
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }
        /// <summary>
        /// 零售价格
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }
        /// <summary>
        /// 入库日期
        /// </summary>
        public string StoreDate
        {
            get { return _storeDate; }
            set { _storeDate = value; }
        }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
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
        /// 零售总额
        /// </summary>
        public double RetailTotal
        {
            get { return _retailTotal; }
            set { _retailTotal = value; }
        }
        /// <summary>
        /// 总价格
        /// </summary>
        public double PriceTotal
        {
            get { return _priceTotal; }
            set { _priceTotal = value; }
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
        /// 门诊价格
        /// </summary>
        public double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }
        #endregion
    }
    #endregion
}







