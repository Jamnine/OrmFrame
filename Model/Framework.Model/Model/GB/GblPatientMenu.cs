

using System;
namespace XYHis.Model
{
	/// <summary>
	///  - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblPatientMenu : BaseModel
    {   
		
		
		
		private int _lsType;  //档案类别：1-基础档案；2-儿童保健；3-妇女保健；4-障碍者/残疾人；5-老人保健；6-慢性非传染性疾病；7-特殊传染病
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private int _parentID;  //父ID
		
		private bool _isTitle;  //是否分类标题
		
		private string _formName;  //表单名称
		
		private string _tableName;  //表格名称
		
		private bool _isForNew;  //是否在菜单直接新增
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private bool _isAuth;  //需要审核
		
		private bool _isPrint;  //是否需要打印
		
		private string _searchConfig;  //
		
		private string _fileEmt;  //Emt文件名
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 档案类别：1-基础档案；2-儿童保健；3-妇女保健；4-障碍者/残疾人；5-老人保健；6-慢性非传染性疾病；7-特殊传染病
		/// </summary>
		public int LsType
		{
			get { return _lsType;}
			set { _lsType = value;}
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
		/// 父ID
		/// </summary>
		public int ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 是否分类标题
		/// </summary>
		public bool IsTitle
		{
			get { return _isTitle;}
			set { _isTitle = value;}
		}                                    
		
		/// <summary>
		/// 表单名称
		/// </summary>
		public string FormName
		{
			get { return _formName;}
			set { _formName = value;}
		}                                    
		
		/// <summary>
		/// 表格名称
		/// </summary>
		public string TableName
		{
			get { return _tableName;}
			set { _tableName = value;}
		}                                    
		
		/// <summary>
		/// 是否在菜单直接新增
		/// </summary>
		public bool IsForNew
		{
			get { return _isForNew;}
			set { _isForNew = value;}
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
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 需要审核
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 是否需要打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SearchConfig
		{
			get { return _searchConfig;}
			set { _searchConfig = value;}
		}                                    
		
		/// <summary>
		/// Emt文件名
		/// </summary>
		public string FileEmt
		{
			get { return _fileEmt;}
			set { _fileEmt = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


