

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊诊断模板 - 实体类
	/// </summary>
	[Serializable]
	public partial class TmpOuEmr:BaseModel
	{    
		private string _name;  //套餐名称
		
		private string _groupMain;  //一级分组
		
		private string _groupSub;  //二级分组
		
		private int _orderBy;  //显示次序
		
		private bool _isActive;  //是否可用
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private int _lsOpenType;  //使用权：1-个人；2-科室；3-公共
		
		private string _operId;  //创建人
		
		private DateTime _operTime;  //创建时间
		
		private string _locationId;  //创建部门
		
		private string _mainInform;  //主诉（社区：主观资料）
		
		private string _sickHist;  //现病史（社区：问题评估）
		
		private double _examT;  //体温
		
		private double _examP;  //
		
		private double _examR;  //
		
		private double _examBp;  //
		
		private double _examBp2;  //
		
		private string _checkUp;  //体格检查
		
		private string _checkCT;  //辅助检查
		
		private string _disposal;  //处理及建议
		
		private string _impression;  //望诊印象
		
		private string _analys;  //治疗原则
		
		private string _others;  //其他
		
		private string _tongue;  //舌象
		
		private string _pulse;  //脉象
		
		private string _moss;  //苔象
		
		private double _examSugar;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _usDrugCase;  //行心云:使用药物情况
		
		private string _menarche;  //行心云:个人史
		
		private string _familyHistoryOther;  //行心云:家族病史
		
		private string _treatment;  //行心云:治疗建议
		
		private string _diagnosis;  //行心云:诊断
		
		private string _allErgy;  //行心云:过敏史
		
		private string _otherHistory;  //行心云:既往史
		
		private string _presenthistory;  //行心云:现病史
		
		private string _abortion;  //行心云:婚育史
		
		private string _toothCasecontID;  //行心云:关联病历短语id
		
		private string _physicalCheck;  //行心云: 治疗过程
		
		private int _HospitalID;  //
		 

		
	 
	                   
		
		/// <summary>
		/// 套餐名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 一级分组
		/// </summary>
		public string GroupMain
		{
			get { return _groupMain;}
			set { _groupMain = value;}
		}                                    
		
		/// <summary>
		/// 二级分组
		/// </summary>
		public string GroupSub
		{
			get { return _groupSub;}
			set { _groupSub = value;}
		}                                    
		
		/// <summary>
		/// 显示次序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 使用权：1-个人；2-科室；3-公共
		/// </summary>
		public int LsOpenType
		{
			get { return _lsOpenType;}
			set { _lsOpenType = value;}
		}                                    
		
		/// <summary>
		/// 创建人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		/// 创建部门
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 主诉（社区：主观资料）
		/// </summary>
		public string MainInform
		{
			get { return _mainInform;}
			set { _mainInform = value;}
		}                                    
		
		/// <summary>
		/// 现病史（社区：问题评估）
		/// </summary>
		public string SickHist
		{
			get { return _sickHist;}
			set { _sickHist = value;}
		}                                    
		
		/// <summary>
		/// 体温
		/// </summary>
		public double ExamT
		{
			get { return _examT;}
			set { _examT = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamP
		{
			get { return _examP;}
			set { _examP = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamR
		{
			get { return _examR;}
			set { _examR = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamBp
		{
			get { return _examBp;}
			set { _examBp = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamBp2
		{
			get { return _examBp2;}
			set { _examBp2 = value;}
		}                                    
		
		/// <summary>
		/// 体格检查
		/// </summary>
		public string CheckUp
		{
			get { return _checkUp;}
			set { _checkUp = value;}
		}                                    
		
		/// <summary>
		/// 辅助检查
		/// </summary>
		public string CheckCT
		{
			get { return _checkCT;}
			set { _checkCT = value;}
		}                                    
		
		/// <summary>
		/// 处理及建议
		/// </summary>
		public string Disposal
		{
			get { return _disposal;}
			set { _disposal = value;}
		}                                    
		
		/// <summary>
		/// 望诊印象
		/// </summary>
		public string Impression
		{
			get { return _impression;}
			set { _impression = value;}
		}                                    
		
		/// <summary>
		/// 治疗原则
		/// </summary>
		public string Analys
		{
			get { return _analys;}
			set { _analys = value;}
		}                                    
		
		/// <summary>
		/// 其他
		/// </summary>
		public string Others
		{
			get { return _others;}
			set { _others = value;}
		}                                    
		
		/// <summary>
		/// 舌象
		/// </summary>
		public string Tongue
		{
			get { return _tongue;}
			set { _tongue = value;}
		}                                    
		
		/// <summary>
		/// 脉象
		/// </summary>
		public string Pulse
		{
			get { return _pulse;}
			set { _pulse = value;}
		}                                    
		
		/// <summary>
		/// 苔象
		/// </summary>
		public string Moss
		{
			get { return _moss;}
			set { _moss = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamSugar
		{
			get { return _examSugar;}
			set { _examSugar = value;}
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
		/// 行心云:使用药物情况
		/// </summary>
		public string UsDrugCase
		{
			get { return _usDrugCase;}
			set { _usDrugCase = value;}
		}                                    
		
		/// <summary>
		/// 行心云:个人史
		/// </summary>
		public string Menarche
		{
			get { return _menarche;}
			set { _menarche = value;}
		}                                    
		
		/// <summary>
		/// 行心云:家族病史
		/// </summary>
		public string FamilyHistoryOther
		{
			get { return _familyHistoryOther;}
			set { _familyHistoryOther = value;}
		}                                    
		
		/// <summary>
		/// 行心云:治疗建议
		/// </summary>
		public string Treatment
		{
			get { return _treatment;}
			set { _treatment = value;}
		}                                    
		
		/// <summary>
		/// 行心云:诊断
		/// </summary>
		public string Diagnosis
		{
			get { return _diagnosis;}
			set { _diagnosis = value;}
		}                                    
		
		/// <summary>
		/// 行心云:过敏史
		/// </summary>
		public string AllErgy
		{
			get { return _allErgy;}
			set { _allErgy = value;}
		}                                    
		
		/// <summary>
		/// 行心云:既往史
		/// </summary>
		public string OtherHistory
		{
			get { return _otherHistory;}
			set { _otherHistory = value;}
		}                                    
		
		/// <summary>
		/// 行心云:现病史
		/// </summary>
		public string Presenthistory
		{
			get { return _presenthistory;}
			set { _presenthistory = value;}
		}                                    
		
		/// <summary>
		/// 行心云:婚育史
		/// </summary>
		public string Abortion
		{
			get { return _abortion;}
			set { _abortion = value;}
		}                                    
		
		/// <summary>
		/// 行心云:关联病历短语id
		/// </summary>
		public string ToothCasecontID
		{
			get { return _toothCasecontID;}
			set { _toothCasecontID = value;}
		}                                    
		
		/// <summary>
		/// 行心云: 治疗过程
		/// </summary>
		public string PhysicalCheck
		{
			get { return _physicalCheck;}
			set { _physicalCheck = value;}
		}                                    
		                                
		        
	}  
}           


