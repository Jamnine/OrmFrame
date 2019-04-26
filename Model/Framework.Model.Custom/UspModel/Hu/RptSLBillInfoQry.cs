using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    #region class of Model:RptSLBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptSLBillInfo.
    /// </summary>
    public class RptSLBillInfoQry : BaseModel
    {
         
        private int _inBatchId;
        private int _itemId;
        private int _unitId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _reason = String.Empty;
        private int _billId;
        private string _billNo = String.Empty;
        private DateTime _operTime;
        private string _memo = String.Empty;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _pNo = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private string _houseName = String.Empty;
        private string _operName = String.Empty;
        private string _signName = String.Empty;

        public RptSLBillInfoQry()
        {
        }



        #region Public Properties
            public int InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }

        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public int UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }

        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }

        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        public int BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }

        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }

        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }

        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }

        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }

        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }

        public string SignName
        {
            get { return _signName; }
            set { _signName = value; }
        }
        public int houseId { get; set; }
        public int operId { get; set; }
        public int signoperId { get; set; }
        #endregion
    }
    #endregion
}







