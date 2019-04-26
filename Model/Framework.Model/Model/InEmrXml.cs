

using System;
namespace Orm.Model
{
	/// <summary>
	/// 电子病历元素内容信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class InEmrXml : BaseModel
	{   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private DateTime _operTime;  //创建时间
		
		private string _catalogId;  //病案类别
		
		private string _xmlField;  //元素名
		
		private string _xmlValue;  //元素值
		
		private string _inEmrId;  //电子病历ID,InEmr.Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InEmrXml() { }
         
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 病案类别
		/// </summary>
		public string CatalogId
		{
			get { return _catalogId;}
			set { _catalogId = value;}
		}                                    
		
		/// <summary>
		/// 元素名
		/// </summary>
		public string XmlField
		{
			get { return _xmlField;}
			set { _xmlField = value;}
		}                                    
		
		/// <summary>
		/// 元素值
		/// </summary>
		public string XmlValue
		{
			get { return _xmlValue;}
			set { _xmlValue = value;}
		}                                    
		
		/// <summary>
		/// 电子病历ID,InEmr.Id
		/// </summary>
		public string InEmrId
		{
			get { return _inEmrId;}
			set { _inEmrId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
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


