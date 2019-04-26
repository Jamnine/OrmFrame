

using System;
namespace Orm.Model
{
	/// <summary>
	/// 电子病历质量评分表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InEmrScore :BaseModel
	{    
		private string _emrQcItemId;  //
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private string _emrItemScore;  //
		
		private string _emrScore;  //
		
		private bool _isScore;  //
		
		private string _partScore;  //
		
		private string _memo;  //备注
		
		private string _itemName;  //病历项目
		
		private string _groupName;  //病历模块
		
		private DateTime _operTime;  //病历评分时间
		
		private string _catalogId;  //病案类别
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InEmrScore() { }
         
		/// <summary>
		/// 
		/// </summary>
		public string EmrQcItemId
		{
			get { return _emrQcItemId;}
			set { _emrQcItemId = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string EmrItemScore
		{
			get { return _emrItemScore;}
			set { _emrItemScore = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string EmrScore
		{
			get { return _emrScore;}
			set { _emrScore = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsScore
		{
			get { return _isScore;}
			set { _isScore = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string PartScore
		{
			get { return _partScore;}
			set { _partScore = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 病历项目
		/// </summary>
		public string ItemName
		{
			get { return _itemName;}
			set { _itemName = value;}
		}                                    
		
		/// <summary>
		/// 病历模块
		/// </summary>
		public string GroupName
		{
			get { return _groupName;}
			set { _groupName = value;}
		}                                    
		
		/// <summary>
		/// 病历评分时间
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


