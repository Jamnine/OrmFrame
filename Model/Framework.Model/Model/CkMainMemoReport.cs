

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMainMemoReport : BaseModel
    {   
		 
		private string _code;  //
		
		private string _groupName;  //
		
		private string _groupSubName;  //
		
		private int _orderBy;  //
		
		private bool _isActive;  //
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string GroupName
		{
			get { return _groupName;}
			set { _groupName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string GroupSubName
		{
			get { return _groupSubName;}
			set { _groupSubName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
	                                  
		        
	}  
}           


