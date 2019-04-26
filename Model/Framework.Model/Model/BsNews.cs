

using System;
namespace Orm.Model
{
	/// <summary>
	/// 医院动态信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsNews:BaseModel
	{   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _description;  //描述
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private string _groupMian;  //一级分组

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 描述
		/// </summary>
		public string Description
		{
			get { return _description;}
			set { _description = value;}
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
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 一级分组
		/// </summary>
		public string GroupMian
		{
			get { return _groupMian;}
			set { _groupMian = value;}
		}

    }  
}           


