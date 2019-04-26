

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检诊断 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMainIll : BaseModel
    {    
		private string _checkId;  //体检单ID
		
		private int _listNum;  //顺序号
		
		private string _icdId;  //诊断（ICD码）
		
		private string _illDesc;  //诊断名称
		
		private string _illAdviceMemo;  //诊断医嘱描述
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 体检单ID
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
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
		/// 诊断医嘱描述
		/// </summary>
		public string IllAdviceMemo
		{
			get { return _illAdviceMemo;}
			set { _illAdviceMemo = value;}
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


