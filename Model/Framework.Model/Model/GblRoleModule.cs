

using System;
namespace Orm.Model
{
	/// <summary>
	/// 角色权限 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblRoleModule : BaseModel
    {   
		private string _roleId;  //角色ID
		
		private string _moduleId;  //对应菜单功能ID
		
		private int _iconIndex;  //图标类型
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间

        private int _HospitalID;   //
		 
		/// <summary>
		/// 角色ID
		/// </summary>
		public string RoleId
		{
			get { return _roleId;}
			set { _roleId = value;}
		}                                    
		
		/// <summary>
		/// 对应菜单功能ID
		/// </summary>
		public string ModuleId
		{
			get { return _moduleId;}
			set { _moduleId = value;}
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
		/// 行心云:最后修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
    }  
}           


