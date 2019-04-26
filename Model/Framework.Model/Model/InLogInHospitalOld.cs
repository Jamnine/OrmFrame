

using System;
namespace Orm.Model
{
	/// <summary>
	/// 旧入院日志 - 实体类
	/// </summary>
	[Serializable]
	public partial class InLogInHospitalOld : BaseModel
    {   
		 
		private string _hospId;  //
		
		private string _locationID;  //
		
		private DateTime _operTime;  //
		
		private int _lsInIllness;  //
		
		private bool _isSum;  //
		
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
		public int LsInIllness
		{
			get { return _lsInIllness;}
			set { _lsInIllness = value;}
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
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


