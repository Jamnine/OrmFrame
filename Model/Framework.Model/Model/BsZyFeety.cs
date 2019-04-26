

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院基础分类 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsZyFeety : BaseModel
    {   
		 
		private string _code;  //住院基础分类ID
		
		private string _name;  //住院基础分类
		
		private string _invItemId;  //发票项目ID
		
		private string _pyCode;  //拼单码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private string _checkType;  //核算分类
		
		private int _checkOrderby;  //核算分类显示顺序
		
		private string _checkGroup;  //核算分类分组
		
		private int _HospitalID;  //

        public BsZyFeety() { }
         
		/// <summary>
		/// 住院基础分类ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 住院基础分类
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 发票项目ID
		/// </summary>
		public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
		}                                    
		
		/// <summary>
		/// 拼单码
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
		/// 排序
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
		/// 核算分类
		/// </summary>
		public string CheckType
		{
			get { return _checkType;}
			set { _checkType = value;}
		}                                    
		
		/// <summary>
		/// 核算分类显示顺序
		/// </summary>
		public int CheckOrderby
		{
			get { return _checkOrderby;}
			set { _checkOrderby = value;}
		}                                    
		
		/// <summary>
		/// 核算分类分组
		/// </summary>
		public string CheckGroup
		{
			get { return _checkGroup;}
			set { _checkGroup = value;}
		}                                    
		
                                   
		        
	}  
}           


