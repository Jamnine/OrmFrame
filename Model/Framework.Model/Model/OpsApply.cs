

using System;
namespace Orm.Model
{
	/// <summary>
	/// 手术申请 - 实体类
	/// </summary>
	[Serializable]
	public partial class OpsApply : BaseModel
    {    
		
		private string _applyNo;  //申请号
		
		private DateTime _applyTime;  //预作手术时间
		
		private string _mzRegId;  //门诊流水号
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _locationId;  //科室ID
		
		private string _doctorId;  //主刀医生
		
		private string _opsId;  //拟作手术名称
		
		private string _opsOtherId;  //拟作手术名称
		
		private string _anaeId;  //麻醉方法
		
		private string _assistant;  //助手
		
		private string _diagnose;  //术前诊断
		
		private DateTime _operTime;  //递手术通知时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _bedNo;  //预约床位
		
		private int _lshbsag;  //
		
		private int _lsAsepsis;  //无菌程度：1-无菌；2-一般；3-隔离
		
		private string _bloodGroup;  //输血血型
		
		private string _blood;  //备血情况
		
		private string _opsBody;  //手术部位
		
		private string _opsPos;  //手术体位
		
		private string _otherTools;  //手术用物
		
		private bool _isUrgent;  //是否急诊手术
		
		private bool _isCalled;  //是否小孩
		
		private string _memo;  //备注(一般为术中所需的特殊器械)
		
		private string _planOperId;  //安排人
		
		private DateTime _planTime;  //安排时间
		
		private string _planMemo;  //安排备注
		
		private bool _isFinish;  //是否已完成确认
		
		private DateTime _finishTime;  //完成时间
		
		private string _finishOperId;  //完成人
		
		private string _finishMemo;  //完成备注
		
		private DateTime _beginTime;  //手术开始时间
		
		private DateTime _endTime;  //手术开始时间
		
		private string _bloodSum;  //输血量
		
		private int _lsCutClass;  //切口分级：1-清洁；2-清洁-污染；3-污染
		
		private int _lsCure;  //愈合类别：1-甲级愈合；2-乙级愈合；3-丙级愈合
		
		private string _bloodRpt;  //配血报告
		
		private string _sensitive;  //药敏试验结果
		
		private string _opsRoomId;  //手术间
		
		private string _seqNum;  //台次
		
		private string _patientName;  //门诊病人姓名
		
		private string _bsOpsName;  //BsOps表项目名
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 申请号
		/// </summary>
		public string ApplyNo
		{
			get { return _applyNo;}
			set { _applyNo = value;}
		}                                    
		
		/// <summary>
		/// 预作手术时间
		/// </summary>
		public DateTime ApplyTime
		{
			get { return _applyTime;}
			set { _applyTime = value;}
		}                                    
		
		/// <summary>
		/// 门诊流水号
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
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
		/// 科室ID
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 主刀医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 拟作手术名称
		/// </summary>
		public string OpsId
		{
			get { return _opsId;}
			set { _opsId = value;}
		}                                    
		
		/// <summary>
		/// 拟作手术名称
		/// </summary>
		public string OpsOtherId
		{
			get { return _opsOtherId;}
			set { _opsOtherId = value;}
		}                                    
		
		/// <summary>
		/// 麻醉方法
		/// </summary>
		public string AnaeId
		{
			get { return _anaeId;}
			set { _anaeId = value;}
		}                                    
		
		/// <summary>
		/// 助手
		/// </summary>
		public string Assistant
		{
			get { return _assistant;}
			set { _assistant = value;}
		}                                    
		
		/// <summary>
		/// 术前诊断
		/// </summary>
		public string Diagnose
		{
			get { return _diagnose;}
			set { _diagnose = value;}
		}                                    
		
