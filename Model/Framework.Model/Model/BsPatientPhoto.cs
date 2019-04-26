

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:病人相片 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsPatientPhoto:BaseModel
	{   
		 
		private string _patientId;  //对应BSpatient
		
		private byte[] _photo;  //相片
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 对应BSpatient
		/// </summary>
		public string PatientId
		{
			get { return _patientId;}
			set { _patientId = value;}
		}                                    
		
		/// <summary>
		/// 相片
		/// </summary>
		public byte[] Photo
		{
			get { return _photo;}
			set { _photo = value;}
		}                                    
		
                                 
		        
	}  
}           


