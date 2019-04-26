

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgIllCheckResult : BaseModel
    {   
		 
		private string _icdId;  //诊断（ICD码）
		
		private string _checkResult;  //症状
		
		private bool _isBaby;  //儿童专用
		
		private bool _isWomen;  //妇女专用
		
		private bool _isMen;  //男性专用
		
		private bool _isOlder;  //老人专用
		
		private string _memo;  //特殊情况专用
		
		private int _iconIndex;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		  
		/// <summary>
		/// 诊断（ICD码）
		/// </summary>
		public string IcdId
		{
			get { return _icdId;}
			set { _icdId = value;}
		}                                    
		
		/// <summary>
		/// 症状
		/// </summary>
		public string CheckResult
		{
			get { return _checkResult;}
			set { _checkResult = value;}
		}                                    
		
		/// <summary>
		/// 儿童专用
		/// </summary>
		public bool IsBaby
		{
			get { return _isBaby;}
			set { _isBaby = value;}
		}                                    
		
		/// <summary>
		/// 妇女专用
		/// </summary>
		public bool IsWomen
		{
			get { return _isWomen;}
			set { _isWomen = value;}
		}                                    
		
		/// <summary>
		/// 男性专用
		/// </summary>
		public bool IsMen
		{
			get { return _isMen;}
			set { _isMen = value;}
		}                                    
		
		/// <summary>
		/// 老人专用
		/// </summary>
		public bool IsOlder
		{
			get { return _isOlder;}
			set { _isOlder = value;}
		}                                    
		
		/// <summary>
		/// 特殊情况专用
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
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


