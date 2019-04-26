

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检申请单 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMain:BaseModel
	{   
		 
		private string _checkNo;  //单据号
		
		private string _patId;  //病人ID，对应于Patient的Pat_Id
		
		private DateTime _checkTime;  //检查时间
		
		private string _companyCkeckId;  //单位体检CkCompanyCkeck.Id
		
		private string _locationId;  //关联到LOCATION表
		
		private string _doctorId;  //关联到DOCTOR表
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private bool _isCancel;  //是否注销
		
		private DateTime _cancelOperTime;  //注销日期
		
		private string _cancelOperId;  //收费操作员
		
		private string _cancelMemo;  //退款备注
		
		private DateTime _recieveTime;  //报到时间
		
		private string _recieveOperId;  //报到人
		
		private DateTime _reportTime;  //发布时间
		
		private string _reportOperId;  //发布人
		
		private int _lsStatus;  //完成状态：1-未完成；2-完成未审批；3-审批未发布报告；4-审批已发布报告；5-部分完成；6-已接收
		
		private string _reportMemo;  //报告发现
		
		private string _techMemo;  //建议
		
		private string _otherMemo;  //综述
		
		private string _companyId;  //体检单位
		
		private string _companyGroupId;  //体检单
		
		private string _rptFileName;  //报告格式文件
		
		private bool _isPay;  //是否结账
		
		private string _code;  //编号
		
		private int _type;  //体检类型
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 单据号
		/// </summary>
		public string CheckNo
		{
			get { return _checkNo;}
			set { _checkNo = value;}
		}                                    
		
		/// <summary>
		/// 病人ID，对应于Patient的Pat_Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 检查时间
		/// </summary>
		public DateTime CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 单位体检CkCompanyCkeck.Id
		/// </summary>
		public string CompanyCkeckId
		{
			get { return _companyCkeckId;}
			set { _companyCkeckId = value;}
		}                                    
		
		/// <summary>
		/// 关联到LOCATION表
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 关联到DOCTOR表
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否注销
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 注销日期
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 收费操作员
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 退款备注
		/// </summary>
		public string CancelMemo
		{
			get { return _cancelMemo;}
			set { _cancelMemo = value;}
		}                                    
		
		/// <summary>
		/// 报到时间
		/// </summary>
		public DateTime RecieveTime
		{
			get { return _recieveTime;}
			set { _recieveTime = value;}
		}                                    
		
		/// <summary>
		/// 报到人
		/// </summary>
		public string RecieveOperId
		{
			get { return _recieveOperId;}
			set { _recieveOperId = value;}
		}                                    
		
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime ReportTime
		{
			get { return _reportTime;}
			set { _reportTime = value;}
		}                                    
		
		/// <summary>
		/// 发布人
		/// </summary>
		public string ReportOperId
		{
			get { return _reportOperId;}
			set { _reportOperId = value;}
		}                                    
		
		/// <summary>
		/// 完成状态：1-未完成；2-完成未审批；3-审批未发布报告；4-审批已发布报告；5-部分完成；6-已接收
		/// </summary>
		public int LsStatus
		{
			get { return _lsStatus;}
			set { _lsStatus = value;}
		}                                    
		
		/// <summary>
		/// 报告发现
		/// </summary>
		public string ReportMemo
		{
			get { return _reportMemo;}
			set { _reportMemo = value;}
		}                                    
		
		/// <summary>
		/// 建议
		/// </summary>
		public string TechMemo
		{
			get { return _techMemo;}
			set { _techMemo = value;}
		}                                    
		
		/// <summary>
		/// 综述
		/// </summary>
		public string OtherMemo
		{
			get { return _otherMemo;}
			set { _otherMemo = value;}
		}                                    
		
		/// <summary>
		/// 体检单位
		/// </summary>
		public string CompanyId
		{
			get { return _companyId;}
			set { _companyId = value;}
		}                                    
		
		/// <summary>
		/// 体检单
		/// </summary>
		public string CompanyGroupId
		{
			get { return _companyGroupId;}
			set { _companyGroupId = value;}
		}                                    
		
		/// <summary>
		/// 报告格式文件
		/// </summary>
		public string RptFileName
		{
			get { return _rptFileName;}
			set { _rptFileName = value;}
		}                                    
		
		/// <summary>
		/// 是否结账
		/// </summary>
		public bool IsPay
		{
			get { return _isPay;}
			set { _isPay = value;}
		}                                    
		
		/// <summary>
		/// 编号
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 体检类型
		/// </summary>
		public int  Type
		{
			get { return _type;}
			set { _type = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
	                                   
		        
	}  
}           


