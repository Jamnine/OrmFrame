

using System;
namespace Orm.Model
{
	/// <summary>
	/// 出院日志表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InLogOutHospital:BaseModel
	{    
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _locationID;  //转出科室
		
		private DateTime _operTime;  //出院时间
		
		private bool _isSum;  //
		
		private int _days;  //天数
		
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
		public string LocationID
		{
			get { return _locationID;}
			set { _locationID = value;}
		}                                    
		
		/// <summary>
		/// 出院时间
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
		/// 天数
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


