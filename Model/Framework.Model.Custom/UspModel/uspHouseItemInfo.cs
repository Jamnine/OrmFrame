using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 物品出库 列表
    /// </summary>
    [Serializable]
    public class uspHouseItemInfo
    {
        private string _inBatchId;
        private string _inBatchNo = String.Empty;
        private string _itemId;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _unitId;
        private string _unitName = String.Empty;
        private string _manuNmae = String.Empty;
        private string _spec;
        private string _groupId;
        private double _stockNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _pNo = String.Empty;
        private DateTime _date;
        private bool _isOnlyForSys;
        private string _barCode = "";
        /// <summary>
        /// 物品出库 列表
        /// </summary>
        public uspHouseItemInfo(){}

        /// <summary>
        /// 入库记录ID
        /// </summary>
        public string InBatchId
        {
            get
            {
                return this._inBatchId;
            }
            set
            {
                this._inBatchId = value;
            }
        }

        /// <summary>
        ///  库存单位数(大单位).
        /// </summary>
        public double StockNum
        {
            get
            {
                return this._stockNum;
            }
            set
            {
                this._stockNum = value;
            }
        }
        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId
        {
            get
            {
                return this._itemId;
            }
            set
            {
                this._itemId = value;
            }
        }
        /// <summary>
        /// 主组。外键，引用BsGroup.GUID.
        /// </summary>
        public string GroupId
        {
            get
            {
                return this._groupId;
            }
            set
            {
                this._groupId = value;
            }
        }
        /// <summary>
        /// 简称
        /// </summary>
        public string ItemName
        {
            get
            {
                return this._itemName;
            }
            set
            {
                this._itemName = value;
            }
        }
        /// <summary>
        /// 编码
        /// </summary>
        public string ItemCode
        {
            get
            {
                return this._itemCode;
            }
            set
            {
                this._itemCode = value;
            }
        }
        /// <summary>
        /// 流水号
        /// </summary>
        public string InBatchNo
        {
            get
            {
                return this._inBatchNo;
            }
            set
            {
                this._inBatchNo = value;
            }
        }
        /// <summary>
        /// 批号
        /// </summary>
        public string PNo
        {
            get
            {
                return this._pNo;
            }
            set
            {
                this._pNo = value;
            }
        }

        /// <summary>
        /// 门诊单位。外键，引用BsUnit..GUID.
        /// </summary>
        public string UnitId
        {
            get
            {
                return this._unitId;
            }
            set
            {
                this._unitId = value;
            }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string UnitName
        {
            get
            {
                return this._unitName;
            }
            set
            {
                this._unitName = value;
            }
        }
        /// <summary>
        /// 生产商名称
        /// </summary>
        public string ManuName
        {
            get
            {
                return this._manuNmae;
            }
            set
            {
                this._manuNmae = value;
            }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string Spec
        {
            get
            {
                return this._spec;
            }
            set
            {
                this._spec = value;
            }
        }
        /// <summary>
        /// 进货(买入)价.
        /// </summary>
        public double StockPrice
        {
            get
            {
                return this._stockPrice;
            }
            set
            {
                this._stockPrice = value;
            }
        }

        /// <summary>
        /// 零售价.
        /// </summary>
        public double RetailPrice
        {
            get
            {
                return this._retailPrice;
            }
            set
            {
                this._retailPrice = value;
            }
        }

        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }

        /// <summary>
        /// 是否库存.
        /// </summary>
        public bool IsOnlyForSys
        {
            get
            {
                return this._isOnlyForSys;
            }
            set
            {
                this._isOnlyForSys = value;
            }
        }

        /// <summary>
        /// 条形码
        /// </summary>
        public string BarCode
        {
            get
            {
                return this._barCode;
            }
            set
            {
                this._barCode = value;
            }
        }
    }
}
