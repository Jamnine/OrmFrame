

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
    public partial class CkLabBank : BaseModel
	{    
		private string _labId;  //标本号
		
		private string _bankId;  //血袋id
		
		private string _serialNo;  //血袋编号方便查询
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 标本号
		/// </summary>
		public string LabId
		{
			get { return _labId;}
			set { _labId = value;}
		}                                    
		
		/// <summary>
		/// 血袋id
		/// </summary>
		public string BankId
		{
			get { return _bankId;}
			set { _bankId = value;}
		}                                    
		
		/// <summary>
		/// 血袋编号方便查询
		/// </summary>
		public string SerialNo
		{
			get { return _serialNo;}
			set { _serialNo = value;}
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


