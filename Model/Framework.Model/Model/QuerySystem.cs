

using System;
namespace Orm.Model
{
	/// <summary>
	/// 叫号系统 - 实体类
	/// </summary>
	[Serializable]
	public partial class QuerySystem:BaseModel
	{   
		
		 
		
		private string _name;  //病人姓名
		
		private string _departmentName;  //诊室
		
		private string _doctorName;  //医生姓名
		
		private string _comments;  //备注
		
		private DateTime _operTime;  //操作时间
		
		private bool _isActive;  //是否可用
		
		private string  _floor;  //楼层
		
		private string _mzregId;  //门诊ID
		
		private string _doctorId;  //医生ID
		 

		                             
		
		/// <summary>
		/// 病人姓名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 诊室
		/// </summary>
		public string DepartmentName
		{
			get { return _departmentName;}
			set { _departmentName = value;}
		}                                    
		
		/// <summary>
		/// 医生姓名
		/// </summary>
		public string DoctorName
		{
			get { return _doctorName;}
			set { _doctorName = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Comments
		{
			get { return _comments;}
			set { _comments = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 楼层
		/// </summary>
		public string  Floor
		{
			get { return _floor;}
			set { _floor = value;}
		}                                    
		
		/// <summary>
		/// 门诊ID
		/// </summary>
		public string MzregId
		{
			get { return _mzregId;}
			set { _mzregId = value;}
		}                                    
		
		/// <summary>
		/// 医生ID
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}
    }  
}           


