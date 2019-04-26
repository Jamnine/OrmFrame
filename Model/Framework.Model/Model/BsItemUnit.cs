

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应单位 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemUnit : BaseModel
	{    
		private string _itemId;  //项目
		
		private string _unitId;  //单位
		
		private bool _isForYk;  //是否适用于药库
		
		private bool _isForYf;  //是否适用于药房
		
		private bool _isForRecipe;  //是否适用于处方
		
		private int _iconIndex;  //图标类型

        public BsItemUnit() { }
         
		/// <summary>
		/// 项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 是否适用于药库
		/// </summary>
		public bool IsForYk
		{
			get { return _isForYk;}
			set { _isForYk = value;}
		}                                    
		
		/// <summary>
		/// 是否适用于药房
		/// </summary>
		public bool IsForYf
		{
			get { return _isForYf;}
			set { _isForYf = value;}
		}                                    
		
		/// <summary>
		/// 是否适用于处方
		/// </summary>
		public bool IsForRecipe
		{
			get { return _isForRecipe;}
			set { _isForRecipe = value;}
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


