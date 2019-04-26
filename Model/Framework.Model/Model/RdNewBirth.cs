

using System;
namespace Orm.Model
{
	/// <summary>
	/// 新生儿登记 - 实体类
	/// </summary>
	[Serializable]
	public partial class RdNewBirth : BaseModel
    {   
		
		
		
		private string _patId;  //病人ID,对应BsPatient.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _operID;  //操作员ID,BsUser.Id
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _provinceId;  //省
		
		private string _regionId;  //城市
		
		private string _areaId;  //区
		
		private string _committeeId;  //所在居委会
		
		private string _familyId;  //所在家庭
		
		private int _lsStatus;  //健康状况：1-良好；2-一般；3-差
		
		private int _weight;  //体重
		
		private int _height;  //身高
		
		private string _motherName;  //母亲
		
		private string _fatherName;  //父亲
		
		private int _lsBornPlace;  //出生地点：1-医院；2-妇幼保健院；3-家庭；4-其他
		
		private string _otherPlace;  //其他出生地点
		
		private string _deliverOrgan;  //接生机构
		
		private string _signOrgan;  //签发机构
		
		private DateTime _signDate;  //签发日期
		
		private string _midwife;  //接生人员
		
		private bool _isDanger;  //高危儿
		
		private bool _isCure;  //是否已治愈
		
		private bool _isFilter;  //是否做新生儿筛选
		
		private string _childBirthId;  //分娩记录ID
		
		private string _motherAge;  //母亲年龄
		
		private string _motherIdCard;  //母亲身份证号
		
		private string _motherNation;  //母亲民簇
		
		private string _motherCountry;  //母亲国籍
		
		private string _fatherIdCard;  //父亲身份证号
		
		private string _weeks;  //周期
		
		private string _fatherAge;  //父亲年龄
		
		private string _fatherCountryid;  //父亲国家
		
		private string _fathernationid;  //父亲民簇
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private int _birthResult;  //出生结果
		
		private int _birthStyle;  //出生样式
		
		private int _birthStifle;  //
		
		private int _bornWay;  //出生方式:1顺产0剖腹产
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
        public RdNewBirth() { }
                             
		
		/// <summary>
		/// 病人ID,对应BsPatient.Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
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
		/// 省
		/// </summary>
		public string ProvinceId
		{
			get { return _provinceId;}
			set { _provinceId = value;}
		}                                    
		
		/// <summary>
		/// 城市
		/// </summary>
		public string RegionId
		{
			get { return _regionId;}
			set { _regionId = value;}
		}                                    
		
		/// <summary>
		/// 区
		/// </summary>
		public string AreaId
		{
			get { return _areaId;}
			set { _areaId = value;}
		}                                    
		
		/// <summary>
		/// 所在居委会
		/// </summary>
		public string CommitteeId
		{
			get { return _committeeId;}
			set { _committeeId = value;}
		}                                    
		
		/// <summary>
		/// 所在家庭
		/// </summary>
		public string FamilyId
		{
			get { return _familyId;}
			set { _familyId = value;}
		}                                    
		
		/// <summary>
		/// 健康状况：1-良好；2-一般；3-差
		/// </summary>
		public int LsStatus
		{
			get { return _lsStatus;}
			set { _lsStatus = value;}
		}                                    
		
		/// <summary>
		/// 体重
		/// </summary>
		public int Weight
		{
			get { return _weight;}
			set { _weight = value;}
		}                                    
		
		/// <summary>
		/// 身高
		/// </summary>
		public int Height
		{
			get { return _height;}
			set { _height = value;}
		}                                    
		
		/// <summary>
		/// 母亲
		/// </summary>
		public string MotherName
		{
			get { return _motherName;}
			set { _motherName = value;}
		}                                    
		
		/// <summary>
		/// 父亲
		/// </summary>
		public string FatherName
		{
			get { return _fatherName;}
			set { _fatherName = value;}
		}                                    
		
		/// <summary>
		/// 出生地点：1-医院；2-妇幼保健院；3-家庭；4-其他
		/// </summary>
		public int LsBornPlace
		{
			get { return _lsBornPlace;}
			set { _lsBornPlace = value;}
		}                                    
		
