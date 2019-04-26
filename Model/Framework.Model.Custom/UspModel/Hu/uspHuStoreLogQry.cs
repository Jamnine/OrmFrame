using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 进出日志信息
    /// </summary>
    [Serializable]
    #region class of Model:uspHuStoreLogQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoreLogQry.
    /// </summary>
    public class uspHuStoreLogQry : BaseModel
    {
        private DateTime _happenTime;
        private string _itemId;
        private string _itemCode;
        private string _itemName;
        private string _pNo;
        private DateTime _limitDate;
        private string _manufacturerName;
        private double _beforeStockNum;
        private double _beforeTotalStockNum;
        private double _happenNum;
        private double _afterStockNum;
        private double _afterTotalStockNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _billNo;
        private string _lsActType;
        private string _memo;
        private string _houseId;
        private string _unitId;
        /// <summary>
        /// 进出日志信息
        /// </summary>
        public uspHuStoreLogQry()
        {
        }


        #region Public Properties

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        /// <summary>
        /// 仓库
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        /// <summary>
        /// 发生时间
        /// </summary>
        public DateTime HappenTime
        {
            get { return _happenTime; }
            set { _happenTime = value; }
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
        /// 批号
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }
        /// <summary>
        /// 制药公司名称
        /// </summary>
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { _manufacturerName = value; }
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
        /// 出入库类型
        /// </summary>
        public string LsActType
        {
            get { return _lsActType; }
            set { _lsActType = value; }
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
        /// 失期日期
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// 操作前该批次的库存数量
        /// </summary>
        public double BeforeStockNum
        {
            get { return _beforeStockNum; }
            set { _beforeStockNum = value; }
        }
        /// <summary>
        /// 操作前该药品的所有批次的总库存数量
        /// </summary>
        public double BeforeTotalStockNum
        {
            get { return _beforeTotalStockNum; }
            set { _beforeTotalStockNum = value; }
        }
        /// <summary>
        /// 发生数量
        /// </summary>
        public double HappenNum
        {
            get { return _happenNum; }
            set { _happenNum = value; }
        }
        /// <summary>
        /// /操作后药品的库存数量
        /// </summary>
        public double AfterStockNum
        {
            get { return _afterStockNum; }
            set { _afterStockNum = value; }
        }
        /// <summary>
        /// 操作后该药品的所有批次的总库存数量
        /// </summary>
        public double AfterTotalStockNum
        {
            get { return _afterTotalStockNum; }
            set { _afterTotalStockNum = value; }
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
        /// 买入价
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }

        /// <summary>
        /// 接收列表行总数
        /// </summary>
        public int RowCount { get; set; }

        #endregion
    }
    #endregion
}