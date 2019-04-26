using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 打印物品申领信息
    /// </summary>
    [Serializable]
    #region class of Model:RptFQBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptFQBillInfo.
    /// </summary>
    public class RptFQBillInfoQry : BaseModel
    {
        private double _dRUG_NUM;
        private string _drugs_ID = String.Empty;
        private string _sHORT_NAME = String.Empty;
        private string _sPECS = String.Empty;
        private string _unit_name = String.Empty;
        private string _apply_id = String.Empty;
        private DateTime _app_DATE;
        private string _house_Name = String.Empty;
        private string _fILLS_MAN = String.Empty;
        private string _billId;
        private double _price;
        private string _name = String.Empty;

        /// <summary>
        /// 打印物品申领信息
        /// </summary>
        public RptFQBillInfoQry()
        {
        }


        #region Public Properties

        /// <summary>
        /// .药房领药申请数量
        /// </summary>
        public double DRUG_NUM
        {
            get { return _dRUG_NUM; }
            set { _dRUG_NUM = value; }
        }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string Drugs_ID
        {
            get { return _drugs_ID; }
            set { _drugs_ID = value; }
        }

        /// <summary>
        /// 简称
        /// </summary>
        public string SHORT_NAME
        {
            get { return _sHORT_NAME; }
            set { _sHORT_NAME = value; }
        }

        /// <summary>
        /// 规格
        /// </summary>

        public string SPECS
        {
            get { return _sPECS; }
            set { _sPECS = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string unit_name
        {
            get { return _unit_name; }
            set { _unit_name = value; }
        }

        /// <summary>
        /// 单据号
        /// </summary>
        public string Apply_id
        {
            get { return _apply_id; }
            set { _apply_id = value; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime App_DATE
        {
            get { return _app_DATE; }
            set { _app_DATE = value; }
        }

        /// <summary>
        /// 药库
        /// </summary>
        public string House_Name
        {
            get { return _house_Name; }
            set { _house_Name = value; }
        }

        /// <summary>
        /// 供应人
        /// </summary>
        public string FILLS_MAN
        {
            get { return _fILLS_MAN; }
            set { _fILLS_MAN = value; }
        }

        /// <summary>
        /// 药房申领ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// 零售价格
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// 药品制造商
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
    }
    #endregion
}



