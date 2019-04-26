

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会诊医嘱执行表 - 实体类
	/// </summary>
	[Serializable]
	public partial class PsExecute : BaseModel
	{   
		
		private string _applyId;  //会诊申请Id,PsDiagMeeting.id
		
		private string _recipeId;  //处方ID
		
		private bool _isExecuted;  //是否已执行
		
		private DateTime _executedTime;  //执行时间
		
		private string _executedOperId;  //执行人
		
		private string _execLocId;  //执行科室
		
		private string _source;  //数据源
		
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
		/// 处方ID
		/// </summary>
		public string RecipeId
		{
			get { return _recipeId;}
			set { _recipeId = value;}
		}                                    
		
		/// <summary>
		/// 是否已执行
		/// </summary>
		public bool IsExecuted
		{
			get { return _isExecuted;}
			set { _isExecuted = value;}
		}                                    
		
		/// <summary>
		/// 执行时间
		/// </summary>
		public DateTime ExecutedTime
		{
			get { return _executedTime;}
			set { _executedTime = value;}
		}                                    
		
		/// <summary>
		/// 执行人
		/// </summary>
		public string ExecutedOperId
		{
			get { return _executedOperId;}
			set { _executedOperId = value;}
		}                                    
		
		/// <summary>
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 数据源
		/// </summary>
		public string Source
		{
			get { return _source;}
			set { _source = value;}
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


