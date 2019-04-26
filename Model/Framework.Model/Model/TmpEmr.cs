

using System;
namespace Orm.Model
{
	/// <summary>
	/// 诊断模板 - 实体类
	/// </summary>
	[Serializable]
	public partial class TmpEmr : BaseModel
	{   
		
		private string _useType;  //使用主题
		
		private string _code;  //快捷码
		
		private string _name;  //内容名
		
		private string _description;  //说明
		
		private int _lsOpenType;  //使用权：1-个人；2-科室；3-公共
		
		private string _operID;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _locationId;  //所属科室
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private string _parentID;  //上级词汇
		
		private string _usageId;  //用法ID
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private string _icdId;  //icd、多功能ID、
		
		private string _comboType;  //套餐类别
		
		private int _HospitalID;  //
		 
		/// <summary>
		/// 使用主题
		/// </summary>
		public string UseType
		{
			get { return _useType;}
			set { _useType = value;}
		}                                    
		
		/// <summary>
		/// 快捷码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 内容名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 说明
		/// </summary>
		public string Description
		{
			get { return _description;}
			set { _description = value;}
		}                                    
		
		/// <summary>
		/// 使用权：1-个人；2-科室；3-公共
		/// </summary>
		public int LsOpenType
		{
			get { return _lsOpenType;}
			set { _lsOpenType = value;}
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
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 上级词汇
		/// </summary>
		public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 用法ID
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
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
		/// icd、多功能ID、
		/// </summary>
		public string IcdId
		{
			get { return _icdId;}
			set { _icdId = value;}
		}                                    
		
		/// <summary>
		/// 套餐类别
		/// </summary>
		public string ComboType
		{
			get { return _comboType;}
			set { _comboType = value;}
		}                                    
		                                 
		        
	}  
}           


