

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目排斥表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemItem : BaseModel
    {   
		 
		private string _itemId1;  //项目1
		
		private string _itemId2;  //项目2
		
		private bool _isReject;  //1-互相排斥；0-提示应该同时
		
		private int _iconIndex;  //图标类型

        public BsItemItem() { }
         
		/// <summary>
		/// 项目1
		/// </summary>
		public string ItemId1
		{
			get { return _itemId1;}
			set { _itemId1 = value;}
		}                                    
		
		/// <summary>
		/// 项目2
		/// </summary>
		public string ItemId2
		{
			get { return _itemId2;}
			set { _itemId2 = value;}
		}                                    
		
		/// <summary>
		/// 1-互相排斥；0-提示应该同时
		/// </summary>
		public bool IsReject
		{
			get { return _isReject;}
			set { _isReject = value;}
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


