

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊病人诊断表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuClincDiag:BaseModel
	{    
		private string _mzRegId;  //门诊流水号
		
		private int _listNum;  //序号
		
		private string _icdId;  //初诊（ICD码）
		
		private string _illDesc;  //诊断（ICD名称）
		
		private int _lsDiagType;  //诊断类别：1-初诊；2-复诊;3-疑诊；4-急性发作
		
		private int _sequenceNum;  //序号
		
		private string _icdCodeZy;  //中医诊断编码
		
		private string _illDescZy;  //中医诊断名称
		
		private DateTime _operTime;  //录入时间
		
		private bool _isDocInput;  //是否医生录入
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 门诊流水号
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 序号
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 初诊（ICD码）
		/// </summary>
		public string IcdId
		{
			get { return _icdId;}
			set { _icdId = value;}
		}                                    
		
		/// <summary>
		/// 诊断（ICD名称）
		/// </summary>
		public string IllDesc
		{
			get { return _illDesc;}
			set { _illDesc = value;}
		}                                    
		
		/// <summary>
		/// 诊断类别：1-初诊；2-复诊;3-疑诊；4-急性发作
		/// </summary>
		public int LsDiagType
		{
			get { return _lsDiagType;}
			set { _lsDiagType = value;}
		}                                    
		
		/// <summary>
		/// 序号
		/// </summary>
		public int SequenceNum
		{
			get { return _sequenceNum;}
			set { _sequenceNum = value;}
		}                                    
		
		/// <summary>
		/// 中医诊断编码
		/// </summary>
		public string IcdCodeZy
		{
			get { return _icdCodeZy;}
			set { _icdCodeZy = value;}
		}                                    
		
		/// <summary>
		/// 中医诊断名称
		/// </summary>
		public string IllDescZy
		{
			get { return _illDescZy;}
			set { _illDescZy = value;}
		}                                    
		
		/// <summary>
		/// 录入时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 是否医生录入
		/// </summary>
		public bool IsDocInput
		{
			get { return _isDocInput;}
			set { _isDocInput = value;}
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
        /// ICD码疾病名称
        /// </summary>
        public string IcdName { get; set; }
    }  
}           


