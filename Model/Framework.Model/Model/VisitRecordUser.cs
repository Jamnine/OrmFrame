

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class VisitRecordUser : BaseModel
	{    
		private string _userId;  //用户id
		
		private string _doctorId;  //医生id
		
		private int _lsUserRole;  //用户权限暂不用
		
		private bool _isAuthed;  //已经封存，不可改删

        public VisitRecordUser() { }

                                      
		
		/// <summary>
		/// 用户id
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 医生id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 用户权限暂不用
		/// </summary>
		public int LsUserRole
		{
			get { return _lsUserRole;}
			set { _lsUserRole = value;}
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


