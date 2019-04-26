

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史住院医嘱执行 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistInExecute : BaseModel
    {   
		
		private DateTime _inSertTime;  //插入时间
		  
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _adviceId;  //医嘱ID
		
		private int _lsMarkType;  //医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		
		private string _memo;  //备注
		
		private bool _isPrint;  //是否打印
		
		private DateTime _printOperTime;  //打印时间
		
		private string _printOperId;  //打印人
		
		private DateTime _adviceTime;  //医嘱时间
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private int _groupNum;  //组号
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _dosage;  //每次量
		
		private string _unitTakeId;  //使用单位
		
		private string _frequencyId;  //频率对应BsFrequency.Id
		
		private string _usageId;  //用法对应BsUsage.Id
		
		private double _priceIn;  //住院项目单价
		
		private double _totality;  //数量
		
		private string _unitInId;  //药房单位
		
		private bool _isUrgent;  //是否紧急
		
		private bool _isAttach;  //是否执行
		
		private bool _isSelf;  //是否自费
		
		private int _lsSpecialUsage;  //特殊用法标志：1-静滴；2-接滴
		
		private int _lsExecLoc;  //执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
		
		private bool _isSkin;  //是否需要皮试？
		
		private DateTime _skinTime;  //皮试时间
		
		private string _skinTest;  //皮试结果
		
		private string _detailId;  //费用时间ID,InInvoicedtl.Id
		
		private string _execLocId;  //执行科室BsLocation.id
		
		private bool _isExecuted;  //是否已执行
		
		private DateTime _executedTime;  //执行时间
		
		private string _executedOperId;  //执行人
		
		private bool _isMinus;  //
		
		private string _nurseMemo;  //
		
		private DateTime _memoTime;  //护理备注
		
		private string _memoOperId;  //备注人
		
		private int _firstDay;  //首日次数
		
		private int _lastDay;  //末日次数
		
		private bool _isLastLong;  //
		
		private int _isArrearage;  //0-正常1-欠费2-删除
		
		private string _yBType;  //医保类别
		
		private bool _isPriority;  //是否紧急
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime InSertTime
		{
			get { return _inSertTime;}
			set { _inSertTime = value;}
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
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		/// 医嘱ID
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
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
		/// 是否打印
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
		/// 医嘱时间
		/// </summary>
		public DateTime AdviceTime
		{
			get { return _adviceTime;}
			set { _adviceTime = value;}
		}                                    
		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
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
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 每次量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 使用单位
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 频率对应BsFrequency.Id
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 用法对应BsUsage.Id
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 住院项目单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 药房单位
		/// </summary>
		public string UnitInId
		{
			get { return _unitInId;}
			set { _unitInId = value;}
		}                                    
		
		/// <summary>
		/// 是否紧急
		/// </summary>
		public bool IsUrgent
		{
			get { return _isUrgent;}
			set { _isUrgent = value;}
		}                                    
		
		/// <summary>
		/// 是否执行
		/// </summary>
		public bool IsAttach
		{
			get { return _isAttach;}
			set { _isAttach = value;}
		}                                    
		
		/// <summary>
		/// 是否自费
		/// </summary>
		public bool IsSelf
		{
			get { return _isSelf;}
			set { _isSelf = value;}
		}                                    
		
		/// <summary>
		/// 特殊用法标志：1-静滴；2-接滴
		/// </summary>
		public int LsSpecialUsage
		{
			get { return _lsSpecialUsage;}
			set { _lsSpecialUsage = value;}
		}                                    
		
		/// <summary>
		/// 执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
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
		/// 费用时间ID,InInvoicedtl.Id
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 执行科室BsLocation.id
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
		/// 
		/// </summary>
		public bool IsMinus
		{
			get { return _isMinus;}
			set { _isMinus = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string NurseMemo
		{
			get { return _nurseMemo;}
			set { _nurseMemo = value;}
		}                                    
		
		/// <summary>
		/// 护理备注
		/// </summary>
		public DateTime MemoTime
		{
			get { return _memoTime;}
			set { _memoTime = value;}
		}                                    
		
		/// <summary>
		/// 备注人
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
		/// 
		/// </summary>
		public bool IsLastLong
		{
			get { return _isLastLong;}
			set { _isLastLong = value;}
		}                                    
		
		/// <summary>
		/// 0-正常1-欠费2-删除
		/// </summary>
		public int IsArrearage
		{
			get { return _isArrearage;}
			set { _isArrearage = value;}
		}                                    
		
		/// <summary>
		/// 医保类别
		/// </summary>
		public string YBType
		{
			get { return _yBType;}
			set { _yBType = value;}
		}                                    
		
		/// <summary>
		/// 是否紧急
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
		}                                    
		                                
		        
	}  
}           


