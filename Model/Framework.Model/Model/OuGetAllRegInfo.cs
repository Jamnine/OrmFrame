

using System;
namespace Orm.Model
{
	/// <summary>
	/// 挂号信息用于微信接口 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuGetAllRegInfo : BaseModel  
	{   
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private string _doctorName;  //医生名称
		
		private string _doctorTitle;  //
		
		private string _timeRegInfoList;  //
		
		private DateTime _regDate;  //
		
		private int _regweekDay;  //
		
		private int _regLeaveCount;  //
		
		private int _totalfee;  //
		
		private double _regFee;  //
		
		private int _regStatus;  //
		
		private string _timeReginfo;  //
		
		private string _startTime;  //
		
		private string _timeEnd;  //结束时间
		
		private int _regTotalCount1;  //
		
		private int _regLeaveCount1;  //
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private int _isCancel;  //是否作废
		
		private string _roomName;  //
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
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
		public int RegweekDay
		{
			get { return _regweekDay;}
			set { _regweekDay = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int RegLeaveCount
		{
			get { return _regLeaveCount;}
			set { _regLeaveCount = value;}
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
		public double RegFee
		{
			get { return _regFee;}
			set { _regFee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int RegStatus
		{
			get { return _regStatus;}
			set { _regStatus = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TimeReginfo
		{
			get { return _timeReginfo;}
			set { _timeReginfo = value;}
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
		public int RegLeaveCount1
		{
			get { return _regLeaveCount1;}
			set { _regLeaveCount1 = value;}
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
		/// 是否作废
		/// </summary>
		public int IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
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


