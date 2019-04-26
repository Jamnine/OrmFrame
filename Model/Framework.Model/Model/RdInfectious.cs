

using System;
namespace Orm.Model
{
	/// <summary>
	/// 传染病报告卡 - 实体类
	/// </summary>
	[Serializable]
	public partial class RdInfectious : BaseModel
	{   
		
		
		
		private string _patId;  //病人ID,对应BsPatient.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _operID;  //操作员ID,BsUser.Id
		
		private string _code;  //编码
		
		private int _lsCardType;  //报卡类型:1-发病报告;2-初次报告;3-订正报告;4-出院报告;5-死亡报告;
		
		private int _lsCensus;  //户籍类型:1-常住户籍;2-常住非户籍;3-暂住户籍;4-流动;
		
		private int _lsZone;  //病人属于
		
		private string _midwife;  //接生人
		
		private int _lsCancelType;  //病例分类
		
		private DateTime _illDate;  //发病日期
		
		private DateTime _inTime;  //入院日期
		
		private DateTime _deadDate;  //死亡日期
		
		private DateTime _diagDate;  //诊断日期
		
		private int _lsPreventive;  //预防接种史
		
		private string _illIdCor;  //订正病名
		
		private string _cancelMemo;  //退卡原因
		
		private string _reportUnit;  //报告单位
		
		private string _locId;  //报告科室
		
		private string _phone;  //联系电话
		
		private string _memo;  //备注
		
		private DateTime _reportDate;  //本院收卡日期
		
		private string _jIllId;  //甲类传染病
		
		private string _yIllId;  //乙类传染病
		
		private string _bIllId;  //丙类传染病
		
		private string _qIllId;  //其他法定管理及重点检测传染病
		
		private string _jName;  //监护人姓名
		
		private string _mzRegId;  //门诊病人ID,Ouhosinfo.Id
		
		private string _reciOperId;  //
		
		private int _isWrite;  //
		
		private string _canceloperid;  //取消人
		
		private string _chkoperid;  //审核人
		
		private bool _printstart;  //是否已打印
		
		private DateTime _chkOperTime;  //审核时间
		
		private DateTime _cancelOperTime;  //作废时间
		
		private int _lscanceltype2;  //
		
		private string _hospid;  //住院病人对应InHosinfo.Id
		
		private int _workType;  //
		
		private string _qilLness;  //
		
		private string _afpID;  //
		
		private string _illNameId;  //报告卡新增名称ID
		
		private string _deleteMemo;  //删卡原因
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RdInfectious() { }

                               
		
		/// <summary>
		/// 病人ID,对应BsPatient.Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
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
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 报卡类型:1-发病报告;2-初次报告;3-订正报告;4-出院报告;5-死亡报告;
		/// </summary>
		public int LsCardType
		{
			get { return _lsCardType;}
			set { _lsCardType = value;}
		}                                    
		
		/// <summary>
		/// 户籍类型:1-常住户籍;2-常住非户籍;3-暂住户籍;4-流动;
		/// </summary>
		public int LsCensus
		{
			get { return _lsCensus;}
			set { _lsCensus = value;}
		}                                    
		
		/// <summary>
		/// 病人属于
		/// </summary>
		public int LsZone
		{
			get { return _lsZone;}
			set { _lsZone = value;}
		}                                    
		
		/// <summary>
		/// 接生人
		/// </summary>
		public string Midwife
		{
			get { return _midwife;}
			set { _midwife = value;}
		}                                    
		
		/// <summary>
		/// 病例分类
		/// </summary>
		public int LsCancelType
		{
			get { return _lsCancelType;}
			set { _lsCancelType = value;}
		}                                    
		
		/// <summary>
		/// 发病日期
		/// </summary>
		public DateTime IllDate
		{
			get { return _illDate;}
			set { _illDate = value;}
		}                                    
		
		/// <summary>
		/// 入院日期
		/// </summary>
		public DateTime InTime
		{
			get { return _inTime;}
			set { _inTime = value;}
		}                                    
		
