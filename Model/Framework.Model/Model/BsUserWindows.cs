

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户常用菜单 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserWindows : BaseModel
    {    
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _menuId;  //菜单ID,对应GblSystemMenu.Id
		
		private string _name;  //窗体名称
		
		private string _caption;  //标题（即Caption）
		
		private int _HospitalID;  //

        public BsUserWindows() { }
         
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
		/// 窗体名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 标题（即Caption）
		/// </summary>
		public string Caption
		{
			get { return _caption;}
			set { _caption = value;}
		}                                    
		
	                                 
		        
	}  
}           


