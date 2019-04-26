

using System;
using Orm.Model.EnumDefine;

namespace Orm.Model
{
	/// <summary>
	/// 行心云:会员充值表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuRecharge : BaseModel
	{   
		
		
		private string _patID;  //病人ID
		
		private string _cardNo;  //病人卡号
		
		private double _income;  //收入
		
		private double _payOut;  //支出
		
		private double _balance;  //余额
		
		private string  _payWayId;  //支付方式
		
		private int _operType;  //操作方式:0充值 1 退款 2 赠送 3支出
		
		private string _operId;  //操作员ID
		
		private DateTime _operTime;  //操作时间
		
		private string _comments;  //备注
		
		private string _vipTypeID;  //会员类型
		
		private string _vipCardID;  //会员卡ID
		
		private double _individualPay;  //个人支付金额
		
		private double _givenamount;  //赠送金额
		
		private double _givenamounthis;  //扣除赠送金额
		
		private double _individualPayhis;  //扣除支付金额
		
		private string _invoID;  //收费单据ID
		
		private string _locationId;  //分店id
		
		private int _HospitalID;  //
		 
                                 
		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatID
		{
			get { return _patID;}
			set { _patID = value;}
		}                                    
		
		/// <summary>
		/// 病人卡号
		/// </summary>
		public string CardNo
		{
			get { return _cardNo;}
			set { _cardNo = value;}
		}                                    
		
		/// <summary>
		/// 收入
		/// </summary>
		public double Income
		{
			get { return _income;}
			set { _income = value;}
		}                                    
		
		/// <summary>
		/// 支出
		/// </summary>
		public double PayOut
		{
			get { return _payOut;}
			set { _payOut = value;}
		}                                    
		
		/// <summary>
		/// 余额
		/// </summary>
		public double Balance
		{
			get { return _balance;}
			set { _balance = value;}
		}

        /// <summary>
        /// 支付方式   //对应bsPayWay.GUID
        /// </summary>
        public string PayWayId
		{
			get { return _payWayId;}
			set { _payWayId = value;}
		}                                    
		
		/// <summary>
		/// 操作方式:0充值 1 退款 2 赠送 3支出
		/// </summary>
		public int OperType
		{
			get { return _operType;}
			set { _operType = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Comments
		{
			get { return _comments;}
			set { _comments = value;}
		}                                    
		
		/// <summary>
		/// 会员类型
		/// </summary>
		public string VipTypeID
		{
			get { return _vipTypeID;}
			set { _vipTypeID = value;}
		}                                    
		
		/// <summary>
		/// 会员卡ID
		/// </summary>
		public string VipCardID
		{
			get { return _vipCardID;}
			set { _vipCardID = value;}
		}                                    
		
		/// <summary>
		/// 个人支付金额
		/// </summary>
		public double IndividualPay
		{
			get { return _individualPay;}
			set { _individualPay = value;}
		}                                    
		
		/// <summary>
		/// 赠送金额
		/// </summary>
		public double Givenamount
		{
			get { return _givenamount;}
			set { _givenamount = value;}
		}                                    
		
		/// <summary>
		/// 扣除赠送金额
		/// </summary>
		public double Givenamounthis
		{
			get { return _givenamounthis;}
			set { _givenamounthis = value;}
		}                                    
		
		/// <summary>
		/// 扣除支付金额
		/// </summary>
		public double IndividualPayhis
		{
			get { return _individualPayhis;}
			set { _individualPayhis = value;}
		}                                    
		
		/// <summary>
		/// 收费单据ID
		/// </summary>
		public string InvoID
		{
			get { return _invoID;}
			set { _invoID = value;}
		}                                    
		
		/// <summary>
		/// 分店id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}

        private string _serialNumber;

        /// <summary>
        /// 会员充值流水号
        /// </summary>
        public string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }

        private bool _isOperTypeRecharge = false;
        public bool u_IsOperTypeRecharge
        {
            get
            {
                if (OperType == (int)EnumVipCardIdOperation.充值)
                {
                    _isOperTypeRecharge = true;
                }
                else
                {
                    _isOperTypeRecharge = false;
                }
                return _isOperTypeRecharge;
            }
            set { _isOperTypeRecharge = value; }
        }
        private bool _isOperTypeGiving = false;
        public bool u_IsOperTypeGiving
        {
            get
            {
                if (OperType == (int)EnumVipCardIdOperation.赠送)
                {
                    _isOperTypeGiving = true;
                }
                else
                {
                    _isOperTypeGiving = false;
                }
                return _isOperTypeGiving;
            }
            set { _isOperTypeGiving = value; }
        }
        private bool _isOperTypeRefund = false;
        public bool u_IsOperTypeRefund
        {
            get
            {
                if (OperType == (int)EnumVipCardIdOperation.退款)
                {
                    _isOperTypeRefund = true;
                }
                else
                {
                    _isOperTypeRefund = false;
                }
                return _isOperTypeRefund;
            }
            set { _isOperTypeRefund = value; }
        }
        private bool _isOperTypePay = false;
        public bool u_IsOperTypePay
        {
            get
            {
                if (OperType == (int)EnumVipCardIdOperation.缴费)
                {
                    _isOperTypePay = true;
                }
                else
                {
                    _isOperTypePay = false;
                }
                return _isOperTypePay;
            }
            set { _isOperTypePay = value; }
        }
        private bool _isOperTypeCancelRefund = false;
        public bool u_IsOperTypeCancelRefund
        {
            get
            {
                if (OperType == (int)EnumVipCardIdOperation.作废退费)
                {
                    _isOperTypeCancelRefund = true;
                }
                else
                {
                    _isOperTypeCancelRefund = false;
                }
                return _isOperTypeCancelRefund;
            }
            set { _isOperTypeCancelRefund = value; }
        }
    }  
}           


