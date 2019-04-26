

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验细菌主表 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkLabMic : BaseModel
	{   
		 
		private string _labId;  //标本ID
		
		private string _bacteriaId;  //细菌
		
		private string _memo;  //报告备注
		
		private DateTime _operTime;  //检查时间
		
		private string _operId;  //检查人
		
		private bool _isPrint;  //是否已打印
		
		private DateTime _printTime;  //打印时间
		
		private string _printOperId;  //打印人，BsUser.Id
		
		private string _labIdStr;  //微生物项目和时间点LabId+"_"+yyyyMMddHHmmss
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 标本ID
		/// </summary>
		public string LabId
		{
			get { return _labId;}
			set { _labId = value;}
		}                                    
		
		/// <summary>
		/// 细菌
		/// </summary>
		public string BacteriaId
		{
			get { return _bacteriaId;}
			set { _bacteriaId = value;}
		}                                    
		
		/// <summary>
		/// 报告备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 检查时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 检查人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		public DateTime PrintTime
		{
			get { return _printTime;}
			set { _printTime = value;}
		}                                    
		
		/// <summary>
		/// 打印人，BsUser.Id
		/// </summary>
		public string PrintOperId
		{
			get { return _printOperId;}
			set { _printOperId = value;}
		}                                    
		
		/// <summary>
		/// 微生物项目和时间点LabId+"_"+yyyyMMddHHmmss
		/// </summary>
		public string LabIdStr
		{
			get { return _labIdStr;}
			set { _labIdStr = value;}
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


