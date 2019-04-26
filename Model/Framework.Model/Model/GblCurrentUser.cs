

using System;
namespace Orm.Model
{
	/// <summary>
	/// 客户端信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblCurrentUser:BaseModel
	{    
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //制表人
		
		private string _houseId;  //药库ID
		
		private string _roomId;  //所属药房
		
		private string _locationId;  //所属科室
		
		private string _doctorId;  //医生
		
		private string _hostname;  //机器名
		
		private string _specialityId;  //科室专业
		
		private DateTime _beginTime;  //开始时间
		
		private DateTime _endTime;  //结束时间
		
		private int _HospitalID;  //

        public GblCurrentUser() { }
         
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 制表人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 药库ID
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 所属药房
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 所属科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 机器名
		/// </summary>
		public string Hostname
		{
			get { return _hostname;}
			set { _hostname = value;}
		}                                    
		
		/// <summary>
		/// 科室专业
		/// </summary>
		public string SpecialityId
		{
			get { return _specialityId;}
			set { _specialityId = value;}
		}                                    
		
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime BeginTime
		{
			get { return _beginTime;}
			set { _beginTime = value;}
		}                                    
		
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime EndTime
		{
			get { return _endTime;}
			set { _endTime = value;}
		}                                    
		                                
		        
	}  
}           


