

using System;
namespace Orm.Model
{
	/// <summary>
	/// 艾滋病报告卡性病附卡 - 实体类
	/// </summary>
	[Serializable]
	public partial class RdVenerism : BaseModel
    {   
		
	 
		
		private string _patId;  //
		
		private string _operTime;  //
		
		private string _operId;  //
		
		private string _code;  //
		
		private DateTime _chkOperTime;  //
		
		private string _chkOperId;  //
		
		private bool _isWrite;  //
		
		private int _printStart;  //
		
		private string _hospId;  //
		
		private string _mzRegId;  //
		
		private string _contactother;  //
		
		private int _contactzs;  //
		
		private int _contactxjc;  //
		
		private int _contacttx;  //
		
		private bool _isZsbds;  //
		
		private bool _isXjcs;  //
		
		private bool _isXbyx;  //
		
		private bool _isNnxxw;  //
		
		private bool _isXxs;  //
		
		private bool _isSss;  //
		
		private bool _isSxs;  //
		
		private bool _isOther;  //
		
		private bool _isZybls;  //
		
		private bool _isMotherRmascc;  //
		
		private bool _isUnKnown;  //
		
		private DateTime _testTime;  //检查日期
		
		private string _testUnit;  //检测单位
		
		private DateTime _aidstime;  //确诊日期
		
		private string _parentsName;  //家长名字
		
		private string _memo;  //
		
		private bool _isMarRied;  //婚姻状况
		
		private int _education;  //文化程度
		
		private string _jbIllId;  //疾病名称
		
		private bool _isXbill;  //性病史
		
		private int _xbIllWay;  //感染途径
		
		private int _sampleFrom;  //样本来源
		
		private int _libTestResult;  //实验室检查结论
		
		private string _wayOther;  //感染途径（其他）
		
		private string _sampleFromOther;  //样本来源（其他）
		
		private string _bsCommitteeRoad;  //户籍街道/村
		
		private string _reportUnit;  //报告单位
		
		private string _cancelOperId;  //
		
		private DateTime _cancelOperTime;  //
		
		private string _cancelMemo;  //
		
		private string _illNameId;  //报告卡名称ID，为2
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RdVenerism() { }

                    
		
		/// <summary>
		/// 
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime ChkOperTime
		{
			get { return _chkOperTime;}
			set { _chkOperTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ChkOperId
		{
			get { return _chkOperId;}
			set { _chkOperId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsWrite
		{
			get { return _isWrite;}
			set { _isWrite = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int PrintStart
		{
			get { return _printStart;}
			set { _printStart = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Contactother
		{
			get { return _contactother;}
			set { _contactother = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Contactzs
		{
			get { return _contactzs;}
			set { _contactzs = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Contactxjc
		{
			get { return _contactxjc;}
			set { _contactxjc = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Contacttx
		{
			get { return _contacttx;}
			set { _contacttx = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsZsbds
		{
			get { return _isZsbds;}
			set { _isZsbds = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsXjcs
		{
			get { return _isXjcs;}
			set { _isXjcs = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsXbyx
		{
			get { return _isXbyx;}
			set { _isXbyx = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsNnxxw
		{
			get { return _isNnxxw;}
			set { _isNnxxw = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsXxs
		{
			get { return _isXxs;}
			set { _isXxs = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSss
		{
			get { return _isSss;}
			set { _isSss = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSxs
		{
			get { return _isSxs;}
			set { _isSxs = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsOther
		{
			get { return _isOther;}
			set { _isOther = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsZybls
		{
			get { return _isZybls;}
			set { _isZybls = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsMotherRmascc
		{
			get { return _isMotherRmascc;}
			set { _isMotherRmascc = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsUnKnown
		{
			get { return _isUnKnown;}
			set { _isUnKnown = value;}
		}                                    
		
		/// <summary>
		/// 检查日期
		/// </summary>
		public DateTime TestTime
		{
			get { return _testTime;}
			set { _testTime = value;}
		}                                    
		
		/// <summary>
		/// 检测单位
		/// </summary>
		public string TestUnit
		{
			get { return _testUnit;}
			set { _testUnit = value;}
		}                                    
		
		/// <summary>
		/// 确诊日期
		/// </summary>
		public DateTime Aidstime
		{
			get { return _aidstime;}
			set { _aidstime = value;}
		}                                    
		
		/// <summary>
		/// 家长名字
		/// </summary>
		public string ParentsName
		{
			get { return _parentsName;}
			set { _parentsName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 婚姻状况
		/// </summary>
		public bool IsMarRied
		{
			get { return _isMarRied;}
			set { _isMarRied = value;}
		}                                    
		
		/// <summary>
		/// 文化程度
		/// </summary>
		public int Education
		{
			get { return _education;}
			set { _education = value;}
		}                                    
		
		/// <summary>
		/// 疾病名称
		/// </summary>
		public string JbIllId
		{
			get { return _jbIllId;}
			set { _jbIllId = value;}
		}                                    
		
		/// <summary>
		/// 性病史
		/// </summary>
		public bool IsXbill
		{
			get { return _isXbill;}
			set { _isXbill = value;}
		}                                    
		
		/// <summary>
		/// 感染途径
		/// </summary>
		public int XbIllWay
		{
			get { return _xbIllWay;}
			set { _xbIllWay = value;}
		}                                    
		
		/// <summary>
		/// 样本来源
		/// </summary>
		public int SampleFrom
		{
			get { return _sampleFrom;}
			set { _sampleFrom = value;}
		}                                    
		
		/// <summary>
		/// 实验室检查结论
		/// </summary>
		public int LibTestResult
		{
			get { return _libTestResult;}
			set { _libTestResult = value;}
		}                                    
		
		/// <summary>
		/// 感染途径（其他）
		/// </summary>
		public string WayOther
		{
			get { return _wayOther;}
			set { _wayOther = value;}
		}                                    
		
		/// <summary>
		/// 样本来源（其他）
		/// </summary>
		public string SampleFromOther
		{
			get { return _sampleFromOther;}
			set { _sampleFromOther = value;}
		}                                    
		
		/// <summary>
		/// 户籍街道/村
		/// </summary>
		public string BsCommitteeRoad
		{
			get { return _bsCommitteeRoad;}
			set { _bsCommitteeRoad = value;}
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
		/// 
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CancelMemo
		{
			get { return _cancelMemo;}
			set { _cancelMemo = value;}
		}                                    
		
		/// <summary>
		/// 报告卡名称ID，为2
		/// </summary>
		public string IllNameId
		{
			get { return _illNameId;}
			set { _illNameId = value;}
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


