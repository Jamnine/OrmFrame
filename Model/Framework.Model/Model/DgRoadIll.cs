

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoadIll : BaseModel
    {   
		 
		private string _illId;  //
		
		private string _roadId;  //
		
		private string _memo;  //
		
		private string _illDesc;  //诊断（ICD名称）
		
		private string _zyZx;  //中医证型
		
		private string _zyZxIcdId;  //中医证型TCDID
		
		private string _icdId;  //西医诊断Id
		
		private string _illDescZy;  //中医诊断名称
		
		private bool _isAuthed;  //已经封存，不可改删
		  
		/// <summary>
		/// 
		/// </summary>
		public string IllId
		{
			get { return _illId;}
			set { _illId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string RoadId
		{
			get { return _roadId;}
			set { _roadId = value;}
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
		/// 诊断（ICD名称）
		/// </summary>
		public string IllDesc
		{
			get { return _illDesc;}
			set { _illDesc = value;}
		}                                    
		
		/// <summary>
		/// 中医证型
		/// </summary>
		public string ZyZx
		{
			get { return _zyZx;}
			set { _zyZx = value;}
		}                                    
		
		/// <summary>
		/// 中医证型TCDID
		/// </summary>
		public string ZyZxIcdId
		{
			get { return _zyZxIcdId;}
			set { _zyZxIcdId = value;}
		}                                    
		
		/// <summary>
		/// 西医诊断Id
		/// </summary>
		public string IcdId
		{
			get { return _icdId;}
			set { _icdId = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		        
	}  
}           


