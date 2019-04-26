

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体温单数据 - 实体类
	/// </summary>
	[Serializable]
	public partial class InBodyHeat:BaseModel
	{    
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _animalHeat;  //体温
		
		private string _heatType;  //体温类型：1-口表；2-腋表；3-肛表
		
		private string _pulse;  //脉搏
		
		private string _heart;  //心率
		
		private string _breath;  //呼吸
		
		private string _stool;  //大便次数
		
		private string _urine;  //小便次数
		
		private string _weight;  //体重
		
		private string _bldpress0;  //收缩压
		
		private string _bldpress1;  //舒张压
		
		private string _fluidM;  //输入液量
		
		private string _totalIn;  //总入量
		
		private string _urineM;  //尿量
		
		private string _otherM;  //其它排出量
		
		private string _totalOut;  //总排出量
		
		private string _memoUp;  //上标注
		
		private string _memoDn;  //下标注
		
		private bool _spinTest;  //皮试
		
		private bool _lowerTemp;  //物理降温
		
		private bool _isRecheck;  //重检
		
		private bool _isOutSide;  //外出
		
		private bool _isMachine;  //仪器(呼吸)
		
		private string _others;  //备注
		
		private bool _isOps;  //是否手术
		
		private DateTime _birthTime;  //分娩时间
		
		private bool _isReject;  //拒试
		
		private DateTime _deadTime;  //死亡时间
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _cwInject;  //
		
		private string _jmInject;  //
		
		private string _cwHeight;  //
		
		private DateTime _operationTime;  //
		
		private bool _isLeave;  //
		
		private string _memoUp1;  //40-42文字
		
		private string _memoDn1;  //35°以下文字
		
		private DateTime _recordTime;  //记录时间
		
		private string _timeQuantum;  //时间段
		
		private string _drainage;  //引流量
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InBodyHeat() { }
         
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
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
		/// 体温
		/// </summary>
		public string AnimalHeat
		{
			get { return _animalHeat;}
			set { _animalHeat = value;}
		}                                    
		
		/// <summary>
		/// 体温类型：1-口表；2-腋表；3-肛表
		/// </summary>
		public string HeatType
		{
			get { return _heatType;}
			set { _heatType = value;}
		}                                    
		
		/// <summary>
		/// 脉搏
		/// </summary>
		public string Pulse
		{
			get { return _pulse;}
			set { _pulse = value;}
		}                                    
		
		/// <summary>
		/// 心率
		/// </summary>
		public string Heart
		{
			get { return _heart;}
			set { _heart = value;}
		}                                    
		
		/// <summary>
		/// 呼吸
		/// </summary>
		public string Breath
		{
			get { return _breath;}
			set { _breath = value;}
		}                                    
		
		/// <summary>
		/// 大便次数
		/// </summary>
		public string Stool
		{
			get { return _stool;}
			set { _stool = value;}
		}                                    
		
		/// <summary>
		/// 小便次数
		/// </summary>
		public string Urine
		{
			get { return _urine;}
			set { _urine = value;}
		}                                    
		
		/// <summary>
		/// 体重
		/// </summary>
		public string Weight
		{
			get { return _weight;}
			set { _weight = value;}
		}                                    
		
		/// <summary>
		/// 收缩压
		/// </summary>
		public string Bldpress0
		{
			get { return _bldpress0;}
			set { _bldpress0 = value;}
		}                                    
		
		/// <summary>
		/// 舒张压
		/// </summary>
		public string Bldpress1
		{
			get { return _bldpress1;}
			set { _bldpress1 = value;}
		}                                    
		
		/// <summary>
		/// 输入液量
		/// </summary>
		public string FluidM
		{
			get { return _fluidM;}
			set { _fluidM = value;}
		}                                    
		
		/// <summary>
		/// 总入量
		/// </summary>
		public string TotalIn
		{
			get { return _totalIn;}
			set { _totalIn = value;}
		}                                    
		
		/// <summary>
		/// 尿量
		/// </summary>
		public string UrineM
		{
			get { return _urineM;}
			set { _urineM = value;}
		}                                    
		
		/// <summary>
		/// 其它排出量
		/// </summary>
		public string OtherM
		{
			get { return _otherM;}
			set { _otherM = value;}
		}                                    
		
		/// <summary>
		/// 总排出量
		/// </summary>
		public string TotalOut
		{
			get { return _totalOut;}
			set { _totalOut = value;}
		}                                    
		
		/// <summary>
		/// 上标注
		/// </summary>
		public string MemoUp
		{
			get { return _memoUp;}
			set { _memoUp = value;}
		}                                    
		
		/// <summary>
		/// 下标注
		/// </summary>
		public string MemoDn
		{
			get { return _memoDn;}
			set { _memoDn = value;}
		}                                    
		
		/// <summary>
		/// 皮试
		/// </summary>
		public bool SpinTest
		{
			get { return _spinTest;}
			set { _spinTest = value;}
		}                                    
		
		/// <summary>
		/// 物理降温
		/// </summary>
		public bool LowerTemp
		{
			get { return _lowerTemp;}
			set { _lowerTemp = value;}
		}                                    
		
		/// <summary>
		/// 重检
		/// </summary>
		public bool IsRecheck
		{
			get { return _isRecheck;}
			set { _isRecheck = value;}
		}                                    
		
		/// <summary>
		/// 外出
		/// </summary>
		public bool IsOutSide
		{
			get { return _isOutSide;}
			set { _isOutSide = value;}
		}                                    
		
		/// <summary>
		/// 仪器(呼吸)
		/// </summary>
		public bool IsMachine
		{
			get { return _isMachine;}
			set { _isMachine = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Others
		{
			get { return _others;}
			set { _others = value;}
		}                                    
		
		/// <summary>
		/// 是否手术
		/// </summary>
		public bool IsOps
		{
			get { return _isOps;}
			set { _isOps = value;}
		}                                    
		
		/// <summary>
		/// 分娩时间
		/// </summary>
		public DateTime BirthTime
		{
			get { return _birthTime;}
			set { _birthTime = value;}
		}                                    
		
		/// <summary>
		/// 拒试
		/// </summary>
		public bool IsReject
		{
			get { return _isReject;}
			set { _isReject = value;}
		}                                    
		
		/// <summary>
		/// 死亡时间
		/// </summary>
		public DateTime DeadTime
		{
			get { return _deadTime;}
			set { _deadTime = value;}
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
		/// 
		/// </summary>
		public string CwInject
		{
			get { return _cwInject;}
			set { _cwInject = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string JmInject
		{
			get { return _jmInject;}
			set { _jmInject = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CwHeight
		{
			get { return _cwHeight;}
			set { _cwHeight = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperationTime
		{
			get { return _operationTime;}
			set { _operationTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsLeave
		{
			get { return _isLeave;}
			set { _isLeave = value;}
		}                                    
		
		/// <summary>
		/// 40-42文字
		/// </summary>
		public string MemoUp1
		{
			get { return _memoUp1;}
			set { _memoUp1 = value;}
		}                                    
		
		/// <summary>
		/// 35°以下文字
		/// </summary>
		public string MemoDn1
		{
			get { return _memoDn1;}
			set { _memoDn1 = value;}
		}                                    
		
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime RecordTime
		{
			get { return _recordTime;}
			set { _recordTime = value;}
		}                                    
		
		/// <summary>
		/// 时间段
		/// </summary>
		public string TimeQuantum
		{
			get { return _timeQuantum;}
			set { _timeQuantum = value;}
		}                                    
		
		/// <summary>
		/// 引流量
		/// </summary>
		public string Drainage
		{
			get { return _drainage;}
			set { _drainage = value;}
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


