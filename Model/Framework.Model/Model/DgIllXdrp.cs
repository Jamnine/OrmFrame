

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgIllXdrp : BaseModel
    {    
		private string _illId;  //诊断（ICD码）
		
		private string _xdrpId;  //协定处方ID
		
		private string _memo;  //特殊情况专用
		
		private int _iconIndex;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		  
		/// <summary>
		/// 诊断（ICD码）
		/// </summary>
		public string IllId
		{
			get { return _illId;}
			set { _illId = value;}
		}                                    
		
		/// <summary>
		/// 协定处方ID
		/// </summary>
		public string XdrpId
		{
			get { return _xdrpId;}
			set { _xdrpId = value;}
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


