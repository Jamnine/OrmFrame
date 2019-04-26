using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 库存记录下限预警
    /// </summary>  
    [Serializable]
    #region class of Model:uspHuStoreUnderLineWarningQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoreUnderLineWarning.
    /// </summary>
    public class uspHuStoreUnderLineWarningQry : BaseModel
    {
        private string _houseId;
        private string _itemId;
        private string _itemCode;
        private string _unitId;
        private string _compId;
        private string _itemName = String.Empty;
        private string _companyName = String.Empty;
        private string _unitName = String.Empty;
        private string _spec = String.Empty;
        private double _stockPrice;
        private double _retailPrice;
        private double _underLineKc;
        private double _uperLineKc;
        private bool _selected;
        private double _stockNum;
        private double _normalLinekc;
        private string _groupId;
        private string _groupName = String.Empty;
        private bool _isOnlyForSys;
        private string _memo=string.Empty;
        public int Status { get; set; }

        /// <summary>
        /// 库存记录下限预警
        /// </summary>  
        public uspHuStoreUnderLineWarningQry()
        {
        }




        #region Public Properties
        /// <summary>
        /// 仓库ID
        /// </summary>
            public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
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
        /// 项目ID
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        
        /// <summary>
        /// 单位ID
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
        /// 组合项目大类ID
        /// </summary>
        public string GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }
        /// <summary>
        /// 组合项目大类名称
        /// </summary>
        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
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
        /// 零售价
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
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
        /// 项目名称(简称)
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
        /// 单位
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// 库存警报下限
        /// </summary>
        public double UnderLineKc
        {
            get { return _underLineKc; }
            set { _underLineKc = value; }
        }
        /// <summary>
        /// 库存警报上限
        /// </summary>
        public double UperLineKc
        {
            get { return _uperLineKc; }
            set { _uperLineKc = value; }
        }
        /// <summary>
        /// 采购维持库存量
        /// </summary>
        public double NormalLinekc
        {
            get { return _normalLinekc; }
            set { _normalLinekc = value; }
        }
        /// <summary>
        /// 是否选中(界面使用)
        /// </summary>
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
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
        /// 是否库存
        /// </summary>
        public bool IsOnlyForSys
        {
            get { return _isOnlyForSys; }
            set { _isOnlyForSys = value; }
        }
        /// <summary>
        /// 描述
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