		/// <summary>
		/// 其他出生地点
		/// </summary>
		public string OtherPlace
		{
			get { return _otherPlace;}
			set { _otherPlace = value;}
		}                                    
		
		/// <summary>
		/// 接生机构
		/// </summary>
		public string DeliverOrgan
		{
			get { return _deliverOrgan;}
			set { _deliverOrgan = value;}
		}                                    
		
		/// <summary>
		/// 签发机构
		/// </summary>
		public string SignOrgan
		{
			get { return _signOrgan;}
			set { _signOrgan = value;}
		}                                    
		
		/// <summary>
		/// 签发日期
		/// </summary>
		public DateTime SignDate
		{
			get { return _signDate;}
			set { _signDate = value;}
		}                                    
		
		/// <summary>
		/// 接生人员
		/// </summary>
		public string Midwife
		{
			get { return _midwife;}
			set { _midwife = value;}
		}                                    
		
		/// <summary>
		/// 高危儿
		/// </summary>
		public bool IsDanger
		{
			get { return _isDanger;}
			set { _isDanger = value;}
		}                                    
		
		/// <summary>
		/// 是否已治愈
		/// </summary>
		public bool IsCure
		{
			get { return _isCure;}
			set { _isCure = value;}
		}                                    
		
		/// <summary>
		/// 是否做新生儿筛选
		/// </summary>
		public bool IsFilter
		{
			get { return _isFilter;}
			set { _isFilter = value;}
		}                                    
		
		/// <summary>
		/// 分娩记录ID
		/// </summary>
		public string ChildBirthId
		{
			get { return _childBirthId;}
			set { _childBirthId = value;}
		}                                    
		
		/// <summary>
		/// 母亲年龄
		/// </summary>
		public string MotherAge
		{
			get { return _motherAge;}
			set { _motherAge = value;}
		}                                    
		
		/// <summary>
		/// 母亲身份证号
		/// </summary>
		public string MotherIdCard
		{
			get { return _motherIdCard;}
			set { _motherIdCard = value;}
		}                                    
		
		/// <summary>
		/// 母亲民簇
		/// </summary>
		public string MotherNation
		{
			get { return _motherNation;}
			set { _motherNation = value;}
		}                                    
		
		/// <summary>
		/// 母亲国籍
		/// </summary>
		public string MotherCountry
		{
			get { return _motherCountry;}
			set { _motherCountry = value;}
		}                                    
		
		/// <summary>
		/// 父亲身份证号
		/// </summary>
		public string FatherIdCard
		{
			get { return _fatherIdCard;}
			set { _fatherIdCard = value;}
		}                                    
		
		/// <summary>
		/// 周期
		/// </summary>
		public string Weeks
		{
			get { return _weeks;}
			set { _weeks = value;}
		}                                    
		
		/// <summary>
		/// 父亲年龄
		/// </summary>
		public string FatherAge
		{
			get { return _fatherAge;}
			set { _fatherAge = value;}
		}                                    
		
		/// <summary>
		/// 父亲国家
		/// </summary>
		public string FatherCountryid
		{
			get { return _fatherCountryid;}
			set { _fatherCountryid = value;}
		}                                    
		
		/// <summary>
		/// 父亲民簇
		/// </summary>
		public string Fathernationid
		{
			get { return _fathernationid;}
			set { _fathernationid = value;}
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
		/// 出生结果
		/// </summary>
		public int BirthResult
		{
			get { return _birthResult;}
			set { _birthResult = value;}
		}                                    
		
		/// <summary>
		/// 出生样式
		/// </summary>
		public int BirthStyle
		{
			get { return _birthStyle;}
			set { _birthStyle = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int BirthStifle
		{
			get { return _birthStifle;}
			set { _birthStifle = value;}
		}                                    
		
		/// <summary>
		/// 出生方式:1顺产0剖腹产
		/// </summary>
		public int BornWay
		{
			get { return _bornWay;}
			set { _bornWay = value;}
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


