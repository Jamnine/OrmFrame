

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class HustoresDays:BaseModel
	{    
		private DateTime _stockTime;  //
		
		private string _stockID;  //
		
		private string _houseId;  //
		
		private string _itemId;  //
		
		private string _unitid;  //
		
		private string _compId;  //
		
		private double _stockPrice;  //
		
		private double _retailPrice;  //
		
		private double _stockNum;  //
		
		private string _isBid;  //
		
		private bool _isInject;  //
		
		private bool _optionPrice;  //
		
		private bool _isSpecSum;  //
		
		private bool _isAntiBacterial;  //
		
		private int _HospitalID;  //

        public HustoresDays() { }
         
		/// <summary>
		/// 
		/// </summary>
		public DateTime StockTime
		{
			get { return _stockTime;}
			set { _stockTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string StockID
		{
			get { return _stockID;}
			set { _stockID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string unitid
		{
			get { return _unitid;}
			set { _unitid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CompId
		{
			get { return _compId;}
			set { _compId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double StockPrice
		{
			get { return _stockPrice;}
			set { _stockPrice = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double RetailPrice
		{
			get { return _retailPrice;}
			set { _retailPrice = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double StockNum
		{
			get { return _stockNum;}
			set { _stockNum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string IsBid
		{
			get { return _isBid;}
			set { _isBid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsInject
		{
			get { return _isInject;}
			set { _isInject = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool OptionPrice
		{
			get { return _optionPrice;}
			set { _optionPrice = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSpecSum
		{
			get { return _isSpecSum;}
			set { _isSpecSum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsAntiBacterial
		{
			get { return _isAntiBacterial;}
			set { _isAntiBacterial = value;}
		}                                    
		                                 
		        
	}  
}           


