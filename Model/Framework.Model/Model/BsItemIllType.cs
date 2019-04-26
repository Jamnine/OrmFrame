

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemIllType : BaseModel
    {   
		private string _itemId;  //项目ID
		
		private string _illTypeId;  //医保种类
		
		private string _ybCode;  //医保码
		
		private int _tallyGroupId;  //医保种类

        public BsItemIllType() { }
         
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 医保种类
		/// </summary>
		public string IllTypeId
		{
			get { return _illTypeId;}
			set { _illTypeId = value;}
		}                                    
		
		/// <summary>
		/// 医保码
		/// </summary>
		public string YbCode
		{
			get { return _ybCode;}
			set { _ybCode = value;}
		}                                    
		
		/// <summary>
		/// 医保种类
		/// </summary>
		public int TallyGroupId
		{
			get { return _tallyGroupId;}
			set { _tallyGroupId = value;}
		}                                    
		        
	}  
}           


