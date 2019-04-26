

using System;
namespace Orm.Model
{
	/// <summary>
	/// 关键元素快捷录入 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblCatalogKey:BaseModel
	{    
		private string _catalogId;  //病案类别
		
		private string _xmlField;  //字段
		
		private string _keyFile;  //关键词模板路径
		
		private string _tmpWord;  //
		
		private int _HospitalID;  //

        public GblCatalogKey() { }
         
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
		/// 关键词模板路径
		/// </summary>
		public string KeyFile
		{
			get { return _keyFile;}
			set { _keyFile = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TmpWord
		{
			get { return _tmpWord;}
			set { _tmpWord = value;}
		}                                    
		
                                
		        
	}  
}           