		/// <summary>
		/// 死亡日期
		/// </summary>
		public DateTime DeadDate
		{
			get { return _deadDate;}
			set { _deadDate = value;}
		}                                    
		
		/// <summary>
		/// 诊断日期
		/// </summary>
		public DateTime DiagDate
		{
			get { return _diagDate;}
			set { _diagDate = value;}
		}                                    
		
		/// <summary>
		/// 预防接种史
		/// </summary>
		public int LsPreventive
		{
			get { return _lsPreventive;}
			set { _lsPreventive = value;}
		}                                    
		
		/// <summary>
		/// 订正病名
		/// </summary>
		public string IllIdCor
		{
			get { return _illIdCor;}
			set { _illIdCor = value;}
		}                                    
		
		/// <summary>
		/// 退卡原因
		/// </summary>
		public string CancelMemo
		{
			get { return _cancelMemo;}
			set { _cancelMemo = value;}
		}                                    
		
		/// <summary>
		/// 报告单位
		/// </summary>
		public string ReportUnit
		{
			get { return _reportUnit;}
			set { _reportUnit = value;}
		}                                    
		
		/// <summary>
		/// 报告科室
		/// </summary>
		public string LocId
		{
			get { return _locId;}
			set { _locId = value;}
		}                                    
		
		/// <summary>
		/// 联系电话
		/// </summary>
		public string Phone
		{
			get { return _phone;}
			set { _phone = value;}
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
		/// 本院收卡日期
		/// </summary>
		public DateTime ReportDate
		{
			get { return _reportDate;}
			set { _reportDate = value;}
		}                                    
		
		/// <summary>
		/// 甲类传染病
		/// </summary>
		public string JIllId
		{
			get { return _jIllId;}
			set { _jIllId = value;}
		}                                    
		
		/// <summary>
		/// 乙类传染病
		/// </summary>
		public string YIllId
		{
			get { return _yIllId;}
			set { _yIllId = value;}
		}                                    
		
		/// <summary>
		/// 丙类传染病
		/// </summary>
		public string BIllId
		{
			get { return _bIllId;}
			set { _bIllId = value;}
		}                                    
		
		/// <summary>
		/// 其他法定管理及重点检测传染病
		/// </summary>
		public string QIllId
		{
			get { return _qIllId;}
			set { _qIllId = value;}
		}                                    
		
		/// <summary>
		/// 监护人姓名
		/// </summary>
		public string JName
		{
			get { return _jName;}
			set { _jName = value;}
		}                                    
		
		/// <summary>
		/// 门诊病人ID,Ouhosinfo.Id
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ReciOperId
		{
			get { return _reciOperId;}
			set { _reciOperId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int IsWrite
		{
			get { return _isWrite;}
			set { _isWrite = value;}
		}                                    
		
		/// <summary>
		/// 取消人
		/// </summary>
		public string Canceloperid
		{
			get { return _canceloperid;}
			set { _canceloperid = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string Chkoperid
		{
			get { return _chkoperid;}
			set { _chkoperid = value;}
		}                                    
		
		/// <summary>
		/// 是否已打印
		/// </summary>
		public bool Printstart
		{
			get { return _printstart;}
			set { _printstart = value;}
		}                                    
		
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime ChkOperTime
		{
			get { return _chkOperTime;}
			set { _chkOperTime = value;}
		}                                    
		
		/// <summary>
		/// 作废时间
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Lscanceltype2
		{
			get { return _lscanceltype2;}
			set { _lscanceltype2 = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string Hospid
		{
			get { return _hospid;}
			set { _hospid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int WorkType
		{
			get { return _workType;}
			set { _workType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string QilLness
		{
			get { return _qilLness;}
			set { _qilLness = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string AfpID
		{
			get { return _afpID;}
			set { _afpID = value;}
		}                                    
		
		/// <summary>
		/// 报告卡新增名称ID
		/// </summary>
		public string IllNameId
		{
			get { return _illNameId;}
			set { _illNameId = value;}
		}                                    
		
		/// <summary>
		/// 删卡原因
		/// </summary>
		public string DeleteMemo
		{
			get { return _deleteMemo;}
			set { _deleteMemo = value;}
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


