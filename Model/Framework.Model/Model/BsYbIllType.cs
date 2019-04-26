

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsYbIllType : BaseModel
    {   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private bool _isGf;  //是否公费
		
		private bool _isYb;  //是否医保
		
		private string _ybHospNo;  //
		
		private int _HospitalID;  //

        public BsYbIllType() { }
                                
		
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
		
		/// <summary>
		/// 是否公费
		/// </summary>
		public bool IsGf
		{
			get { return _isGf;}
			set { _isGf = value;}
		}                                    
		
		/// <summary>
		/// 是否医保
		/// </summary>
		public bool IsYb
		{
			get { return _isYb;}
			set { _isYb = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string YbHospNo
		{
			get { return _ybHospNo;}
			set { _ybHospNo = value;}
		}                                    
		
	                                 
		        
	}  
}           


