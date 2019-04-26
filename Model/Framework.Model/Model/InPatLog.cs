

using System;
namespace Orm.Model
{
	/// <summary>
	/// 床位操作日志表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InPatLog : BaseModel
    {    
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _locationId;  //转出科室
		
		private DateTime _operTime;  //入科时间
		
		private string _actType;  //日志类别
		
		private string _memo;  //备注
		
		private string _operId;  //操作员
		
		private string _bedName;  //床号
		
		private string _bedId;  //bsbed的ID
		
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
		/// 转出科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 入科时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 日志类别
		/// </summary>
		public string ActType
		{
			get { return _actType;}
			set { _actType = value;}
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
		/// 操作员
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 床号
		/// </summary>
		public string BedName
		{
			get { return _bedName;}
			set { _bedName = value;}
		}                                    
		
		/// <summary>
		/// bsbed的ID
		/// </summary>
		public string BedId
		{
			get { return _bedId;}
			set { _bedId = value;}
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


