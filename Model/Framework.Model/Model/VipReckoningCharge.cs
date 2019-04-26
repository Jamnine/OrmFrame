

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class VipReckoningCharge : BaseModel
	{   
		
		
		
		private string _vipCardId;  //病人id
		
		private string _itemId;  //项目id
		
		private int _totalCount;  //总次数
		
		private int _consumeCount;  //消费次数
		
		private DateTime _lastChargeTime;  //最后消费时间
		
		private double _discountPrice;  //优惠单价
		
		private bool _isDiscount;  //是否使用优惠单价
		
		private bool _isActive = true;  //是否可用
		
		private string _comments;  //操作备注
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public VipReckoningCharge() { }

                                  
		
		/// <summary>
		/// 病人Vip id
		/// </summary>
		public string VipCardId
		{
			get { return _vipCardId;}
			set { _vipCardId = value;}
		}                                    
		
		/// <summary>
		/// 项目id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 总次数
		/// </summary>
		public int TotalCount
		{
			get { return _totalCount;}
			set { _totalCount = value;}
		}                                    
		
		/// <summary>
		/// 消费次数
		/// </summary>
		public int ConsumeCount
		{
			get { return _consumeCount;}
			set { _consumeCount = value;}
		}                                    
		
		/// <summary>
		/// 最后消费时间
		/// </summary>
		public DateTime LastChargeTime
		{
			get { return _lastChargeTime;}
			set { _lastChargeTime = value;}
		}                                    
		
		/// <summary>
		/// 优惠单价
		/// </summary>
		public double DiscountPrice
		{
			get { return _discountPrice;}
			set { _discountPrice = value;}
		}                                    
		
		/// <summary>
		/// 是否使用优惠单价
		/// </summary>
		public bool IsDiscount
		{
			get { return _isDiscount;}
			set { _isDiscount = value;}
		}                                    
		
		/// <summary>
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 操作备注
		/// </summary>
		public string Comments
		{
			get { return _comments;}
			set { _comments = value;}
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


