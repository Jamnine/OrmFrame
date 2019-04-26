

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgIllGroup : BaseModel
    {    
		private string _icdId;  //诊断（ICD码）
		
		private string _groupDesc;  //治疗方案
		
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
		/// 治疗方案
		/// </summary>
		public string GroupDesc
		{
			get { return _groupDesc;}
			set { _groupDesc = value;}
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


