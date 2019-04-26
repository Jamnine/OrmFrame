

using System;
namespace Orm.Model
{
	/// <summary>
	/// 旧转科日志 - 实体类
	/// </summary>
	[Serializable]
	public partial class InLogOutLocationOld:BaseModel
	{   
		 
		private string _hospId;  //
		
		private string _locationID;  //
		
		private DateTime _operTime;  //
		
		private string _inLocId;  //
		
		private int _lsType;  //
		
		private string _memo;  //
		
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
		public string InLocId
		{
			get { return _inLocId;}
			set { _inLocId = value;}
		}                                    
		
		/// <summary>
		/// 
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


