using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    #region class of Model:HuDrugOutByBillNoQry
    /// <summary>
    /// This object represents the properties and methods of a HuDrugOutByBillNo.
    /// </summary>
    public class HuDrugOutByBillNoQry : BaseModel
    {
         
        private string _billNo = String.Empty;
        private int _houseId;
        private int _roomId;
        private bool _isAffirm;
        private int _billId;
        private int _itemId;
        private double _drugNum;
        private int _unitId;
        private int _applyId;

        public HuDrugOutByBillNoQry()
        {
        }


        #region Public Properties
            public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }

        public int HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }

        public int RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }

        public bool IsAffirm
        {
            get { return _isAffirm; }
            set { _isAffirm = value; }
        }

        public int BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }

        public int UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        public int ApplyId
        {
            get { return _applyId; }
            set { _applyId = value; }
        }
        #endregion
    }
    #endregion
}



