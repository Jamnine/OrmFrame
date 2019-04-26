

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsRoom:BaseModel
	{   
		 
		private string _code;  //药房ID
		
		private string _name;  //药房
		
		private int _lsInOut;  //药房分类：1-门诊；2-住院；3-其他
		
		private string _locationId;  //科室代码
		
		private int _lsRoomType;  //用途：1-西药药房；2-中药药房；3-配制中心
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private bool _isRoom;  //是否药房
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //


        /// <summary>
        /// 药房ID
        /// </summary>
        [Collumn(HeaderName = "编码", RelatedTableType = null)]
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 药房
        /// </summary>
        [Collumn(HeaderName = "药房", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 药房分类：1-门诊；2-住院；3-其他
        /// </summary>
        [Collumn(HeaderName = "药房分类", RelatedTableType = null, LstType = "1:门诊|2:住院|3:其他")]
        public int LsInOut
		{
			get { return _lsInOut;}
			set { _lsInOut = value;}
		}

        /// <summary>
        /// 科室代码
        /// </summary>
        [Collumn(HeaderName = "科室代码", RelatedTableType = typeof(BsLocation))]
        public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}

        /// <summary>
        /// 用途：1-西药药房；2-中药药房；3-配制中心
        /// </summary>
        [Collumn(HeaderName = "用途", RelatedTableType = null, LstType = "1:西药药房|2:中药药房|3:配制中心")]
        public int LsRoomType
		{
			get { return _lsRoomType;}
			set { _lsRoomType = value;}
		}

        /// <summary>
        /// 五笔码
        /// </summary>
        [Collumn(HeaderName = "五笔码", RelatedTableType = null)]
        public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}

        /// <summary>
        /// 拼音码
        /// </summary>
        [Collumn(HeaderName = "拼音码", RelatedTableType = null)]
        public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}

        /// <summary>
        /// 显示顺序
        /// </summary>
        [Collumn(HeaderName = "显示顺序", RelatedTableType = null)]
        public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}

        /// <summary>
        /// 有效标志
        /// </summary>
        [Collumn(HeaderName = "有效标志", RelatedTableType = null)]
        public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}

        /// <summary>
        /// 图标类型
        /// </summary>
        [Collumn(HeaderName = "图标", IsShow = false, RelatedTableType = null)]
        public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}

        /// <summary>
        /// 是否药房
        /// </summary>
        [Collumn(HeaderName = "是否药品房", RelatedTableType = null)]
        public bool IsRoom
		{
			get { return _isRoom;}
			set { _isRoom = value;}
		}

        /// <summary>
        /// 行心云:最后修改人
        /// </summary>
        [Collumn(HeaderName = "ModiOperId", RelatedTableType = null, IsShow = false)]
        public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}

        /// <summary>
        /// 行心云:最后修改时间
        /// </summary>
        [Collumn(HeaderName = "ModiTime", RelatedTableType = null, IsShow = false)]
        public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
                                  
		        
	}  
}           


