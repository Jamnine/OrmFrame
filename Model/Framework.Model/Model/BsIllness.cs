

using System;
namespace Orm.Model
{
	/// <summary>
	/// ICD码疾病数据字典 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsIllness : BaseModel
    {   
		
		
		
		private string _code;  //编码
		
		private string _wbCode;  //五笔码（固定）
		
		private string _pyCode;  //拼音码（固定）
		
		private string _otherCode;  //其他码
		
		private string _name;  //疾病名称
		
		private string _otherDesc;  //英文名
		
		private string _groupMain;  //主组
		
		private string _groupSub;  //子组
		
		private string _groupSSub;  //子子组
		
		private int _belongIcd;  //四位数亚目的三位数类目（父编码）
		
		private bool _isSum;  //
		
		private double _feeHigh;  //预设医疗费用上限
		
		private int _dayHigh;  //预设住院天数上限
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private bool _isInfectious;  //是否提示写报告卡
		
		private bool _isGoodRecipeIllNess;  //是否好处方
		
		private string _reportType;  //报告卡类别：传染病、病毒性肝炎、性病、脑卒中、肿瘤
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 五笔码（固定）
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音码（固定）
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 其他码
		/// </summary>
		public string OtherCode
		{
			get { return _otherCode;}
			set { _otherCode = value;}
		}                                    
		
		/// <summary>
		/// 疾病名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 英文名
		/// </summary>
		public string OtherDesc
		{
			get { return _otherDesc;}
			set { _otherDesc = value;}
		}

        /// <summary>
        /// 主组
        /// </summary>
        [Collumn(HeaderName = "主组", RelatedTableType = typeof(BsGroup))]
        public string GroupMain
		{
			get { return _groupMain;}
			set { _groupMain = value;}
		}

        /// <summary>
        /// 子组
        /// </summary>
        [Collumn(HeaderName = "子组", RelatedTableType = typeof(BsGroupSub))]
        public string GroupSub
		{
			get { return _groupSub;}
			set { _groupSub = value;}
		}

        /// <summary>
        /// 子子组
        /// </summary>
        [Collumn(HeaderName = "子子组", RelatedTableType = typeof(BsGroupSub2))]
        public string GroupSSub
		{
			get { return _groupSSub;}
			set { _groupSSub = value;}
		}                                    
		
		/// <summary>
		/// 四位数亚目的三位数类目（父编码）
		/// </summary>
		public int BelongIcd
		{
			get { return _belongIcd;}
			set { _belongIcd = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSum
		{
			get { return _isSum;}
			set { _isSum = value;}
		}                                    
		
		/// <summary>
		/// 预设医疗费用上限
		/// </summary>
		public double FeeHigh
		{
			get { return _feeHigh;}
			set { _feeHigh = value;}
		}                                    
		
		/// <summary>
		/// 预设住院天数上限
		/// </summary>
		public int DayHigh
		{
			get { return _dayHigh;}
			set { _dayHigh = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}

        /// <summary>
        /// 是否提示写报告卡
        /// </summary>
        [Collumn(HeaderName = "是否提示写报告卡", RelatedTableType = null)]
        public bool IsInfectious
		{
			get { return _isInfectious;}
			set { _isInfectious = value;}
		}

        /// <summary>
        /// 是否好处方
        /// </summary>
        [Collumn(HeaderName = "是否好处方", RelatedTableType = null)]
        public bool IsGoodRecipeIllNess
		{
			get { return _isGoodRecipeIllNess;}
			set { _isGoodRecipeIllNess = value;}
		}

        /// <summary>
        /// 报告卡类别：传染病、病毒性肝炎、性病、脑卒中、肿瘤
        /// </summary>
        [Collumn(HeaderName = "报告卡类别", RelatedTableType = null,LstType = "1:传染病|2:病毒性肝炎|3:性病|4:脑卒中|5:肿瘤")]
        public string ReportType
		{
			get { return _reportType;}
			set { _reportType = value;}
		}                                    
		                                  
		        
	}  
}           


