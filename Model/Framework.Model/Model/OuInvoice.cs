

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊收费发票 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuInvoice :  BaseModel  
	{   
		 
		private string _invoNo;  //发票号码
		
		private string _mzRegId;  //门诊流水号
		
		private string _patId;  //病人ID，对应于Patient的Pat_Id
		
		private DateTime _invoTime;  //发票时间
		
		private double _beprice;  //应结算金额（总金额）
		
		private double _factGet;  //自付金额（乘以DiscSelf前的金额）
		
		private double _insurance;  //医保/公医记帐金额
		
		private double _paySelf;  //个人缴费金额
		
		private double _amountPay;  //应交金额（乘以DiscSelf后的金额）
		
		private double _addFee;  //凑整费
		
		private string _tallyNo;  //起伏线
		
		private string _remark;  //退款备注
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private bool _isCancel;  //是否注销
		
		private DateTime _cancelOperTime;  //注销日期
		
		private string _cancelOperId;  //收费操作员
		
		private string _cancelMemo;  //退款备注
		
		private string _invoLastId;  //退费的原发票
		
		private DateTime _tallyTime;  //
		
		private DateTime _cancelTallyTime;  //
		
		private double _reAmount;  //
		
		private DateTime _reAmountDate;  //
		
		private string _reAmountMemo;  //
		
		private string _patTypeId;  //病人类别
		
		private int _HospitalID;  //院区Id,BsHospital.Id
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private DateTime _checkTime;  //交款时间
		
		private DateTime _cancelCheckTime;  //作废交款时间
		
		private string _docLocId;  //医生所嘱科室(BsDoctor.Locationid)
		
		private int _cancelHospital;  //作废发票的分院名称
		
		private string _ybSeqNo;  //医保流水号
		
		private string _reReprintOperId;  //重打发票操作员
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private double _packaDiscount;  //套餐优惠
		
		private double _fixedDiscount;  //固定优惠
		
		private double _fixedSubsidy;  //固定补助
		
		private string _vipCardID;  //行心云:会员ID
		
		private string _arrearsTypeId;  //行心云:欠费类别 关联BsInvMzItem
		
		private DateTime _hideOperTime;  //行心云:隐藏操作时间
		
		private string _hideOperID;  //行心云:隐藏操作人ID
		
		private bool _isHide;  //行心云:是否隐藏
		
		private double _previousArrears;  //行心云:上次欠款
		
		private double _currentPay;  //行心云:本次费用
		
		private double _currentArrears;  //行心云:本次欠款
		
		private string _tallyCancelOperId;  //行心云:取消记账人
		
		private bool _lsRepType;  //行心云:1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药；6-附加项目；7-材料；8-营养素 9其他（挂号费）10退费

        private bool _isVerify;//是否审核   

        private double _discountNum;

        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsVerify
        {
            get { return _isVerify; }
            set { _isVerify = value; }
        }

        /// <summary>
        /// 发票号码
        /// </summary>
        public string InvoNo
		{
			get { return _invoNo;}
			set { _invoNo = value;}
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
		/// 病人ID，对应于Patient的Pat_Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 发票时间
		/// </summary>
		public DateTime InvoTime
		{
			get { return _invoTime;}
			set { _invoTime = value;}
		}                                    
		
		/// <summary>
		/// 应结算金额（总金额）
		/// </summary>
		public double Beprice
		{
			get { return _beprice;}
			set { _beprice = value;}
		}                                    
		
		/// <summary>
		/// 自付金额（乘以DiscSelf前的金额）
		/// </summary>
		public double FactGet
		{
			get { return _factGet;}
			set { _factGet = value;}
		}                                    
		
		/// <summary>
		/// 医保/公医记帐金额
		/// </summary>
		public double Insurance
		{
			get { return _insurance;}
			set { _insurance = value;}
		}                                    
		
		/// <summary>
		/// 个人缴费金额
		/// </summary>
		public double PaySelf
		{
			get { return _paySelf;}
			set { _paySelf = value;}
		}                                    
		
		/// <summary>
		/// 应交金额（乘以DiscSelf后的金额）
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 凑整费
		/// </summary>
		public double AddFee
		{
			get { return _addFee;}
			set { _addFee = value;}
		}                                    
		
		/// <summary>
		/// 起伏线
		/// </summary>
		public string TallyNo
		{
			get { return _tallyNo;}
			set { _tallyNo = value;}
		}                                    
		
		/// <summary>
		/// 退款备注
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
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
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		/// 注销日期
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 收费操作员
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 退款备注
		/// </summary>
		public string CancelMemo
		{
			get { return _cancelMemo;}
			set { _cancelMemo = value;}
		}                                    
		
		/// <summary>
		/// 退费的原发票
		/// </summary>
		public string InvoLastId
		{
			get { return _invoLastId;}
			set { _invoLastId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime TallyTime
		{
			get { return _tallyTime;}
			set { _tallyTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime CancelTallyTime
		{
			get { return _cancelTallyTime;}
			set { _cancelTallyTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ReAmount
		{
			get { return _reAmount;}
			set { _reAmount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReAmountDate
		{
			get { return _reAmountDate;}
			set { _reAmountDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ReAmountMemo
		{
			get { return _reAmountMemo;}
			set { _reAmountMemo = value;}
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
		/// 交款时间
		/// </summary>
		public DateTime CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 作废交款时间
		/// </summary>
		public DateTime CancelCheckTime
		{
			get { return _cancelCheckTime;}
			set { _cancelCheckTime = value;}
		}                                    
		
		/// <summary>
		/// 医生所嘱科室(BsDoctor.Locationid)
		/// </summary>
		public string DocLocId
		{
			get { return _docLocId;}
			set { _docLocId = value;}
		}                                    
		
		/// <summary>
		/// 作废发票的分院名称
		/// </summary>
		public int CancelHospital
		{
			get { return _cancelHospital;}
			set { _cancelHospital = value;}
		}                                    
		
		/// <summary>
		/// 医保流水号
		/// </summary>
		public string YbSeqNo
		{
			get { return _ybSeqNo;}
			set { _ybSeqNo = value;}
		}                                    
		
		/// <summary>
		/// 重打发票操作员
		/// </summary>
		public string ReReprintOperId
		{
			get { return _reReprintOperId;}
			set { _reReprintOperId = value;}
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
		/// 套餐优惠
		/// </summary>
		public double PackaDiscount
		{
			get { return _packaDiscount;}
			set { _packaDiscount = value;}
		}                                    
		
		/// <summary>
		/// 固定优惠
		/// </summary>
	     public double FixedDiscount
		{
			get { return _fixedDiscount;}
			set { _fixedDiscount = value;}
		}                                    
		
		/// <summary>
		/// 固定补助
		/// </summary>
		public double FixedSubsidy
		{
			get { return _fixedSubsidy;}
			set { _fixedSubsidy = value;}
		}                                    
		
		/// <summary>
		/// 行心云:会员ID
		/// </summary>
		public string VipCardID
		{
			get { return _vipCardID;}
			set { _vipCardID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:欠费类别 关联BsInvMzItem
		/// </summary>
		public string ArrearsTypeId
		{
			get { return _arrearsTypeId;}
			set { _arrearsTypeId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:隐藏操作时间
		/// </summary>
		public DateTime HideOperTime
		{
			get { return _hideOperTime;}
			set { _hideOperTime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:隐藏操作人ID
		/// </summary>
		public string HideOperID
		{
			get { return _hideOperID;}
			set { _hideOperID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:是否隐藏
		/// </summary>
		public bool IsHide
		{
			get { return _isHide;}
			set { _isHide = value;}
		}                                    
		
		/// <summary>
		/// 行心云:上次欠款
		/// </summary>
		public double PreviousArrears
		{
			get { return _previousArrears;}
			set { _previousArrears = value;}
		}                                    
		
		/// <summary>
		/// 行心云:本次费用
		/// </summary>
		public double CurrentPay
		{
			get { return _currentPay;}
			set { _currentPay = value;}
		}                                    
		
		/// <summary>
		/// 行心云:本次欠款
		/// </summary>
		public double CurrentArrears
		{
			get { return _currentArrears;}
			set { _currentArrears = value;}
		}                                    
		
		/// <summary>
		/// 行心云:取消记账人
		/// </summary>
		public string TallyCancelOperId
		{
			get { return _tallyCancelOperId;}
			set { _tallyCancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药；6-附加项目；7-材料；8-营养素 9其他（挂号费）10退费
		/// </summary>
		public bool LsRepType
		{
			get { return _lsRepType;}
			set { _lsRepType = value;}
		}                                    
		        
        public double DiscountNum
        {
            get { return _discountNum; }
            set { _discountNum = value; }
        }
    }  
}           


