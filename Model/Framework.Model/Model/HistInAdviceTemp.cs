

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史临嘱 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistInAdviceTemp : BaseModel
    {   
		
		private DateTime _inSertTime;  //插入时间
		
		
		
		private DateTime _adviceTime;  //医嘱时间
		
		private string _doctorId;  //开嘱医生BsDoctor.Id
		
		private string _locationId;  //开嘱科室BsLocation.Id
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private int _groupNum;  //组号
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _dosage;  //每次量
		
		private string _unitTakeId;  //使用单位
		
		private string _frequencyId;  //频率对应BsFrequency.Id
		
		private string _usageId;  //用法对应BsUsage.Id
		
		private double _priceIn;  //住院项目单价
		
		private double _totality;  //数量
		
		private string _unitInId;  //药房单位
		
		private bool _isUrgent;  //是否紧急
		
		private bool _isAttach;  //是否执行
		
		private bool _isSelf;  //是否自费
		
		private int _lsSpecialUsage;  //特殊用法标志：1-静滴；2-接滴
		
		private int _lsExecLoc;  //执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
		
		private bool _isSkin;  //是否需要皮试？
		
		private DateTime _skinTime;  //皮试时间
		
		private string _skinTest;  //皮试结果
		
		private DateTime _operTime;  //操作时间
		
		private string _operID;  //操作员ID,BsUser.Id
		
		private bool _isPrinted;  //是否已打印？。
		
		private bool _isOtherFee;  //是否附加项目
		
		private bool _isChk;  //是否已审核确认？
		
		private DateTime _chkOperTime;  //审核时间
		
		private string _chkOperID;  //审核人
		
		private bool _isAuth;  //是否查对。
		
		private DateTime _authOperTime;  //查对时间
		
		private string _authOperID;  //查对护士
		
		private bool _isAuthFee;  //是否查对。Fee
		
		private DateTime _authFeeOperTime;  //
		
		private string _authFeeOperID;  //
		
		private bool _isCancel;  //是否作废
		
		private DateTime _cancelOperTime;  //作废时间
		
		private string _cancelOperID;  //作废人
		
		private string _memo;  //备注
		
		private string _execLocId;  //执行科室BsLocation.id
		
		private string _execDoctorId;  //执行医生
		
		private bool _isYbxj;  //是否医保限制
		
		private string _ybType;  //医保类别
		
		private string _adviceTempMemo;  //临嘱备注
		
		private string _applyId;  //检查申请PsApplyReport.GUID
		
		private string _colours;  //颜色
		
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
		/// 医嘱时间
		/// </summary>
		public DateTime AdviceTime
		{
			get { return _adviceTime;}
			set { _adviceTime = value;}
		}                                    
		
		/// <summary>
		/// 开嘱医生BsDoctor.Id
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
		/// 住院项目单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
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
		/// 药房单位
		/// </summary>
		public string UnitInId
		{
			get { return _unitInId;}
			set { _unitInId = value;}
		}                                    
		
		/// <summary>
		/// 是否紧急
		/// </summary>
		public bool IsUrgent
		{
			get { return _isUrgent;}
			set { _isUrgent = value;}
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
		/// 是否需要皮试？
		/// </summary>
		public bool IsSkin
		{
			get { return _isSkin;}
			set { _isSkin = value;}
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
		/// 皮试结果
		/// </summary>
		public string SkinTest
		{
			get { return _skinTest;}
			set { _skinTest = value;}
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
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
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
		/// 是否附加项目
		/// </summary>
		public bool IsOtherFee
		{
			get { return _isOtherFee;}
			set { _isOtherFee = value;}
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
		public string AuthOperID
		{
			get { return _authOperID;}
			set { _authOperID = value;}
		}                                    
		
		/// <summary>
		/// 是否查对。Fee
		/// </summary>
		public bool IsAuthFee
		{
			get { return _isAuthFee;}
			set { _isAuthFee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime AuthFeeOperTime
		{
			get { return _authFeeOperTime;}
			set { _authFeeOperTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string AuthFeeOperID
		{
			get { return _authFeeOperID;}
			set { _authFeeOperID = value;}
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
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 作废人
		/// </summary>
		public string CancelOperID
		{
			get { return _cancelOperID;}
			set { _cancelOperID = value;}
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
		/// 执行科室BsLocation.id
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
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
		/// 医保类别
		/// </summary>
		public string YbType
		{
			get { return _ybType;}
			set { _ybType = value;}
		}                                    
		
		/// <summary>
		/// 临嘱备注
		/// </summary>
		public string AdviceTempMemo
		{
			get { return _adviceTempMemo;}
			set { _adviceTempMemo = value;}
		}                                    
		
		/// <summary>
		/// 检查申请PsApplyReport.GUID
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 颜色
		/// </summary>
		public string Colours
		{
			get { return _colours;}
			set { _colours = value;}
		}                                    
		                                
		        
	}  
}           


