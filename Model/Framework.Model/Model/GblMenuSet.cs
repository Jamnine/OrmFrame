

using System;
namespace Orm.Model
{
	/// <summary>
	/// 系统菜单对应参数 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblMenuSet : BaseModel
    {    
		
		private string _menuId;  //对应Ggblsystemmenu.Id
		
		private string _settingId;  //对应gblsetting.Id
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 对应Ggblsystemmenu.Id
		/// </summary>
		public string MenuId
		{
			get { return _menuId;}
			set { _menuId = value;}
		}                                    
		
		/// <summary>
		/// 对应gblsetting.Id
		/// </summary>
		public string SettingId
		{
			get { return _settingId;}
			set { _settingId = value;}
		}                                    
		                                 
		        
	}  
}           


