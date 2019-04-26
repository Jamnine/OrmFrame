

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用法附带项目 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUsageItem:BaseModel
	{    
		private string _usageId;  //符合的用法条件
		
		private string _itemId;  //附加项目
		
		private double _totality;  //一个主项目需要多少个附加项目？
		
		private int _lsUseArea;  //特定用途：1-门诊；2-住院；3-所有
		
		private string _locationId;  //专用科室
		
		private int _iconIndex;  //图标类型
		
		private bool _isBaby;  //儿童专用
		
		private bool _isWomen;  //妇女专用
		
		private bool _isMen;  //男性专用
		
		private bool _isOlder;  //老人专用
		
		private string _memo;  //特殊情况专用
		
		private bool _isDrugTwoDay;  //
		
		private bool _isOnlyUseOne;  //只实用一次
		
		private bool _isForFrequency;  //是否根据频率收
		
		private bool _isForDays;  //是否根据天数收

        private DateTime _modiTime;
        private string _modiOperId;
        private string _specMemo ;  //行心云:F3特殊情况，例如双通道
        private int _HospitalID;//医院ID

        /// <summary>
        /// 行心云:F3特殊情况，例如双通道
        /// </summary>
        public string  SpecMemo
        {
            get { return _specMemo; }
            set { _specMemo = value; }
        }
        /// <summary>
        /// 最后修改时间.
        /// </summary>                     
        [Collumn(HeaderName = "ModiTime", RelatedTableType = null, IsShow = false)]
        public DateTime ModiTime
        {
            get
            {
                return this._modiTime;
            }
            set
            {
                this._modiTime = value;
            }
        }
     
        /// <summary>
        /// 最后修改人.
        /// </summary>
        [Collumn(HeaderName = "ModiOperId", RelatedTableType = null, IsShow = false)]
        public string ModiOperId
        {
            get
            {
                return this._modiOperId;
            }
            set
            {
                this._modiOperId = value;
            }
        }
                                        
		
		/// <summary>
		/// 符合的用法条件
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 附加项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 一个主项目需要多少个附加项目？
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 特定用途：1-门诊；2-住院；3-所有
		/// </summary>
		public int LsUseArea
		{
			get { return _lsUseArea;}
			set { _lsUseArea = value;}
		}                                    
		
		/// <summary>
		/// 专用科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 儿童专用
		/// </summary>
		public bool IsBaby
		{
			get { return _isBaby;}
			set { _isBaby = value;}
		}                                    
		
		/// <summary>
		/// 妇女专用
		/// </summary>
		public bool IsWomen
		{
			get { return _isWomen;}
			set { _isWomen = value;}
		}                                    
		
		/// <summary>
		/// 男性专用
		/// </summary>
		public bool IsMen
		{
			get { return _isMen;}
			set { _isMen = value;}
		}                                    
		
		/// <summary>
		/// 老人专用
		/// </summary>
		public bool IsOlder
		{
			get { return _isOlder;}
			set { _isOlder = value;}
		}                                    
		
		/// <summary>
		/// 特殊情况专用
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsDrugTwoDay
		{
			get { return _isDrugTwoDay;}
			set { _isDrugTwoDay = value;}
		}                                    
		
		/// <summary>
		/// 只实用一次
		/// </summary>
		public bool IsOnlyUseOne
		{
			get { return _isOnlyUseOne;}
			set { _isOnlyUseOne = value;}
		}                                    
		
		/// <summary>
		/// 是否根据频率收
		/// </summary>
		public bool IsForFrequency
		{
			get { return _isForFrequency;}
			set { _isForFrequency = value;}
		}                                    
		
		/// <summary>
		/// 是否根据天数收
		/// </summary>
		public bool IsForDays
		{
			get { return _isForDays;}
			set { _isForDays = value;}
		}

        private string _modiOperName;

        /// <summary>
        /// 修改人名称
        /// </summary>
        public string ModiOperName
        {
            get { return _modiOperName; }
            set { _modiOperName = value; }
        }

        private string _itemName;

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }



    }  
}           


