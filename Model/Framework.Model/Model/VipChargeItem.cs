

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会员金额对应项目表 - 实体类
	/// </summary>
	[Serializable]
	public partial class VipChargeItem : BaseModel
	{    
		private string _vccId;  //会员金额设置id
		
		private string _itemId;  //项目id
		
		private int _totalCount;  //次数
		
		private double _discountPrice;  //优惠单价
		
		private bool _isDisCount;  //是否使用优惠单价
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _vipLevelId;  //行心云:会员等级ID
		
		private int _HospitalID;  //

        public VipChargeItem() { }

                                     
		
		/// <summary>
		/// 会员金额设置id
		/// </summary>
		public string VccId
		{
			get { return _vccId;}
			set { _vccId = value;}
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
		/// 次数
		/// </summary>
		public int TotalCount
		{
			get { return _totalCount;}
			set { _totalCount = value;}
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
		public bool IsDisCount
		{
			get { return _isDisCount;}
			set { _isDisCount = value;}
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
		/// 行心云:会员等级ID
		/// </summary>
		public string VipLevelId
		{
			get { return _vipLevelId;}
			set { _vipLevelId = value;}
		}                                    
		
	

    }  
}           


