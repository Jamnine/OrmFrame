using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 库存盘点记录
    /// </summary>
    [Serializable]
    #region class of Model:uspHuStoreLogBatchActtypeSumQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuStoreLogBatchActtypeSum.
    /// </summary>
    public class uspHuStoreLogBatchActtypeSumQry : BaseModel
    {
         
        private double _totalRetail;
        private int _lsacttype;

        /// <summary>
        /// 库存盘点记录
        /// </summary>
        public uspHuStoreLogBatchActtypeSumQry()
        {
        }




        #region Public Properties
        /// <summary>
        /// 药房退药.
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// 出入库类型
        /// </summary>
        public int lsacttype
        {
            get { return _lsacttype; }
            set { _lsacttype = value; }
        }
        #endregion
    }
    #endregion
}







