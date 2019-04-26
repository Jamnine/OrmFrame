

using System;
namespace Orm.Model
{
	/// <summary>
	/// 科室 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsLocation:BaseModel
	{   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private int _hospitalId;  //所属分院
		
		private int _lsInOut;  //1-住院科室;2-门诊科室;3-所有业务科室;4-后勤科室;5-大科室;6-医技科室;7-药剂科室;8-物资仓库
		
		private bool _isForwomen;  //1-女性科室
		
		private string _phoneCode;  //1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA
		
		private double _medicineRatio;  //控制药比
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private string _specialityId;  //科室专业
		
		private int _bedSum;  //床位编制数
		
		private string _baSysCode;  //病案编码
		
		private string _director;  //科室主任
		
		private string _deptTypeId;  //部门类别
		
		private bool _isCostApp;  //参与成本分摊标志
		
		private int _appLevel;  //科室分摊级别
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _area;  //面积
		
		private string _ouRoomId;  //门诊药房
		
		private string _inRoomId;  //住院药房
		
		private bool _isPriceSub;  //是否特殊价格
		
		private bool _isClinical;  //是否临床科室
		
		private bool _isChinLocation;  //标识是否为中医科
		
		private bool _isRegLocation;  //是否公共科室
		
		private bool _isAllLocation;  //是否住院护士可以管理整个病区的病人（不分科）

        private DateTime _moditime;  //最后修改时间

        private string _modioperId;  //最后修改人

        /// <summary>
        /// 编码
        /// </summary>
        [Collumn(HeaderName = "编码", RelatedTableType = null)]
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 名称
        /// </summary>
        [Collumn(HeaderName = "科室", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 所属分院
        /// </summary>
        [Collumn(HeaderName = "所属分院", RelatedTableType = typeof(BsHospital))]
        public int HospitalId
		{
			get { return _hospitalId; }
			set { _hospitalId = value;}
		}                                    
		
		/// <summary>
		/// 1-住院科室;2-门诊科室;3-所有业务科室;4-后勤科室;5-大科室;6-医技科室;7-药剂科室;8-物资仓库
		/// </summary>
		public int LsInOut
		{
			get { return _lsInOut;}
			set { _lsInOut = value;}
		}                                    
		
		/// <summary>
		/// 1-女性科室
		/// </summary>
		public bool IsForwomen
		{
			get { return _isForwomen;}
			set { _isForwomen = value;}
		}

        /// <summary>
        /// 1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA
        /// </summary>
        [Collumn(HeaderName = "PhoneCode", RelatedTableType = null, LstType = "1:CT|2:DR|3:MR|4:CR|5:RF|6:US|7:脑电图|8:心电图|9:镜检查|10:MG|11:DSA")]
        public string PhoneCode
		{
			get { return _phoneCode;}
			set { _phoneCode = value;}
		}

        /// <summary>
        /// 控制药比
        /// </summary>
        [Collumn(HeaderName = "控制药比", RelatedTableType = null)]
        public double MedicineRatio
		{
			get { return _medicineRatio;}
			set { _medicineRatio = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}

        /// <summary>
        /// 是否有效标识
        /// </summary>
        [Collumn(HeaderName = "是否有效标识", RelatedTableType = null)]
        public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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
        /// 科室专业
        /// </summary>
        [Collumn(HeaderName = "科室专业", RelatedTableType = typeof(BsSpeciality))]
        public string SpecialityId
		{
			get { return _specialityId;}
			set { _specialityId = value;}
		}                                    
		
		/// <summary>
		/// 床位编制数
		/// </summary>
		public int BedSum
		{
			get { return _bedSum;}
			set { _bedSum = value;}
		}                                    
		
		/// <summary>
		/// 病案编码
		/// </summary>
		public string BaSysCode
		{
			get { return _baSysCode;}
			set { _baSysCode = value;}
		}                                    
		
		/// <summary>
		/// 科室主任
		/// </summary>
		public string Director
		{
			get { return _director;}
			set { _director = value;}
		}                                    
		
		/// <summary>
		/// 部门类别
		/// </summary>
		public string DeptTypeId
		{
			get { return _deptTypeId;}
			set { _deptTypeId = value;}
		}                                    
		
		/// <summary>
		/// 参与成本分摊标志
		/// </summary>
		public bool IsCostApp
		{
			get { return _isCostApp;}
			set { _isCostApp = value;}
		}                                    
		
		/// <summary>
		/// 科室分摊级别
		/// </summary>
		public int AppLevel
		{
			get { return _appLevel;}
			set { _appLevel = value;}
		}

     
        /// /// <summary>
        /// 拼音码
        /// </summary>
        [Collumn(HeaderName = "拼音码", RelatedTableType = null)]
        public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
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
		/// 面积
		/// </summary>
		public int Area
		{
			get { return _area;}
			set { _area = value;}
		}                                    
		
		/// <summary>
		/// 门诊药房
		/// </summary>
		public string OuRoomId
		{
			get { return _ouRoomId;}
			set { _ouRoomId = value;}
		}                                    
		
		/// <summary>
		/// 住院药房
		/// </summary>
		public string InRoomId
		{
			get { return _inRoomId;}
			set { _inRoomId = value;}
		}                                    
		
		/// <summary>
		/// 是否特殊价格
		/// </summary>
		public bool IsPriceSub
		{
			get { return _isPriceSub;}
			set { _isPriceSub = value;}
		}                                    
		
		/// <summary>
		/// 是否临床科室
		/// </summary>
		public bool IsClinical
		{
			get { return _isClinical;}
			set { _isClinical = value;}
		}                                    
		
		/// <summary>
		/// 标识是否为中医科
		/// </summary>
		public bool IsChinLocation
		{
			get { return _isChinLocation;}
			set { _isChinLocation = value;}
		}                                    
		
		/// <summary>
		/// 是否公共科室
		/// </summary>
		public bool IsRegLocation
		{
			get { return _isRegLocation;}
			set { _isRegLocation = value;}
		}                                    
		
		/// <summary>
		/// 是否住院护士可以管理整个病区的病人（不分科）
		/// </summary>
		public bool IsAllLocation
		{
			get { return _isAllLocation;}
			set { _isAllLocation = value;}
		}

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime Moditime
        {
            get { return _moditime; }
            set { _moditime = value; }
        }

        /// <summary>
        /// 最后修改人
        /// </summary>
        public string ModioperId
        {
            get { return _modioperId; }
            set { _modioperId = value; }
        }

    }  
}           


