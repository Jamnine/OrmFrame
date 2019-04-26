

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InRecFirstPage : BaseModel
    {   
		 
		private string _recNo;  //编号
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private DateTime _operTime;  //创建时间
		
		private string _operID;  //操作员
		
		private DateTime _modifyOperTime;  //修改时间
		
		private string _modifyOperID;  //操作员
		
		private bool _isAuth;  //是否审核
		
		private DateTime _authOperTime;  //审核日期
		
		private string _authOperId;  //审核人
		
		private DateTime _confirmIllDate;  //确诊日期
		
		private bool _isOPS;  //是否手术
		
		private bool _isBabyCard;  //是否输入妇婴卡
		
		private bool _isMutiIll;  //是否并发症
		
		private int _infectTimes;  //医院感染次数
		
		private bool _isSalvage;  //是否抢救病人
		
		private int _salvageTimes;  //抢救次数
		
		private bool _isSalvSucess;  //是否抢救成功
		
		private int _salvSucessTimes;  //抢救成功次数
		
		private bool _isFollow;  //是否随诊
		
		private DateTime _followEndDate;  //随诊期限
		
		private bool _isDeadBodyCheck;  //是否尸检
		
		private bool _isStudyCase;  //是否示教病案
		
		private int _lsQuality;  //病案质量：1-好；2-一般；3-差
		
		private string _zrDoctorId;  //主任医生
		
		private string _zzDoctorId;  //主治医生
		
		private string _zyDoctorId;  //住院医生
		
		private string _sxDoctorId;  //实习医生
		
		private string _jxDoctorId;  //进修医师
		
		private string _yjsDoctorId;  //责任护士
		
		private string _zkDoctorId;  //质控医师
		
		private int _lsAccMzIll;  //门诊诊断符合：1-未做；2-符合；3-不符合；4-不确定
		
		private int _lsAccZyIll;  //住院诊断符合：1-未做；2-符合；3-不符合；4-不确定
		
		private int _lsAccOPSIll1;  //手术1符合：1-未做；2-符合；3-不符合；4-不确定
		
		private int _lsAccOPSIll2;  //手术2符合：1-未做；2-符合；3-不符合；4-不确定
		
		private int _lsAccOPSIll3;  //手术3符合：1-未做；2-符合；3-不符合；4-不确定
		
		private int _lsAccOPSIll4;  //手术4符合：1-未做；2-符合；3-不符合；4-不确定
		
		private bool _isTjIll;  //是否部分病种
		
		private bool _isConfirm3D;  //是否三日确诊
		
		private int _babyNum;  //婴儿数
		
		private bool _isTranNeact;  //是否输血反应
		
		private bool _isOxygenNeact;  //是否输氧反应
		
		private bool _isMidFireBurn;  //是否中度烧伤
		
		private bool _isSingleIll;  //是否单病种
		
		private bool _isHbsAg;  //是否HbsAg
		
		private bool _isHCVAb;  //是否HCVAb
		
		private bool _isHIVAb;  //是否0HIVAb
		
		private bool _isHbsAg3;  //是否HbsAg
		
		private string _headOperId;  //科主任
		
		private string _zkOperId;  //质控护士
		
		private DateTime _zkDate;  //质控日期
		
		private bool _isRH;  //是否RH
		
		private bool _isOpsFirst;  //是否首次手术
		
		private bool _isCureFirst;  //是否首次治疗
		
		private bool _isCheckFirst;  //是否首次检查
		
		private bool _isDiagFirst;  //是否首次诊断
		
		private int _redCellNum;  //输血红细胞数量
		
		private int _plaqueNum;  //血小板数量
		
		private int _serousNum;  //血浆数量
		
		private int _allBloodNum;  //全血数量
		
		private int _otherBloodNum;  //其他血袋数量
		
		private int _consultHosputal;  //院际会诊（次）
		
		private int _consultRemote;  //远程会诊（次）
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 编号
		/// </summary>
		public string RecNo
		{
			get { return _recNo;}
			set { _recNo = value;}
		}                                    
		
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime ModifyOperTime
		{
			get { return _modifyOperTime;}
			set { _modifyOperTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员
		/// </summary>
		public string ModifyOperID
		{
			get { return _modifyOperID;}
			set { _modifyOperID = value;}
		}                                    
		
		/// <summary>
		/// 是否审核
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime AuthOperTime
		{
			get { return _authOperTime;}
			set { _authOperTime = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
		}                                    
		
		/// <summary>
		/// 确诊日期
		/// </summary>
		public DateTime ConfirmIllDate
		{
			get { return _confirmIllDate;}
			set { _confirmIllDate = value;}
		}                                    
		
		/// <summary>
		/// 是否手术
		/// </summary>
		public bool IsOPS
		{
			get { return _isOPS;}
			set { _isOPS = value;}
		}                                    
		
		/// <summary>
		/// 是否输入妇婴卡
		/// </summary>
		public bool IsBabyCard
		{
			get { return _isBabyCard;}
			set { _isBabyCard = value;}
		}                                    
		
		/// <summary>
		/// 是否并发症
		/// </summary>
		public bool IsMutiIll
		{
			get { return _isMutiIll;}
			set { _isMutiIll = value;}
		}                                    
		
		/// <summary>
		/// 医院感染次数
		/// </summary>
		public int InfectTimes
		{
			get { return _infectTimes;}
			set { _infectTimes = value;}
		}                                    
		
		/// <summary>
		/// 是否抢救病人
		/// </summary>
		public bool IsSalvage
		{
			get { return _isSalvage;}
			set { _isSalvage = value;}
		}                                    
		
		/// <summary>
		/// 抢救次数
		/// </summary>
		public int SalvageTimes
		{
			get { return _salvageTimes;}
			set { _salvageTimes = value;}
		}                                    
		
		/// <summary>
		/// 是否抢救成功
		/// </summary>
		public bool IsSalvSucess
		{
			get { return _isSalvSucess;}
			set { _isSalvSucess = value;}
		}                                    
		
		/// <summary>
		/// 抢救成功次数
		/// </summary>
		public int SalvSucessTimes
		{
			get { return _salvSucessTimes;}
			set { _salvSucessTimes = value;}
		}                                    
		
		/// <summary>
		/// 是否随诊
		/// </summary>
		public bool IsFollow
		{
			get { return _isFollow;}
			set { _isFollow = value;}
		}                                    
		
		/// <summary>
		/// 随诊期限
		/// </summary>
		public DateTime FollowEndDate
		{
			get { return _followEndDate;}
			set { _followEndDate = value;}
		}                                    
		
		/// <summary>
		/// 是否尸检
		/// </summary>
		public bool IsDeadBodyCheck
		{
			get { return _isDeadBodyCheck;}
			set { _isDeadBodyCheck = value;}
		}                                    
		
		/// <summary>
		/// 是否示教病案
		/// </summary>
		public bool IsStudyCase
		{
			get { return _isStudyCase;}
			set { _isStudyCase = value;}
		}                                    
		
		/// <summary>
		/// 病案质量：1-好；2-一般；3-差
		/// </summary>
		public int LsQuality
		{
			get { return _lsQuality;}
			set { _lsQuality = value;}
		}                                    
		
		/// <summary>
		/// 主任医生
		/// </summary>
		public string ZrDoctorId
		{
			get { return _zrDoctorId;}
			set { _zrDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 主治医生
		/// </summary>
		public string ZzDoctorId
		{
			get { return _zzDoctorId;}
			set { _zzDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 住院医生
		/// </summary>
		public string ZyDoctorId
		{
			get { return _zyDoctorId;}
			set { _zyDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 实习医生
		/// </summary>
		public string SxDoctorId
		{
			get { return _sxDoctorId;}
			set { _sxDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 进修医师
		/// </summary>
		public string JxDoctorId
		{
			get { return _jxDoctorId;}
			set { _jxDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 责任护士
		/// </summary>
		public string YjsDoctorId
		{
			get { return _yjsDoctorId;}
			set { _yjsDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 质控医师
		/// </summary>
		public string ZkDoctorId
		{
			get { return _zkDoctorId;}
			set { _zkDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 门诊诊断符合：1-未做；2-符合；3-不符合；4-不确定
		/// </summary>
		public int LsAccMzIll
		{
			get { return _lsAccMzIll;}
			set { _lsAccMzIll = value;}
		}                                    
		
		/// <summary>
		/// 住院诊断符合：1-未做；2-符合；3-不符合；4-不确定
		/// </summary>
		public int LsAccZyIll
		{
			get { return _lsAccZyIll;}
			set { _lsAccZyIll = value;}
		}                                    
		
		/// <summary>
		/// 手术1符合：1-未做；2-符合；3-不符合；4-不确定
		/// </summary>
		public int LsAccOPSIll1
		{
			get { return _lsAccOPSIll1;}
			set { _lsAccOPSIll1 = value;}
		}                                    
		
		/// <summary>
		/// 手术2符合：1-未做；2-符合；3-不符合；4-不确定
		/// </summary>
		public int LsAccOPSIll2
		{
			get { return _lsAccOPSIll2;}
			set { _lsAccOPSIll2 = value;}
		}                                    
		
		/// <summary>
		/// 手术3符合：1-未做；2-符合；3-不符合；4-不确定
		/// </summary>
		public int LsAccOPSIll3
		{
			get { return _lsAccOPSIll3;}
			set { _lsAccOPSIll3 = value;}
		}                                    
		
		/// <summary>
		/// 手术4符合：1-未做；2-符合；3-不符合；4-不确定
		/// </summary>
		public int LsAccOPSIll4
		{
			get { return _lsAccOPSIll4;}
			set { _lsAccOPSIll4 = value;}
		}                                    
		
		/// <summary>
		/// 是否部分病种
		/// </summary>
		public bool IsTjIll
		{
			get { return _isTjIll;}
			set { _isTjIll = value;}
		}                                    
		
		/// <summary>
		/// 是否三日确诊
		/// </summary>
		public bool IsConfirm3D
		{
			get { return _isConfirm3D;}
			set { _isConfirm3D = value;}
		}                                    
		
		/// <summary>
		/// 婴儿数
		/// </summary>
		public int BabyNum
		{
			get { return _babyNum;}
			set { _babyNum = value;}
		}                                    
		
		/// <summary>
		/// 是否输血反应
		/// </summary>
		public bool IsTranNeact
		{
			get { return _isTranNeact;}
			set { _isTranNeact = value;}
		}                                    
		
		/// <summary>
		/// 是否输氧反应
		/// </summary>
		public bool IsOxygenNeact
		{
			get { return _isOxygenNeact;}
			set { _isOxygenNeact = value;}
		}                                    
		
		/// <summary>
		/// 是否中度烧伤
		/// </summary>
		public bool IsMidFireBurn
		{
			get { return _isMidFireBurn;}
			set { _isMidFireBurn = value;}
		}                                    
		
		/// <summary>
		/// 是否单病种
		/// </summary>
		public bool IsSingleIll
		{
			get { return _isSingleIll;}
			set { _isSingleIll = value;}
		}                                    
		
		/// <summary>
		/// 是否HbsAg
		/// </summary>
		public bool IsHbsAg
		{
			get { return _isHbsAg;}
			set { _isHbsAg = value;}
		}                                    
		
		/// <summary>
		/// 是否HCVAb
		/// </summary>
		public bool IsHCVAb
		{
			get { return _isHCVAb;}
			set { _isHCVAb = value;}
		}                                    
		
		/// <summary>
		/// 是否0HIVAb
		/// </summary>
		public bool IsHIVAb
		{
			get { return _isHIVAb;}
			set { _isHIVAb = value;}
		}                                    
		
		/// <summary>
		/// 是否HbsAg
		/// </summary>
		public bool IsHbsAg3
		{
			get { return _isHbsAg3;}
			set { _isHbsAg3 = value;}
		}                                    
		
		/// <summary>
		/// 科主任
		/// </summary>
		public string HeadOperId
		{
			get { return _headOperId;}
			set { _headOperId = value;}
		}                                    
		
		/// <summary>
		/// 质控护士
		/// </summary>
		public string ZkOperId
		{
			get { return _zkOperId;}
			set { _zkOperId = value;}
		}                                    
		
		/// <summary>
		/// 质控日期
		/// </summary>
		public DateTime ZkDate
		{
			get { return _zkDate;}
			set { _zkDate = value;}
		}                                    
		
		/// <summary>
		/// 是否RH
		/// </summary>
		public bool IsRH
		{
			get { return _isRH;}
			set { _isRH = value;}
		}                                    
		
		/// <summary>
		/// 是否首次手术
		/// </summary>
		public bool IsOpsFirst
		{
			get { return _isOpsFirst;}
			set { _isOpsFirst = value;}
		}                                    
		
		/// <summary>
		/// 是否首次治疗
		/// </summary>
		public bool IsCureFirst
		{
			get { return _isCureFirst;}
			set { _isCureFirst = value;}
		}                                    
		
		/// <summary>
		/// 是否首次检查
		/// </summary>
		public bool IsCheckFirst
		{
			get { return _isCheckFirst;}
			set { _isCheckFirst = value;}
		}                                    
		
		/// <summary>
		/// 是否首次诊断
		/// </summary>
		public bool IsDiagFirst
		{
			get { return _isDiagFirst;}
			set { _isDiagFirst = value;}
		}                                    
		
		/// <summary>
		/// 输血红细胞数量
		/// </summary>
		public int RedCellNum
		{
			get { return _redCellNum;}
			set { _redCellNum = value;}
		}                                    
		
		/// <summary>
		/// 血小板数量
		/// </summary>
		public int PlaqueNum
		{
			get { return _plaqueNum;}
			set { _plaqueNum = value;}
		}                                    
		
		/// <summary>
		/// 血浆数量
		/// </summary>
		public int SerousNum
		{
			get { return _serousNum;}
			set { _serousNum = value;}
		}                                    
		
		/// <summary>
		/// 全血数量
		/// </summary>
		public int AllBloodNum
		{
			get { return _allBloodNum;}
			set { _allBloodNum = value;}
		}                                    
		
		/// <summary>
		/// 其他血袋数量
		/// </summary>
		public int OtherBloodNum
		{
			get { return _otherBloodNum;}
			set { _otherBloodNum = value;}
		}                                    
		
		/// <summary>
		/// 院际会诊（次）
		/// </summary>
		public int ConsultHosputal
		{
			get { return _consultHosputal;}
			set { _consultHosputal = value;}
		}                                    
		
		/// <summary>
		/// 远程会诊（次）
		/// </summary>
		public int ConsultRemote
		{
			get { return _consultRemote;}
			set { _consultRemote = value;}
		}                                    
		                                 
		        
	}  
}           


