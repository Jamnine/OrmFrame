

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应多个名称 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemNameMulti : BaseModel
    {    
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _nameMulti;  //名称
		
		private string _wbMulti;  //五笔码
		
		private string _pyMulti;  //拼音码

        public BsItemNameMulti() { }
         
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string NameMulti
		{
			get { return _nameMulti;}
			set { _nameMulti = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbMulti
		{
			get { return _wbMulti;}
			set { _wbMulti = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyMulti
		{
			get { return _pyMulti;}
			set { _pyMulti = value;}
		}                                    
		        
	}  
}           


