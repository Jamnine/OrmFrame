

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:病人基本档案 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuHealthCheckBase : BaseModel  
	{   
		 
		private string _patId;  //
		
		private string _locationId;  //
		
		private string _mzRegId;  //
		
		private string _operId;  //
		
		private DateTime _operLastDate;  //
		
		private string _symptomIds;  // 症状
		
		private double _temperature;  // 体温
		
		private double _pulseRate;  // 脉率
		
		private double _respiratoryRate;  // 呼吸频率
		
		private double _waist;  // 腰围
		
		private double _bloodPressureLeft;  // 血压左侧
		
		private double _bloodPressureReght;  // 血压右侧
		
		private double _bloodPressureLeft2;  // 血压左侧
		
		private double _bloodPressureReght2;  // 血压右侧
		
		private double _weight;  // 体重
		
		private double _height;  // 身高
		
		private double _bmi;  // 体重指数
		
		private double _statusAssessment;  // 状态评估
		
		private double _selfCare;  // 自理能力
		
		private string _cognition;  // 认知功能
		
		private double _cognitionScore;  // 分数
		
		private string _emotion;  // 感情
		
		private double _emotionScore;  // 分数
		
		private double _sportsRate;  // 体育频率
		
		private double _sportsTime;  // 体育分钟
		
		private double _sportsCountYers;  // 体育年
		
		private string _sportsType;  // 体育方式
		
		private double _dietType;  // 饮食习惯
		
		private double _smokeStatus;  // 吸烟状况
		
		private double _smokeCount;  // 吸烟日支
		
		private double _smokeAge;  // 吸烟年龄
		
		private double _noSmokeAge;  // 戒烟年龄
		
		private double _alcoholRate;  // 饮酒频率
		
		private double _alcoholCount;  // 饮酒日两
		
		private bool _isNoAlcohol;  // 是否戒酒
		
		private double _noAlcoholAge;  // 戒酒年龄
		
		private double _startNoAlcoholAge;  // 开始戒酒年龄
		
		private bool _isLatelyDrunk;  // 是否近一年醉酒
		
		private string _alcoholType;  // 酒种类
		
		private bool _isOccupationalHarm;  // 是否存在职业病危害
		
		private double _workDate;  // 工作时间年
		
		private double _dustAnswer;  // 粉尘防护措施
		
		private double _radiationAnswer;  // 辐射防护措施
		
		private double _physicsAnswer;  // 物理因素防护措施
		
		private double _tasteMatterAnswer;  // 何尝物质防护措施
		
		private double _otherAnswer;  // 其他防护措施
		
		private string _symptomNames;  // 症状名称
		
		private int _HospitalID;  //
		 
 
		/// <summary>
		/// 
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperLastDate
		{
			get { return _operLastDate;}
			set { _operLastDate = value;}
		}                                    
		
		/// <summary>
		///  症状
		/// </summary>
		public string SymptomIds
		{
			get { return _symptomIds;}
			set { _symptomIds = value;}
		}                                    
		
		/// <summary>
		///  体温
		/// </summary>
		public double Temperature
		{
			get { return _temperature;}
			set { _temperature = value;}
		}                                    
		
		/// <summary>
		///  脉率
		/// </summary>
		public double PulseRate
		{
			get { return _pulseRate;}
			set { _pulseRate = value;}
		}                                    
		
		/// <summary>
		///  呼吸频率
		/// </summary>
		public double RespiratoryRate
		{
			get { return _respiratoryRate;}
			set { _respiratoryRate = value;}
		}                                    
		
		/// <summary>
		///  腰围
		/// </summary>
		public double Waist
		{
			get { return _waist;}
			set { _waist = value;}
		}                                    
		
		/// <summary>
		///  血压左侧
		/// </summary>
		public double BloodPressureLeft
		{
			get { return _bloodPressureLeft;}
			set { _bloodPressureLeft = value;}
		}                                    
		
		/// <summary>
		///  血压右侧
		/// </summary>
		public double BloodPressureReght
		{
			get { return _bloodPressureReght;}
			set { _bloodPressureReght = value;}
		}                                    
		
		/// <summary>
		///  血压左侧
		/// </summary>
		public double BloodPressureLeft2
		{
			get { return _bloodPressureLeft2;}
			set { _bloodPressureLeft2 = value;}
		}                                    
		
		/// <summary>
		///  血压右侧
		/// </summary>
		public double BloodPressureReght2
		{
			get { return _bloodPressureReght2;}
			set { _bloodPressureReght2 = value;}
		}                                    
		
		/// <summary>
		///  体重
		/// </summary>
		public double Weight
		{
			get { return _weight;}
			set { _weight = value;}
		}                                    
		
		/// <summary>
		///  身高
		/// </summary>
		public double Height
		{
			get { return _height;}
			set { _height = value;}
		}                                    
		
		/// <summary>
		///  体重指数
		/// </summary>
		public double Bmi
		{
			get { return _bmi;}
			set { _bmi = value;}
		}                                    
		
		/// <summary>
		///  状态评估
		/// </summary>
		public double StatusAssessment
		{
			get { return _statusAssessment;}
			set { _statusAssessment = value;}
		}                                    
		
		/// <summary>
		///  自理能力
		/// </summary>
		public double SelfCare
		{
			get { return _selfCare;}
			set { _selfCare = value;}
		}                                    
		
		/// <summary>
		///  认知功能
		/// </summary>
		public string Cognition
		{
			get { return _cognition;}
			set { _cognition = value;}
		}                                    
		
		/// <summary>
		///  分数
		/// </summary>
		public double CognitionScore
		{
			get { return _cognitionScore;}
			set { _cognitionScore = value;}
		}                                    
		
		/// <summary>
		///  感情
		/// </summary>
		public string Emotion
		{
			get { return _emotion;}
			set { _emotion = value;}
		}                                    
		
		/// <summary>
		///  分数
		/// </summary>
		public double EmotionScore
		{
			get { return _emotionScore;}
			set { _emotionScore = value;}
		}                                    
		
		/// <summary>
		///  体育频率
		/// </summary>
		public double SportsRate
		{
			get { return _sportsRate;}
			set { _sportsRate = value;}
		}                                    
		
		/// <summary>
		///  体育分钟
		/// </summary>
		public double SportsTime
		{
			get { return _sportsTime;}
			set { _sportsTime = value;}
		}                                    
		
		/// <summary>
		///  体育年
		/// </summary>
		public double SportsCountYers
		{
			get { return _sportsCountYers;}
			set { _sportsCountYers = value;}
		}                                    
		
		/// <summary>
		///  体育方式
		/// </summary>
		public string SportsType
		{
			get { return _sportsType;}
			set { _sportsType = value;}
		}                                    
		
		/// <summary>
		///  饮食习惯
		/// </summary>
		public double DietType
		{
			get { return _dietType;}
			set { _dietType = value;}
		}                                    
		
		/// <summary>
		///  吸烟状况
		/// </summary>
		public double SmokeStatus
		{
			get { return _smokeStatus;}
			set { _smokeStatus = value;}
		}                                    
		
		/// <summary>
		///  吸烟日支
		/// </summary>
		public double SmokeCount
		{
			get { return _smokeCount;}
			set { _smokeCount = value;}
		}                                    
		
		/// <summary>
		///  吸烟年龄
		/// </summary>
		public double SmokeAge
		{
			get { return _smokeAge;}
			set { _smokeAge = value;}
		}                                    
		
		/// <summary>
		///  戒烟年龄
		/// </summary>
		public double NoSmokeAge
		{
			get { return _noSmokeAge;}
			set { _noSmokeAge = value;}
		}                                    
		
		/// <summary>
		///  饮酒频率
		/// </summary>
		public double AlcoholRate
		{
			get { return _alcoholRate;}
			set { _alcoholRate = value;}
		}                                    
		
		/// <summary>
		///  饮酒日两
		/// </summary>
		public double AlcoholCount
		{
			get { return _alcoholCount;}
			set { _alcoholCount = value;}
		}                                    
		
		/// <summary>
		///  是否戒酒
		/// </summary>
		public bool IsNoAlcohol
		{
			get { return _isNoAlcohol;}
			set { _isNoAlcohol = value;}
		}                                    
		
		/// <summary>
		///  戒酒年龄
		/// </summary>
		public double NoAlcoholAge
		{
			get { return _noAlcoholAge;}
			set { _noAlcoholAge = value;}
		}                                    
		
		/// <summary>
		///  开始戒酒年龄
		/// </summary>
		public double StartNoAlcoholAge
		{
			get { return _startNoAlcoholAge;}
			set { _startNoAlcoholAge = value;}
		}                                    
		
		/// <summary>
		///  是否近一年醉酒
		/// </summary>
		public bool IsLatelyDrunk
		{
			get { return _isLatelyDrunk;}
			set { _isLatelyDrunk = value;}
		}                                    
		
		/// <summary>
		///  酒种类
		/// </summary>
		public string AlcoholType
		{
			get { return _alcoholType;}
			set { _alcoholType = value;}
		}                                    
		
		/// <summary>
		///  是否存在职业病危害
		/// </summary>
		public bool IsOccupationalHarm
		{
			get { return _isOccupationalHarm;}
			set { _isOccupationalHarm = value;}
		}                                    
		
		/// <summary>
		///  工作时间年
		/// </summary>
		public double WorkDate
		{
			get { return _workDate;}
			set { _workDate = value;}
		}                                    
		
		/// <summary>
		///  粉尘防护措施
		/// </summary>
		public double DustAnswer
		{
			get { return _dustAnswer;}
			set { _dustAnswer = value;}
		}                                    
		
		/// <summary>
		///  辐射防护措施
		/// </summary>
		public double RadiationAnswer
		{
			get { return _radiationAnswer;}
			set { _radiationAnswer = value;}
		}                                    
		
		/// <summary>
		///  物理因素防护措施
		/// </summary>
		public double PhysicsAnswer
		{
			get { return _physicsAnswer;}
			set { _physicsAnswer = value;}
		}                                    
		
		/// <summary>
		///  何尝物质防护措施
		/// </summary>
		public double TasteMatterAnswer
		{
			get { return _tasteMatterAnswer;}
			set { _tasteMatterAnswer = value;}
		}                                    
		
		/// <summary>
		///  其他防护措施
		/// </summary>
		public double OtherAnswer
		{
			get { return _otherAnswer;}
			set { _otherAnswer = value;}
		}                                    
		
		/// <summary>
		///  症状名称
		/// </summary>
		public string SymptomNames
		{
			get { return _symptomNames;}
			set { _symptomNames = value;}
		}                                    
		                                
		        
	}  
}           


