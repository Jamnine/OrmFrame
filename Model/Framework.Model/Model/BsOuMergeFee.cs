

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsOuMergeFee : BaseModel
	{   
		 
		private int _patTypeId;  //病人类别
		
		private string _itemId1;  //合并前项目
		
		private string _itemId2;  //合并后项目
		
		private int _iconIndex;  //图标类型
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 病人类别
		/// </summary>
		public int PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 合并前项目
		/// </summary>
		public string ItemId1
		{
			get { return _itemId1;}
			set { _itemId1 = value;}
		}                                    
		
		/// <summary>
		/// 合并后项目
		/// </summary>
		public string ItemId2
		{
			get { return _itemId2;}
			set { _itemId2 = value;}
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


