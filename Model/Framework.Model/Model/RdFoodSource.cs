

using System;
namespace Orm.Model
{
	/// <summary>
	/// 食源性疾病病例监测信息表 - 实体类
	/// </summary>
	[Serializable]
	public partial class RdFoodSource : BaseModel
	{   
		
		private string _patId;  //
		
		private DateTime _operTime;  //填卡日期
		
		private string _operId;  //填卡人
		
		private string _code;  //
		
		private string _hospId;  //住院ID
		
		private string _mzRegId;  //门诊流水号ID
		
		private string _chkOperId;  //审核人
		
		private DateTime _chkOperTime;  //审核日期
		
		private bool _isWrite;  //书写情况：1-未书写；2-已完成；3-已审核；4-退卡；5-删除
		
		private int _printStart;  //是否打印
		
		private string _mobile;  //联系电话
		
		private DateTime _illDate;  //
		
		private DateTime _diagDate;  //
		
		private DateTime _deadDate;  //
		
		private int _workType;  //患者职业
		
		private int _lsZone;  //病人属于
		
		private string _heart;  //全身体征
		
		private string _digeStive;  //消化系统
		
		private string _breath;  //呼吸系统
		
		private string _blood;  //心脑血管
		
		private string _urinary;  //泌尿系统
		
		private string _nervous;  //神经系统
		
		private string _skin;  //皮肤和皮下组织
		
		private double _heartfr;  //发热度数
		
		private string _heartQt;  //全身体征其他
		
		private int _digeStiveFx;  //消化系统腹泻次数
		
		private string _digeStiveQt;  //消化系统其他
		
		private string _digeStivePxwqt;  //消化系统排泄物其他
		
		private string _breathQt;  //呼吸系统其他
		
		private string _bloodQt;  //心脑血管其他
		
		private string _urinaryQt;  //泌尿系统其他
		
		private string _nervousQt;  //神经系统其他
		
		private string _skinQt;  //皮肤和皮下组织其他
		
		private int _firstDiag;  //初步诊断
		
		private string _firstDiagOther;  //初步诊断其他
		
		private int _useMedIndex;  //1-住院2-使用抗生素3-住院，使用抗生素
		
		private string _kssName;  //抗生素名字
		
		private int _onceDiag;  //既往病史
		
		private string _onceDiagOther;  //既往病史其他
		
		private int _eatCollectIndex;  //1-怀疑进食2-采集标本3-怀疑进食，采集标本
		
		private string _foodName;  //食品名称
		
		private int _foodTYPE;  //食品分类
		
		private int _foodMachingType;  //加工或包装方式
		
		private string _foodBrand;  //食品品牌
		
		private string _foodCompany;  //生产厂家
		
		private string _eatPlace;  //进食场所
		
		private int _foodEatPlaceType;  //进食场所类型
		
		private string _shopPlace;  //购买地点
		
		private int _shopPlaceType;  //购买地点类型
		
		private DateTime _eatTime;  //进食时间
		
		private int _eatNumberOfPeople;  //进食人数
		
		private bool _isIllOthers;  //其他人是否发病1-是2-否
		
		private string _sampleCode;  //标本编号
		
		private int _sampleType;  //标本类型
		
		private string _sampleNumUnit;  //标本数量级单位
		
		private DateTime _sampleTime;  //采样日期
		
		private string _sampleMemo;  //备注
		
		private string _hospitalName;  //医疗机构名称
		
		private int _preparer;  //填表人
		
		private DateTime _writeTime;  //填表时间
		
		private string _jName;  //监护人姓名
		
		private string _cancelOperId;  //退卡人
		
		private DateTime _cancelOperTime;  //退卡时间
		
		private string _cancelMemo;  //退卡原因
		
		private string _illNameId;  //该报告卡名称ID，为3
		
		private bool _isAuthed;  //已经封存，不可改删
		
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
		/// 填卡日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 填卡人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 住院ID
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 门诊流水号ID
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string ChkOperId
		{
			get { return _chkOperId;}
			set { _chkOperId = value;}
		}                                    
		
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime ChkOperTime
		{
			get { return _chkOperTime;}
			set { _chkOperTime = value;}
		}                                    
		
		/// <summary>
		/// 书写情况：1-未书写；2-已完成；3-已审核；4-退卡；5-删除
		/// </summary>
		public bool IsWrite
		{
			get { return _isWrite;}
			set { _isWrite = value;}
		}                                    
		
		/// <summary>
		/// 是否打印
		/// </summary>
		public int PrintStart
		{
			get { return _printStart;}
			set { _printStart = value;}
		}                                    
		
