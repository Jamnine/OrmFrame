using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
/// <summary>
/// 出，入库记录详情
/// </summary>
    [Serializable]
    #region class of Model:uspHuStoresDtailDtlQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoresDtailDtl.
    /// </summary>
    public class uspHuStoresDtailDtlQry : BaseModel
    {
         
        private DateTime _happenTime;
        private string _inBatchNo = String.Empty;
        private string _pNo = String.Empty;
        private double _happenNumIn;
        private double _happenNumOut;
        private double _afterStockNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _memo = String.Empty;

        /// <summary>
        /// 出，入库记录详情
        public uspHuStoresDtailDtlQry()
        {
        }




        #region Public Properties
        /// <summary>
        /// 发生时间
        /// </summary>
        public DateTime HappenTime
        {
            get { return _happenTime; }
            set { _happenTime = value; }
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
        /// 批号
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }
        /// <summary>
        /// 入库发生数量
        /// </summary>
        public double HappenNumIn
        {
            get { return _happenNumIn; }
            set { _happenNumIn = value; }
        }
        /// <summary>
        ///  出库发生数量
        /// </summary>
        public double HappenNumOut
        {
            get { return _happenNumOut; }
            set { _happenNumOut = value; }
        }
        /// <summary>
        /// 操作后药品的库存数量
        /// </summary>
        public double AfterStockNum
        {
            get { return _afterStockNum; }
            set { _afterStockNum = value; }
        }
        /// <summary>
        /// 零售价格
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
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
        /// 备注
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







