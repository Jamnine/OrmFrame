

using System;
namespace Orm.Model
{
	/// <summary>
	/// 球菌库 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBacteria : BaseModel
    {   
		  
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _typeId;  //病原体类别
		
		private string _gramsId;  //革兰氏染色
		
		private string _shuId;  //病原体属
		
		private string _standTypeId;  //标准分类
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private int _hoSpitalId;  //

        public BsBacteria() { }
  
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
		/// 病原体类别
		/// </summary>
		public string TypeId
		{
			get { return _typeId;}
			set { _typeId = value;}
		}                                    
		
		/// <summary>
		/// 革兰氏染色
		/// </summary>
		public string GramsId
		{
			get { return _gramsId;}
			set { _gramsId = value;}
		}                                    
		
		/// <summary>
		/// 病原体属
		/// </summary>
		public string ShuId
		{
			get { return _shuId;}
			set { _shuId = value;}
		}                                    
		
		/// <summary>
		/// 标准分类
		/// </summary>
		public string StandTypeId
		{
			get { return _standTypeId;}
			set { _standTypeId = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
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
	     
	}  
}           


