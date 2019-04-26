using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 库存查询（入，出库明细）
    /// </summary>
    [Serializable]
    #region class of Model:uspHustoresTotalQry
    /// <summary>
    /// This object represents the properties and methods of a uspHustoresTotal.
    /// </summary>
    public class uspHustoresTotalQry : BaseModel
    {

        private string _unitId;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _spec = String.Empty;
        private string _manuId;
        private string _itemName = String.Empty;
        private double _stockNumSun;
        private double _totalPrice;
        private double _totalRetail;
        private double _underLineKc;
        private double _uperLineKc;
        /// <summary>
        /// 库存查询（入，出库明细）
        /// </summary>
        public uspHustoresTotalQry()
        {
        }


        #region Public Properties
        /// <summary>
        /// 单位ID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
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
        /// 规格
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// 制药公司ID
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
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
        /// 库存总量
        /// </summary>
        public double StockNumSum
        {
            get { return _stockNumSun; }
            set { _stockNumSun = value; }
        }
        /// <summary>
        /// 总价
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        /// <summary>
        /// 零售总额 
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// /库存警报下限
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
        /// 行总数
        /// </summary>
        public int RowCount { get; set; }
        #endregion
    }
    #endregion
}







