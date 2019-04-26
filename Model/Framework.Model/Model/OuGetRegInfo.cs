

using System;
namespace Orm.Model
{
	/// <summary>
	/// 挂号信息用于微信接口 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuGetRegInfo : BaseModel  
	{   
		
		private string _doctorID;  //医生Id,BsDoctor.Id
		
		private string _doctorName;  //医生名称
		
		private string _doctorTitle;  //
		
		private string _timeRegInfoList;  //
		
		private DateTime _regDate;  //
		
		private int _regWeekDay;  //
		
		private int _regTotalCount;  //
		
		private int _regleaveCount;  //
		
		private int _totalfee;  //
		
		private double _regfee;  //
		
		private double _treatfee;  //
		
		private int _isTimeReg;  //
		
		private int _shiftType;  //
		
		private string _timeRegInfo;  //
		
		private string _startTime;  //
		
		private string _timeEnd;  //结束时间
		
		private int _regTotalCount1;  //
		
		private int _regleaveCount1;  //
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _onlyId;  //
		
		private string _roomName;  //
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DoctorID
		{
			get { return _doctorID;}
			set { _doctorID = value;}
		}                                    
		
		/// <summary>
		/// 医生名称
		/// </summary>
		public string DoctorName
		{
			get { return _doctorName;}
			set { _doctorName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DoctorTitle
		{
			get { return _doctorTitle;}
			set { _doctorTitle = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TimeRegInfoList
		{
			get { return _timeRegInfoList;}
			set { _timeRegInfoList = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime RegDate
		{
			get { return _regDate;}
			set { _regDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int RegWeekDay
		{
			get { return _regWeekDay;}
			set { _regWeekDay = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int RegTotalCount
		{
			get { return _regTotalCount;}
			set { _regTotalCount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int RegleaveCount
		{
			get { return _regleaveCount;}
			set { _regleaveCount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Totalfee
		{
			get { return _totalfee;}
			set { _totalfee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Regfee
		{
			get { return _regfee;}
			set { _regfee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Treatfee
		{
			get { return _treatfee;}
			set { _treatfee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int IsTimeReg
		{
			get { return _isTimeReg;}
			set { _isTimeReg = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int ShiftType
		{
			get { return _shiftType;}
			set { _shiftType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TimeRegInfo
		{
			get { return _timeRegInfo;}
			set { _timeRegInfo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string StartTime
		{
			get { return _startTime;}
			set { _startTime = value;}
		}                                    
		
		/// <summary>
		/// 结束时间
		/// </summary>
		public string TimeEnd
		{
			get { return _timeEnd;}
			set { _timeEnd = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int RegTotalCount1
		{
			get { return _regTotalCount1;}
			set { _regTotalCount1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int RegleaveCount1
		{
			get { return _regleaveCount1;}
			set { _regleaveCount1 = value;}
		}                                    
		
		/// <summary>
		/// 科室ID,BsLocation.Id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OnlyId
		{
			get { return _onlyId;}
			set { _onlyId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string RoomName
		{
			get { return _roomName;}
			set { _roomName = value;}
		}                                    
		                                
		        
	}  
}           


