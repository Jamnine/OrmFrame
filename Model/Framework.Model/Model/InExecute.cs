

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院护士执行 - 实体类
	/// </summary>
	[Serializable]
	public partial class InExecute : BaseModel
	{   
		 
		private DateTime _operTime;  //计划执行时间
		
		private string _operId;  //申请人
		
		private string _locationId;  //申请科室
		
		private string _adviceId;  //医嘱id号
		
		private int _lsMarkType;  //执行单类：1-长期；2-临时；3-其他；4-床位；5-出院带药
		
		private string _memo;  //备注
		
		private bool _isPrint;  //是否已打印
		
		private DateTime _printOperTime;  //打印时间
		
		private string _printOperId;  //打印人
		
		private DateTime _adviceTime;  //开医嘱时间
		
		private string _doctorId;  //开嘱医生
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private int _groupNum;  //组号
		
		private string _itemId;  //医嘱项目
		
		private double _dosage;  //每次服用量
		
		private string _unitTakeId;  //服用单位
		
		private string _frequencyId;  //每天服用次数
		
		private string _usageId;  //用法
		
		private double _priceIn;  //单价
		
		private double _totality;  //当天总量
		
		private string _unitInId;  //总量单位
		
		private bool _isUrgent;  //紧急
		
		private bool _isAttach;  //是否执行isNoAttach
		
		private bool _isSelf;  //自备药
		
		private int _lsSpecialUsage;  //特殊用法标志：0-静滴；1-接滴
		
		private int _lsExecLoc;  //执行地点：1-西药房；2-中心药房；3-本科执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
		
		private bool _isSkin;  //是否需要皮试？
		
		private DateTime _skinTime;  //皮试时间
		
		private string _skinTest;  //皮试结果
		
		private string _detailId;  //记帐表的费用ID
		
		private string _execLocId;  //执行科室
		
		private bool _isExecuted;  //是否已执行
		
		private DateTime _executedTime;  //执行时间
		
		private string _executedOperId;  //执行人
		
		private bool _isMinus;  //是否免摆药
		
		private string _nurseMemo;  //护士备注
		
		private DateTime _memoTime;  //执行时间
		
		private string _memoOperId;  //执行人
		
		private int _firstDay;  //首日次数
		
		private int _lastDay;  //末日次数
		
		private bool _isLastLong;  //旧长嘱
		
		private bool _isArrearage;  //0-正常1-欠费2-删除
		
		private string _yBType;  //甲类、乙类、丙类、自费
		
		private bool _isPriority;  //紧急
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InExecute() { }
                                       
		
		/// <summary>
		/// 计划执行时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 申请科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱id号
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 执行单类：1-长期；2-临时；3-其他；4-床位；5-出院带药
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
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
		/// 是否已打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 打印时间
		/// </summary>
		public DateTime PrintOperTime
		{
			get { return _printOperTime;}
			set { _printOperTime = value;}
		}                                    
		
		/// <summary>
		/// 打印人
		/// </summary>
		public string PrintOperId
		{
			get { return _printOperId;}
			set { _printOperId = value;}
		}                                    
		
		/// <summary>
		/// 开医嘱时间
		/// </summary>
		public DateTime AdviceTime
		{
			get { return _adviceTime;}
			set { _adviceTime = value;}
		}                                    
		
		/// <summary>
		/// 开嘱医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
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
		/// 医嘱项目
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
		public bool IsUrgent
		{
			get { return _isUrgent;}
			set { _isUrgent = value;}
		}                                    
		
		/// <summary>
		/// 是否执行isNoAttach
		/// </summary>
		public bool IsAttach
		{
			get { return _isAttach;}
			set { _isAttach = value;}
		}                                    
		
		/// <summary>
		/// 自备药
		/// </summary>
		public bool IsSelf
		{
			get { return _isSelf;}
			set { _isSelf = value;}
		}                                    
		
		/// <summary>
		/// 特殊用法标志：0-静滴；1-接滴
		/// </summary>
		public int LsSpecialUsage
		{
			get { return _lsSpecialUsage;}
			set { _lsSpecialUsage = value;}
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
		/// 是否需要皮试？
		/// </summary>
		public bool IsSkin
		{
			get { return _isSkin;}
			set { _isSkin = value;}
		}                                    
		
		/// <summary>
		/// 皮试时间
		/// </summary>
		public DateTime SkinTime
		{
			get { return _skinTime;}
			set { _skinTime = value;}
		}                                    
		
		/// <summary>
		/// 皮试结果
		/// </summary>
		public string SkinTest
		{
			get { return _skinTest;}
			set { _skinTest = value;}
		}                                    
		
		/// <summary>
		/// 记帐表的费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 是否已执行
		/// </summary>
		public bool IsExecuted
		{
			get { return _isExecuted;}
			set { _isExecuted = value;}
		}                                    
		
		/// <summary>
		/// 执行时间
		/// </summary>
		public DateTime ExecutedTime
		{
			get { return _executedTime;}
			set { _executedTime = value;}
		}                                    
		
		/// <summary>
		/// 执行人
		/// </summary>
		public string ExecutedOperId
		{
			get { return _executedOperId;}
			set { _executedOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否免摆药
		/// </summary>
		public bool IsMinus
		{
			get { return _isMinus;}
			set { _isMinus = value;}
		}                                    
		
		/// <summary>
		/// 护士备注
		/// </summary>
		public string NurseMemo
		{
			get { return _nurseMemo;}
			set { _nurseMemo = value;}
		}                                    
		
		/// <summary>
		/// 执行时间
		/// </summary>
		public DateTime MemoTime
		{
			get { return _memoTime;}
			set { _memoTime = value;}
		}                                    
		
		/// <summary>
		/// 执行人
		/// </summary>
		public string MemoOperId
		{
			get { return _memoOperId;}
			set { _memoOperId = value;}
		}                                    
		
		/// <summary>
		/// 首日次数
		/// </summary>
		public int FirstDay
		{
			get { return _firstDay;}
			set { _firstDay = value;}
		}                                    
		
		/// <summary>
		/// 末日次数
		/// </summary>
		public int LastDay
		{
			get { return _lastDay;}
			set { _lastDay = value;}
		}                                    
		
		/// <summary>
		/// 旧长嘱
		/// </summary>
		public bool IsLastLong
		{
			get { return _isLastLong;}
			set { _isLastLong = value;}
		}                                    
		
		/// <summary>
		/// 0-正常1-欠费2-删除
		/// </summary>
		public bool IsArrearage
		{
			get { return _isArrearage;}
			set { _isArrearage = value;}
		}                                    
		
		/// <summary>
		/// 甲类、乙类、丙类、自费
		/// </summary>
		public string YBType
		{
			get { return _yBType;}
			set { _yBType = value;}
		}                                    
		
		/// <summary>
		/// 紧急
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
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
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


