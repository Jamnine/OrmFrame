

using System;
namespace Orm.Model
{
	/// <summary>
	/// 入院日志表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InLogInHospital:BaseModel
	{    
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _locationID;  //转出科室
		
		private DateTime _operTime;  //入科时间
		
		private int _lsInIllness;  //入院病情：1-危；2-急；3-一般；4-重
		
		private bool _isSum;  //是否统计
		
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
		/// 入科时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 入院病情：1-危；2-急；3-一般；4-重
		/// </summary>
		public int LsInIllness
		{
			get { return _lsInIllness;}
			set { _lsInIllness = value;}
		}                                    
		
		/// <summary>
		/// 是否统计
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


