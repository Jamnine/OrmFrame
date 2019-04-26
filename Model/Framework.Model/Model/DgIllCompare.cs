

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgIllCompare : BaseModel
    {   
		 
		private string _icdId1;  //诊断（ICD码）
		
		private string _icdId2;  //鉴别诊断
		
		private string _memo;  //特殊情况专用
		
		private int _iconIndex;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		  
		/// <summary>
		/// 诊断（ICD码）
		/// </summary>
		public string IcdId1
		{
			get { return _icdId1;}
			set { _icdId1 = value;}
		}                                    
		
		/// <summary>
		/// 鉴别诊断
		/// </summary>
		public string IcdId2
		{
			get { return _icdId2;}
			set { _icdId2 = value;}
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


