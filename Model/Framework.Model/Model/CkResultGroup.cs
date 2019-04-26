

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检小结 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkResultGroup : BaseModel
	{    
		private string _testGroupId;  //检验分组,CkTestGroup.Id
		
		private string _checkId;  //检查ID
		
		private string _checkDesc;  //检查综述
		
		private string _summary;  //体检小结
		
		private string _doctorAdvice;  //医生建议
		
		private int _lsStatus;  //完成状态：1-未完成；2-完成未审批；3-审批未发布报告；4-审批已发布报告
		
		private DateTime _resultTime;  //完成时间
		
		private string _resultOperId;  //完成人
		
		private DateTime _authTime;  //批准时间
		
		private string _authOperId;  //批准人
		
		private string _testGroupName;  //体检分组名称
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 检验分组,CkTestGroup.Id
		/// </summary>
		public string TestGroupId
		{
			get { return _testGroupId;}
			set { _testGroupId = value;}
		}                                    
		
		/// <summary>
		/// 检查ID
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
		}                                    
		
		/// <summary>
		/// 检查综述
		/// </summary>
		public string CheckDesc
		{
			get { return _checkDesc;}
			set { _checkDesc = value;}
		}                                    
		
		/// <summary>
		/// 体检小结
		/// </summary>
		public string Summary
		{
			get { return _summary;}
			set { _summary = value;}
		}                                    
		
		/// <summary>
		/// 医生建议
		/// </summary>
		public string DoctorAdvice
		{
			get { return _doctorAdvice;}
			set { _doctorAdvice = value;}
		}                                    
		
		/// <summary>
		/// 完成状态：1-未完成；2-完成未审批；3-审批未发布报告；4-审批已发布报告
		/// </summary>
		public int LsStatus
		{
			get { return _lsStatus;}
			set { _lsStatus = value;}
		}                                    
		
		/// <summary>
		/// 完成时间
		/// </summary>
		public DateTime ResultTime
		{
			get { return _resultTime;}
			set { _resultTime = value;}
		}                                    
		
		/// <summary>
		/// 完成人
		/// </summary>
		public string ResultOperId
		{
			get { return _resultOperId;}
			set { _resultOperId = value;}
		}                                    
		
		/// <summary>
		/// 批准时间
		/// </summary>
		public DateTime AuthTime
		{
			get { return _authTime;}
			set { _authTime = value;}
		}                                    
		
		/// <summary>
		/// 批准人
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
		}                                    
		
		/// <summary>
		/// 体检分组名称
		/// </summary>
		public string TestGroupName
		{
			get { return _testGroupName;}
			set { _testGroupName = value;}
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


