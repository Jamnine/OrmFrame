

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class VipCardLog: BaseModel
	{   
		
	 
		private string _vipCardId;  //会员卡Id,VipCard.id
		
		private string _oldCardNo;  //旧卡号
		
		private string _newCardNo;  //新卡号
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		                              
		
		/// <summary>
		/// 会员卡Id,VipCard.id
		/// </summary>
		public string VipCardId
		{
			get { return _vipCardId;}
			set { _vipCardId = value;}
		}                                    
		
		/// <summary>
		/// 旧卡号
		/// </summary>
		public string OldCardNo
		{
			get { return _oldCardNo;}
			set { _oldCardNo = value;}
		}                                    
		
		/// <summary>
		/// 新卡号
		/// </summary>
		public string NewCardNo
		{
			get { return _newCardNo;}
			set { _newCardNo = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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


