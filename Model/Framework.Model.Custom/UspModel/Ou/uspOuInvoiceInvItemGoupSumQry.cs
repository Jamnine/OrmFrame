using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary> 
    /// 收费发票分类信息
    /// </summary>
    [Serializable]
    #region class of Model:uspOuInvoiceInvItemGoupSumQry
   
    public class uspOuInvoiceInvItemGoupSumQry : BaseModel  
    {
         
        private string _name = String.Empty;
        private string _invItemId;
        private double _amount;
        private double _amountFact;
        private double _amountSelf;
        private double _amountTally;
        private double _amountPay;
        private double _amountJZ;
        private double _amountZF;

        public uspOuInvoiceInvItemGoupSumQry()
        {

        }
        #region Public Properties
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 发票项目id
        /// </summary>
        public string InvItemId
        {
            get { return _invItemId; }
            set { _invItemId = value; }
        }
        /// <summary>
        ///金额
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        /// <summary>
        /// 应交金额
        /// </summary>
        public double AmountFact
        {
            get { return _amountFact; }
            set { _amountFact = value; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public double AmountSelf
        {
            get { return _amountSelf; }
            set { _amountSelf = value; }
        }
        /// <summary>
        //金额统计
        /// </summary>
        public double AmountTally
        {
            get { return _amountTally; }
            set { _amountTally = value; }
        }
        /// <summary>
        /// 支付金额
        /// </summary>
        public double AmountPay
        {
            get { return _amountPay; }
            set { _amountPay = value; }
        }
        /// <summary>
        /// 实收金额-应收金额
        /// </summary>
        public double AmountJZ
        {
            get { return _amountJZ; }
            set { _amountJZ = value; }
        }
        /// <summary>
        /// 应交金额-金额
        /// </summary>
        public double AmountZF
        {
            get { return _amountZF; }
            set { _amountZF = value; }
        }
        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 操作人名称
        /// </summary>
        public string OperName { get; set; }
        #endregion
    }
    #endregion
}







