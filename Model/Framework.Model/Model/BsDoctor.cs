

using System;
namespace Orm.Model
{
	/// <summary>
	/// 医生表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsDoctor : BaseModel
    {   

		private string _code;  //内码
		
		private string _name;  //中文名
		
		private string _sex;  //性别
		
		private DateTime _birthDate;  //出生日期
		
		private string _address;  //地址
		
		private string _city;  //城市
		
		private string _mobile;  //手机号码
		
		private string _email;  //邮箱
		
		private string _levelId;  //学历编码
		
		private string _docLevId;  //职称
		
		private string _introduce;  //介绍
		
		private string _locationId;  //所属科室
		
		private string _regTypeId;  //门诊类别
		
		private string _picturePath;  //相片文件路径
		
		private int _lsStatus;  //在职离职状态：1-在职；2-离职
		
		private int _orderBy;  //显示排序
		
		private int _iconIndex;  //图标类型
		
		private string _userId;  //用户Id,对应BsUser.Id
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private string _supDoctorId;  //上级医生
		
		private string _diagRoomID;  //诊室对应BsDiagRoom.id
		
		private DateTime _operTime;  //操作时间
		
		private bool _isPoisonMa;  //是否有开毒麻处方权限
		
		private bool _isRecipe;  //是否有开处方权限
		
		private int _grade;  //医生等级，0普通医师,1上级医师,2主任医师。用来审核医嘱，病历，诊断之类的。
		
		private bool _isConsult;  //是否有会诊转诊的权限

        private int _HospitalID;  //



		/// <summary>
		/// 内码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 中文名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			get { return _sex;}
			set { _sex = value;}
		}                                    
		
		/// <summary>
		/// 出生日期
		/// </summary>
		public DateTime BirthDate
		{
			get { return _birthDate;}
			set { _birthDate = value;}
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
		/// 城市
		/// </summary>
		public string City
		{
			get { return _city;}
			set { _city = value;}
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
		/// 邮箱
		/// </summary>
		public string Email
		{
			get { return _email;}
			set { _email = value;}
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
		
		/// <summary>
		/// 介绍
		/// </summary>
		public string Introduce
		{
			get { return _introduce;}
			set { _introduce = value;}
		}                                    
		
		/// <summary>
		/// 所属科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 门诊类别
		/// </summary>
		public string RegTypeId
		{
			get { return _regTypeId;}
			set { _regTypeId = value;}
		}                                    
		
		/// <summary>
		/// 相片文件路径
		/// </summary>
		public string PicturePath
		{
			get { return _picturePath;}
			set { _picturePath = value;}
		}                                    
		
		/// <summary>
		/// 在职离职状态：1-在职；2-离职
		/// </summary>
		public int LsStatus
		{
			get { return _lsStatus;}
			set { _lsStatus = value;}
		}                                    
		
		/// <summary>
		/// 显示排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 用户Id,对应BsUser.Id
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
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
		/// 上级医生
		/// </summary>
		public string SupDoctorId
		{
			get { return _supDoctorId;}
			set { _supDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 诊室对应BsDiagRoom.id
		/// </summary>
		public string DiagRoomID
		{
			get { return _diagRoomID;}
			set { _diagRoomID = value;}
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
		/// 是否有开毒麻处方权限
		/// </summary>
		public bool IsPoisonMa
		{
			get { return _isPoisonMa;}
			set { _isPoisonMa = value;}
		}                                    
		
		/// <summary>
		/// 是否有开处方权限
		/// </summary>
		public bool IsRecipe
		{
			get { return _isRecipe;}
			set { _isRecipe = value;}
		}                                    
		
		/// <summary>
		/// 医生等级，0普通医师,1上级医师,2主任医师。用来审核医嘱，病历，诊断之类的。
		/// </summary>
		public int Grade
		{
			get { return _grade;}
			set { _grade = value;}
		}                                    
		
		/// <summary>
		/// 是否有会诊转诊的权限
		/// </summary>
		public bool IsConsult
		{
			get { return _isConsult;}
			set { _isConsult = value;}
		}

    

    }  
}           


