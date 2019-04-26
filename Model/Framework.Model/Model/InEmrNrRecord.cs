

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InEmrNrRecord : BaseModel
	{   
		 
		private string _type;  //记录单类别
		
		private string _mzRegId;  //门诊流水号
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _locationId;  //科室ID
		
		private double _examT;  //体温
		
		private double _examP;  //P/HR
		
		private double _examR;  //R
		
		private double _examBp;  //BP
		
		private double _examBp2;  //
		
		private double _hight;  //体重
		
		private string _mentality;  //意识
		
		private string _inItem1;  //静脉用药项目
		
		private double _inVolumn1;  //静脉用药量
		
		private string _inItem2;  //饮食项目
		
		private double _inVolumn2;  //饮食量
		
		private double _inVolumnAll;  //入量总量
		
		private string _outItem1;  //大便
		
		private double _outVolumn1;  //量ml
		
		private string _outItem2;  //小便
		
		private double _outVolumn2;  //
		
		private double _outVolumnAll;  //入量总量
		
		private bool _urineFree;  //尿液顺畅
		
		private string _urineProper;  //尿液性状
		
		private string _urineColor;  //颜色
		
		private double _outOther;  //其它ml
		
		private string _specialMemo;  //特殊情况记录
		
		private string _breast;  //乳房情况
		
		private string _milk;  //泌乳情况
		
		private string _uterusHigh;  //
		
		private string _uterusShrink;  //子宫收缩
		
		private string _wound;  //伤口
		
		private string _hand;  //手
		
		private string _foot;  //足
		
		private string _buttocks;  //臀
		
		private string _mouth;  //口腔
		
		private string _face;  //面色
		
		private string _breath;  //呼吸系统
		
		private string _blood;  //循环系统
		
		private string _boxTemp;  //箱温
		
		private string _pupilL;  //瞳孔左
		
		private string _pupilR;  //瞳孔右
		
		private string _pupilBright;  //对光反射
		
		private string _oxygenBr;  //呼吸模式
		
		private string _oxygenF;  //f
		
		private string _oxygenFiO2;  //FiO2%
		
		private string _oxygenPipeDeep;  //插管深度cm
		
		private string _oxygenCpap;  //CPAP％
		
		private string _oxygenPipeNose;  //鼻导管L/min
		
		private string _oxygenVein;  //静脉导管
		
		private string _liePose;  //卧位
		
		private string _skin;  //受压皮肤
		
		private string _others;  //其他
		
		private string _disposal;  //护理措施
		
		private int _operId;  //执行人
		
		private DateTime _operTime;  //操作时间
		
		private string _pupilLReflex;  //左瞳孔反射
		
		private string _pupilRReflex;  //左瞳孔反射
		
		private string _resultMMO;  //血糖检测结果
		
		private string _channelName;  //通道管理名称
		
		private string _channelSituation;  //通道管理名称情况
		
		private string _condition;  //病情
		
		private string _puncture;  //穿刺部位
		
		private string _joint;  //正压接头
		
		private string _dropIn;  //液体滴入顺利
		
		private string _vein;  //静脉炎
		
		private string _drugExudation;  //药物渗出
		
		private string _tumorExudation;  //红肿渗出
		
		private string _plaster;  //敷贴
		
		private string _hDilution;  //稀释肝素
		
		private string _pSaline;  //生理盐水
		
		private string _operName;  //操作人名称
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InEmrNrRecord() { }
                                        
		
		/// <summary>
		/// 记录单类别
		/// </summary>
		public string Type
		{
			get { return _type;}
			set { _type = value;}
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
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 科室ID
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
		/// P/HR
		/// </summary>
		public double ExamP
		{
			get { return _examP;}
			set { _examP = value;}
		}                                    
		
		/// <summary>
		/// R
		/// </summary>
		public double ExamR
		{
			get { return _examR;}
			set { _examR = value;}
		}                                    
		
		/// <summary>
		/// BP
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
		/// 体重
		/// </summary>
		public double Hight
		{
			get { return _hight;}
			set { _hight = value;}
		}                                    
		
		/// <summary>
		/// 意识
		/// </summary>
		public string Mentality
		{
			get { return _mentality;}
			set { _mentality = value;}
		}                                    
		
		/// <summary>
		/// 静脉用药项目
		/// </summary>
		public string InItem1
		{
			get { return _inItem1;}
			set { _inItem1 = value;}
		}                                    
		
		/// <summary>
		/// 静脉用药量
		/// </summary>
		public double InVolumn1
		{
			get { return _inVolumn1;}
			set { _inVolumn1 = value;}
		}                                    
		
		/// <summary>
		/// 饮食项目
		/// </summary>
		public string InItem2
		{
			get { return _inItem2;}
			set { _inItem2 = value;}
		}                                    
		
		/// <summary>
		/// 饮食量
		/// </summary>
		public double InVolumn2
		{
			get { return _inVolumn2;}
			set { _inVolumn2 = value;}
		}                                    
		
		/// <summary>
		/// 入量总量
		/// </summary>
		public double InVolumnAll
		{
			get { return _inVolumnAll;}
			set { _inVolumnAll = value;}
		}                                    
		
		/// <summary>
		/// 大便
		/// </summary>
		public string OutItem1
		{
			get { return _outItem1;}
			set { _outItem1 = value;}
		}                                    
		
		/// <summary>
		/// 量ml
		/// </summary>
		public double OutVolumn1
		{
			get { return _outVolumn1;}
			set { _outVolumn1 = value;}
		}                                    
		
		/// <summary>
		/// 小便
		/// </summary>
		public string OutItem2
		{
			get { return _outItem2;}
			set { _outItem2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double OutVolumn2
		{
			get { return _outVolumn2;}
			set { _outVolumn2 = value;}
		}                                    
		
		/// <summary>
		/// 入量总量
		/// </summary>
		public double OutVolumnAll
		{
			get { return _outVolumnAll;}
			set { _outVolumnAll = value;}
		}                                    
		
		/// <summary>
		/// 尿液顺畅
		/// </summary>
		public bool UrineFree
		{
			get { return _urineFree;}
			set { _urineFree = value;}
		}                                    
		
		/// <summary>
		/// 尿液性状
		/// </summary>
		public string UrineProper
		{
			get { return _urineProper;}
			set { _urineProper = value;}
		}                                    
		
		/// <summary>
		/// 颜色
		/// </summary>
		public string UrineColor
		{
			get { return _urineColor;}
			set { _urineColor = value;}
		}                                    
		
		/// <summary>
		/// 其它ml
		/// </summary>
		public double OutOther
		{
			get { return _outOther;}
			set { _outOther = value;}
		}                                    
		
		/// <summary>
		/// 特殊情况记录
		/// </summary>
		public string SpecialMemo
		{
			get { return _specialMemo;}
			set { _specialMemo = value;}
		}                                    
		
		/// <summary>
		/// 乳房情况
		/// </summary>
		public string Breast
		{
			get { return _breast;}
			set { _breast = value;}
		}                                    
		
		/// <summary>
		/// 泌乳情况
		/// </summary>
		public string Milk
		{
			get { return _milk;}
			set { _milk = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string UterusHigh
		{
			get { return _uterusHigh;}
			set { _uterusHigh = value;}
		}                                    
		
		/// <summary>
		/// 子宫收缩
		/// </summary>
		public string UterusShrink
		{
			get { return _uterusShrink;}
			set { _uterusShrink = value;}
		}                                    
		
		/// <summary>
		/// 伤口
		/// </summary>
		public string Wound
		{
			get { return _wound;}
			set { _wound = value;}
		}                                    
		
		/// <summary>
		/// 手
		/// </summary>
		public string Hand
		{
			get { return _hand;}
			set { _hand = value;}
		}                                    
		
		/// <summary>
		/// 足
		/// </summary>
		public string Foot
		{
			get { return _foot;}
			set { _foot = value;}
		}                                    
		
		/// <summary>
		/// 臀
		/// </summary>
		public string Buttocks
		{
			get { return _buttocks;}
			set { _buttocks = value;}
		}                                    
		
		/// <summary>
		/// 口腔
		/// </summary>
		public string Mouth
		{
			get { return _mouth;}
			set { _mouth = value;}
		}                                    
		
		/// <summary>
		/// 面色
		/// </summary>
		public string Face
		{
			get { return _face;}
			set { _face = value;}
		}                                    
		
		/// <summary>
		/// 呼吸系统
		/// </summary>
		public string Breath
		{
			get { return _breath;}
			set { _breath = value;}
		}                                    
		
		/// <summary>
		/// 循环系统
		/// </summary>
		public string Blood
		{
			get { return _blood;}
			set { _blood = value;}
		}                                    
		
		/// <summary>
		/// 箱温
		/// </summary>
		public string BoxTemp
		{
			get { return _boxTemp;}
			set { _boxTemp = value;}
		}                                    
		
		/// <summary>
		/// 瞳孔左
		/// </summary>
		public string PupilL
		{
			get { return _pupilL;}
			set { _pupilL = value;}
		}                                    
		
		/// <summary>
		/// 瞳孔右
		/// </summary>
		public string PupilR
		{
			get { return _pupilR;}
			set { _pupilR = value;}
		}                                    
		
		/// <summary>
		/// 对光反射
		/// </summary>
		public string PupilBright
		{
			get { return _pupilBright;}
			set { _pupilBright = value;}
		}                                    
		
		/// <summary>
		/// 呼吸模式
		/// </summary>
		public string OxygenBr
		{
			get { return _oxygenBr;}
			set { _oxygenBr = value;}
		}                                    
		
		/// <summary>
		/// f
		/// </summary>
		public string OxygenF
		{
			get { return _oxygenF;}
			set { _oxygenF = value;}
		}                                    
		
		/// <summary>
		/// FiO2%
		/// </summary>
		public string OxygenFiO2
		{
			get { return _oxygenFiO2;}
			set { _oxygenFiO2 = value;}
		}                                    
		
		/// <summary>
		/// 插管深度cm
		/// </summary>
		public string OxygenPipeDeep
		{
			get { return _oxygenPipeDeep;}
			set { _oxygenPipeDeep = value;}
		}                                    
		
		/// <summary>
		/// CPAP％
		/// </summary>
		public string OxygenCpap
		{
			get { return _oxygenCpap;}
			set { _oxygenCpap = value;}
		}                                    
		
		/// <summary>
		/// 鼻导管L/min
		/// </summary>
		public string OxygenPipeNose
		{
			get { return _oxygenPipeNose;}
			set { _oxygenPipeNose = value;}
		}                                    
		
		/// <summary>
		/// 静脉导管
		/// </summary>
		public string OxygenVein
		{
			get { return _oxygenVein;}
			set { _oxygenVein = value;}
		}                                    
		
		/// <summary>
		/// 卧位
		/// </summary>
		public string LiePose
		{
			get { return _liePose;}
			set { _liePose = value;}
		}                                    
		
		/// <summary>
		/// 受压皮肤
		/// </summary>
		public string Skin
		{
			get { return _skin;}
			set { _skin = value;}
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
		/// 护理措施
		/// </summary>
		public string Disposal
		{
			get { return _disposal;}
			set { _disposal = value;}
		}                                    
		
		/// <summary>
		/// 执行人
		/// </summary>
		public int OperId
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
		/// 左瞳孔反射
		/// </summary>
		public string PupilLReflex
		{
			get { return _pupilLReflex;}
			set { _pupilLReflex = value;}
		}                                    
		
		/// <summary>
		/// 左瞳孔反射
		/// </summary>
		public string PupilRReflex
		{
			get { return _pupilRReflex;}
			set { _pupilRReflex = value;}
		}                                    
		
		/// <summary>
		/// 血糖检测结果
		/// </summary>
		public string ResultMMO
		{
			get { return _resultMMO;}
			set { _resultMMO = value;}
		}                                    
		
		/// <summary>
		/// 通道管理名称
		/// </summary>
		public string ChannelName
		{
			get { return _channelName;}
			set { _channelName = value;}
		}                                    
		
		/// <summary>
		/// 通道管理名称情况
		/// </summary>
		public string ChannelSituation
		{
			get { return _channelSituation;}
			set { _channelSituation = value;}
		}                                    
		
		/// <summary>
		/// 病情
		/// </summary>
		public string Condition
		{
			get { return _condition;}
			set { _condition = value;}
		}                                    
		
		/// <summary>
		/// 穿刺部位
		/// </summary>
		public string Puncture
		{
			get { return _puncture;}
			set { _puncture = value;}
		}                                    
		
		/// <summary>
		/// 正压接头
		/// </summary>
		public string Joint
		{
			get { return _joint;}
			set { _joint = value;}
		}                                    
		
		/// <summary>
		/// 液体滴入顺利
		/// </summary>
		public string DropIn
		{
			get { return _dropIn;}
			set { _dropIn = value;}
		}                                    
		
		/// <summary>
		/// 静脉炎
		/// </summary>
		public string Vein
		{
			get { return _vein;}
			set { _vein = value;}
		}                                    
		
		/// <summary>
		/// 药物渗出
		/// </summary>
		public string DrugExudation
		{
			get { return _drugExudation;}
			set { _drugExudation = value;}
		}                                    
		
		/// <summary>
		/// 红肿渗出
		/// </summary>
		public string TumorExudation
		{
			get { return _tumorExudation;}
			set { _tumorExudation = value;}
		}                                    
		
		/// <summary>
		/// 敷贴
		/// </summary>
		public string Plaster
		{
			get { return _plaster;}
			set { _plaster = value;}
		}                                    
		
		/// <summary>
		/// 稀释肝素
		/// </summary>
		public string HDilution
		{
			get { return _hDilution;}
			set { _hDilution = value;}
		}                                    
		
		/// <summary>
		/// 生理盐水
		/// </summary>
		public string PSaline
		{
			get { return _pSaline;}
			set { _pSaline = value;}
		}                                    
		
		/// <summary>
		/// 操作人名称
		/// </summary>
		public string OperName
		{
			get { return _operName;}
			set { _operName = value;}
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
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


