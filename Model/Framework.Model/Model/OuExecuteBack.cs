

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊退药执行 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuExecuteBack : BaseModel  
	{   
		
		private string _executeId;  //执行ID
		
		private string _executeDtlId;  //执行明细表Id,OuExecutedtl.id
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isBack;  //药房是否已经确认退药
		
		private string _ksBackBillId;  //药房科室退药单ID
		
		private DateTime _backTime;  //药房退药时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		                             
		
		/// <summary>
		/// 执行ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 执行明细表Id,OuExecutedtl.id
		/// </summary>
		public string ExecuteDtlId
		{
			get { return _executeDtlId;}
			set { _executeDtlId = value;}
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
		/// 药房是否已经确认退药
		/// </summary>
		public bool IsBack
		{
			get { return _isBack;}
			set { _isBack = value;}
		}                                    
		
		/// <summary>
		/// 药房科室退药单ID
		/// </summary>
		public string KsBackBillId
		{
			get { return _ksBackBillId;}
			set { _ksBackBillId = value;}
		}                                    
		
		/// <summary>
		/// 药房退药时间
		/// </summary>
		public DateTime BackTime
		{
			get { return _backTime;}
			set { _backTime = value;}
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


