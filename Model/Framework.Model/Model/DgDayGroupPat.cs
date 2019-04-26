

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgDayGroupPat : BaseModel
    {    
		private string _roadPatId;  //
		
		private string _dayGroupId;  //
		
		private int _lsChangeType;  //
		
		private string _changeReason;  //
		
		private string _changeContent;  //
		
		private string _signNurseUsertId;  //
		
		private string _signDoctorId;  //
		
		private DateTime _signOperTime;  //
		
		private string _dayGroupCode;  //路径日编码
		
		private string _dayGroupName;  //路径日名称
		
		private bool _isAuthed;  //已经封存，不可改删
		  
		/// <summary>
		/// 
		/// </summary>
		public string RoadPatId
		{
			get { return _roadPatId;}
			set { _roadPatId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DayGroupId
		{
			get { return _dayGroupId;}
			set { _dayGroupId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsChangeType
		{
			get { return _lsChangeType;}
			set { _lsChangeType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ChangeReason
		{
			get { return _changeReason;}
			set { _changeReason = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ChangeContent
		{
			get { return _changeContent;}
			set { _changeContent = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SignNurseUsertId
		{
			get { return _signNurseUsertId;}
			set { _signNurseUsertId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SignDoctorId
		{
			get { return _signDoctorId;}
			set { _signDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime SignOperTime
		{
			get { return _signOperTime;}
			set { _signOperTime = value;}
		}                                    
		
		/// <summary>
		/// 路径日编码
		/// </summary>
		public string DayGroupCode
		{
			get { return _dayGroupCode;}
			set { _dayGroupCode = value;}
		}                                    
		
		/// <summary>
		/// 路径日名称
		/// </summary>
		public string DayGroupName
		{
			get { return _dayGroupName;}
			set { _dayGroupName = value;}
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


