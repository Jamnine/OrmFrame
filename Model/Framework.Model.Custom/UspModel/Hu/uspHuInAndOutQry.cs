using System;

namespace Orm.Model.Custom
{
    /// <summary>
    ///调拨(入,出)库
    /// </summary>
    [Serializable]
    #region class of Model:uspHuInAndOutQry
    /// <summary>
    /// This object represents the properties and methods of a uspSelectHuNotAuthorize.
    /// </summary>
    public class uspHuInAndOutQry : BaseModel
    {

        private string _billNo = String.Empty;
        private string _houseId;
        private string _operId;
        private string _operName;
        private DateTime _operTime;
        private bool _isSign;
        private double _retailTotle;
        private double _stockTotle;
        private string _type = String.Empty;
        private int _lsActType;
        private DateTime _signTime;
        private string _name = String.Empty;
        private bool _isSelected = false;
        private string _pNo = String.Empty;
        private string _itemCodey;
        private int _cons;

        public int PageNumber { get; set; }
        public string Depotid { get; set; }

        public int HasInvo { get; set; }

        public string RoomName { get; set; }//药房
        public string CompName { get; set; }//供应商

        public string Memo { get; set; }
        public string Reason { get; set; }

        public string DispUnit { get; set; }


        /// <summary>
        ///调拨(入,出)库
        /// </summary>
        public uspHuInAndOutQry()
        {
        }

        #region Public Properties
        /// <summary>
        /// 单据号
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// 仓库Id 
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
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
        /// 操作人姓名
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
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
        /// 是否已审核：0:未审核,1:已审核.
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
        /// 审核时间 
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
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
        ///是否选中单据
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }
        /// <summary>
        /// 类别(出入库类别)
        /// </summary>
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        /// <summary>
        /// 批号
        /// </summary>
        public string PNo
        {
            get
            {
                return _pNo;
            }

            set
            {
                _pNo = value;
            }
        }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string ItemCodey
        {
            get
            {
                return _itemCodey;
            }

            set
            {
                _itemCodey = value;
            }
        }

        /// <summary>
        /// 门店名称
        /// </summary>
        public string LocName { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        public int Cons { get; set; }
        #endregion
    }
    #endregion
}







