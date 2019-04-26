

using System;
namespace Orm.Model
{
	/// <summary>
	/// 转科日志表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InLogOutLocation:BaseModel
	{    
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _locationID;  //转出科室
		
		private DateTime _operTime;  //入科时间
		
		private string _inLocId;  //转入科室
		
		private int _lsType;  //1:转出2：转入
		
		private string _memo;  //
		
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
		/// 转入科室
		/// </summary>
		public string InLocId
		{
			get { return _inLocId;}
			set { _inLocId = value;}
		}                                    
		
		/// <summary>
		/// 1:转出2：转入
		/// </summary>
		public int LsType
		{
			get { return _lsType;}
			set { _lsType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 是否统计
		/// </summary>
		public bool IsSum
		{
			get { return _isSum;}
			set { _isSum = value;}
		}                                    
		                                   
		        
	}  
}           


