

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊处方发药申请表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuRecipeTemp : BaseModel
	{   
		
		
		private string _recipeId;  //处方Id,OuRecipe.id
		
		private string _mzRegId;  //门诊病人ID,Ouhosinfo.Id
		
		private string _mzRegNo;  //门诊流水号
		
		private DateTime _regTime;  //挂号时间
		
		private string _sex;  //性别
		
		private int _age;  //年龄
		
		private int _babyMonth;  //月份
		
		private string _addressHome;  //家庭住址
		
		private string _illDesc;  //诊断
		
		private string _name;  //名称
		
		private int _lsRepType;  //项目类别
		
		private string _recipeNum;  //处方号
		
		private DateTime _recipeTime;  //处方时间
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private int _howMany;  //剂数
		
		private bool _isPriority;  //是否紧急
		
		private string _memo;  //备注
		
		private bool _isPend;  //
		
		private bool _isExecuted;  //是否已执行
		
		private string _cardNo;  //病人卡号
		
		private string _contactPhone;  //联系电话
		
		private string _pyCode1;  //拼音码1
		
		private string _wbCode1;  //五笔码1
		
		private string _pyCode2;  //拼音码2
		
		private string _wbCode2;  //五笔码2
		
		private string _pyCode3;  //拼音码3
		
		private string _wbCode3;  //五笔码3
		
		private double _amount;  //金额
		
		private string _doctorName;  //医生名称
		
		private string _locationName;  //科室名称
		
		private int _HospitalID;  //院区Id,BsHospital.Id
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private bool _isIssue;  //是否发药
		
		private bool _isBack;  //是否已退
		
		private string _roomWindowName;  //窗口名
		
		private DateTime _operTime;  //操作时间
		
		private int _lsReportType;  //公费报销报表费用类别
		
		private string _dosageOperId;  //每次量OperId
		
		private DateTime _dosageTime;  //每次量Time
		
		private string _patTypeId;  //病人类别
		
		private string _patId;  //病人Id对应Bspatient.id
		
		private string _invoNo;  //发票号
		
		private bool _isOuAddInvo;  //门诊发药是否按照发票号来新增
		
		private bool _isPrinted;  //是否已经打印
		
		private bool _isCancel;  //是否注销
		
		private bool _isDosage;  //是否配药
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _listNo;  //行心云
		
		private bool _isMachineComfirm;  //行心云
		
		private string _patTypeName;  //行心云：F1病人类别??????
		
		private bool _isDosaged;  //行心云：F3是否已确认打印
		
		private DateTime _ouChargeDate;  //行心云：

        private DateTime _issueTime;

        private string _issueOperId;

        /// <summary>
        /// 发药人
        /// </summary>
        public string IssueOperId
        {
            get { return _issueOperId; }
            set { _issueOperId = value; }
        }
        /// <summary>
        /// 发药时间
        /// </summary>
        public DateTime IssueTime
        {
            get { return _issueTime; }
            set { _issueTime = value; }
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
		/// 门诊病人ID,Ouhosinfo.Id
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 门诊流水号
		/// </summary>
		public string MzRegNo
		{
			get { return _mzRegNo;}
			set { _mzRegNo = value;}
		}                                    
		
		/// <summary>
		/// 挂号时间
		/// </summary>
		public DateTime RegTime
		{
			get { return _regTime;}
			set { _regTime = value;}
		}                                    
		
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			get { return _sex;}
			set { _sex = value;}
		}                                    
		
		/// <summary>
		/// 年龄
		/// </summary>
		public int Age
		{
			get { return _age;}
			set { _age = value;}
		}                                    
		
		/// <summary>
		/// 月份
		/// </summary>
		public int BabyMonth
		{
			get { return _babyMonth;}
			set { _babyMonth = value;}
		}                                    
		
		/// <summary>
		/// 家庭住址
		/// </summary>
		public string AddressHome
		{
			get { return _addressHome;}
			set { _addressHome = value;}
		}                                    
		
		/// <summary>
		/// 诊断
		/// </summary>
		public string IllDesc
		{
			get { return _illDesc;}
			set { _illDesc = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 项目类别
		/// </summary>
		public int LsRepType
		{
			get { return _lsRepType;}
			set { _lsRepType = value;}
		}                                    
		
		/// <summary>
		/// 处方号
		/// </summary>
		public string RecipeNum
		{
			get { return _recipeNum;}
			set { _recipeNum = value;}
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
		/// 剂数
		/// </summary>
		public int HowMany
		{
			get { return _howMany;}
			set { _howMany = value;}
		}                                    
		
		/// <summary>
		/// 是否紧急
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
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
		/// 
		/// </summary>
		public bool IsPend
		{
			get { return _isPend;}
			set { _isPend = value;}
		}                                    
		
		/// <summary>
		/// 是否已执行
		/// </summary>
		public bool IsExecuted
		{
			get { return _isExecuted;}
			set { _isExecuted = value;}
		}                                    
		
		/// <summary>
		/// 病人卡号
		/// </summary>
		public string CardNo
		{
			get { return _cardNo;}
			set { _cardNo = value;}
		}                                    
		
		/// <summary>
		/// 联系电话
		/// </summary>
		public string ContactPhone
		{
			get { return _contactPhone;}
			set { _contactPhone = value;}
		}                                    
		
		/// <summary>
		/// 拼音码1
		/// </summary>
		public string PyCode1
		{
			get { return _pyCode1;}
			set { _pyCode1 = value;}
		}                                    
		
		/// <summary>
		/// 五笔码1
		/// </summary>
		public string WbCode1
		{
			get { return _wbCode1;}
			set { _wbCode1 = value;}
		}                                    
		
		/// <summary>
		/// 拼音码2
		/// </summary>
		public string PyCode2
		{
			get { return _pyCode2;}
			set { _pyCode2 = value;}
		}                                    
		
		/// <summary>
		/// 五笔码2
		/// </summary>
		public string WbCode2
		{
			get { return _wbCode2;}
			set { _wbCode2 = value;}
		}                                    
		
		/// <summary>
		/// 拼音码3
		/// </summary>
		public string PyCode3
		{
			get { return _pyCode3;}
			set { _pyCode3 = value;}
		}                                    
		
		/// <summary>
		/// 五笔码3
		/// </summary>
		public string WbCode3
		{
			get { return _wbCode3;}
			set { _wbCode3 = value;}
		}                                    
		
		/// <summary>
		/// 金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 医生名称
		/// </summary>
		public string DoctorName
		{
			get { return _doctorName;}
			set { _doctorName = value;}
		}                                    
		
		/// <summary>
		/// 科室名称
		/// </summary>
		public string LocationName
		{
			get { return _locationName;}
			set { _locationName = value;}
		}                                    
		                                
		
		/// <summary>
		/// 药房ID,BsRoom.Id
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
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
		/// 是否已退
		/// </summary>
		public bool IsBack
		{
			get { return _isBack;}
			set { _isBack = value;}
		}                                    
		
		/// <summary>
		/// 窗口名
		/// </summary>
		public string RoomWindowName
		{
			get { return _roomWindowName;}
			set { _roomWindowName = value;}
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
		/// 公费报销报表费用类别
		/// </summary>
		public int LsReportType
		{
			get { return _lsReportType;}
			set { _lsReportType = value;}
		}                                    
		
		/// <summary>
		/// 每次量OperId
		/// </summary>
		public string DosageOperId
		{
			get { return _dosageOperId;}
			set { _dosageOperId = value;}
		}                                    
		
		/// <summary>
		/// 每次量Time
		/// </summary>
		public DateTime DosageTime
		{
			get { return _dosageTime;}
			set { _dosageTime = value;}
		}                                    
		
		/// <summary>
		/// 病人类别
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 病人Id对应Bspatient.id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
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
		/// 门诊发药是否按照发票号来新增
		/// </summary>
		public bool IsOuAddInvo
		{
			get { return _isOuAddInvo;}
			set { _isOuAddInvo = value;}
		}                                    
		
		/// <summary>
		/// 是否已经打印
		/// </summary>
		public bool IsPrinted
		{
			get { return _isPrinted;}
			set { _isPrinted = value;}
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
		/// 是否配药
		/// </summary>
		public bool IsDosage
		{
			get { return _isDosage;}
			set { _isDosage = value;}
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
		/// 行心云
		/// </summary>
		public string ListNo
		{
			get { return _listNo;}
			set { _listNo = value;}
		}                                    
		
		/// <summary>
		/// 行心云
		/// </summary>
		public bool IsMachineComfirm
		{
			get { return _isMachineComfirm;}
			set { _isMachineComfirm = value;}
		}                                    
		
		/// <summary>
		/// 行心云：F1病人类别??????
		/// </summary>
		public string PatTypeName
		{
			get { return _patTypeName;}
			set { _patTypeName = value;}
		}                                    
		
		/// <summary>
		/// 行心云：F3是否已确认打印
		/// </summary>
		public bool IsDosaged
		{
			get { return _isDosaged;}
			set { _isDosaged = value;}
		}                                    
		
		/// <summary>
		/// 行心云：
		/// </summary>
		public DateTime OuChargeDate
		{
			get { return _ouChargeDate;}
			set { _ouChargeDate = value;}
		}
       

        private string _fayaoID;
        /// <summary>  
        /// 发药
        /// </summary>  
        public string FayaoID
        {
            get { return this._fayaoID; }
            set { this._fayaoID = value; }
        }

    }  
}           


