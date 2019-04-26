

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院中药处方单 - 实体类
	/// </summary>
	[Serializable]
	public partial class InChinRicipe:BaseModel
	{   
		 
		private string _recipeNo;  //处方号
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _locationId;  //申请科室
		
		private string _doctorId;  //医生
		
		private int _drugNum;  //用药付数
		
		private int _decoctNum;  //煎药付数
		
		private bool _isConfirm;  //药房是否已确认
		
		private int _lsCookSelf;  //煎药方法：1-代煎；2-自煎
		
		private string _confirmOperID;  //药房确认人
		
		private DateTime _confirmOperTime;  //确认时间
		
		private bool _isBack;  //是否已退？
		
		private bool _isPrint;  //是否已打印
		
		private string _memo;  //说明
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _frequencyId;  //每天服用次数
		
		private string _usageId;  //用法
		
		private bool _isPriority;  //急煎
		
		private bool _isAuth;  //是否已审核？
		
		private DateTime _backTime;  //退药日期
		
		private int _cookMinute;  //煎药分钟
		
		private int _lsFire;  //火候：1-文火;2-中火;3-武火
		
		private string _adviceLocationId;  //医嘱科室
		
		private double _amount;  //处方总额
		
		private string _cookSelfDtlId;  //F4代收的煎药费明细id
		
		private string _authOper;  //审核人名字
		
		private DateTime _authTime;  //审核时间
		
		private bool _isAuthed;  //已经封存，不可改删


        private bool _u_IsRecipeNo;

        private bool _u_IsMemoNull;

        private bool _u_IsForRecipe;

        private bool _u_IsHospIdNull;

        public InChinRicipe() { }
         
		/// <summary>
		/// 处方号
		/// </summary>
		public string RecipeNo
		{
			get { return _recipeNo;}
			set { _recipeNo = value;}
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
		/// 申请科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 用药付数
		/// </summary>
		public int DrugNum
		{
			get { return _drugNum;}
			set { _drugNum = value;}
		}                                    
		
		/// <summary>
		/// 煎药付数
		/// </summary>
		public int DecoctNum
		{
			get { return _decoctNum;}
			set { _decoctNum = value;}
		}                                    
		
		/// <summary>
		/// 药房是否已确认
		/// </summary>
		public bool IsConfirm
		{
			get { return _isConfirm;}
			set { _isConfirm = value;}
		}                                    
		
		/// <summary>
		/// 煎药方法：1-代煎；2-自煎
		/// </summary>
		public int LsCookSelf
		{
			get { return _lsCookSelf;}
			set { _lsCookSelf = value;}
		}                                    
		
		/// <summary>
		/// 药房确认人
		/// </summary>
		public string ConfirmOperID
		{
			get { return _confirmOperID;}
			set { _confirmOperID = value;}
		}                                    
		
		/// <summary>
		/// 确认时间
		/// </summary>
		public DateTime ConfirmOperTime
		{
			get { return _confirmOperTime;}
			set { _confirmOperTime = value;}
		}                                    
		
		/// <summary>
		/// 是否已退？
		/// </summary>
		public bool IsBack
		{
			get { return _isBack;}
			set { _isBack = value;}
		}                                    
		
		/// <summary>
		/// 是否已打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 说明
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
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
		/// 急煎
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
		}                                    
		
		/// <summary>
		/// 是否已审核？
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 退药日期
		/// </summary>
		public DateTime BackTime
		{
			get { return _backTime;}
			set { _backTime = value;}
		}                                    
		
		/// <summary>
		/// 煎药分钟
		/// </summary>
		public int CookMinute
		{
			get { return _cookMinute;}
			set { _cookMinute = value;}
		}                                    
		
		/// <summary>
		/// 火候：1-文火;2-中火;3-武火
		/// </summary>
		public int LsFire
		{
			get { return _lsFire;}
			set { _lsFire = value;}
		}                                    
		
		/// <summary>
		/// 医嘱科室
		/// </summary>
		public string AdviceLocationId
		{
			get { return _adviceLocationId;}
			set { _adviceLocationId = value;}
		}                                    
		
		/// <summary>
		/// 处方总额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// F4代收的煎药费明细id
		/// </summary>
		public string CookSelfDtlId
		{
			get { return _cookSelfDtlId;}
			set { _cookSelfDtlId = value;}
		}                                    
		
		/// <summary>
		/// 审核人名字
		/// </summary>
		public string AuthOper
		{
			get { return _authOper;}
			set { _authOper = value;}
		}                                    
		
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime AuthTime
		{
			get { return _authTime;}
			set { _authTime = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}
        private bool _isLsCookSelf = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsLsCookSelf
        {
            get
            {
                if (LsCookSelf == (int)EnumDefine.EnumCookSelf.CoctByHospital)
                {
                    _isLsCookSelf = true;
                }
                else
                {
                    _isLsCookSelf = false;
                }
                return _isLsCookSelf;
            }
            set { _isLsCookSelf = value; }
        }
        private bool _isNtoCookSelfDtlIdNull = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNtoCookSelfDtlIdNull
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(CookSelfDtlId))
                {
                    _isNtoCookSelfDtlIdNull = true;
                }
                else
                {
                    _isNtoCookSelfDtlIdNull = false;
                }
                return _isNtoCookSelfDtlIdNull;
            }
            set { _isNtoCookSelfDtlIdNull = value; }
        }
        private bool _isFrequencyIdNull = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsFrequencyIdNull
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FrequencyId))
                {
                    _isFrequencyIdNull = true;
                }
                else
                {
                    _isFrequencyIdNull = false;
                }
                return _isFrequencyIdNull;
            }
            set { _isFrequencyIdNull = value; }
        }
        private bool _isUsageIdNull = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsUsageIdNull
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UsageId))
                {
                    _isUsageIdNull = true;
                }
                else
                {
                    _isUsageIdNull = false;
                }
                return _isUsageIdNull;
            }
            set { _isUsageIdNull = value; }
        }
        public bool u_IsRecipeNo
        {
            get { return _u_IsRecipeNo; }
            set { _u_IsRecipeNo = value; }
        }

        public bool u_IsMemoNull
        {
            get { return _u_IsMemoNull; }
            set { _u_IsMemoNull = value; }
        }

        public bool u_IsForRecipe
        {
            get { return _u_IsForRecipe; }
            set { _u_IsForRecipe = value; }
        }

        public bool u_IsHospIdNull
        {
            get { return _u_IsHospIdNull; }
            set { _u_IsHospIdNull = value; }
        }
    }  
}           


