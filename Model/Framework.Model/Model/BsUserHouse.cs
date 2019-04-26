

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户对应仓库 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserHouse:BaseModel
	{   
		 
		private string _operId;  //用户名
		
		private string _houseId;  //所属药库
		
		private int _iconIndex;  //图标类型

        private int _HospitalID;//医院ID

                                    
		
		/// <summary>
		/// 用户名
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 所属药库
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
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


