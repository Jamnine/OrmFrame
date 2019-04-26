

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验标本登记 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkLab : BaseModel
	{   
		 
		private string _labNum;  //标本号
		
		private string _patId;  //病人ID,对应BsPatient.Id
		
		private string _mzRegId;  //门诊流水号
		
		private string _hospId;  //住院流水号
		
		private int _lsSource;  //标本来源：             1-门诊；2-住院；3-外来单位；4-体检

        private string _locationId;  //关联到LOCATION表
		
		private string _doctorId;  //关联到DOCTOR表
		
		private string _refLocation;  //体检单据号CheckNo
		
		private string _illHistory;  //病历
		
		private string _diagnose;  //临床诊断
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isPriority;  //优先
		
		private DateTime _collectTime;  //采集时间
		
		private string _collectOperId;  //采集人，BsUser.Id
		
		private string _memo;  //备注
		
		private bool _isCancel;  //是否作废
		
		private DateTime _cancelTime;  //作废时间
		
		private string _cancelOperId;  //作废人，BsUser.Id
		
		private bool _isPass;  //是否合格
		
		private string _reportMemo;  //报告备注
		
		private string _techMemo;  //技术备注
		
		private string _otherMemo;  //其他备注
		
		private DateTime _recieveTime;  //标本接收时间
		
		private string _recieveOperId;  //接收人，BsUser.Id
		
		private DateTime _resultTime;  //完成时间
		
		private string _resultOperId;  //完成人
		
		private DateTime _authTime;  //批准时间
		
		private string _authOperId;  //批准人
		
		private DateTime _reportTime;  //发布时间
		
		private string _reportOperId;  //发布人
		
		private int _lsStatus;  //完成状态：1-未完成；2-完成未审批；3-审批未发布报告；4-审批已发布报告；5-部分完成；6-已接收7、已收集8、打印条码。9、LIS已取消。10、Lis已接收,11、Lis已退费.12:已打印报
		
		private string _testTypeId;  //体检分类,CkTestType.Id
		
		private string _collectLocId;  //收集科室
		
		private int _togetherNum;  //
		
		private string _sJOperId;  //送检人,BsUser.Id
		
		private DateTime _sJOperTime;  //送检时间
		
		private string _patientName;  //病人姓名
		
		private bool _isHandInput;  //是否手工登记
		
		private string _reportColName;  //报告字段名
		
		private string _sJName;  //送检人
		
		private DateTime _serviceOpertime;  //送达时间
		
		private bool _isPrint;  //是否已打印
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        private string _checkId;  //检查ID

        private bool _isOver;  //行心云：是否小结

        private bool _isCharge;  //行心云：是否收费

        private string _properties;  //行心云：样本性状

        private string _qCstandId;  //行心云：标本样本Id

        private string _qCReagentlot;  //行心云：试剂批号

        private string _ouRecipeDtlID;  //费用明细Id

        private string _itemName;//项目名字


        

        /// <summary>
        /// 项目名字
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }


        /// <summary>
        /// 标本号
        /// </summary>
        public string LabNum
		{
			get { return _labNum;}
			set { _labNum = value;}
		}                                    
		
		/// <summary>
		/// 病人ID,对应BsPatient.Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 门诊流水号
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 住院流水号
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}

        /// <summary>
        /// 标本来源：1  完成状态：1-未完成；2-完成未审批；3-审批未发布报告；4-审批已发布报告；5-部分完成；6-已接收7、已收集8、打印条码。9、LIS已取消。10、Lis已接收,11、Lis已退费.12:已打印报                               1-门诊；2-住院；3-外来单位；4-体检
        /// </summary>
        public int LsSource
		{
			get { return _lsSource;}
			set { _lsSource = value;}
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
		/// 体检单据号CheckNo
		/// </summary>
		public string RefLocation
		{
			get { return _refLocation;}
			set { _refLocation = value;}
		}                                    
		
		/// <summary>
		/// 病历
		/// </summary>
		public string IllHistory
		{
			get { return _illHistory;}
			set { _illHistory = value;}
		}                                    
		
		/// <summary>
		/// 临床诊断
		/// </summary>
		public string Diagnose
		{
			get { return _diagnose;}
			set { _diagnose = value;}
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
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 优先
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
		}                                    
		
		/// <summary>
		/// 采集时间
		/// </summary>
		public DateTime CollectTime
		{
			get { return _collectTime;}
			set { _collectTime = value;}
		}                                    
		
		/// <summary>
		/// 采集人，BsUser.Id
		/// </summary>
		public string CollectOperId
		{
			get { return _collectOperId;}
			set { _collectOperId = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 是否作废
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 作废时间
		/// </summary>
		public DateTime CancelTime
		{
			get { return _cancelTime;}
			set { _cancelTime = value;}
		}                                    
		
		/// <summary>
		/// 作废人，BsUser.Id
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否合格
		/// </summary>
		public bool IsPass
		{
			get { return _isPass;}
			set { _isPass = value;}
		}                                    
		
		/// <summary>
		/// 报告备注
		/// </summary>
		public string ReportMemo
		{
			get { return _reportMemo;}
			set { _reportMemo = value;}
		}                                    
		
		/// <summary>
		/// 技术备注
		/// </summary>
		public string TechMemo
		{
			get { return _techMemo;}
			set { _techMemo = value;}
		}                                    
		
		/// <summary>
		/// 其他备注
		/// </summary>
		public string OtherMemo
		{
			get { return _otherMemo;}
			set { _otherMemo = value;}
		}                                    
		
		/// <summary>
		/// 标本接收时间
		/// </summary>
		public DateTime RecieveTime
		{
			get { return _recieveTime;}
			set { _recieveTime = value;}
		}                                    
		
		/// <summary>
		/// 接收人，BsUser.Id
		/// </summary>
		public string RecieveOperId
		{
			get { return _recieveOperId;}
			set { _recieveOperId = value;}
		}                                    
		
		/// <summary>
		/// 完成时间
		/// </summary>
		public DateTime ResultTime
		{
			get { return _resultTime;}
			set { _resultTime = value;}
		}                                    
		
		/// <summary>
		/// 完成人
		/// </summary>
		public string ResultOperId
		{
			get { return _resultOperId;}
			set { _resultOperId = value;}
		}                                    
		
		/// <summary>
		/// 批准时间
		/// </summary>
		public DateTime AuthTime
		{
			get { return _authTime;}
			set { _authTime = value;}
		}                                    
		
		/// <summary>
		/// 批准人
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
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
		/// 完成状态：1-未完成；2-完成未审批；3-审批未发布报告；4-审批已发布报告；5-部分完成；6-已接收7、已收集8、打印条码。9、LIS已取消。10、Lis已接收,11、Lis已退费.12:已打印报
		/// </summary>
		public int LsStatus
		{
			get { return _lsStatus;}
			set { _lsStatus = value;}
		}                                    
		
		/// <summary>
		/// 体检分类,CkTestType.Id
		/// </summary>
		public string TestTypeId
		{
			get { return _testTypeId;}
			set { _testTypeId = value;}
		}                                    
		
		/// <summary>
		/// 收集科室
		/// </summary>
		public string CollectLocId
		{
			get { return _collectLocId;}
			set { _collectLocId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int TogetherNum
		{
			get { return _togetherNum;}
			set { _togetherNum = value;}
		}                                    
		
		/// <summary>
		/// 送检人,BsUser.Id
		/// </summary>
		public string SJOperId
		{
			get { return _sJOperId;}
			set { _sJOperId = value;}
		}                                    
		
		/// <summary>
		/// 送检时间
		/// </summary>
		public DateTime SJOperTime
		{
			get { return _sJOperTime;}
			set { _sJOperTime = value;}
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
		/// 是否手工登记
		/// </summary>
		public bool IsHandInput
		{
			get { return _isHandInput;}
			set { _isHandInput = value;}
		}                                    
		
		/// <summary>
		/// 报告字段名
		/// </summary>
		public string ReportColName
		{
			get { return _reportColName;}
			set { _reportColName = value;}
		}                                    
		
		/// <summary>
		/// 送检人
		/// </summary>
		public string SJName
		{
			get { return _sJName;}
			set { _sJName = value;}
		}                                    
		
		/// <summary>
		/// 送达时间
		/// </summary>
		public DateTime ServiceOpertime
		{
			get { return _serviceOpertime;}
			set { _serviceOpertime = value;}
		}                                    
		
		/// <summary>
		/// 是否已打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		



        /// <summary>
        /// 对应体验申请表,CkMain.Id  行心云： 用来存ckSummary Id
        /// </summary>
        public string CheckId
        {
            get { return _checkId; }
            set { _checkId = value; }
        }

        /// <summary>
        /// 行心云：是否小结
        /// </summary>
        public bool IsOver
        {
            get { return _isOver; }
            set { _isOver = value; }
        }

        /// <summary>
        /// 行心云：是否收费
        /// </summary>
        public bool IsCharge
        {
            get { return _isCharge; }
            set { _isCharge = value; }
        }

        /// <summary>
        /// 行心云：样本性状
        /// </summary>
        public string Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        /// <summary>
        /// 行心云：标本样本Id
        /// </summary>
        public string QCstandId
        {
            get { return _qCstandId; }
            set { _qCstandId = value; }
        }

        /// <summary>
        /// 行心云：试剂批号
        /// </summary>
        public string QCReagentlot
        {
            get { return _qCReagentlot; }
            set { _qCReagentlot = value; }
        }

        /// <summary>
        /// 费用明细Id
        /// </summary>
        public string OuRecipeDtlID
        {
            get { return _ouRecipeDtlID; }
            set { _ouRecipeDtlID = value; }
        }

        public string PatName { get; set; }

        private bool _isApproval;
        ///批准
        public bool IsApproval
        {
            get { return _isApproval; }
            set { this._isApproval = value; }
        }

        private bool _isGroup;
        /// <summary>
        ///  冗余字段：是否组合 
        /// </summary>
        public bool IsGroup
        {
            get { return _isGroup; }
            set { _isGroup = value; }
        }

        private bool _isSelected;
        /// <summary>
        /// 是否选中 冗余字段
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set { this._isSelected = value; }
        }
    }
}           


