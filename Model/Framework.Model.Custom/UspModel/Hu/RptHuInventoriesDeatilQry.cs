using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 打印空白盘点单  报表
    /// </summary>
    [Serializable]
    #region class of Model:RptHuInventoriesDeatilQry
    /// <summary>
    /// This object represents the properties and methods of a RptHuInventoriesDeatil.
    /// </summary>
    public class RptHuInventoriesDeatilQry : BaseModel
    {
         
        private string _inBatchId;
        private double _balanceNum;
        private double _stcokNum;
        private double _instoreNum;
        private double _checkNum;
        private double _pkNum;
        private double _stockPrice;
        private double _retailPrice;
        private double _retailPricePk;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _pNo = String.Empty;
        private string _itemType = String.Empty;
        private DateTime _limitDate;
        private string _formName = String.Empty;
        private string _unitName = String.Empty;
        private DateTime _checkTime;
        private string _checkName = String.Empty;
        private string _spec = String.Empty;
        private string _houseName = String.Empty;
        private string _compName = string.Empty;
        private bool _optionPrice;
        private bool _isSpecSum;
        private bool _isCheched;
        private string _code = String.Empty;

        /// <summary>
        /// 打印空白盘点单  报表
        /// </summary>
        public RptHuInventoriesDeatilQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// 是否已结转记账：0-未记账 1-已记账
        /// </summary>
        public bool IsChecked
        {
            get { return _isCheched; }
            set { _isCheched = value; }
        }
        /// <summary>
        /// 药品批次ID.
        /// </summary>
        public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }
       
   

        /// <summary>
        /// .结存数量
        /// </summary>
        public double BalanceNum
        {
            get { return _balanceNum; }
            set { _balanceNum = value; }
        }
        /// <summary>
        /// 库存数量.
        /// </summary>
        public double StcokNum
        {
            get { return _stcokNum; }
            set { _stcokNum = value; }
        }
        /// <summary>
        /// 入库数量
        /// </summary>
        public double InstoreNum
        {
            get { return _instoreNum; }
            set { _instoreNum = value; }
        }
        /// <summary>
        /// 盘点数量.
        /// </summary>
        public double CheckNum
        {
            get { return _checkNum; }
            set { _checkNum = value; }
        }
        /// <summary>
        /// 盈亏数量
        /// </summary>
        public double PkNum
        {
            get { return _pkNum; }
            set { _pkNum = value; }
        }
        /// <summary>
        /// 实价
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
        /// 零售价盘亏
        /// </summary>
        public double RetailPricePk
        {
            get { return _retailPricePk; }
            set { _retailPricePk = value; }
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
        /// 项目类型
        /// </summary>
        public string ItemType
        {
            get { return _itemType; }
            set { _itemType = value; }
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
        /// 规格名称
        /// </summary>
        public string FormName
        {
            get { return _formName; }
            set { _formName = value; }
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
        /// 盘点时间
        /// </summary>
        public DateTime CheckTime
        {
            get { return _checkTime; }
            set { _checkTime = value; }
        }
        /// <summary>
        /// 盘点人
        /// </summary>
        public string CheckName
        {
            get { return _checkName; }
            set { _checkName = value; }
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
        /// 编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
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
        /// 医药公司名称
        /// </summary>
        public string CompName
        {
            get { return _compName; }
            set { _compName = value; }
        }
        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// 仓库ID
        /// </summary>
        public string HouseId { get; set; }
        /// <summary>
        /// 操作人ID
        /// </summary>
        public string OperId { get; set; }
        /// <summary>
        /// 医药公司ID
        /// </summary>
        public string CompId { get; set; }
        /// <summary>
        /// 单位ID
        /// </summary>
        public string UnitId { get; set; }

        #endregion
    }
    #endregion
}







