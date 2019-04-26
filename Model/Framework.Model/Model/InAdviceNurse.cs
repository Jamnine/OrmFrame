

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院护嘱 - 实体类
	/// </summary>
	[Serializable]
	public partial class InAdviceNurse:BaseModel
	{   
		 
		private DateTime _adviceTime;  //开医嘱时间
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private int _groupNum;  //组号
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _dosage;  //每次服用量
		
		private string _unitTakeId;  //服用单位
		
		private string _frequencyId;  //每天服用次数
		
		private string _usageId;  //用法
		
		private double _priceIn;  //单价
		
		private double _totality;  //当天总量
		
		private string _unitInId;  //总量单位
		
		private bool _isUrgeny;  //紧急
		
		private int _lsExecLoc;  //执行地点：1-西药房；2-中心药房；3-本科执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
		
		private DateTime _operTime;  //操作时间
		
		private string _operID;  //操作员ID,BsUser.Id
		
		private bool _isAuth;  //是否审核
		
		private DateTime _authOperTime;  //最后查对时间
		
		private string _authOperId;  //查对护士
		
		private bool _isLong;  //是否长嘱
		
		private bool _isCancel;  //是否作废
		
		private DateTime _cancelOperTime;  //取消时间
		
		private string _cancelOperId;  //作废人
		
		private string _memo;  //备注
		
		private string _ybType;  //医保类别
		
		private bool _isYbxj;  //是否医保限制
		
		private string _applyId;  //检查申请Id
		
		private string _colours;  //显示颜色
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InAdviceNurse() { }
         
		/// <summary>
		/// 开医嘱时间
		/// </summary>
		public DateTime AdviceTime
		{
			get { return _adviceTime;}
			set { _adviceTime = value;}
		}                                    
		
		/// <summary>
		/// 科室ID,BsLocation.Id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string hospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 组号
		/// </summary>
		public int GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 每次服用量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 服用单位
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 每天服用次数
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
		}                                    
		
		/// <summary>
		/// 当天总量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 总量单位
		/// </summary>
		public string UnitInId
		{
			get { return _unitInId;}
			set { _unitInId = value;}
		}                                    
		
		/// <summary>
		/// 紧急
		/// </summary>
		public bool IsUrgeny
		{
			get { return _isUrgeny;}
			set { _isUrgeny = value;}
		}                                    
		
		/// <summary>
		/// 执行地点：1-西药房；2-中心药房；3-本科执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
		/// </summary>
		public int LsExecLoc
		{
			get { return _lsExecLoc;}
			set { _lsExecLoc = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 是否审核
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 最后查对时间
		/// </summary>
		public DateTime AuthOperTime
		{
			get { return _authOperTime;}
			set { _authOperTime = value;}
		}                                    
		
		/// <summary>
		/// 查对护士
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否长嘱
		/// </summary>
		public bool IsLong
		{
			get { return _isLong;}
			set { _isLong = value;}
		}                                    
		
		/// <summary>
		/// 是否作废
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 取消时间
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 作废人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
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
		/// 医保类别
		/// </summary>
		public string YbType
		{
			get { return _ybType;}
			set { _ybType = value;}
		}                                    
		
		/// <summary>
		/// 是否医保限制
		/// </summary>
		public bool IsYbxj
		{
			get { return _isYbxj;}
			set { _isYbxj = value;}
		}                                    
		
		/// <summary>
		/// 检查申请Id
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 显示颜色
		/// </summary>
		public string Colours
		{
			get { return _colours;}
			set { _colours = value;}
		}                                    
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double DiscountAoumt
		{
			get { return _discountAoumt;}
			set { _discountAoumt = value;}
		}                                    
		
		/// <summary>
		/// 儿童价格
		/// </summary>
		public double ChildPrice
		{
			get { return _childPrice;}
			set { _childPrice = value;}
		}                                    
		
		/// <summary>
		/// 折扣价格
		/// </summary>
		public double DiscountPrice
		{
			get { return _discountPrice;}
			set { _discountPrice = value;}
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


