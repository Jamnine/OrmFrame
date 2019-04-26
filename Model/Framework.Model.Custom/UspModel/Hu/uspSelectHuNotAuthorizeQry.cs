using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 库存管理列表信息
    /// (物品出库,退回厂商,物品报损,其他入库,物品入库,盘盈入库,盘亏出库,其他出库,领用退库,调拨入库,采购计划)
    /// </summary>
    [Serializable]
    #region class of Model:uspSelectHuNotAuthorizeQry
    /// <summary>
    /// This object represents the properties and methods of a uspSelectHuNotAuthorize.
    /// </summary>
    public class uspSelectHuNotAuthorizeQry : BaseModel
    {
         
        private string _billNo = String.Empty;
        private string _houseId;
        private string _operId;
        private DateTime _operTime;
        private bool _isSign;
        private double _retailTotle;
        private double _stockTotle;
        private string _type = String.Empty;
        private int _lsActType;
        private DateTime _signTime;
        private string _name = String.Empty;
        private string _memo = String.Empty;
        /// <summary>
        /// 库存管理列表信息
        /// (物品出库,退回厂商,物品报损,其他入库,物品入库,盘盈入库,盘亏出库,其他出库,领用退库,调拨入库,采购计划)
        /// </summary>
        public uspSelectHuNotAuthorizeQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// 单据编号
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
        /// 制单人
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string OperName { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        /// <summary>
        /// 是否已审核：0:未审核,1:已审核
        /// </summary>
        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
        }
        /// <summary>
        /// 零售总金额
        /// </summary>
        public double RetailTotle
        {
            get { return _retailTotle; }
            set { _retailTotle = value; }
        }
        /// <summary>
        /// 买入总金额
        /// </summary>
        public double StockTotle
        {
            get { return _stockTotle; }
            set { _stockTotle = value; }
        }
        /// <summary>
        /// 类型
        /// (比如：领用退库,调拨入库,采购计划..)
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// 出入库类别
        /// </summary>
        public int LsActType
        {
            get { return _lsActType; }
            set { _lsActType = value; }
        }
        /// <summary>
        /// 出入库时间
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 出库备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        
        #endregion
    }
    #endregion
}







