

using System;
namespace Orm.Model
{
	/// <summary>
	/// 基础表维护对应角色 - 实体类
	/// </summary>
	[Serializable]
	public partial class BaseTableRole : BaseModel
    {   
		
		private string _baseTableId;  //基本维护表id对应GblBaseTableItem.id
		
		private string _roleId;  //角色id对应gblRole.id
		
		private string _hoSpitalId;  //

        public BaseTableRole() { }


                                       
		
		/// <summary>
		/// 基本维护表id对应GblBaseTableItem.id
		/// </summary>
		public string BaseTableId
		{
			get { return _baseTableId;}
			set { _baseTableId = value;}
		}                                    
		
		/// <summary>
		/// 角色id对应gblRole.id
		/// </summary>
		public string RoleId
		{
			get { return _roleId;}
			set { _roleId = value;}
		}                                    
		
         
    }  
}           


