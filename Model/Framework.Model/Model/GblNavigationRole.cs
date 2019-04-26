

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class GblNavigationRole : BaseModel
    {    
		private string _navigationId;  //向导图
		
		private string _roleId;  //角色权限
		
		private int _HospitalID;  //
		                           
		
		/// <summary>
		/// 向导图
		/// </summary>
		public string NavigationId
		{
			get { return _navigationId;}
			set { _navigationId = value;}
		}                                    
		
		/// <summary>
		/// 角色权限
		/// </summary>
		public string RoleId
		{
			get { return _roleId;}
			set { _roleId = value;}
		}                                    
		                                  
		        
	}  
}           


