

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InPatLogBed : BaseModel
    {    
		private string _hospId;  //
		
		private string _locationId;  //
		
		private DateTime _operTime;  //
		
		private int _lsInstatus;  //
		
		private bool _isSum;  //是否统计
		
		private string _bedId;  //
		
		private string _bedName;  //
		
		private bool _isBaby;  //是否婴儿
		
		private bool _isAuthed;  //已经封存，不可改删
		
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
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
		public int lsInstatus
		{
			get { return _lsInstatus;}
			set { _lsInstatus = value;}
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
		public string BedId
		{
			get { return _bedId;}
			set { _bedId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BedName
		{
			get { return _bedName;}
			set { _bedName = value;}
		}                                    
		
		/// <summary>
		/// 是否婴儿
		/// </summary>
		public bool IsBaby
		{
			get { return _isBaby;}
			set { _isBaby = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                                  
		        
	}  
}           


