

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院临嘱 - 实体类
	/// </summary>
	[Serializable]
	public partial class InAdviceTemp:BaseModel
	{    
		private DateTime _adviceTime;  //开医嘱时间
		
		private string _doctorId;  //开嘱医生
		
		private string _locationId;  //开嘱科室
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private int _groupNum;  //组号
		
		private string _itemId;  //医嘱项目
		
		private double _dosage;  //每次服用量
		
		private string _unitTakeId;  //服用单位
		
		private string _frequencyId;  //每天服用次数
		
		private string _usageId;  //用法
		
		private double _priceIn;  //单价
		
		private double _totality;  //当天总量
		
		private string _unitInId;  //总量单位
		
		private bool _isUrgent;  //紧急
		
		private bool _isAttach;  //是否执行isNoAttach
		
		private bool _isSelf;  //自备药
		
		private int _lsSpecialUsage;  //特殊用法标志：0-静滴；1-接滴
		
		private int _lsExecLoc;  //执行地点：1-西药房；2-中心药房；3-本科执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
		
		private bool _isSkin;  //是否需要皮试？
		
		private DateTime _skinTime;  //皮试时间
		
		private string _skinTest;  //皮试结果
		
		private DateTime _operTime;  //登记时间
		
		private string _operID;  //登记人
		
		private bool _isPrinted;  //是否已打印？
		
		private bool _isOtherFee;  //是否附加项目
		
		private bool _isChk;  //是否已审核确认？
		
		private DateTime _chkOperTime;  //审核确认时间
		
		private string _chkOperID;  //核对护士
		
		private bool _isAuth;  //是否查对
		
		private DateTime _authOperTime;  //最后查对时间
		
		private string _authOperID;  //最后查对护士
		
		private bool _isAuthFee;  //是否已收费确认
		
		private DateTime _authFeeOperTime;  //收费确认时间
		
		private string _authFeeOperID;  //收费确认人
		
		private bool _isCancel;  //是否取消
		
		private DateTime _cancelOperTime;  //取消时间
		
		private string _cancelOperID;  //取消人
		
		private string _memo;  //备注
		
		private string _execLocId;  //执行科室
		
		private string _execDoctorId;  //执行医生
		
		private bool _isYbxj;  //是否医保限制
		
		private string _ybType;  //医保类别
		
		private string _adviceTempMemo;  //临嘱备注
		
		private string _applyId;  //PsApplyReport表的ID
		
		private string _colours;  //显示颜色
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isDelete;  //是否已删除
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        private string _sN;

        private bool _isPis;

        private string _opsApplyId;

        private string _sourceId;

        public InAdviceTemp() { }
                                    
		
		/// <summary>
		/// 开医嘱时间
		/// </summary>
		public DateTime AdviceTime
		{
			get { return _adviceTime;}
			set { _adviceTime = value;}
		}                                    
		
		/// <summary>
		/// 开嘱医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 开嘱科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
		/// 组号
		/// </summary>
		public int GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 医嘱项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 每次服用量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 服用单位
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 每天服用次数
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
		}                                    
		
		/// <summary>
		/// 当天总量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 总量单位
		/// </summary>
		public string UnitInId
		{
			get { return _unitInId;}
			set { _unitInId = value;}
		}                                    
		
		/// <summary>
		/// 紧急
		/// </summary>
		public bool IsUrgent
		{
			get { return _isUrgent;}
			set { _isUrgent = value;}
		}                                    
		
		/// <summary>
		/// 是否执行isNoAttach
		/// </summary>
		public bool IsAttach
		{
			get { return _isAttach;}
			set { _isAttach = value;}
		}                                    
		
		/// <summary>
		/// 自备药
		/// </summary>
		public bool IsSelf
		{
			get { return _isSelf;}
			set { _isSelf = value;}
		}                                    
		
		/// <summary>
		/// 特殊用法标志：0-静滴；1-接滴
		/// </summary>
		public int LsSpecialUsage
		{
			get { return _lsSpecialUsage;}
			set { _lsSpecialUsage = value;}
		}                                    
		
		/// <summary>
		/// 执行地点：1-西药房；2-中心药房；3-本科执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
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
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 是否已打印？
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
		/// 审核确认时间
		/// </summary>
		public DateTime ChkOperTime
		{
			get { return _chkOperTime;}
			set { _chkOperTime = value;}
		}                                    
		
		/// <summary>
		/// 核对护士
		/// </summary>
		public string ChkOperID
		{
			get { return _chkOperID;}
			set { _chkOperID = value;}
		}                                    
		
		/// <summary>
		/// 是否查对
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 最后查对时间
		/// </summary>
		public DateTime AuthOperTime
		{
			get { return _authOperTime;}
			set { _authOperTime = value;}
		}                                    
		
		/// <summary>
		/// 最后查对护士
		/// </summary>
		public string AuthOperID
		{
			get { return _authOperID;}
			set { _authOperID = value;}
		}                                    
		
		/// <summary>
		/// 是否已收费确认
		/// </summary>
		public bool IsAuthFee
		{
			get { return _isAuthFee;}
			set { _isAuthFee = value;}
		}                                    
		
		/// <summary>
		/// 收费确认时间
		/// </summary>
		public DateTime AuthFeeOperTime
		{
			get { return _authFeeOperTime;}
			set { _authFeeOperTime = value;}
		}                                    
		
		/// <summary>
		/// 收费确认人
		/// </summary>
		public string AuthFeeOperID
		{
			get { return _authFeeOperID;}
			set { _authFeeOperID = value;}
		}                                    
		
		/// <summary>
		/// 是否取消
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 取消时间
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 取消人
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
		/// 执行科室
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
		/// PsApplyReport表的ID
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 显示颜色
		/// </summary>
		public string Colours
		{
			get { return _colours;}
			set { _colours = value;}
		}                                    
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double DiscountAoumt
		{
			get { return _discountAoumt;}
			set { _discountAoumt = value;}
		}                                    
		
		/// <summary>
		/// 儿童价格
		/// </summary>
		public double ChildPrice
		{
			get { return _childPrice;}
			set { _childPrice = value;}
		}                                    
		
		/// <summary>
		/// 折扣价格
		/// </summary>
		public double DiscountPrice
		{
			get { return _discountPrice;}
			set { _discountPrice = value;}
		}                                    
		
		/// <summary>
		/// 是否已删除
		/// </summary>
		public bool IsDelete
		{
			get { return _isDelete;}
			set { _isDelete = value;}
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

        public string SN
        {
            get { return _sN; }
            set { _sN = value; }
        }

        public bool IsPis
        {
            get { return _isPis; }
            set { _isPis = value; }
        }

        public string OpsApplyId
        {
            get { return _opsApplyId; }
            set { _opsApplyId = value; }
        }

        public string SourceId
        {
            get { return _sourceId; }
            set { _sourceId = value; }
        }

    }  
}           


