

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class GblCatalogExcept:BaseModel
	{   
		 
		private string _catalogId;  //病案类别
		
		private string _xmlField;  //字段
		
		private bool _isHide;  //是否隐藏
		
		private string _defaultValue;  //默认值
		
		private bool _isBaby;  //儿童专用
		
		private bool _isWomen;  //妇女专用
		
		private bool _isMen;  //男性专用
		
		private bool _isOlder;  //老人专用
		
		private string _memo;  //特殊情况专用
		
		private int _HospitalID;  //

        public GblCatalogExcept() { }
         
		/// <summary>
		/// 病案类别
		/// </summary>
		public string CatalogId
		{
			get { return _catalogId;}
			set { _catalogId = value;}
		}                                    
		
		/// <summary>
		/// 字段
		/// </summary>
		public string XmlField
		{
			get { return _xmlField;}
			set { _xmlField = value;}
		}                                    
		
		/// <summary>
		/// 是否隐藏
		/// </summary>
		public bool IsHide
		{
			get { return _isHide;}
			set { _isHide = value;}
		}                                    
		
		/// <summary>
		/// 默认值
		/// </summary>
		public string DefaultValue
		{
			get { return _defaultValue;}
			set { _defaultValue = value;}
		}                                    
		
		/// <summary>
		/// 儿童专用
		/// </summary>
		public bool IsBaby
		{
			get { return _isBaby;}
			set { _isBaby = value;}
		}                                    
		
		/// <summary>
		/// 妇女专用
		/// </summary>
		public bool IsWomen
		{
			get { return _isWomen;}
			set { _isWomen = value;}
		}                                    
		
		/// <summary>
		/// 男性专用
		/// </summary>
		public bool IsMen
		{
			get { return _isMen;}
			set { _isMen = value;}
		}                                    
		
		/// <summary>
		/// 老人专用
		/// </summary>
		public bool IsOlder
		{
			get { return _isOlder;}
			set { _isOlder = value;}
		}                                    
		
		/// <summary>
		/// 特殊情况专用
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
                                 
		        
	}  
}           


