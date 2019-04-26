

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class TrDoctorEmr:BaseModel
	{    
		private string _doctorId;  //批准医生Auth_man
		
		private DateTime _operTime;  //登记日期时间
		
		private string _patID;  //病人ID
		
		private string _fileName;  //文件名
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 批准医生Auth_man
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 登记日期时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatID
		{
			get { return _patID;}
			set { _patID = value;}
		}                                    
		
		/// <summary>
		/// 文件名
		/// </summary>
		public string FileName
		{
			get { return _fileName;}
			set { _fileName = value;}
		}                                    
		                                  
		        
	}  
}           


