

using System;
namespace Orm.Model
{
	/// <summary>
	/// 基本药物库 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemBasic : BaseModel
	{   
		 
		private string _itemId;  //项目ID
		
		private bool _isInOut;  //1门诊0住院
		
		private bool _isActive;  //1启用，0禁用
		
		private int _orderBy;  //排序
		
		private int _HospitalID;  //

        public BsItemBasic() { }
 
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 1门诊0住院
		/// </summary>
		public bool IsInOut
		{
			get { return _isInOut;}
			set { _isInOut = value;}
		}                                    
		
		/// <summary>
		/// 1启用，0禁用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


