

using System;
namespace Orm.Model
{
	/// <summary>
	/// 手术项目 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsOpsItem:BaseModel
	{   
		 
		private string _opsItem;  //手术项目
		
		private string _itemId;  //项目ID
		
		private int _iconIndex;  //图标类型


        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 手术项目
		/// </summary>
		public string OpsItem
		{
			get { return _opsItem;}
			set { _opsItem = value;}
		}                                    
		
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
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


