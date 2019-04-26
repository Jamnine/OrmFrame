using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 库存警报下限
    /// </summary>
    [Serializable]
    #region class of Model:uspHuStoreUnderLineQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoreUnderLine.
    /// </summary>
    public class uspHuStoreUnderLineQry : BaseModel
    {
         
        private string _itemName = String.Empty;
        private string _companyName = String.Empty;
        private string _unitName = String.Empty;
        private string _areaName = String.Empty;
        private string _compId;
        private string _spec = String.Empty;
        private double _underLine;
        private double _uperLine;
        private double _stockPriceKc;
        private double _retailPriceKc;
        private string _houseName = String.Empty;
        private double _normalLineKc;
        private string _itemId;
        private int _orderBy;
        private string _itemCode = String.Empty;

        /// <summary>
        /// 库存警报下限
        /// </summary>
        public uspHuStoreUnderLineQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// 项目名
        /// </summary>
            public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
        /// 医药公司名称
        /// </summary>
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
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
        /// 地区名称
        /// </summary>
        public string AreaName
        {
            get { return _areaName; }
            set { _areaName = value; }
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
        /// 规格
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// 库存警报下限
        /// </summary>
        public double UnderLine
        {
            get { return _underLine; }
            set { _underLine = value; }
        }
        /// <summary>
        /// 库存警报上限
        /// </summary>
        public double UperLine
        {
            get { return _uperLine; }
            set { _uperLine = value; }
        }
        /// <summary>
        /// 买入价
        /// </summary>
        public double StockPriceKc
        {
            get { return _stockPriceKc; }
            set { _stockPriceKc = value; }
        }
        /// <summary>
        /// 零售价格
        /// </summary>
        public double RetailPriceKc
        {
            get { return _retailPriceKc; }
            set { _retailPriceKc = value; }
        }
        /// <summary>
        /// 仓库名
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }
        /// <summary>
        /// 采购维持库存量
        /// </summary>
        public double NormalLineKc
        {
            get { return _normalLineKc; }
            set { _normalLineKc = value; }
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
        /// 排序
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }
        /// <summary>
        /// 制药公司ID
        /// </summary>
        public string ManuId { set; get; }
        /// <summary>
        /// 药库单位
        /// </summary>
        public int UnitKc { set; get; }
        /// <summary>
        /// 仓库ID
        /// </summary>
        public string HouseId { set; get; }
       
        #endregion
    }
    #endregion
}







