

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsMessageTemplate:BaseModel
	{   
		 
		private string _name;  //模板名称
		
		private string _contents;  //模板内容
		
		private string _parentID;  //父级ID
		
		private string _operID;  //操作员ID
		
		private DateTime _operTime;  //操作时间
		
		private bool _isDefault;  //是否默认
		
		private bool _isActive;  //是否有效标识 

        private int _HospitalID;//医院ID 
         
		/// <summary>
		/// 模板名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 模板内容
		/// </summary>
		public string Contents
		{
			get { return _contents;}
			set { _contents = value;}
		}                                    
		
		/// <summary>
		/// 父级ID
		/// </summary>
		public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 是否默认
		/// </summary>
		public bool IsDefault
		{
			get { return _isDefault;}
			set { _isDefault = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}
   
    }  
}           


