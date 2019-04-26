

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CsLocService : BaseModel
    {   
		 
		private string _locId;  //科室
		
		private string _logisticServeId;  //
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 科室
		/// </summary>
		public string LocId
		{
			get { return _locId;}
			set { _locId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LogisticServeId
		{
			get { return _logisticServeId;}
			set { _logisticServeId = value;}
		}                                    
		
                                 
		        
	}  
}           


