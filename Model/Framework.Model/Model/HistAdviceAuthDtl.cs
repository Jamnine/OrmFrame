

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史医嘱查对表 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistAdviceAuthDtl:BaseModel
	{   
		
		private DateTime _inSertTime;  //插入时间
		 
		private int _lsMarkType;  //医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		
		private DateTime _adviceTime;  //医嘱时间
		
		private string _adviceId;  //医嘱ID
		
		private string _doctorId;  //开嘱医生，BsDoctor.Id
		
		private string _locationId;  //开嘱科室BsLocation.Id
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private int _groupNum;  //组号
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _formId;  //剂型对应BsFormDrug.id
		
		private double _priceIn;  //住院项目单价
		
		private string _unitTakeId;  //使用单位
		
		private string _frequencyId;  //频率对应BsFrequency.Id
		
		private string _usageId;  //用法对应BsUsage.Id
		
		private double _totality;  //数量
		
		private double _toTalityAll;  //总量
		
		private double _amount;  //金额
		
		private string _unitInId;  //药房单位
		
		private bool _isAttach;  //是否执行
		
		private bool _isSelf;  //是否自费
		
		private int _lsSpecialUsage;  //特殊用法标志：1-静滴；2-接滴
		
		private int _lsExecLoc;  //执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
		
		private DateTime _skinTime;  //皮试时间
		
		private bool _isSkin;  //是否需要皮试？
		
		private string _skinTest;  //皮试结果
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private bool _isPrinted;  //是否已打印？。
		
		private bool _isChk;  //是否已审核确认？
		
		private DateTime _chkOperTime;  //审核时间
		
		private string _chkOperID;  //审核人
		
		private bool _isEnd;  //是否已停止？
		
		private DateTime _endOperTime;  //停止时间
		
		private string _endOperID;  //停止人
		
		private string _endDoctorID;  //停止医生
		
		private bool _isAuth;  //是否查对。
		
		private DateTime _authOperTime;  //查对时间
		
		private string _authOperId;  //查对护士
		
		private string _memo;  //备注
		
		private bool _isOtherFee;  //是否附加项目
		
		private bool _isBeforeops;  //是否术前医嘱
		
		private int _lsRpType;  //处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-其他；10-物资
		
		private bool _isInject;  //是否注射剂
		
		private int _firstDay;  //首日次数
		
		private int _lastDay;  //末日次数
		
		private string _execLocId;  //执行科室BsLocation.id
		
		private string _oriAdviceId;  //
		
		private int _infeeCheck;  //
		
		private int _adcolor;  //
		
		private bool _isManual;  //是否手工输入
		
		private int _isArrearage;  //0-正常1-欠费2-删除
		
		private bool _isTodayIn;  //是否首日
		
		private string _drugReqId1;  //药房申请id
		
		private string _drugReqId2;  //药房申请id用于处理首日
		
		private string _detailId1;  //费用ID对应Ininvoicedtl.id
		
		private string _detailId2;  //费用ID对应Ininvoicedtl.id用于处理首日
		
		private string _adviceName;  //医嘱名称：来源于医嘱
		
		private string _name;  //名称
		
		private string _code;  //编码
		
		private string _spec;  //规格
		
		private string _executeId;  //执行ID
		
		private string _executeId2;  //执行ID用于处理首日
		
		private double _dosage;  //每次量
		
		private string _execDoctorId;  //执行医生
		
		private bool _isYbxj;  //是否医保限制
		
		private bool _isAutoMatic;  //是否自助收
		
		private string _yBType;  //甲类、乙类、丙类、自费
		
		private bool _isPriority;  //是否优先
		
		private string _tempStr;  //临时分组用(LsMarkType|GroupNum)
		
		private string _colours;  //用于判断显示颜色
		
		private string _usageItemId;  //对应bsUsageItem.id
		
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
		/// 医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 医嘱时间
		/// </summary>
		public DateTime AdviceTime
		{
			get { return _adviceTime;}
			set { _adviceTime = value;}
		}                                    
		
		/// <summary>
		/// 医嘱ID
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 开嘱医生，BsDoctor.Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 开嘱科室BsLocation.Id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
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
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 剂型对应BsFormDrug.id
		/// </summary>
		public string FormId
		{
			get { return _formId;}
			set { _formId = value;}
		}                                    
		
		/// <summary>
		/// 住院项目单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
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
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 总量
		/// </summary>
		public double ToTalityAll
		{
			get { return _toTalityAll;}
			set { _toTalityAll = value;}
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
		/// 药房单位
		/// </summary>
		public string UnitInId
		{
			get { return _unitInId;}
			set { _unitInId = value;}
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
		/// 是否自费
		/// </summary>
		public bool IsSelf
		{
			get { return _isSelf;}
			set { _isSelf = value;}
		}                                    
		
		/// <summary>
		/// 特殊用法标志：1-静滴；2-接滴
		/// </summary>
		public int LsSpecialUsage
		{
			get { return _lsSpecialUsage;}
			set { _lsSpecialUsage = value;}
		}                                    
		
		/// <summary>
		/// 执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
		/// </summary>
		public int LsExecLoc
		{
			get { return _lsExecLoc;}
			set { _lsExecLoc = value;}
		}                                    
		
		/// <summary>
		/// 皮试时间
		/// </summary>
		public DateTime SkinTime
		{
			get { return _skinTime;}
			set { _skinTime = value;}
		}                                    
		
		/// <summary>
		/// 是否需要皮试？
		/// </summary>
		public bool IsSkin
		{
			get { return _isSkin;}
			set { _isSkin = value;}
		}                                    
		
		/// <summary>
		/// 皮试结果
		/// </summary>
		public string SkinTest
		{
			get { return _skinTest;}
			set { _skinTest = value;}
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
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 是否已打印？。
		/// </summary>
		public bool IsPrinted
		{
			get { return _isPrinted;}
			set { _isPrinted = value;}
		}                                    
		
		/// <summary>
		/// 是否已审核确认？
		/// </summary>
		public bool IsChk
		{
			get { return _isChk;}
			set { _isChk = value;}
		}                                    
		
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime ChkOperTime
		{
			get { return _chkOperTime;}
			set { _chkOperTime = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string ChkOperID
		{
			get { return _chkOperID;}
			set { _chkOperID = value;}
		}                                    
		
		/// <summary>
		/// 是否已停止？
		/// </summary>
		public bool IsEnd
		{
			get { return _isEnd;}
			set { _isEnd = value;}
		}                                    
		
		/// <summary>
		/// 停止时间
		/// </summary>
		public DateTime EndOperTime
		{
			get { return _endOperTime;}
			set { _endOperTime = value;}
		}                                    
		
		/// <summary>
		/// 停止人
		/// </summary>
		public string EndOperID
		{
			get { return _endOperID;}
			set { _endOperID = value;}
		}                                    
		
		/// <summary>
		/// 停止医生
		/// </summary>
		public string EndDoctorID
		{
			get { return _endDoctorID;}
			set { _endDoctorID = value;}
		}                                    
		
		/// <summary>
		/// 是否查对。
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 查对时间
		/// </summary>
		public DateTime AuthOperTime
		{
			get { return _authOperTime;}
			set { _authOperTime = value;}
		}                                    
		
		/// <summary>
		/// 查对护士
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
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
		/// 是否附加项目
		/// </summary>
		public bool IsOtherFee
		{
			get { return _isOtherFee;}
			set { _isOtherFee = value;}
		}                                    
		
		/// <summary>
		/// 是否术前医嘱
		/// </summary>
		public bool IsBeforeops
		{
			get { return _isBeforeops;}
			set { _isBeforeops = value;}
		}                                    
		
		/// <summary>
		/// 处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-其他；10-物资
		/// </summary>
		public int LsRpType
		{
			get { return _lsRpType;}
			set { _lsRpType = value;}
		}                                    
		
		/// <summary>
		/// 是否注射剂
		/// </summary>
		public bool IsInject
		{
			get { return _isInject;}
			set { _isInject = value;}
		}                                    
		
		/// <summary>
		/// 首日次数
		/// </summary>
		public int FirstDay
		{
			get { return _firstDay;}
			set { _firstDay = value;}
		}                                    
		
		/// <summary>
		/// 末日次数
		/// </summary>
		public int LastDay
		{
			get { return _lastDay;}
			set { _lastDay = value;}
		}                                    
		
		/// <summary>
		/// 执行科室BsLocation.id
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OriAdviceId
		{
			get { return _oriAdviceId;}
			set { _oriAdviceId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int InfeeCheck
		{
			get { return _infeeCheck;}
			set { _infeeCheck = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Adcolor
		{
			get { return _adcolor;}
			set { _adcolor = value;}
		}                                    
		
		/// <summary>
		/// 是否手工输入
		/// </summary>
		public bool IsManual
		{
			get { return _isManual;}
			set { _isManual = value;}
		}                                    
		
		/// <summary>
		/// 0-正常1-欠费2-删除
		/// </summary>
		public int IsArrearage
		{
			get { return _isArrearage;}
			set { _isArrearage = value;}
		}                                    
		
		/// <summary>
		/// 是否首日
		/// </summary>
		public bool IsTodayIn
		{
			get { return _isTodayIn;}
			set { _isTodayIn = value;}
		}                                    
		
		/// <summary>
		/// 药房申请id
		/// </summary>
		public string DrugReqId1
		{
			get { return _drugReqId1;}
			set { _drugReqId1 = value;}
		}                                    
		
		/// <summary>
		/// 药房申请id用于处理首日
		/// </summary>
		public string DrugReqId2
		{
			get { return _drugReqId2;}
			set { _drugReqId2 = value;}
		}                                    
		
		/// <summary>
		/// 费用ID对应Ininvoicedtl.id
		/// </summary>
		public string DetailId1
		{
			get { return _detailId1;}
			set { _detailId1 = value;}
		}                                    
		
		/// <summary>
		/// 费用ID对应Ininvoicedtl.id用于处理首日
		/// </summary>
		public string DetailId2
		{
			get { return _detailId2;}
			set { _detailId2 = value;}
		}                                    
		
		/// <summary>
		/// 医嘱名称：来源于医嘱
		/// </summary>
		public string AdviceName
		{
			get { return _adviceName;}
			set { _adviceName = value;}
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
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 规格
		/// </summary>
		public string Spec
		{
			get { return _spec;}
			set { _spec = value;}
		}                                    
		
		/// <summary>
		/// 执行ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 执行ID用于处理首日
		/// </summary>
		public string ExecuteId2
		{
			get { return _executeId2;}
			set { _executeId2 = value;}
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
		/// 执行医生
		/// </summary>
		public string ExecDoctorId
		{
			get { return _execDoctorId;}
			set { _execDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 是否医保限制
		/// </summary>
		public bool IsYbxj
		{
			get { return _isYbxj;}
			set { _isYbxj = value;}
		}                                    
		
		/// <summary>
		/// 是否自助收
		/// </summary>
		public bool IsAutoMatic
		{
			get { return _isAutoMatic;}
			set { _isAutoMatic = value;}
		}                                    
		
		/// <summary>
		/// 甲类、乙类、丙类、自费
		/// </summary>
		public string YBType
		{
			get { return _yBType;}
			set { _yBType = value;}
		}                                    
		
		/// <summary>
		/// 是否优先
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
		}                                    
		
		/// <summary>
		/// 临时分组用(LsMarkType|GroupNum)
		/// </summary>
		public string TempStr
		{
			get { return _tempStr;}
			set { _tempStr = value;}
		}                                    
		
		/// <summary>
		/// 用于判断显示颜色
		/// </summary>
		public string Colours
		{
			get { return _colours;}
			set { _colours = value;}
		}                                    
		
		/// <summary>
		/// 对应bsUsageItem.id
		/// </summary>
		public string UsageItemId
		{
			get { return _usageItemId;}
			set { _usageItemId = value;}
		}                                    
		                            
		        
	}  
}           


