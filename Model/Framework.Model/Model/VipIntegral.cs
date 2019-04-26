

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会员积分表 - 实体类
	/// </summary>
	[Serializable]
	public partial class VipIntegral : BaseModel
	{   
		
		
		
		private string _patId;  //病人id
		
		private string _vipcardId;  //会员卡id
		
		private double _integral;  //积分
		
		private DateTime _operTime;  //开卡时间
		
		private string _operId;  //操作人
		
		private int _operStatus;  //操作状态（1开卡加积分2充值加积分3消费加积分4兑换减积分5推荐送积分）
		
		private string _comments;  //备注
		
		private bool _isActive;  //是否有效标识
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _invoId;  //行心云:发票ID(用于作废发票时扣减积分)
		
		private int _HospitalID;  //

        public VipIntegral() { }

                                       
		
		/// <summary>
		/// 病人id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 会员卡id
		/// </summary>
		public string VipcardId
		{
			get { return _vipcardId;}
			set { _vipcardId = value;}
		}                                    
		
		/// <summary>
		/// 积分
		/// </summary>
		public double Integral
		{
			get { return _integral;}
			set { _integral = value;}
		}                                    
		
		/// <summary>
		/// 开卡时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 操作状态（1开卡加积分2充值加积分3消费加积分4兑换减积分5推荐送积分）
		/// </summary>
		public int OperStatus
		{
			get { return _operStatus;}
			set { _operStatus = value;}
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
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 行心云:发票ID(用于作废发票时扣减积分)
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
	



    }  
}           


