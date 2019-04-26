

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会员卡表 - 实体类
	/// </summary>
	[Serializable]
	public partial class VipCard : BaseModel
	{   
		
		
		
		private string _patId;  //病人id
		
		private string _cardNo;  //卡号
		
		private string _vipLevelId;  //会员等级id
		
		private double _discount;  //折扣
		
		private string _password;  //密码
		
		private DateTime _createTime;  //开卡时间
		
		private DateTime _invalidDate;  //有效截止日期
		
		private string _operId;  //开卡人
		
		private int _cardStatus;  //卡状态（1正常2挂失3停用）
		
		private bool _isActive;  //是否有效标识
		
		private string _introducerId;  //介绍人
		
		private string _introducerOperId;  //内部推荐人
		
		private DateTime _modiTime;  //最后修改时间
		
		private string _modiOperId;  //最后修改人
		
		private string _salesDate;  //销售日期
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private double _introDucerreWard;  //行心云:推荐奖励
		
		private string _firstintRoducerId;  //行心云:初始推荐人
		
		private int _HospitalID;  //
		 

	                     
		
		/// <summary>
		/// 病人id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 卡号
		/// </summary>
		public string CardNo
		{
			get { return _cardNo;}
			set { _cardNo = value;}
		}                                    
		
		/// <summary>
		/// 会员等级id
		/// </summary>
		public string VipLevelId
		{
			get { return _vipLevelId;}
			set { _vipLevelId = value;}
		}                                    
		
		/// <summary>
		/// 折扣
		/// </summary>
		public double Discount
		{
			get { return _discount;}
			set { _discount = value;}
		}                                    
		
		/// <summary>
		/// 密码
		/// </summary>
		public string Password
		{
			get { return _password;}
			set { _password = value;}
		}                                    
		
		/// <summary>
		/// 开卡时间
		/// </summary>
		public DateTime CreateTime
		{
			get { return _createTime;}
			set { _createTime = value;}
		}                                    
		
		/// <summary>
		/// 有效截止日期
		/// </summary>
		public DateTime InvalidDate
		{
			get { return _invalidDate;}
			set { _invalidDate = value;}
		}                                    
		
		/// <summary>
		/// 开卡人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 卡状态（1正常2挂失3停用）
		/// </summary>
		public int CardStatus
		{
			get { return _cardStatus;}
			set { _cardStatus = value;}
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
		/// 介绍人
		/// </summary>
		public string IntroducerId
		{
			get { return _introducerId;}
			set { _introducerId = value;}
		}                                    
		
		/// <summary>
		/// 内部推荐人
		/// </summary>
		public string IntroducerOperId
		{
			get { return _introducerOperId;}
			set { _introducerOperId = value;}
		}                                    
		
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 最后修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 销售日期
		/// </summary>
		public string SalesDate
		{
			get { return _salesDate;}
			set { _salesDate = value;}
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
        /// 行心云:推荐奖励 IntroducerReward IntroDucerreWard IntroducerReward
        /// </summary>
        public double IntroducerReward
        {
			get { return _introDucerreWard;}
			set { _introDucerreWard = value;}
		}                                    
		
		/// <summary>
		/// 行心云:初始推荐人
		/// </summary>
		public string FirstintRoducerId
		{
			get { return _firstintRoducerId;}
			set { _firstintRoducerId = value;}
		}                                    
		
                                  
		        
	}  
}           


