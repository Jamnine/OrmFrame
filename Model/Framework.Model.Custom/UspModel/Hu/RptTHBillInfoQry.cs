using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 打印退回明细 报表
    /// </summary>
    [Serializable]
    #region class of Model:RptTHBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptTHBillInfo.
    /// </summary>
    public class RptTHBillInfoQry : BaseModel
    {
         
        private string _bACK_ID;
        private string _iN_BATCHID;
        private double _dRUG_NUM;
        private double _retail_PRIC;
        private double _pRICES;
        private string _memo = String.Empty;
        private string _vOUCHER_NO = String.Empty;
        private bool _isMargin;
        private DateTime _bACK_DATE;
        private string _unit_name = String.Empty;
        private string _drugs_ID = String.Empty;
        private string _sHORT_NAME = String.Empty;
        private string _sPECS = String.Empty;
        private string _manu_Name = String.Empty;
        private double _tOTAL_PRIC;
        private string _p_NO = String.Empty;
        private string _house_Name = String.Empty;
        private string _sign_man = String.Empty;
        private string _sTORE_MAN = String.Empty;
        private string _cOMP_NAME = String.Empty;
        private string _billNo = String.Empty;
        private string _f4 = String.Empty;

        /// <summary>
        /// 打印退回明细 报表
        /// </summary>
        public RptTHBillInfoQry()
        {
        }



        #region Public Properties
        /// <summary>
        ///退回单据ID
        /// </summary>
            public string BACK_ID
        {
            get { return _bACK_ID; }
            set { _bACK_ID = value; }
        }
        /// <summary>
        /// 药品批次ID
        /// </summary>
        public string IN_BATCHID
        {
            get { return _iN_BATCHID; }
            set { _iN_BATCHID = value; }
        }
        /// <summary>
        /// 药品数量.
        /// </summary>
        public double DRUG_NUM
        {
            get { return _dRUG_NUM; }
            set { _dRUG_NUM = value; }
        }
        /// <summary>
        /// 零售价.
        /// </summary>
        public double Retail_PRIC
        {
            get { return _retail_PRIC; }
            set { _retail_PRIC = value; }
        }
        /// <summary>
        /// 进货(买入)价.
        /// </summary>
        public double PRICES
        {
            get { return _pRICES; }
            set { _pRICES = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        /// <summary>
        /// 发票号.
        /// </summary>
        public string VOUCHER_NO
        {
            get { return _vOUCHER_NO; }
            set { _vOUCHER_NO = value; }
        }
        /// <summary>
        /// 补差价退货.
        /// </summary>
        public bool IsMargin
        {
            get { return _isMargin; }
            set { _isMargin = value; }
        }
        /// <summary>
        /// 退货日期.
        /// </summary>
        public DateTime BACK_DATE
        {
            get { return _bACK_DATE; }
            set { _bACK_DATE = value; }
        }
        /// <summary>
        /// 单位名
        /// </summary>
        public string Unit_Name
        {
            get { return _unit_name; }
            set { _unit_name = value; }
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
        /// 项目名称
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
        /// 制药公司名称
        /// </summary>
        public string Manu_Name
        {
            get { return _manu_Name; }
            set { _manu_Name = value; }
        }
        /// <summary>
        /// 支出总金额
        /// (进货)
        /// </summary>
        public double TOTAL_PRIC
        {
            get { return _tOTAL_PRIC; }
            set { _tOTAL_PRIC = value; }
        }
        /// <summary>
        /// 批号
        /// </summary>
        public string P_NO
        {
            get { return _p_NO; }
            set { _p_NO = value; }
        }
        /// <summary>
        /// 仓库名
        /// </summary>
        public string House_Name
        {
            get { return _house_Name; }
            set { _house_Name = value; }
        }
        /// <summary>
        /// 操作人1
        /// </summary>
        public string Sign_man
        {
            get { return _sign_man; }
            set { _sign_man = value; }
        }
        /// <summary>
        /// 操作人2
        /// </summary>
        public string STORE_MAN
        {
            get { return _sTORE_MAN; }
            set { _sTORE_MAN = value; }
        }
        /// <summary>
        /// 医药公司名称
        /// </summary>
        public string COMP_NAME
        {
            get { return _cOMP_NAME; }
            set { _cOMP_NAME = value; }
        }
        /// <summary>
        /// 单据号
        /// </summary>
        public string BillNO
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// F1
        /// </summary>
        public string F4
        {
            get { return _f4; }
            set { _f4 = value; }
        }
        #endregion
    }
    #endregion
}







