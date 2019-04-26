

using System;
namespace Orm.Model
{
	/// <summary>
	/// 自助机支付日志 - 实体类
	/// </summary>
	[Serializable]
	public partial class BKStoreLog : BaseModel
    {   
		
		private DateTime _happenTime;  //发生时间
		
		private string _userId;  //用户Id,对应BsUser.Id
		
		private string _patCardid;  //诊疗卡主表IdPatCardFee.id
		
		private string _bKRegNo;  //流水号
		
		private int _lsActType;  //1、充值。,2、门诊挂号,3、挂号退款,4、门诊收费,5、门诊退款
		
		private double _beforeMoney;  //操作前金额
		
		private double _happenMoney;  //发生金额
		
		private double _afterMoney;  //操作后金额
		
		private string _memo;  //备注
		
		private string _transactionNum;  //交易流水号
		
		private string _bHosName;  //机器名
		
		private string _payWayId;  //支付对应BkPayWay.Id
		
		private string _iDType;  //记录挂号或者收费Id。OulInvoiceReg.Id，Ouinvoice.Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _hoSpitalId;  //

        public BKStoreLog() { }

        /// <summary>
        /// 发生时间
        /// </summary>
        public DateTime HappenTime
		{
			get { return _happenTime;}
			set { _happenTime = value;}
		}                                    
		
		/// <summary>
		/// 用户Id,对应BsUser.Id
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 诊疗卡主表IdPatCardFee.id
		/// </summary>
		public string PatCardid
		{
			get { return _patCardid;}
			set { _patCardid = value;}
		}                                    
		
		/// <summary>
		/// 流水号
		/// </summary>
		public string BKRegNo
		{
			get { return _bKRegNo;}
			set { _bKRegNo = value;}
		}                                    
		
		/// <summary>
		/// 1、充值。,2、门诊挂号,3、挂号退款,4、门诊收费,5、门诊退款
		/// </summary>
		public int LsActType
		{
			get { return _lsActType;}
			set { _lsActType = value;}
		}                                    
		
		/// <summary>
		/// 操作前金额
		/// </summary>
		public double BeforeMoney
		{
			get { return _beforeMoney;}
			set { _beforeMoney = value;}
		}                                    
		
		/// <summary>
		/// 发生金额
		/// </summary>
		public double HappenMoney
		{
			get { return _happenMoney;}
			set { _happenMoney = value;}
		}                                    
		
		/// <summary>
		/// 操作后金额
		/// </summary>
		public double AfterMoney
		{
			get { return _afterMoney;}
			set { _afterMoney = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 交易流水号
		/// </summary>
		public string TransactionNum
		{
			get { return _transactionNum;}
			set { _transactionNum = value;}
		}                                    
		
		/// <summary>
		/// 机器名
		/// </summary>
		public string BHosName
		{
			get { return _bHosName;}
			set { _bHosName = value;}
		}                                    
		
		/// <summary>
		/// 支付对应BkPayWay.Id
		/// </summary>
		public string PayWayId
		{
			get { return _payWayId;}
			set { _payWayId = value;}
		}                                    
		
		/// <summary>
		/// 记录挂号或者收费Id。OulInvoiceReg.Id，Ouinvoice.Id
		/// </summary>
		public string IDType
		{
			get { return _iDType;}
			set { _iDType = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
                                  
		        
	}  
}           


