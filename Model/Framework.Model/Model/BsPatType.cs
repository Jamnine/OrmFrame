

using System;
namespace Orm.Model
{
	/// <summary>
	/// 病人类别 - 实体类
	/// </summary>
	[Serializable]
		public partial class BsPatType:BaseModel
	{   
		 
		private string _code;  //病人类别编码
		
		private string _name;  //病人类别名称
		
		private double _limitFee;  //门诊限额
		
		private double _limitIn;  //住院自费底线金额
		
		private double _arrearFei;  //住院欠款限额
		
		private double _discDiag;  //门诊记帐折扣
		
		private double _discIn;  //住院记帐折扣
		
		private string _headNo;  //医疗卡分类字头
		
		private string _tallyTypeId;  //记帐方式
		
		private double _arrearAmount;  //欠费多少就限制录入费用
		
		private int _lsGFPatType;  //公费病人类别：1-干部；2-家属；3-离休干部
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private bool _isActive;  //有效标志
		
		private int _orderBy;  //显示次序
		
		private int _iconIndex;  //图标类型
		
		private double _twoDiscIn1;  //
		
		private double _twoDiscIn2;  //
		
		private string _upCode;  //行心云:上报码
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private string _yBCode;  //行心云:医保码
		
 

		  
		
        /// <summary>
		/// 病人类别编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 病人类别
        /// </summary>
        [Collumn(HeaderName = "病人类别", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 门诊限额
        /// </summary>
        [Collumn(HeaderName = "门诊限额", RelatedTableType = null)]
        public double LimitFee
		{
			get { return _limitFee;}
			set { _limitFee = value;}
		}

        /// <summary>
        /// 住院自费底线金额
        /// </summary>
        [Collumn(HeaderName = "住院自费底线金额", RelatedTableType = null)]
        public double LimitIn
		{
			get { return _limitIn;}
			set { _limitIn = value;}
		}

        /// <summary>
        /// 住院欠款限额
        /// </summary>
        [Collumn(HeaderName = "住院欠款限额", RelatedTableType = null)]
        public double ArrearFei
		{
			get { return _arrearFei;}
			set { _arrearFei = value;}
		}

        /// <summary>
        /// 门诊记帐折扣
        /// </summary>
        [Collumn(HeaderName = "门诊记帐折扣", RelatedTableType = null)]
        public double DiscDiag
		{
			get { return _discDiag;}
			set { _discDiag = value;}
		}

        /// <summary>
        /// 住院记帐折扣
        /// </summary>
        [Collumn(HeaderName = "住院记帐折扣", RelatedTableType = null)]
        public double DiscIn
		{
			get { return _discIn;}
			set { _discIn = value;}
		}

        /// <summary>
        /// 医疗卡分类字头
        /// </summary>
        [Collumn(HeaderName = "医疗卡分类字头", RelatedTableType = null)]
        public string HeadNo
		{
			get { return _headNo;}
			set { _headNo = value;}
		}

        /// <summary>
        /// 记帐方式
        /// </summary>
        [Collumn(HeaderName = "记帐方式", RelatedTableType = typeof(BsTallyType))]
        public string TallyTypeId
		{
			get { return _tallyTypeId;}
			set { _tallyTypeId = value;}
		}

        /// <summary>
        /// 欠费多少就限制录入费用
        /// </summary>
        [Collumn(HeaderName = "欠费多少就限制录入费用", RelatedTableType = null)]
        public double ArrearAmount
		{
			get { return _arrearAmount;}
			set { _arrearAmount = value;}
		}

        /// <summary>
        /// 公费病人类别：1-干部；2-家属；3-离休干部
        /// </summary>
        
        [Collumn(HeaderName = "公费病人类别", RelatedTableType = null, LstType = "1:干部|2:家属|3:离休干部")]
        public int LsGFPatType
		{
			get { return _lsGFPatType;}
			set { _lsGFPatType = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 显示次序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 
		/// </summary>
		public double TwoDiscIn1
		{
			get { return _twoDiscIn1;}
			set { _twoDiscIn1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double TwoDiscIn2
		{
			get { return _twoDiscIn2;}
			set { _twoDiscIn2 = value;}
		}                                    
		
		/// <summary>
		/// 行心云:上报码
		/// </summary>
		public string UpCode
		{
			get { return _upCode;}
			set { _upCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:医保码
		/// </summary>
		public string YBCode
		{
			get { return _yBCode;}
			set { _yBCode = value;}
		}                                    
		
	                                  
		        
	}  
}           


