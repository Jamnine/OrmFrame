

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:患者回访表 - 实体类
	/// </summary>
	[Serializable]
	public partial class FollowPatient:BaseModel
	{    
		private string _patId;  //_patId

        private DateTime _followTime;  //随访时间
		
		private string _timeQuantum;  //时间段
		
		private string _operId;  //操作人
		
		private DateTime _operTime;  //操作时间
		
		private int _followType;  //随访类别 3;复诊提醒,4:健康教育,5:诊后关怀,6:病情跟踪,7:满意度调查,8:用药提示
		
		private string _followContent;  //随访内容
		
		private bool _isfeedBack;  //是否需要反馈
		
		private string _mzRegId;  //就诊ID
		
		private string _feedBackContent;  //反馈内容
		
		private string _toothCaseId;  //病历ID
		
		private bool _isAutocreate;  //是否自动创建
		
		private int _followStatus;  //回访状态：0 未回访 1 已回访 2待跟进
		
		private int _followWay;  //随访方式：0 手机APP 1短信 2电话 10其他
		
		private string _patientName;  //患者姓名
		
		private int _appRaiseType;  //满意度
		
		private bool _isDeleted;  //标识是否已删除
		
		private string _modifyerOpenId;  //回访保存ID
		
		private string _returnContent;  //回访结果
		
		private int _returnCycle;  //
		
		private string _sickTypeId;  //病情类型ID TmpEmr.id
		
		private int _HospitalID;  //

        public FollowPatient() { }
                                  
		
		/// <summary>
		/// 随访时间
		/// </summary>
		public DateTime FollowTime
		{
			get { return _followTime;}
			set { _followTime = value;}
		}  
		
		/// <summary>
		/// patId
		/// </summary>
		public string PatId
        {
			get { return _patId; }
			set { _patId = value;}
		}                                
		
		/// <summary>
		/// 时间段
		/// </summary>
		public string TimeQuantum
		{
			get { return _timeQuantum;}
			set { _timeQuantum = value;}
		}                                    
		
		/// <summary>
		/// 操作人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		/// 随访类别 3;复诊提醒,4:健康教育,5:诊后关怀,6:病情跟踪,7:满意度调查,8:用药提示
		/// </summary>
		public int FollowType
		{
			get { return _followType;}
			set { _followType = value;}
		}                                    
		
		/// <summary>
		/// 随访内容
		/// </summary>
		public string FollowContent
		{
			get { return _followContent;}
			set { _followContent = value;}
		}                                    
		
		/// <summary>
		/// 是否需要反馈
		/// </summary>
		public bool IsFeedBack
		{
			get { return _isfeedBack;}
			set { _isfeedBack = value;}
		}                                    
		
		/// <summary>
		/// 就诊ID
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 反馈内容
		/// </summary>
		public string FeedBackContent
		{
			get { return _feedBackContent;}
			set { _feedBackContent = value;}
		}                                    
		
		/// <summary>
		/// 病历ID
		/// </summary>
		public string ToothCaseId
		{
			get { return _toothCaseId;}
			set { _toothCaseId = value;}
		}                                    
		
		/// <summary>
		/// 是否自动创建
		/// </summary>
		public bool IsAutoCreate
		{
			get { return _isAutocreate;}
			set { _isAutocreate = value;}
		}                                    
		
		/// <summary>
		/// 回访状态：0 未回访 1 已回访 2待跟进
		/// </summary>
		public int FollowStatus
		{
			get { return _followStatus;}
			set { _followStatus = value;}
		}                                    
		
		/// <summary>
		/// 随访方式：0 手机APP 1短信 2电话 10其他
		/// </summary>
		public int FollowWay
		{
			get { return _followWay;}
			set { _followWay = value;}
		}                                    
		
		/// <summary>
		/// 患者姓名
		/// </summary>
		public string PatientName
		{
			get { return _patientName;}
			set { _patientName = value;}
		}                                    
		
		/// <summary>
		/// 满意度
		/// </summary>
		public int AppRaiseType
		{
			get { return _appRaiseType;}
			set { _appRaiseType = value;}
		}                                    
		
		/// <summary>
		/// 标识是否已删除
		/// </summary>
		public bool IsDeleted
		{
			get { return _isDeleted;}
			set { _isDeleted = value;}
		}                                    
		
		/// <summary>
		/// 回访保存ID
		/// </summary>
		public string ModifyerOpenId
		{
			get { return _modifyerOpenId;}
			set { _modifyerOpenId = value;}
		}                                    
		
		/// <summary>
		/// 回访结果
		/// </summary>
		public string ReturnContent
		{
			get { return _returnContent;}
			set { _returnContent = value;}
		}

        /// <summary>  
        ///回访周期
        /// </summary>  
        public int ReturnCycle
        {
			get { return _returnCycle;}
			set { _returnCycle = value;}
		}                                    
		
		/// <summary>
		/// 病情类型ID TmpEmr.id
		/// </summary>
		public string SickTypeId
		{
			get { return _sickTypeId;}
			set { _sickTypeId = value;}
		}                                    
		                                
		        
	}  
}           


