

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院病人诊断表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InHosMzIll : BaseModel
    {   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private int _listNum;  //顺序号
		
		private string _icdId;  //诊断（ICD码）
		
		private string _illDesc;  //诊断名称
		
		private int _lsInOut;  //门诊/住院诊断
		
		private int _lsWestChin;  //西医/中医诊断
		
		private bool _isInfect;  //是否医院感染
		
		private bool _isCoincidence;  //是否并发症
		
		private string _checkOperId;  //审核人
		
		private DateTime _checkTime;  //审核审核时间
		
		private string _bPGroupId;  //编号
		
		private bool _isDg;  //是否临床路径
		
		private bool _isBP;  //是否BP结构化
		
		private string _illType;  //诊断类别门诊诊断1,入院诊断2,初步诊断3,转科诊断4,其他诊断5,出院诊断6,补充诊断7,修正诊断8,最后诊断9
		
		private string _operId;  //操作人
		
		private DateTime _operTime;  //操作时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 顺序号
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 诊断（ICD码）
		/// </summary>
		public string IcdId
		{
			get { return _icdId;}
			set { _icdId = value;}
		}                                    
		
		/// <summary>
		/// 诊断名称
		/// </summary>
		public string IllDesc
		{
			get { return _illDesc;}
			set { _illDesc = value;}
		}                                    
		
		/// <summary>
		/// 门诊/住院诊断
		/// </summary>
		public int LsInOut
		{
			get { return _lsInOut;}
			set { _lsInOut = value;}
		}                                    
		
		/// <summary>
		/// 西医/中医诊断
		/// </summary>
		public int LsWestChin
		{
			get { return _lsWestChin;}
			set { _lsWestChin = value;}
		}                                    
		
		/// <summary>
		/// 是否医院感染
		/// </summary>
		public bool IsInfect
		{
			get { return _isInfect;}
			set { _isInfect = value;}
		}                                    
		
		/// <summary>
		/// 是否并发症
		/// </summary>
		public bool IsCoincidence
		{
			get { return _isCoincidence;}
			set { _isCoincidence = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string CheckOperId
		{
			get { return _checkOperId;}
			set { _checkOperId = value;}
		}                                    
		
		/// <summary>
		/// 审核审核时间
		/// </summary>
		public DateTime CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 编号
		/// </summary>
		public string BPGroupId
		{
			get { return _bPGroupId;}
			set { _bPGroupId = value;}
		}                                    
		
		/// <summary>
		/// 是否临床路径
		/// </summary>
		public bool IsDg
		{
			get { return _isDg;}
			set { _isDg = value;}
		}                                    
		
		/// <summary>
		/// 是否BP结构化
		/// </summary>
		public bool IsBP
		{
			get { return _isBP;}
			set { _isBP = value;}
		}                                    
		
		/// <summary>
		/// 诊断类别门诊诊断1,入院诊断2,初步诊断3,转科诊断4,其他诊断5,出院诊断6,补充诊断7,修正诊断8,最后诊断9
		/// </summary>
		public string IllType
		{
			get { return _illType;}
			set { _illType = value;}
		}                                    
		
		/// <summary>
		/// 操作人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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


