

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:专家管理 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsSpecialist:BaseModel
	{   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _sex;  //姓别 F女 M男 
		
		private string _provinceId;  //省ID
		
		private string _regionId;  //市ID
		
		private string _areaId;  //地区ID
		
		private string _addRess;  //地址
		
		private string _docLevId;  //职称
		
		private string _phone;  //联系电话
		
		private string _email;  //EMAIL
		
		private string _clinicId;  //所属诊所
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private DateTime _operTime;  //最后修改时间
		
		private string _operId;  //最后修改人
		
		private bool _isAudit;  //是否审核 0未审核(默认) 1审核通过 2审核不通过
		
		private DateTime _birthDate;  //生日
		
		private string _hospital;  //所属医院
		
		private string _department;  //所属科室
		
		private string  _HospitalID;  //所属医院ID
		
		private string _departmentId;  //所属科室ID
		
		private string _hospitalUnionId;  //所属医联体ID
		
		private byte[] _occupationCertificate;  //职业证书
		
		private byte[] _hireCertificate;  //职称聘书

        private byte[] _manPhoto; //头像

        /// <summary>
        /// 头像
        /// </summary>
        public byte[] ManPhoto
        {
            get { return _manPhoto; }
            set { _manPhoto = value; }
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
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 姓别 F女 M男 
		/// </summary>
		public string Sex
		{
			get { return _sex;}
			set { _sex = value;}
		}                                    
		
		/// <summary>
		/// 省ID
		/// </summary>
		public string ProvinceId
		{
			get { return _provinceId;}
			set { _provinceId = value;}
		}                                    
		
		/// <summary>
		/// 市ID
		/// </summary>
		public string RegionId
		{
			get { return _regionId;}
			set { _regionId = value;}
		}                                    
		
		/// <summary>
		/// 地区ID
		/// </summary>
		public string AreaId
		{
			get { return _areaId;}
			set { _areaId = value;}
		}                                    
		
		/// <summary>
		/// 地址
		/// </summary>
		public string AddRess
		{
			get { return _addRess;}
			set { _addRess = value;}
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
		/// 联系电话
		/// </summary>
		public string Phone
		{
			get { return _phone;}
			set { _phone = value;}
		}                                    
		
		/// <summary>
		/// EMAIL
		/// </summary>
		public string Email
		{
			get { return _email;}
			set { _email = value;}
		}                                    
		
		/// <summary>
		/// 所属诊所
		/// </summary>
		public string ClinicId
		{
			get { return _clinicId;}
			set { _clinicId = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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
		/// 最后修改时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 最后修改人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否审核 0未审核(默认) 1审核通过 2审核不通过
		/// </summary>
		public bool IsAudit
		{
			get { return _isAudit;}
			set { _isAudit = value;}
		}                                    
		
		/// <summary>
		/// 生日
		/// </summary>
		public DateTime BirthDate
		{
			get { return _birthDate;}
			set { _birthDate = value;}
		}                                    
		
		/// <summary>
		/// 所属医院
		/// </summary>
		public string Hospital
		{
			get { return _hospital;}
			set { _hospital = value;}
		}                                    
		
		/// <summary>
		/// 所属科室
		/// </summary>
		public string Department
		{
			get { return _department;}
			set { _department = value;}
		}                                    
		
	                                  
		
		/// <summary>
		/// 所属科室ID
		/// </summary>
		public string DepartmentId
		{
			get { return _departmentId;}
			set { _departmentId = value;}
		}                                    
		
		/// <summary>
		/// 所属医联体ID
		/// </summary>
		public string HospitalUnionId
		{
			get { return _hospitalUnionId;}
			set { _hospitalUnionId = value;}
		}                                    
		
		/// <summary>
		/// 职业证书
		/// </summary>
		public byte[] OccupationCertificate
		{
			get { return _occupationCertificate;}
			set { _occupationCertificate = value;}
		}                                    
		
		/// <summary>
		/// 职称聘书
		/// </summary>
		public byte[] HireCertificate
		{
			get { return _hireCertificate;}
			set { _hireCertificate = value;}
		}                                    
		        
	}  
}           


