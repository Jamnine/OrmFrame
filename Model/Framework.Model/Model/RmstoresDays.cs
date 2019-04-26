

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房库存每天情况表 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmstoresDays : BaseModel
    {   
		 
		private DateTime _stockTime;  //入库时间
		
		private string _stockID;  //库存Id,RmStores.id
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _unitid;  //单位
		
		private string _compId;  //供应公司
		
		private double _stockPrice;  //药库买入价
		
		private double _retailPrice;  //零售价
		
		private double _stockNum;  //库存数量
		
		private string _isBid;  //招标药品
		
		private bool _isInject;  //是否注射剂
		
		private bool _optionPrice;  //是否国基
		
		private bool _isSpecSum;  //是否省基础
		
		private bool _isAntiBacterial;  //是否抗菌药
		
		private int _HospitalID;  //

        public RmstoresDays() { }

                                
		
		/// <summary>
		/// 入库时间
		/// </summary>
		public DateTime StockTime
		{
			get { return _stockTime;}
			set { _stockTime = value;}
		}                                    
		
		/// <summary>
		/// 库存Id,RmStores.id
		/// </summary>
		public string StockID
		{
			get { return _stockID;}
			set { _stockID = value;}
		}                                    
		
		/// <summary>
		/// 药房ID,BsRoom.Id
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string unitid
		{
			get { return _unitid;}
			set { _unitid = value;}
		}                                    
		
		/// <summary>
		/// 供应公司
		/// </summary>
		public string CompId
		{
			get { return _compId;}
			set { _compId = value;}
		}                                    
		
		/// <summary>
		/// 药库买入价
		/// </summary>
		public double StockPrice
		{
			get { return _stockPrice;}
			set { _stockPrice = value;}
		}                                    
		
		/// <summary>
		/// 零售价
		/// </summary>
		public double RetailPrice
		{
			get { return _retailPrice;}
			set { _retailPrice = value;}
		}                                    
		
		/// <summary>
		/// 库存数量
		/// </summary>
		public double StockNum
		{
			get { return _stockNum;}
			set { _stockNum = value;}
		}                                    
		
		/// <summary>
		/// 招标药品
		/// </summary>
		public string IsBid
		{
			get { return _isBid;}
			set { _isBid = value;}
		}                                    
		
		/// <summary>
		/// 是否注射剂
		/// </summary>
		public bool IsInject
		{
			get { return _isInject;}
			set { _isInject = value;}
		}                                    
		
		/// <summary>
		/// 是否国基
		/// </summary>
		public bool OptionPrice
		{
			get { return _optionPrice;}
			set { _optionPrice = value;}
		}                                    
		
		/// <summary>
		/// 是否省基础
		/// </summary>
		public bool IsSpecSum
		{
			get { return _isSpecSum;}
			set { _isSpecSum = value;}
		}                                    
		
		/// <summary>
		/// 是否抗菌药
		/// </summary>
		public bool IsAntiBacterial
		{
			get { return _isAntiBacterial;}
			set { _isAntiBacterial = value;}
		}                                    
		
		/// <summary>
		/// 医院ID
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


