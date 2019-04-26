

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户角色 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserRole : BaseModel
    {    
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _roleId;  //角色ID,对应GblRole.Id
		
		private int _iconIndex;  //图标类型
		
		private DateTime _limitDate;  //权限终止日期
		
		private string _modioperId;  //行心云:最后修改人
		
		private DateTime _moditime;  //行心云:最后修改时间
		
		private int _HospitalID;  //

        public BsUserRole() { }
         
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 角色ID,对应GblRole.Id
		/// </summary>
		public string RoleId
		{
			get { return _roleId;}
			set { _roleId = value;}
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
		/// 权限终止日期
		/// </summary>
		public DateTime LimitDate
		{
			get { return _limitDate;}
			set { _limitDate = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioperId
		{
			get { return _modioperId;}
			set { _modioperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime Moditime
		{
			get { return _moditime;}
			set { _moditime = value;}
		}                                    
		
	                                    
		        
	}  
}           


