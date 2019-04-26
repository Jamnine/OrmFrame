

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:病史表 - 实体类
	/// </summary>
	[Serializable]
	public partial class MediCalhiStory : BaseModel
	{   
		 
		private int _medicalTime;  //发病年龄
		
		private string _medicalName;  //病史名称
		
		private DateTime _openTime;  //添加时间
		
		private string _openId;  //添加人
		
		private string _patId;  //客人id
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 发病年龄
		/// </summary>
		public int MedicalTime
		{
			get { return _medicalTime;}
			set { _medicalTime = value;}
		}                                    
		
		/// <summary>
		/// 病史名称
		/// </summary>
		public string MedicalName
		{
			get { return _medicalName;}
			set { _medicalName = value;}
		}                                    
		
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime OpenTime
		{
			get { return _openTime;}
			set { _openTime = value;}
		}                                    
		
		/// <summary>
		/// 添加人
		/// </summary>
		public string OpenId
		{
			get { return _openId;}
			set { _openId = value;}
		}                                    
		
		/// <summary>
		/// 客人id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		                                  
		        
	}  
}           


