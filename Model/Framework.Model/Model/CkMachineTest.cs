

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMachineTest : BaseModel
    {   
		 
		private string _dictTestid;  //检验项ID，系统内码
		
		private string _wbm;  //
		
		private string _pym;  //
		
		private string _testCode;  //检验项编码
		
		private string _engShortName;  //英文缩写
		
		private string _engLongName;  //
		
		private string _testName;  //
		
		private string _printName;  //
		
		private string _unit;  //
		
		private int _displayOrder;  //
		
		private int _precision;  //Precision
		
		private string _refMethod;  //参考值方式：<10,<=10,>20,1-20等等
		
		private string _deltaCheckType;  //
		
		private int _deltaCheckValue;  //设定对比的值
		
		private int _keepStorageDay;  //标本保存时间，单位：天"
		
		private int _price;  //
		
		private string _resultType;  //结果类型0-定量1-定性2-列表选择
		
		private string _resultTips;  //结果提示类型箭头/阴阳性
		
		private string _defaultResult;  //
		
		private string _forSex;  //
		
		private string _printAlias;  //此项目在条码打印时的别名
		
		private string _clinicRemark;  //
		
		private string _operationComment;  //分管原则，对应表dictLibrary
		
		private string _remark;  //
		
		private bool _isCaculateItem;  //
		
		private bool _isSendoutItem;  //
		
		private bool _isPrivacy;  //
		
		private bool _isImportantItem;  //
		
		private bool _isSpecialItem;  //
		
		private bool _isActive;  //
		
		private DateTime _createDate;  //
		
		private string _dictResultOptionid;  //[结果录入方式，对应表dictLibrary]
		
		private string _dictTestMethodid;  //检验方法，对应表dictLibrary
		
		private string _dictTubeGroupid;  //
		
		private string _dictContainerid;  //容器类型，对应表dictLibrary
		
		private string _dictSpecimenTypeid;  //标本类型，对应表dictLibrary
		
		private string _dictMedicalTypeid;  //医学专业组，对应表dictLibrary
		
		private string _dictLabDeptid;  //实验室部门分组，对应表dictLibrary"
		
		private bool _isGroup;  //
		
		private bool _isReport;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 检验项ID，系统内码
		/// </summary>
		public string DictTestid
		{
			get { return _dictTestid;}
			set { _dictTestid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Wbm
		{
			get { return _wbm;}
			set { _wbm = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Pym
		{
			get { return _pym;}
			set { _pym = value;}
		}                                    
		
		/// <summary>
		/// 检验项编码
		/// </summary>
		public string TestCode
		{
			get { return _testCode;}
			set { _testCode = value;}
		}                                    
		
		/// <summary>
		/// 英文缩写
		/// </summary>
		public string EngShortName
		{
			get { return _engShortName;}
			set { _engShortName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string EngLongName
		{
			get { return _engLongName;}
			set { _engLongName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TestName
		{
			get { return _testName;}
			set { _testName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string PrintName
		{
			get { return _printName;}
			set { _printName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Unit
		{
			get { return _unit;}
			set { _unit = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int DisplayOrder
		{
			get { return _displayOrder;}
			set { _displayOrder = value;}
		}                                    
		
		/// <summary>
		/// Precision
		/// </summary>
		public int Precision
		{
			get { return _precision;}
			set { _precision = value;}
		}                                    
		
		/// <summary>
		/// 参考值方式：<10,<=10,>20,1-20等等
		/// </summary>
		public string RefMethod
		{
			get { return _refMethod;}
			set { _refMethod = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DeltaCheckType
		{
			get { return _deltaCheckType;}
			set { _deltaCheckType = value;}
		}                                    
		
		/// <summary>
		/// 设定对比的值
		/// </summary>
		public int DeltaCheckValue
		{
			get { return _deltaCheckValue;}
			set { _deltaCheckValue = value;}
		}                                    
		
		/// <summary>
		/// 标本保存时间，单位：天"
		/// </summary>
		public int KeepStorageDay
		{
			get { return _keepStorageDay;}
			set { _keepStorageDay = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Price
		{
			get { return _price;}
			set { _price = value;}
		}                                    
		
		/// <summary>
		/// 结果类型0-定量1-定性2-列表选择
		/// </summary>
		public string ResultType
		{
			get { return _resultType;}
			set { _resultType = value;}
		}                                    
		
		/// <summary>
		/// 结果提示类型箭头/阴阳性
		/// </summary>
		public string ResultTips
		{
			get { return _resultTips;}
			set { _resultTips = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DefaultResult
		{
			get { return _defaultResult;}
			set { _defaultResult = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ForSex
		{
			get { return _forSex;}
			set { _forSex = value;}
		}                                    
		
		/// <summary>
		/// 此项目在条码打印时的别名
		/// </summary>
		public string PrintAlias
		{
			get { return _printAlias;}
			set { _printAlias = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ClinicRemark
		{
			get { return _clinicRemark;}
			set { _clinicRemark = value;}
		}                                    
		
		/// <summary>
		/// 分管原则，对应表dictLibrary
		/// </summary>
		public string OperationComment
		{
			get { return _operationComment;}
			set { _operationComment = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsCaculateItem
		{
			get { return _isCaculateItem;}
			set { _isCaculateItem = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSendoutItem
		{
			get { return _isSendoutItem;}
			set { _isSendoutItem = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsPrivacy
		{
			get { return _isPrivacy;}
			set { _isPrivacy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsImportantItem
		{
			get { return _isImportantItem;}
			set { _isImportantItem = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSpecialItem
		{
			get { return _isSpecialItem;}
			set { _isSpecialItem = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			get { return _createDate;}
			set { _createDate = value;}
		}                                    
		
		/// <summary>
		/// [结果录入方式，对应表dictLibrary]
		/// </summary>
		public string DictResultOptionid
		{
			get { return _dictResultOptionid;}
			set { _dictResultOptionid = value;}
		}                                    
		
		/// <summary>
		/// 检验方法，对应表dictLibrary
		/// </summary>
		public string DictTestMethodid
		{
			get { return _dictTestMethodid;}
			set { _dictTestMethodid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DictTubeGroupid
		{
			get { return _dictTubeGroupid;}
			set { _dictTubeGroupid = value;}
		}                                    
		
		/// <summary>
		/// 容器类型，对应表dictLibrary
		/// </summary>
		public string DictContainerid
		{
			get { return _dictContainerid;}
			set { _dictContainerid = value;}
		}                                    
		
		/// <summary>
		/// 标本类型，对应表dictLibrary
		/// </summary>
		public string DictSpecimenTypeid
		{
			get { return _dictSpecimenTypeid;}
			set { _dictSpecimenTypeid = value;}
		}                                    
		
		/// <summary>
		/// 医学专业组，对应表dictLibrary
		/// </summary>
		public string DictMedicalTypeid
		{
			get { return _dictMedicalTypeid;}
			set { _dictMedicalTypeid = value;}
		}                                    
		
		/// <summary>
		/// 实验室部门分组，对应表dictLibrary"
		/// </summary>
		public string DictLabDeptid
		{
			get { return _dictLabDeptid;}
			set { _dictLabDeptid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsGroup
		{
			get { return _isGroup;}
			set { _isGroup = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsReport
		{
			get { return _isReport;}
			set { _isReport = value;}
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


