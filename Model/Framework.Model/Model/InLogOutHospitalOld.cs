

using System;
namespace Orm.Model
{
	/// <summary>
	/// 旧出院日志 - 实体类
	/// </summary>
	[Serializable]
	public partial class InLogOutHospitalOld:BaseModel
	{    
		private string _hospId;  //
		
		private string _locationID;  //
		
		private DateTime _operTime;  //
		
		private bool _isSum;  //
		
		private int _days;  //
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LocationID
		{
			get { return _locationID;}
			set { _locationID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSum
		{
			get { return _isSum;}
			set { _isSum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
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


