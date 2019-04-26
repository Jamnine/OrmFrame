using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    public class uspHustoresTotal
    {
        public string GUID { get; set; }
        private string _inBatchNo;  //流水号

        private string _houseId;  //药库ID

        private string _itemId;  //药品ID

        private string _pNo;  //批号

        private string _unitId;  //入库单位（大单位）

        private string _compId;  //医药公司ID

        private double _stockNum;  //库存单位数(大单位)

        private double _instoreNum;  //入库数量

        private double _stockPrice;  //进货(买入)价

        private double _retailPrice;  //零售价

        private DateTime _storeDate;  //入库日期

        private DateTime _produceDate;  //生产日期

        private DateTime _limitDate;  //失期日期

        private bool _isBalance;  //结存

        private bool _isNewin;  //是否新入库

        private bool _isBid;  //是否招标

        private int _HospitalID;  //

        private double _retailTotal;

        private double _priceTotal;

        private string _unitName;  //单位

        private int _rN;
        public int RN
        {
            get { return _rN; }
            set { _rN = value; }
        }

        #region BsItem
        private string _itemCode = "";  //BsItem编码

        private string _itemName = "";  //BsItem简称

        private string _itemSpec = string.Empty;  //BsItem规格
        private string _groupMainId = string.Empty;  //BsItem主组
        #endregion


        #region BsItemDrug


        private string _formId;  //剂型

        private string _manuId;  //生产商
        private int _proAreaId;  //产地

        private double _underLineKc;  //库存警报下限

        private double _uperLineKc;  //库存警报上限

        private double _normalLineKc;  //采购维持库存量

        private int _lsImport;  //药品来源：1-进口药；2-合资药；3-国产药

        private bool _isInject;  //是否注射剂

        private string _areaKc;  //药库放置位置

        #endregion

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        /// <summary>
        /// 药库放置位置
        /// </summary>
        public string AreaKc
        {
            get { return _areaKc; }
            set { _areaKc = value; }
        }

        /// <summary>
        /// 药品来源：1-进口药；2-合资药；3-国产药
        /// </summary>
        public int LsImport
        {
            get { return _lsImport; }
            set { _lsImport = value; }
        }

        /// <summary>
        /// 是否注射剂
        /// </summary>
        public bool IsInject
        {
            get { return _isInject; }
            set { _isInject = value; }
        }

        /// <summary>
        /// 库存警报下限 UnderlineKc
        /// </summary>
        public double UnderLineKc
        {
            get { return _underLineKc; }
            set { _underLineKc = value; }
        }

        /// <summary>
        /// 库存警报上限 UperLineKc UperlineKc
        /// </summary>
        public double UperLineKc
        {
            get { return _uperLineKc; }
            set { _uperLineKc = value; }
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
        /// 产地
        /// </summary>
        public int ProAreaId
        {
            get { return _proAreaId; }
            set { _proAreaId = value; }
        }

        /// <summary>
        /// 剂型
        /// </summary>
        public string FormId
        {
            get { return _formId; }
            set { _formId = value; }
        }

        /// <summary>
        /// 生产商
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
        }










        public double PriceTotal
        {
            get { return _priceTotal; }
            set { _priceTotal = value; }
        }



        public double RetailTotal
        {
            get { return _retailTotal; }
            set { _retailTotal = value; }
        }

        /// <summary>
        /// 规格
        /// </summary>
        public string ItemSpec
        {
            get { return _itemSpec; }
            set { _itemSpec = value; }
        }

        /// <summary>
        /// 主组
        /// </summary>
        public string GroupMainId
        {
            get { return _groupMainId; }
            set { _groupMainId = value; }
        }

        /// <summary>
        /// 编码
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        /// <summary>
        /// 简称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
        /// 药库ID
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }

        /// <summary>
        /// 药品ID
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
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
        /// 入库单位（大单位）
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
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
        /// 库存单位数(大单位)
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
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
        /// 进货(买入)价
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
        /// 入库日期
        /// </summary>
        public DateTime StoreDate
        {
            get { return _storeDate; }
            set { _storeDate = value; }
        }

        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
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
        /// 结存
        /// </summary>
        public bool IsBalance
        {
            get { return _isBalance; }
            set { _isBalance = value; }
        }

        /// <summary>
        /// 是否新入库
        /// </summary>
        public bool IsNewin
        {
            get { return _isNewin; }
            set { _isNewin = value; }
        }

        /// <summary>
        /// 是否招标
        /// </summary>
        public bool IsBid
        {
            get { return _isBid; }
            set { _isBid = value; }
        }



        /// <summary>
        /// 
        /// </summary>
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }


    }
}
