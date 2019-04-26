

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgDayGroup:BaseModel
	{    
		private string _code;  //
		
		private string _name;  //
		
		private int _iconIndex;  //
		
		private int _days;  //
		
		private string _dgRoadId;  //
		
		private int _pageNum;  //
		
		private int _columnNum;  //
		
		private int _eedDays;  //
		
		private int _lsTimeType;  //
		 
         
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
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DgRoadId
		{
			get { return _dgRoadId;}
			set { _dgRoadId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int PageNum
		{
			get { return _pageNum;}
			set { _pageNum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int ColumnNum
		{
			get { return _columnNum;}
			set { _columnNum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int EedDays
		{
			get { return _eedDays;}
			set { _eedDays = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsTimeType
		{
			get { return _lsTimeType;}
			set { _lsTimeType = value;}
		}                                    
		        
	}  
}           


