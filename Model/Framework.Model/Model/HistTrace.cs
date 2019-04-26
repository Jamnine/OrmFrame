

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史每日数据质量信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistTrace : BaseModel
    {   
		
		private DateTime _inSertTime;  //插入时间 
		
		private DateTime _createDate;  //创建时间
		
		private string _userID;  //用户Id,对应BsUser.Id
		
		private string _messages;  //更改信息
		
		private string _type;  //类别
		
		private string _operateType;  //操作类别
		
		private string _recordId;  //记录表Id
		
		private string _ouInNo;  //住院号\门诊号
		
		private string _patientName;  //病人姓名
		
		private string _workFlow;  //业务流程描述
		
		private string _locationName;  //科室名称
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime InSertTime
		{
			get { return _inSertTime;}
			set { _inSertTime = value;}
		}                                    
		 
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateDate
		{
			get { return _createDate;}
			set { _createDate = value;}
		}                                    
		
		/// <summary>
		/// 用户Id,对应BsUser.Id
		/// </summary>
		public string UserID
		{
			get { return _userID;}
			set { _userID = value;}
		}                                    
		
		/// <summary>
		/// 更改信息
		/// </summary>
		public string Messages
		{
			get { return _messages;}
			set { _messages = value;}
		}                                    
		
		/// <summary>
		/// 类别
		/// </summary>
		public string Type
		{
			get { return _type;}
			set { _type = value;}
		}                                    
		
		/// <summary>
		/// 操作类别
		/// </summary>
		public string OperateType
		{
			get { return _operateType;}
			set { _operateType = value;}
		}                                    
		
		/// <summary>
		/// 记录表Id
		/// </summary>
		public string RecordId
		{
			get { return _recordId;}
			set { _recordId = value;}
		}                                    
		
		/// <summary>
		/// 住院号\门诊号
		/// </summary>
		public string OuInNo
		{
			get { return _ouInNo;}
			set { _ouInNo = value;}
		}                                    
		
		/// <summary>
		/// 病人姓名
		/// </summary>
		public string PatientName
		{
			get { return _patientName;}
			set { _patientName = value;}
		}                                    
		
		/// <summary>
		/// 业务流程描述
		/// </summary>
		public string WorkFlow
		{
			get { return _workFlow;}
			set { _workFlow = value;}
		}                                    
		
		/// <summary>
		/// 科室名称
		/// </summary>
		public string LocationName
		{
			get { return _locationName;}
			set { _locationName = value;}
		}                                    
		                                  
		        
	}  
}           


