using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 收费单据打印模板数据集
    /// </summary>
    [Serializable]
    #region class of Model:uspOuInvoiceInvItemGoupSumQryTwoPoints
    
    public class uspOuInvoiceInvItemGoupSumQryTwoPoints : BaseModel
    {

        private string _firstName = String.Empty;
        private double _firstAmount;
        private string _secondName = String.Empty;
        private double _secondAmount;
        private string _patientName;
        private string _medicalRecordNo;
        private string _invoNo;
        private double _sumAmount;
        private double _amountTally;
        private double _amountPay;
        private string _beneficiary;
        private string _doctor;
        private string _nurse;
        private string _capitalAmout;
        private bool _isVip;

        public uspOuInvoiceInvItemGoupSumQryTwoPoints()
        {
        }

        #region Public Properties
        /// <summary>
        /// 左边的收费类型
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        /// <summary>
        ///  左边的收费金额
        /// </summary>
        public double FirstAmount
        {
            get { return _firstAmount; }
            set { _firstAmount = value; }
        }
        /// <summary>
        /// 右边的收费类型
        /// </summary>
        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }
        /// <summary>
        /// 右边的收费金额
        /// </summary>
        public double SecondAmount
        {
            get { return _secondAmount; }
            set { _secondAmount = value; }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }
        /// <summary>
        /// 病历号
        /// </summary>
        public string MedicalRecordNo
        {
            get { return _medicalRecordNo; }
            set { _medicalRecordNo = value; }
        }
        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoNo
        {
            get { return _invoNo; }
            set { _invoNo = value; }
        }
        /// <summary>
        /// 总金额
        /// </summary>
        public double SumAmount
        {
            get { return _sumAmount; }
            set { _sumAmount = value; }
        }
        /// <summary>
        /// 欠费
        /// </summary>
        public double AmountTally
        {
            get { return _amountTally; }
            set { _amountTally = value; }
        }
        /// <summary>
        /// 应交
        /// </summary>
        public double AmountPay
        {
            get { return _amountPay; }
            set { _amountPay = value; }
        }
        /// <summary>
        /// 收款人
        /// </summary>
        public string Beneficiary
        {
            get { return _beneficiary; }
            set { _beneficiary = value; }
        }
        /// <summary>
        /// 医生
        /// </summary>
        public string Doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }
        /// <summary>
        /// 护士
        /// </summary>
        public string Nurse
        {
            get { return _nurse; }
            set { _nurse = value; }
        }
        /// <summary>
        /// 实收额大写
        /// </summary>
        public string CapitalAmout
        {
            get { return _capitalAmout; }
            set { _capitalAmout = value; }
        }

        /// <summary>
        /// 上次欠款
        /// </summary>
        public double PreviousArrears { get; set; }
        /// <summary>
        /// 整单折扣
        /// </summary>
        public double DiscountNum { get; set; }
        /// <summary>
        /// 找回金额
        /// </summary>
        public double BackAmout { get; set; }
        /// <summary>
        /// 记账金额
        /// </summary>
        public double AccountAmount { get; set; }

        /// <summary>
        /// 其中：免费金额
        /// </summary>
        public double FreeAmount { get; set; }
        /// <summary>
        /// 会员折扣
        /// </summary>
        public double VIPdiscount { get; set; }
        /// <summary>
        /// 会员余额
        /// </summary>
        public double VIPBalance { get; set; }
        /// <summary>
        /// 会员等级
        /// </summary>
        public string VIPLevel { get; set; }
        /// <summary>
        /// 当次使用的会员卡卡号
        /// </summary>
        public string vipCardNo { get; set; }
        /// <summary>
        /// 是否会员
        /// </summary>
        public bool IsVip
        {
            get { return _isVip; }
            set { _isVip = value; }
        }  
        /// <summary>
        /// 赠送金额 扣
        /// </summary>
        public double Givenamounthis
        {
            get; set;
        }
        /// <summary>
        /// 自付金额
        /// </summary>
        public double SelfAmount
        {
            get;set;

        }

        /// <summary>
        /// 自付金额大写
        /// </summary>
        public string SelfAmountCN{get; set;}
        /// <summary>
        /// 会员余额大写
        /// </summary>
        public string VIPBalanceCN { get; set; }
        /// <summary>
        /// 其中：免费金额大写
        /// </summary>
        public string FreeAmountCN { get; set; }
        #endregion
    }
    #endregion
}
