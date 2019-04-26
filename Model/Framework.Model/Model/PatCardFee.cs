

using System;
namespace Orm.Model
{
	/// <summary>
	/// 自助缴费金额 - 实体类
	/// </summary>
	[Serializable]
	public partial class PatCardFee : BaseModel
	{   
		
		private string _patId;  //病人ID，对应于Patient的Pat_Id
		
		private DateTime _operTime;  //录入时间
		
		private string _operID;  //录入人
		
		private string _payWayId;  //支付方式
		
		private double _amount;  //金额
		
		private string _memo;  //备注
		
		private int _callOrder;  //叫号排序
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		
		/// <summary>
		/// 病人ID，对应于Patient的Pat_Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 录入时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 录入人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 支付方式
		/// </summary>
		public string PayWayId
		{
			get { return _payWayId;}
			set { _payWayId = value;}
		}                                    
		
		/// <summary>
		/// 金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
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
		/// 叫号排序
		/// </summary>
		public int CallOrder
		{
			get { return _callOrder;}
			set { _callOrder = value;}
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


