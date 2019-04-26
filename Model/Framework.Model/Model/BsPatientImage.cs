

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsPatientImage:BaseModel
	{   
		 
		private string _patId;  //
		
		private byte[] _userImage;  //病人相片
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 病人相片
		/// </summary>
		public byte[] UserImage
		{
			get { return _userImage;}
			set { _userImage = value;}
		}                                    
		
	                                 
		        
	}  
}           


