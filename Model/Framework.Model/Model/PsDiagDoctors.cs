

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会诊答复表 - 实体类
	/// </summary>
	[Serializable]
	public partial class PsDiagDoctors : BaseModel
	{   
		
		
		
		private string _applyId;  //会诊申请Id,PsDiagMeeting.id
		
		private string _locationId;  //会诊科室
		
		private string _doctorId;  //会诊医生
		
		private bool _isConfirm;  //影像科确认
		
		private DateTime _confirmTime;  //确认时间
		
		private string _answer;  //答复
		
		private int _itemDetail;  //项目详细数量
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

		                            
		
		/// <summary>
		/// 会诊申请Id,PsDiagMeeting.id
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 会诊科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 会诊医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 影像科确认
		/// </summary>
		public bool IsConfirm
		{
			get { return _isConfirm;}
			set { _isConfirm = value;}
		}                                    
		
		/// <summary>
		/// 确认时间
		/// </summary>
		public DateTime ConfirmTime
		{
			get { return _confirmTime;}
			set { _confirmTime = value;}
		}                                    
		
		/// <summary>
		/// 答复
		/// </summary>
		public string Answer
		{
			get { return _answer;}
			set { _answer = value;}
		}                                    
		
		/// <summary>
		/// 项目详细数量
		/// </summary>
		public int ItemDetail
		{
			get { return _itemDetail;}
			set { _itemDetail = value;}
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


