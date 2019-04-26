

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会员等级 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsVipLevel : BaseModel
    {    
		private string _vipTypeId;  //会员类别ID
		
		private string _name;  //名称
		
		private double _discount;  //折扣
		
		private double _defaultBalance;  //初始金额
		
		private int _orderBy;  //顺序
		
		private bool _isActive;  //是否有效标识
		
		private int _inValidDays;  //有效期(天)
		
		private bool _isVipPrice;  //是否使用会员价
		
		private bool _isStoredCard;  //
		
		private string _memo;  //备注
		
		private double _sincePay;  //行心云:自付比例
		
		private int _HospitalID;  //

        public BsVipLevel() { }

        

        /// <summary>
        /// 名称
        /// </summary>
        [Collumn(HeaderName = "名称", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 会员类别ID
        /// </summary>
        [Collumn(HeaderName = "会员类别", RelatedTableType = typeof(BsVipType))]
        public string VipTypeId
        {
            get { return _vipTypeId; }
            set { _vipTypeId = value; }
        }

        /// <summary>
        /// 折扣
        /// </summary>
        [Collumn(HeaderName = "折扣", RelatedTableType = null)]
        public double Discount
		{
			get { return _discount;}
			set { _discount = value;}
		}                                    
		
		/// <summary>
		/// 初始金额
		/// </summary>
		public double DefaultBalance
		{
			get { return _defaultBalance;}
			set { _defaultBalance = value;}
		}

        /// <summary>
        /// 顺序
        /// </summary>
        [Collumn(HeaderName = "顺序", RelatedTableType = null)]
        public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}

        /// <summary>
        /// 是否有效标识
        /// </summary>
        [Collumn(HeaderName = "启用", RelatedTableType = null)]
        public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}

        /// <summary>
        /// 有效期(天)
        /// </summary>
        [Collumn(HeaderName = "有效期(天)", RelatedTableType = null)]
        public int InValidDays
		{
			get { return _inValidDays;}
			set { _inValidDays = value;}
		}                                    
		
		/// <summary>
		/// 是否使用会员价
		/// </summary>
		public bool IsVipPrice
		{
			get { return _isVipPrice;}
			set { _isVipPrice = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsStoredCard
		{
			get { return _isStoredCard;}
			set { _isStoredCard = value;}
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
        /// 行心云:自付比例
        /// </summary>
        [Collumn(HeaderName = "自付比例", RelatedTableType = null)]
        public double SincePay
		{
			get { return _sincePay;}
			set { _sincePay = value;}
		}                                    
		
	                                 
		        
	}  
}           