		/// <summary>
		/// 联系电话
		/// </summary>
		public string Mobile
		{
			get { return _mobile;}
			set { _mobile = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime IllDate
		{
			get { return _illDate;}
			set { _illDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime DiagDate
		{
			get { return _diagDate;}
			set { _diagDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime DeadDate
		{
			get { return _deadDate;}
			set { _deadDate = value;}
		}                                    
		
		/// <summary>
		/// 患者职业
		/// </summary>
		public int WorkType
		{
			get { return _workType;}
			set { _workType = value;}
		}                                    
		
		/// <summary>
		/// 病人属于
		/// </summary>
		public int LsZone
		{
			get { return _lsZone;}
			set { _lsZone = value;}
		}                                    
		
		/// <summary>
		/// 全身体征
		/// </summary>
		public string Heart
		{
			get { return _heart;}
			set { _heart = value;}
		}                                    
		
		/// <summary>
		/// 消化系统
		/// </summary>
		public string DigeStive
		{
			get { return _digeStive;}
			set { _digeStive = value;}
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
		/// 心脑血管
		/// </summary>
		public string Blood
		{
			get { return _blood;}
			set { _blood = value;}
		}                                    
		
		/// <summary>
		/// 泌尿系统
		/// </summary>
		public string Urinary
		{
			get { return _urinary;}
			set { _urinary = value;}
		}                                    
		
		/// <summary>
		/// 神经系统
		/// </summary>
		public string Nervous
		{
			get { return _nervous;}
			set { _nervous = value;}
		}                                    
		
		/// <summary>
		/// 皮肤和皮下组织
		/// </summary>
		public string Skin
		{
			get { return _skin;}
			set { _skin = value;}
		}                                    
		
		/// <summary>
		/// 发热度数
		/// </summary>
		public double Heartfr
		{
			get { return _heartfr;}
			set { _heartfr = value;}
		}                                    
		
		/// <summary>
		/// 全身体征其他
		/// </summary>
		public string HeartQt
		{
			get { return _heartQt;}
			set { _heartQt = value;}
		}                                    
		
		/// <summary>
		/// 消化系统腹泻次数
		/// </summary>
		public int DigeStiveFx
		{
			get { return _digeStiveFx;}
			set { _digeStiveFx = value;}
		}                                    
		
		/// <summary>
		/// 消化系统其他
		/// </summary>
		public string DigeStiveQt
		{
			get { return _digeStiveQt;}
			set { _digeStiveQt = value;}
		}                                    
		
		/// <summary>
		/// 消化系统排泄物其他
		/// </summary>
		public string DigeStivePxwqt
		{
			get { return _digeStivePxwqt;}
			set { _digeStivePxwqt = value;}
		}                                    
		
		/// <summary>
		/// 呼吸系统其他
		/// </summary>
		public string BreathQt
		{
			get { return _breathQt;}
			set { _breathQt = value;}
		}                                    
		
		/// <summary>
		/// 心脑血管其他
		/// </summary>
		public string BloodQt
		{
			get { return _bloodQt;}
			set { _bloodQt = value;}
		}                                    
		
		/// <summary>
		/// 泌尿系统其他
		/// </summary>
		public string UrinaryQt
		{
			get { return _urinaryQt;}
			set { _urinaryQt = value;}
		}                                    
		
		/// <summary>
		/// 神经系统其他
		/// </summary>
		public string NervousQt
		{
			get { return _nervousQt;}
			set { _nervousQt = value;}
		}                                    
		
		/// <summary>
		/// 皮肤和皮下组织其他
		/// </summary>
		public string SkinQt
		{
			get { return _skinQt;}
			set { _skinQt = value;}
		}                                    
		
		/// <summary>
		/// 初步诊断
		/// </summary>
		public int FirstDiag
		{
			get { return _firstDiag;}
			set { _firstDiag = value;}
		}                                    
		
		/// <summary>
		/// 初步诊断其他
		/// </summary>
		public string FirstDiagOther
		{
			get { return _firstDiagOther;}
			set { _firstDiagOther = value;}
		}                                    
		
		/// <summary>
		/// 1-住院2-使用抗生素3-住院，使用抗生素
		/// </summary>
		public int UseMedIndex
		{
			get { return _useMedIndex;}
			set { _useMedIndex = value;}
		}                                    
		
		/// <summary>
		/// 抗生素名字
		/// </summary>
		public string KssName
		{
			get { return _kssName;}
			set { _kssName = value;}
		}                                    
		
		/// <summary>
		/// 既往病史
		/// </summary>
		public int OnceDiag
		{
			get { return _onceDiag;}
			set { _onceDiag = value;}
		}                                    
		
		/// <summary>
		/// 既往病史其他
		/// </summary>
		public string OnceDiagOther
		{
			get { return _onceDiagOther;}
			set { _onceDiagOther = value;}
		}                                    
		
		/// <summary>
		/// 1-怀疑进食2-采集标本3-怀疑进食，采集标本
		/// </summary>
		public int EatCollectIndex
		{
			get { return _eatCollectIndex;}
			set { _eatCollectIndex = value;}
		}                                    
		
		/// <summary>
		/// 食品名称
		/// </summary>
		public string FoodName
		{
			get { return _foodName;}
			set { _foodName = value;}
		}                                    
		
		/// <summary>
		/// 食品分类
		/// </summary>
		public int FoodTYPE
		{
			get { return _foodTYPE;}
			set { _foodTYPE = value;}
		}                                    
		
		/// <summary>
		/// 加工或包装方式
		/// </summary>
		public int FoodMachingType
		{
			get { return _foodMachingType;}
			set { _foodMachingType = value;}
		}                                    
		
		/// <summary>
		/// 食品品牌
		/// </summary>
		public string FoodBrand
		{
			get { return _foodBrand;}
			set { _foodBrand = value;}
		}                                    
		
		/// <summary>
		/// 生产厂家
		/// </summary>
		public string FoodCompany
		{
			get { return _foodCompany;}
			set { _foodCompany = value;}
		}                                    
		
		/// <summary>
		/// 进食场所
		/// </summary>
		public string EatPlace
		{
			get { return _eatPlace;}
			set { _eatPlace = value;}
		}                                    
		
		/// <summary>
		/// 进食场所类型
		/// </summary>
		public int FoodEatPlaceType
		{
			get { return _foodEatPlaceType;}
			set { _foodEatPlaceType = value;}
		}                                    
		
		/// <summary>
		/// 购买地点
		/// </summary>
		public string ShopPlace
		{
			get { return _shopPlace;}
			set { _shopPlace = value;}
		}                                    
		
		/// <summary>
		/// 购买地点类型
		/// </summary>
		public int ShopPlaceType
		{
			get { return _shopPlaceType;}
			set { _shopPlaceType = value;}
		}                                    
		
		/// <summary>
		/// 进食时间
		/// </summary>
		public DateTime EatTime
		{
			get { return _eatTime;}
			set { _eatTime = value;}
		}                                    
		
		/// <summary>
		/// 进食人数
		/// </summary>
		public int EatNumberOfPeople
		{
			get { return _eatNumberOfPeople;}
			set { _eatNumberOfPeople = value;}
		}                                    
		
		/// <summary>
		/// 其他人是否发病1-是2-否
		/// </summary>
		public bool IsIllOthers
		{
			get { return _isIllOthers;}
			set { _isIllOthers = value;}
		}                                    
		
		/// <summary>
		/// 标本编号
		/// </summary>
		public string SampleCode
		{
			get { return _sampleCode;}
			set { _sampleCode = value;}
		}                                    
		
		/// <summary>
		/// 标本类型
		/// </summary>
		public int SampleType
		{
			get { return _sampleType;}
			set { _sampleType = value;}
		}                                    
		
		/// <summary>
		/// 标本数量级单位
		/// </summary>
		public string SampleNumUnit
		{
			get { return _sampleNumUnit;}
			set { _sampleNumUnit = value;}
		}                                    
		
		/// <summary>
		/// 采样日期
		/// </summary>
		public DateTime SampleTime
		{
			get { return _sampleTime;}
			set { _sampleTime = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string SampleMemo
		{
			get { return _sampleMemo;}
			set { _sampleMemo = value;}
		}                                    
		
		/// <summary>
		/// 医疗机构名称
		/// </summary>
		public string HospitalName
		{
			get { return _hospitalName;}
			set { _hospitalName = value;}
		}                                    
		
		/// <summary>
		/// 填表人
		/// </summary>
		public int Preparer
		{
			get { return _preparer;}
			set { _preparer = value;}
		}                                    
		
		/// <summary>
		/// 填表时间
		/// </summary>
		public DateTime WriteTime
		{
			get { return _writeTime;}
			set { _writeTime = value;}
		}                                    
		
		/// <summary>
		/// 监护人姓名
		/// </summary>
		public string JName
		{
			get { return _jName;}
			set { _jName = value;}
		}                                    
		
		/// <summary>
		/// 退卡人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 退卡时间
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 退卡原因
		/// </summary>
		public string CancelMemo
		{
			get { return _cancelMemo;}
			set { _cancelMemo = value;}
		}                                    
		
		/// <summary>
		/// 该报告卡名称ID，为3
		/// </summary>
		public string IllNameId
		{
			get { return _illNameId;}
			set { _illNameId = value;}
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


