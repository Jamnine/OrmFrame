

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 系统菜单对应参数 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblMenuSet : BaseModel
    {   
		
		
		
		private int _menuId;  //对应Ggblsystemmenu.Id
		
		private int _settingId;  //对应gblsetting.Id
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 对应Ggblsystemmenu.Id
		/// </summary>
		public int MenuId
		{
			get { return _menuId;}
			set { _menuId = value;}
		}                                    
		
		/// <summary>
		/// 对应gblsetting.Id
		/// </summary>
		public int SettingId
		{
			get { return _settingId;}
			set { _settingId = value;}
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