		/// <summary>
		/// 递手术通知时间
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
		/// 预约床位
		/// </summary>
		public string BedNo
		{
			get { return _bedNo;}
			set { _bedNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Lshbsag
		{
			get { return _lshbsag;}
			set { _lshbsag = value;}
		}                                    
		
		/// <summary>
		/// 无菌程度：1-无菌；2-一般；3-隔离
		/// </summary>
		public int LsAsepsis
		{
			get { return _lsAsepsis;}
			set { _lsAsepsis = value;}
		}                                    
		
		/// <summary>
		/// 输血血型
		/// </summary>
		public string BloodGroup
		{
			get { return _bloodGroup;}
			set { _bloodGroup = value;}
		}                                    
		
		/// <summary>
		/// 备血情况
		/// </summary>
		public string Blood
		{
			get { return _blood;}
			set { _blood = value;}
		}                                    
		
		/// <summary>
		/// 手术部位
		/// </summary>
		public string OpsBody
		{
			get { return _opsBody;}
			set { _opsBody = value;}
		}                                    
		
		/// <summary>
		/// 手术体位
		/// </summary>
		public string OpsPos
		{
			get { return _opsPos;}
			set { _opsPos = value;}
		}                                    
		
		/// <summary>
		/// 手术用物
		/// </summary>
		public string OtherTools
		{
			get { return _otherTools;}
			set { _otherTools = value;}
		}                                    
		
		/// <summary>
		/// 是否急诊手术
		/// </summary>
		public bool IsUrgent
		{
			get { return _isUrgent;}
			set { _isUrgent = value;}
		}                                    
		
		/// <summary>
		/// 是否小孩
		/// </summary>
		public bool IsCalled
		{
			get { return _isCalled;}
			set { _isCalled = value;}
		}                                    
		
		/// <summary>
		/// 备注(一般为术中所需的特殊器械)
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 安排人
		/// </summary>
		public string PlanOperId
		{
			get { return _planOperId;}
			set { _planOperId = value;}
		}                                    
		
		/// <summary>
		/// 安排时间
		/// </summary>
		public DateTime PlanTime
		{
			get { return _planTime;}
			set { _planTime = value;}
		}                                    
		
		/// <summary>
		/// 安排备注
		/// </summary>
		public string PlanMemo
		{
			get { return _planMemo;}
			set { _planMemo = value;}
		}                                    
		
		/// <summary>
		/// 是否已完成确认
		/// </summary>
		public bool IsFinish
		{
			get { return _isFinish;}
			set { _isFinish = value;}
		}                                    
		
		/// <summary>
		/// 完成时间
		/// </summary>
		public DateTime FinishTime
		{
			get { return _finishTime;}
			set { _finishTime = value;}
		}                                    
		
		/// <summary>
		/// 完成人
		/// </summary>
		public string FinishOperId
		{
			get { return _finishOperId;}
			set { _finishOperId = value;}
		}                                    
		
		/// <summary>
		/// 完成备注
		/// </summary>
		public string FinishMemo
		{
			get { return _finishMemo;}
			set { _finishMemo = value;}
		}                                    
		
		/// <summary>
		/// 手术开始时间
		/// </summary>
		public DateTime BeginTime
		{
			get { return _beginTime;}
			set { _beginTime = value;}
		}                                    
		
		/// <summary>
		/// 手术开始时间
		/// </summary>
		public DateTime EndTime
		{
			get { return _endTime;}
			set { _endTime = value;}
		}                                    
		
		/// <summary>
		/// 输血量
		/// </summary>
		public string BloodSum
		{
			get { return _bloodSum;}
			set { _bloodSum = value;}
		}                                    
		
		/// <summary>
		/// 切口分级：1-清洁；2-清洁-污染；3-污染
		/// </summary>
		public int LsCutClass
		{
			get { return _lsCutClass;}
			set { _lsCutClass = value;}
		}                                    
		
		/// <summary>
		/// 愈合类别：1-甲级愈合；2-乙级愈合；3-丙级愈合
		/// </summary>
		public int LsCure
		{
			get { return _lsCure;}
			set { _lsCure = value;}
		}                                    
		
		/// <summary>
		/// 配血报告
		/// </summary>
		public string BloodRpt
		{
			get { return _bloodRpt;}
			set { _bloodRpt = value;}
		}                                    
		
		/// <summary>
		/// 药敏试验结果
		/// </summary>
		public string Sensitive
		{
			get { return _sensitive;}
			set { _sensitive = value;}
		}                                    
		
		/// <summary>
		/// 手术间
		/// </summary>
		public string OpsRoomId
		{
			get { return _opsRoomId;}
			set { _opsRoomId = value;}
		}                                    
		
		/// <summary>
		/// 台次
		/// </summary>
		public string SeqNum
		{
			get { return _seqNum;}
			set { _seqNum = value;}
		}                                    
		
		/// <summary>
		/// 门诊病人姓名
		/// </summary>
		public string PatientName
		{
			get { return _patientName;}
			set { _patientName = value;}
		}                                    
		
		/// <summary>
		/// BsOps表项目名
		/// </summary>
		public string BsOpsName
		{
			get { return _bsOpsName;}
			set { _bsOpsName = value;}
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


