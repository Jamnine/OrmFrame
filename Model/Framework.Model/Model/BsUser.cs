

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUser : BaseModel
	{
        private int _roleIdCode; // 对应 EnumRole 中的项

        private string _code;  //用户编码
		
		private string _name;  //用户名称
		
		private string _password;  //密码
		
		
		private string _reason;  //原因
		
		private int _lsInputWay;  //默认中文输入方式：1-拼音；2-五笔
		
		private int _iconIndex;  //图标类型
		
		private bool _isUserInputWB;  //选择五笔录入
		
		private bool _isUserInputPY;  //选择拼音录入
		
		private bool _isUserInputCode;  //选择编码录入
		
		private bool _isUserInputName;  //选择名称录入
		
		private bool _isUserInputStrokeCode;  //选择助记码录入
		
		private bool _isUserInputEngDesc;  //选择化学名录入
		
		//private string _introduce;  //介绍
		
		private string _picturePath;  //相片文件路径
		
		private string _address;  //地址
		
		private string _mobile;  //手机号码
		
		private string _levelId;  //学历编码
		
		private string _docLevId;  //职称ID

        private string _docLevName;  //职称

        private int _HospitalID;  //医院Id,BsHospital.Id
		
		private string _careGroupId;  //签约团队
		
		private int _careGroupId1;  //
		
		private string _certIdNo;  //
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private bool _isUserInputF1;  //是否下拉跟随
		
		private bool _isUserInputList;  //用户输入法设置——下拉跟随输入
		
		private bool _isUserWordPad;  //用户输入法设置——写字板
		
		private bool _isUserSelectOnly;  //用户输入法设置——精确查找

        private string _diagRoomId; //行心云:所属诊室
        
        private int _isCancancel; //行心云:是否取消 

        private bool _isVolunteer;//是否志愿者 

        private bool _isIntegralStaff;//行心云:推荐人    

        private DateTime _operTime;//行心云:F2录入时间 

        private DateTime _modiTime;//行心云:最后修改时间、

        private string _modiOperId;// 行心云:最后修改人

        private bool _isActive = true;

        private string _sex;//行心云:性别

        private string _email;// 行心云:email
        private DateTime _birthDate;//行心云:出生日期c 

        private int _lsStatus;// 行心云:在职离职状态：1-在职；2-离职 

        private string _diagroomId;////行心云:所属诊室  

        private double _deduct;//行心云:提成   

        private bool _isInternalStaff;//行心云:是否是内部员工

        private string _DepartmentId;//行心云:科室
        private string _DepartmentName;
        private string _remark;//行心云:备注

        private bool _isGiveredenvelopes;//行心云:是否允许发红包

        private bool _isRecipe; //行心云:处方权(是否医生)

        private bool _isItAnExpert;

        private string _ruleId;

        /// <summary>
        /// 在线状态
        /// </summary>
        public string isOnline { get; set; }


        /// <summary>
        /// 规则ID
        /// </summary>
        public string RuleId
        {
            get { return _ruleId; }
            set { _ruleId = value; }
        }

        /// <summary>
        /// 是否专家
        /// </summary>
        public bool IsItAnExpert
        {
            get { return _isItAnExpert; }
            set { _isItAnExpert = value; }
        }

        /// <summary>
        /// 行心云:处方权(是否医生)
        /// </summary>
        public bool IsRecipe
        {
            get { return _isRecipe; }
            set { _isRecipe = value; }
        }

        /// <summary>
        /// 行心云:是否允许发红包
        /// </summary>
        public bool IsGivereDenvelopes
        {
            get { return _isGiveredenvelopes; }
            set { _isGiveredenvelopes = value; }
        }

        /// <summary>
        /// 行心云:备注
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }


        /// <summary>
        /// 行心云:科室
        /// </summary>
        public string DepartmentId
        {
            get { return _DepartmentId; }
            set { _DepartmentId = value; }
        }

        public string DepartmentName 
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
        /// <summary>
        /// 行心云:是否是内部员工
        /// </summary>
        public bool IsInternalStaff
        {
            get { return _isInternalStaff; }
            set { _isInternalStaff = value; }
        } 
        /// <summary>
        /// 行心云:提成  
        /// </summary>
        public double Deduct
        {
            get { return _deduct; }
            set { _deduct = value; }
        } 

        /// <summary>
        /// //行心云:所属诊室  
        /// </summary>
        public string DiagroomId
        {
            get { return _diagroomId; }
            set { _diagroomId = value; }
        }


        /// <summary>
        ///  行心云:在职离职状态：1-在职；2-离职
        /// </summary>
        public int LsStatus
        {
            get { return _lsStatus; }
            set { _lsStatus = value; }
        } 

        /// <summary>
        ///  行心云:email
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// 行心云:出生日期
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        /// <summary>
        /// 行心云:性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }


        /// <summary>
        /// 行心云:最后修改人
        /// </summary>
        public string ModiOperId
        {
            get { return _modiOperId; }
            set { _modiOperId = value; }
        }


        /// <summary>
        /// 行心云:最后修改时间、
        /// </summary>
        public DateTime ModiTime
        {
            get { return _modiTime; }
            set { _modiTime = value; }
        }


        /// <summary>
        /// 行心云:F2录入时间 
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }




        /// <summary>
        /// 行心云:推荐人   
        /// </summary>
        public bool IsIntegralStaff
        {
            get { return _isIntegralStaff; }
            set { _isIntegralStaff = value; }
        }

        /// <summary>
        /// 是否志愿者
        /// </summary>
        public bool IsVolunteer
        {
            get { return _isVolunteer; }
            set { _isVolunteer = value; }
        }

        /// <summary>
        /// 行心云:是否取消
        /// </summary>
        public int IsCancancel
        {
            get { return _isCancancel; }
            set { _isCancancel = value; }
        }
                              
		
		/// <summary>
		/// 用户编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 用户名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 密码
		/// </summary>
		public string Password
		{
			get { return _password;}
			set { _password = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 原因
		/// </summary>
		public string Reason
		{
			get { return _reason;}
			set { _reason = value;}
		}                                    
		
		/// <summary>
		/// 默认中文输入方式：1-拼音；2-五笔
		/// </summary>
		public int LsInputWay
		{
			get { return _lsInputWay;}
			set { _lsInputWay = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 选择五笔录入
		/// </summary>
		public bool IsUserInputWB
		{
			get { return _isUserInputWB;}
			set { _isUserInputWB = value;}
		}                                    
		
		/// <summary>
		/// 选择拼音录入
		/// </summary>
		public bool IsUserInputPY
		{
			get { return _isUserInputPY;}
			set { _isUserInputPY = value;}
		}                                    
		
		/// <summary>
		/// 选择编码录入
		/// </summary>
		public bool IsUserInputCode
		{
			get { return _isUserInputCode;}
			set { _isUserInputCode = value;}
		}                                    
		
		/// <summary>
		/// 选择名称录入
		/// </summary>
		public bool IsUserInputName
		{
			get { return _isUserInputName;}
			set { _isUserInputName = value;}
		}                                    
		
		/// <summary>
		/// 选择助记码录入
		/// </summary>
		public bool IsUserInputStrokeCode
		{
			get { return _isUserInputStrokeCode;}
			set { _isUserInputStrokeCode = value;}
		}                                    
		
		/// <summary>
		/// 选择化学名录入
		/// </summary>
		public bool IsUserInputEngDesc
		{
			get { return _isUserInputEngDesc;}
			set { _isUserInputEngDesc = value;}
		}                                    
		
		///// <summary>
		///// 介绍
		///// </summary>
		////public string Introduce
		//{
		//	get { return _introduce;}
		//	set { _introduce = value;}
		//}                                    
		
		/// <summary>
		/// 相片文件路径
		/// </summary>
		public string PicturePath
		{
			get { return _picturePath;}
			set { _picturePath = value;}
		}                                    
		
		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			get { return _address;}
			set { _address = value;}
		}                                    
		
		/// <summary>
		/// 手机号码
		/// </summary>
		public string Mobile
		{
			get { return _mobile;}
			set { _mobile = value;}
		}                                    
		
		/// <summary>
		/// 学历编码
		/// </summary>
		public string LevelId
		{
			get { return _levelId;}
			set { _levelId = value;}
		}                                    
		
		/// <summary>
		/// 职称
		/// </summary>
		public string DocLevId
		{
			get { return _docLevId;}
			set { _docLevId = value;}
		}
        public string DocLevName
        {
            get { return _docLevName; }
            set { _docLevName = value; }
        }
        

        /// <summary>
        /// 签约团队
        /// </summary>
        public string CareGroupId
		{
			get { return _careGroupId;}
			set { _careGroupId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int CareGroupId1
		{
			get { return _careGroupId1;}
			set { _careGroupId1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CertIdNo
		{
			get { return _certIdNo;}
			set { _certIdNo = value;}
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
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 是否下拉跟随
		/// </summary>
		public bool IsUserInputF1
		{
			get { return _isUserInputF1;}
			set { _isUserInputF1 = value;}
		}                                    
		
		/// <summary>
		/// 用户输入法设置——下拉跟随输入
		/// </summary>
		public bool IsUserInputList
		{
			get { return _isUserInputList;}
			set { _isUserInputList = value;}
		}                                    
		
		/// <summary>
		/// 用户输入法设置——写字板
		/// </summary>
		public bool IsUserWordPad
		{
			get { return _isUserWordPad;}
			set { _isUserWordPad = value;}
		}                                    
		
		/// <summary>
		/// 用户输入法设置——精确查找
		/// </summary>
		public bool IsUserSelectOnly
		{
			get { return _isUserSelectOnly;}
			set { _isUserSelectOnly = value;}
		}
        /// <summary>
        /// 所属诊室
        /// </summary>
         public string DiagRoomId
        {
            get
            {
                return this._diagRoomId;
            }
            set
            {
                this._diagRoomId = value;
            }
        }

        /// <summary>
        /// 对应 EnumRole 中的项
        /// </summary>
        public int RoleIdCode
        {
            get { return _roleIdCode; }
            set { _roleIdCode = value; }
        }
    }
}           


