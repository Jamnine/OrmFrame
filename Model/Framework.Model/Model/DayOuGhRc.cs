

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayOuGhRc : BaseModel
    {    
		private DateTime _operTime;  //时间
		
		private string _locationId;  //科室
		
		private string _doctorId;  //医生
		
		private int _ghRc;  //挂号人次
		
		private bool _isRegistration;  //是否临挂
		
		private int _fzRc;  //复诊人次
		
		private bool _isPreReg;  //是否预约
		
		private string _yuYueType;  //预约方式
		
		private int _jxFzRc;  //急性发作人次
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 挂号人次
		/// </summary>
		public int GhRc
		{
			get { return _ghRc;}
			set { _ghRc = value;}
		}                                    
		
		/// <summary>
		/// 是否临挂
		/// </summary>
		public bool IsRegistration
		{
			get { return _isRegistration;}
			set { _isRegistration = value;}
		}                                    
		
		/// <summary>
		/// 复诊人次
		/// </summary>
		public int FzRc
		{
			get { return _fzRc;}
			set { _fzRc = value;}
		}                                    
		
		/// <summary>
		/// 是否预约
		/// </summary>
		public bool IsPreReg
		{
			get { return _isPreReg;}
			set { _isPreReg = value;}
		}                                    
		
		/// <summary>
		/// 预约方式
		/// </summary>
		public string YuYueType
		{
			get { return _yuYueType;}
			set { _yuYueType = value;}
		}                                    
		
		/// <summary>
		/// 急性发作人次
		/// </summary>
		public int JxFzRc
		{
			get { return _jxFzRc;}
			set { _jxFzRc = value;}
		}                                    
		
                                   
		        
	}  
}           


