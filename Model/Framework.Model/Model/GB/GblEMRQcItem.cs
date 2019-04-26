

using System;
namespace XYHis.Model
{
	/// <summary>
	///  - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblEMRQcItem : BaseModel
    {   
		
		
		
		private int _groupID;  //质量项目
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _standard;  //标准
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //
		
		private int _orderBy;  //
		
		private bool _isActive;  //
		
		private int _iconIndex;  //
		
		private int _fullPoint;  //
		
		private int _failPoint;  //
		
		private int _lsImportant;  //
		
		private bool _isLock;  //
		
		private string _tipInfo;  //
		
		private int _catalogId;  //
		
		private string _memo;  //
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 质量项目
		/// </summary>
		public int GroupID
		{
			get { return _groupID;}
			set { _groupID = value;}
		}                                    
		
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
		/// 标准
		/// </summary>
		public string Standard
		{
			get { return _standard;}
			set { _standard = value;}
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
		/// 
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int FullPoint
		{
			get { return _fullPoint;}
			set { _fullPoint = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int FailPoint
		{
			get { return _failPoint;}
			set { _failPoint = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsImportant
		{
			get { return _lsImportant;}
			set { _lsImportant = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsLock
		{
			get { return _isLock;}
			set { _isLock = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TipInfo
		{
			get { return _tipInfo;}
			set { _tipInfo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int CatalogId
		{
			get { return _catalogId;}
			set { _catalogId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


