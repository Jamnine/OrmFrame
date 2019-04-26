

using System;
namespace XYHis.Model
{
	/// <summary>
	///  - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblEMRQcGroup : BaseModel
    {   
		
		private int _id;  //
		
		private string _code;  //
		
		private string _name;  //
		
		private int _point;  //
		
		private string _pyCode;  //
		
		private string _wbCode;  //
		
		private int _orderBy;  //
		
		private bool _isActive;  //
		
		private int _iconIndex;  //
		
		private string _memo;  //
		
		private int _catalogId;  //
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Point
		{
			get { return _point;}
			set { _point = value;}
		}                                    
		
		/// <summary>
		/// 
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
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
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
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


