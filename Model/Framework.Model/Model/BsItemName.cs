

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应多个名称 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemName : BaseModel
    {   
		 
		private string _itemId;  //项目
		
		private string _name;  //名称

        public BsItemName() { }
         
		/// <summary>
		/// 项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		        
	}  
}           


