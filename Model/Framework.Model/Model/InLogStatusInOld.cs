

using System;
namespace Orm.Model
{
	/// <summary>
	/// 旧在院日志 - 实体类
	/// </summary>
	[Serializable]
	public partial class InLogStatusInOld : BaseModel
	{    
		private string _hospId;  //
		
		private string _locationID;  //
		
		private DateTime _operTime;  //
		
		private int _lsInIllness;  //
		
		private  string  _lsinstatus;  //
		
		private  string  _bedName;  //
		
		private string _bedid;  //
		
		private bool _isbaby;  //
		
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
		public string    lsinstatus
		{
			get { return _lsinstatus;}
			set { _lsinstatus = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string  bedName
		{
			get { return _bedName;}
			set { _bedName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string bedid
		{
			get { return _bedid;}
			set { _bedid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool Isbaby
		{
			get { return _isbaby;}
			set { _isbaby = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSum
		{
			get { return _isSum;}
			set { _isSum = value;}
		}                                    
		                                 
		        
	}  
}           


