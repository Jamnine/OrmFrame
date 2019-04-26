

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class VipReCharge : BaseModel
	{   
		private string _vipCardID;  //会员卡ID
		
		private string _patID;  //病人ID
		
		private string _cardNo;  //病人卡号
		
		private double _inCome;  //收入
		
		private double _payOut;  //支出
		
		private double _balance;  //余额
		
		private int _payWay;  //支付方式
		
		private int _operType;  //操作方式:0充值1退款2赠送3支出
		
		private string _operID;  //操作员ID
		
		private DateTime _operTime;  //操作时间
		
		private string _comments;  //备注
		
		private string _vipTypeID;  //会员类型
		
		private int _lsVipChaFromType;  //支出方式：0-非支出;1-门诊挂号;2-门诊收费;3-办卡消费(不走业务)
		
		private string _invoId;  //支出方式的来源标识：
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public VipReCharge() { }

                                   
		
		/// <summary>
		/// 会员卡ID
		/// </summary>
		public string VipCardID
		{
			get { return _vipCardID;}
			set { _vipCardID = value;}
		}                                    
		
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
		public double InCome
		{
			get { return _inCome;}
			set { _inCome = value;}
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
		/// 支付方式
		/// </summary>
		public int PayWay
		{
			get { return _payWay;}
			set { _payWay = value;}
		}                                    
		
		/// <summary>
		/// 操作方式:0充值1退款2赠送3支出
		/// </summary>
		public int OperType
		{
			get { return _operType;}
			set { _operType = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
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
		/// 支出方式：0-非支出;1-门诊挂号;2-门诊收费;3-办卡消费(不走业务)
		/// </summary>
		public int LsVipChaFromType
		{
			get { return _lsVipChaFromType;}
			set { _lsVipChaFromType = value;}
		}                                    
		
		/// <summary>
		/// 支出方式的来源标识：
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
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


