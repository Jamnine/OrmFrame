using System;
using System.Data;
using System.Data.Common;

namespace Orm.Model.Custom
{
    [Serializable]
    #region class of Model:rptTjBillInfoQry
    /// <summary>   
    /// This object represents the properties and methods of a rptTjBillInfo.   
    /// </summary>   
    public class RptTjBillInfoQry : BaseModel
    {
        protected int _iD;
        protected int _billId;
        protected string _billNo = String.Empty;
        protected int _houseId;
        protected string _houseName = String.Empty;
        protected string _code = String.Empty;
        protected int _itemId;
        protected string _itemName = String.Empty;
        protected string _spec = String.Empty;
        protected double _oldPrice;
        protected double _newPrice;
        protected DateTime _notifyDate;
        protected int _unitId;
        protected string _unitName = String.Empty;
        protected DateTime _operTime;
        protected string _operName = String.Empty;
        protected string _memo = String.Empty;
        protected string _jy = String.Empty;
        protected string _f1 = String.Empty;
        protected string _f2 = String.Empty;
        protected string _f3 = String.Empty;
        protected string _f4 = String.Empty;


        public RptTjBillInfoQry()
        {
        }       

        #region Public Properties
        //public override int ID
        //{
        //    get { return _iD; }
        //    set { _iD = value; }
        //}


        /// <summary>  
        ///   
        /// </summary>  
        public int BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public int HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public double OldPrice
        {
            get { return _oldPrice; }
            set { _oldPrice = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public double NewPrice
        {
            get { return _newPrice; }
            set { _newPrice = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public DateTime NotifyDate
        {
            get { return _notifyDate; }
            set { _notifyDate = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public int UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string Jy
        {
            get { return _jy; }
            set { _jy = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string F1
        {
            get { return _f1; }
            set { _f1 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string F2
        {
            get { return _f2; }
            set { _f2 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string F3
        {
            get { return _f3; }
            set { _f3 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string F4
        {
            get { return _f4; }
            set { _f4 = value; }
        }

        #endregion
    }
    #endregion
}



