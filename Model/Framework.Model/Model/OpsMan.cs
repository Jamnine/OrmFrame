

using System;
namespace Orm.Model
{
	/// <summary>
	/// 手术人员表（护士、医生） - 实体类
	/// </summary>
	[Serializable]
	public partial class OpsMan : BaseModel
    {   
		 
		private string _applyId;  //申请IdOpsApply.Id
		
		private string _userId;  //人员
		
		private int _lsRole;  //角色：1-助手；2-洗手护士；3-巡回护士；4-器械师
		
		private string _locationId;  //科室ID
		
		private string _docLevId;  //职称
		
		private string _memo;  //备注
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 申请IdOpsApply.Id
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 人员
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 角色：1-助手；2-洗手护士；3-巡回护士；4-器械师
		/// </summary>
		public int LsRole
		{
			get { return _lsRole;}
			set { _lsRole = value;}
		}                                    
		
		/// <summary>
		/// 科室ID
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 职称
		/// </summary>
		public string DocLevId
		{
			get { return _docLevId;}
			set { _docLevId = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
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


