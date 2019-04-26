

using System;
namespace Orm.Model
{
	/// <summary>
	/// 出院招回记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class InCallBack:BaseModel
	{   
		 
		private string _locationId;  //申请科室Req_Loc
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private DateTime _backTime;  //召回时间
		
		private string _reason;  //召回原因
		
		private DateTime _operTime;  //记录时间
		
		private string _operId;  //记录者姓名
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InCallBack() { }
         
		/// <summary>
		/// 申请科室Req_Loc
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 召回时间
		/// </summary>
		public DateTime BackTime
		{
			get { return _backTime;}
			set { _backTime = value;}
		}                                    
		
		/// <summary>
		/// 召回原因
		/// </summary>
		public string Reason
		{
			get { return _reason;}
			set { _reason = value;}
		}                                    
		
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 记录者姓名
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


