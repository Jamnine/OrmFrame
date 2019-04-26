

using System;
namespace Orm.Model
{
	/// <summary>
	/// 包床记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class InHosBed : BaseModel 
	{    
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _bedId;  //床位
		
		private DateTime _operTime;  //安排日期
		
		private string _operId;  //安排人
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 床位
		/// </summary>
		public string BedId
		{
			get { return _bedId;}
			set { _bedId = value;}
		}                                    
		
		/// <summary>
		/// 安排日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 安排人
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
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


