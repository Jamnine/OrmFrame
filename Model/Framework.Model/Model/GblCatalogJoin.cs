

using System;
namespace Orm.Model
{
	/// <summary>
	/// 电子病历元素互读表 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblCatalogJoin:BaseModel
	{    
		private string _catalogId1;  //病案类别（写入）
		
		private string _xmlField1;  //字段（写入）
		
		private string _catalogId2;  //病案类别（读取）
		
		private string _xmlField2;  //字段（读取）
		
		private int _HospitalID;  //

        public GblCatalogJoin() { }
         
		/// <summary>
		/// 病案类别（写入）
		/// </summary>
		public string CatalogId1
		{
			get { return _catalogId1;}
			set { _catalogId1 = value;}
		}                                    
		
		/// <summary>
		/// 字段（写入）
		/// </summary>
		public string XmlField1
		{
			get { return _xmlField1;}
			set { _xmlField1 = value;}
		}                                    
		
		/// <summary>
		/// 病案类别（读取）
		/// </summary>
		public string CatalogId2
		{
			get { return _catalogId2;}
			set { _catalogId2 = value;}
		}                                    
		
		/// <summary>
		/// 字段（读取）
		/// </summary>
		public string XmlField2
		{
			get { return _xmlField2;}
			set { _xmlField2 = value;}
		}                                    
		
                                 
		        
	}  
}           


