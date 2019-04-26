

using System;
namespace Orm.Model
{
	/// <summary>
	/// 申请退血 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkBldApplyBank : BaseModel
    {   
		 
		private string _applyId;  //申请单ID,CkBldApply.id
		
		private string _bankId;  //血袋id
		
		private string _serilalNo;  //血袋编号
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public CkBldApplyBank() { }
         
		/// <summary>
		/// 申请单ID,CkBldApply.id
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
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
		/// 血袋编号
		/// </summary>
		public string SerilalNo
		{
			get { return _serilalNo;}
			set { _serilalNo = value;}
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


