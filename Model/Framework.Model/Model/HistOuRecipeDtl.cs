

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史门诊处方明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistOuRecipeDtl : BaseModel
    {   
		
		private DateTime _inSertTime;  //插入时间 

		private string _recipeId;  //处方Id,OuRecipe.id
		
		private int _listNum;  //方号
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private int _groupNum;  //组号
		
		private double _dosage;  //每次量
		
		private string _unitTakeId;  //使用单位
		
		private string _frequencyId;  //频率对应BsFrequency.Id
		
		private string _usageId;  //用法对应BsUsage.Id
		
		private int _days;  //天数
		
		private double _totality;  //数量
		
		private string _unitDiagId;  //门诊单位
		
		private bool _isAttach;  //是否执行
		
		private bool _isOtherFee;  //是否附加项目
		
		private string _xDRpId;  //协定处方Id,BsXdRp.Id
		
		private string _memo;  //备注
		
		private bool _isCharged;  //是否收费
		
		private bool _isCancel;  //是否作废
		
		private DateTime _cancelTime;  //作废时间
		
		private string _cancelOperId;  //作废人
		
		private bool _isPrint;  //是否打印
		
		private DateTime _printTime;  //打印时间
		
		private string _printOperId;  //打印人
		
		private bool _isPrepared;  //是否准备
		
		private string _prepareTime;  //准备时间
		
		private string _prepareOperId;  //准备人
		
		private bool _isIssue;  //是否发药
		
		private DateTime _issueTime;  //发药时间
		
		private string _issueOperId;  //发药人
		
		private bool _isToBack;  //医生是否确认退药
		
		private bool _isBack;  //是否已退药
		
		private bool _isDoctorInput;  //是否医生录入
		
		private int _recNum;  //
		
		private DateTime _recipeTime;  //处方时间
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private int _allPageNo;  //
		
		private int _pageNo;  //
		
		private string _cureDtlId;  //
		
		private bool _isBP;  //是否BP
		
		private string _bPReason;  //BP原因
		
		private string _ybType;  //医保类别
		
		private string _invoNo;  //发票号
		
		private bool _isAutoCharged;  //是否自动收
		
		private bool _isForCharge;  //是否从门诊收费调用录入
		
		private string _applyId;  //检查申请单ID
		
		private double _price;  //单价
		
		private string _tempStr;  //代码临时使用
		
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
		/// 处方Id,OuRecipe.id
		/// </summary>
		public string RecipeId
		{
			get { return _recipeId;}
			set { _recipeId = value;}
		}                                    
		
		/// <summary>
		/// 方号
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 组号
		/// </summary>
		public int GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 每次量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 使用单位
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 频率对应BsFrequency.Id
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 用法对应BsUsage.Id
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 天数
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 门诊单位
		/// </summary>
		public string UnitDiagId
		{
			get { return _unitDiagId;}
			set { _unitDiagId = value;}
		}                                    
		
		/// <summary>
		/// 是否执行
		/// </summary>
		public bool IsAttach
		{
			get { return _isAttach;}
			set { _isAttach = value;}
		}                                    
		
		/// <summary>
		/// 是否附加项目
		/// </summary>
		public bool IsOtherFee
		{
			get { return _isOtherFee;}
			set { _isOtherFee = value;}
		}                                    
		
		/// <summary>
		/// 协定处方Id,BsXdRp.Id
		/// </summary>
		public string XDRpId
		{
			get { return _xDRpId;}
			set { _xDRpId = value;}
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
		/// 是否收费
		/// </summary>
		public bool IsCharged
		{
			get { return _isCharged;}
			set { _isCharged = value;}
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
		/// 作废人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 打印时间
		/// </summary>
		public DateTime PrintTime
		{
			get { return _printTime;}
			set { _printTime = value;}
		}                                    
		
		/// <summary>
		/// 打印人
		/// </summary>
		public string PrintOperId
		{
			get { return _printOperId;}
			set { _printOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否准备
		/// </summary>
		public bool IsPrepared
		{
			get { return _isPrepared;}
			set { _isPrepared = value;}
		}                                    
		
		/// <summary>
		/// 准备时间
		/// </summary>
		public string PrepareTime
		{
			get { return _prepareTime;}
			set { _prepareTime = value;}
		}                                    
		
		/// <summary>
		/// 准备人
		/// </summary>
		public string PrepareOperId
		{
			get { return _prepareOperId;}
			set { _prepareOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否发药
		/// </summary>
		public bool IsIssue
		{
			get { return _isIssue;}
			set { _isIssue = value;}
		}                                    
		
		/// <summary>
		/// 发药时间
		/// </summary>
		public DateTime IssueTime
		{
			get { return _issueTime;}
			set { _issueTime = value;}
		}                                    
		
		/// <summary>
		/// 发药人
		/// </summary>
		public string IssueOperId
		{
			get { return _issueOperId;}
			set { _issueOperId = value;}
		}                                    
		
		/// <summary>
		/// 医生是否确认退药
		/// </summary>
		public bool IsToBack
		{
			get { return _isToBack;}
			set { _isToBack = value;}
		}                                    
		
		/// <summary>
		/// 是否已退药
		/// </summary>
		public bool IsBack
		{
			get { return _isBack;}
			set { _isBack = value;}
		}                                    
		
		/// <summary>
		/// 是否医生录入
		/// </summary>
		public bool IsDoctorInput
		{
			get { return _isDoctorInput;}
			set { _isDoctorInput = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int RecNum
		{
			get { return _recNum;}
			set { _recNum = value;}
		}                                    
		
		/// <summary>
		/// 处方时间
		/// </summary>
		public DateTime RecipeTime
		{
			get { return _recipeTime;}
			set { _recipeTime = value;}
		}                                    
		
		/// <summary>
		/// 科室ID,BsLocation.Id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int AllPageNo
		{
			get { return _allPageNo;}
			set { _allPageNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int PageNo
		{
			get { return _pageNo;}
			set { _pageNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CureDtlId
		{
			get { return _cureDtlId;}
			set { _cureDtlId = value;}
		}                                    
		
		/// <summary>
		/// 是否BP
		/// </summary>
		public bool IsBP
		{
			get { return _isBP;}
			set { _isBP = value;}
		}                                    
		
		/// <summary>
		/// BP原因
		/// </summary>
		public string BPReason
		{
			get { return _bPReason;}
			set { _bPReason = value;}
		}                                    
		
		/// <summary>
		/// 医保类别
		/// </summary>
		public string YbType
		{
			get { return _ybType;}
			set { _ybType = value;}
		}                                    
		
		/// <summary>
		/// 发票号
		/// </summary>
		public string InvoNo
		{
			get { return _invoNo;}
			set { _invoNo = value;}
		}                                    
		
		/// <summary>
		/// 是否自动收
		/// </summary>
		public bool IsAutoCharged
		{
			get { return _isAutoCharged;}
			set { _isAutoCharged = value;}
		}                                    
		
		/// <summary>
		/// 是否从门诊收费调用录入
		/// </summary>
		public bool IsForCharge
		{
			get { return _isForCharge;}
			set { _isForCharge = value;}
		}                                    
		
		/// <summary>
		/// 检查申请单ID
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
		}                                    
		
		/// <summary>
		/// 代码临时使用
		/// </summary>
		public string TempStr
		{
			get { return _tempStr;}
			set { _tempStr = value;}
		}                                    
		
                                   
		        
	}  
}           


