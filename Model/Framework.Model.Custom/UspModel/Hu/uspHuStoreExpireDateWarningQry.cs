using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    ///库存药品有效期预警集合类
    /// </summary>
    [Serializable]
    public partial class uspHuStoreExpireDateWarningQry : BaseModel
    {
        
        protected string _inBatchNo;
        protected string _code;
        protected string _name;
        protected string _spce;
        protected string _houseUnitName;
        protected string _companyName;
        protected bool _selected;
        protected string _storeDate;
        protected string _produceDate;
        protected string _limitDate;
        protected double _aheadAlert;
        protected double _stockNum;
        protected double _instoreNum;
        protected double _stockPrice;
        protected string _houseId;
        protected string _houseName;
        protected string _pNo;
        protected string _storesItemID;
        protected string _manuName;
        protected double _retailPrice;



        /// <summary>
        /// 流水号
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
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
        /// 简称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 规格
        /// </summary>
        public string Spce
        {
            get { return _spce; }
            set { _spce = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string HouseUnitName
        {
            get { return _houseUnitName; }
            set { _houseUnitName = value; }
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
        /// 是否选中
        /// </summary>
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }

        /// <summary>
        /// 入库日期
        /// </summary>
        public string StoreDate
        {
            get { return _storeDate; }
            set { _storeDate = value; }
        }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
        }

        /// <summary>
        /// 失效日期
        /// </summary>
        public string LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }

        /// <summary>
        /// 失效期提前提示的天数.
        /// </summary>
        public double AheadAlert
        {
            get { return _aheadAlert; }
            set { _aheadAlert = value; }
        }

        /// <summary>
        /// 库存单位数(大单位).
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
        /// 进货(买入)价.
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
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
        /// 药库名字
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
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
        /// 药品ID
        /// </summary>
        public string StoresItemID
        {
            get { return _storesItemID; }
            set { _storesItemID = value; }
        }

        /// <summary>
        /// 生产商名称
        /// </summary>
        public string ManuName
        {
            get { return _manuName; }
            set { _manuName = value; }
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
        /// 库存单位
        /// </summary>
        public int HouseUnit { get; set; }
        /// <summary>
        /// 医药公司id
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// 生产商id
        /// </summary>
        public int ManuId { set; get; }
    }
}

