

using System;
namespace XYHis.Model
{
	/// <summary>
	///  - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblNavigationRole : BaseModel
    {   
		
		private int _id;  //
		
		private int _navigationId;  //向导图
		
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
		/// 向导图
		/// </summary>
		public int NavigationId
		{
			get { return _navigationId;}
			set { _navigationId = value;}
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


