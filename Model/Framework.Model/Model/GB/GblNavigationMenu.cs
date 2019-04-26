

using System;
namespace XYHis.Model
{
	/// <summary>
	///  - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblNavigationMenu : BaseModel
    {   
		
		private int _id;  //
		
		private string _name;  //名称
		
		private string _hint;  //提示
		
		private int _navigationId;  //向导图ID
		
		private int _menuId;  //系统菜单
		
		private string _imageName;  //图片路径
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //可用
		
		private int _iconIndex;  //
		
		private int _roleId;  //角色权限
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
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
		/// 提示
		/// </summary>
		public string Hint
		{
			get { return _hint;}
			set { _hint = value;}
		}                                    
		
		/// <summary>
		/// 向导图ID
		/// </summary>
		public int NavigationId
		{
			get { return _navigationId;}
			set { _navigationId = value;}
		}                                    
		
		/// <summary>
		/// 系统菜单
		/// </summary>
		public int MenuId
		{
			get { return _menuId;}
			set { _menuId = value;}
		}                                    
		
		/// <summary>
		/// 图片路径
		/// </summary>
		public string ImageName
		{
			get { return _imageName;}
			set { _imageName = value;}
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
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 角色权限
		/// </summary>
		public int RoleId
		{
			get { return _roleId;}
			set { _roleId = value;}
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


