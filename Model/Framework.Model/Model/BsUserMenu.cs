

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户常用菜单 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserMenu:BaseModel
	{    
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _menuId;  //菜单ID,对应GblSystemMenu.Id
		
		private int _orderBy;  //排序
		
		private int _iconIndex;  //图标类型

        private int _HospitalID;//医院ID

         
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 菜单ID,对应GblSystemMenu.Id
		/// </summary>
		public string MenuId
		{
			get { return _menuId;}
			set { _menuId = value;}
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
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}

   
    }  
}           


