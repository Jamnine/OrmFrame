

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房库存明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class Rmstores : BaseModel
	{   
		
		
		
		private string _inBatchNo;  //入库流水号
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _pNo;  //批号
		
		private string _unitId;  //单位
		
		private string _compId;  //供应公司
		
		private double _stockPrice;  //药库买入价
		
		private double _retailPrice;  //零售价
		
		private double _stockNum;  //库存数量
		
		private double _instoreNum;  //入库数量
		
		private DateTime _storeDate;  //入库日期
		
		private DateTime _produceDate;  //生产日期
		
		private DateTime _limitDate;  //过期时间
		
		private bool _isBalance;  //是否结存
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _huStoresId;  //药库库存Id
		
		private int _HospitalID;  //
        

        private int _hisType;

        private DateTime _insertTime;

        public Rmstores() { }

        private bool _isStockNum = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsStockNum
        {
            get
            {
                if (StockNum < 0)
                {
                    _isStockNum = true;
                }
                return _isStockNum;
            }
            set { _isStockNum = value; }
        }

        /// <summary>
        /// 入库流水号
        /// </summary>
        public string InBatchNo
		{
			get { return _inBatchNo;}
			set { _inBatchNo = value;}
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
		/// 批号
		/// </summary>
		public string PNo
		{
			get { return _pNo;}
			set { _pNo = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
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
		/// 入库数量
		/// </summary>
		public double InstoreNum
		{
			get { return _instoreNum;}
			set { _instoreNum = value;}
		}                                    
		
		/// <summary>
		/// 入库日期
		/// </summary>
		public DateTime StoreDate
		{
			get { return _storeDate;}
			set { _storeDate = value;}
		}                                    
		
		/// <summary>
		/// 生产日期
		/// </summary>
		public DateTime ProduceDate
		{
			get { return _produceDate;}
			set { _produceDate = value;}
		}                                    
		
		/// <summary>
		/// 过期时间
		/// </summary>
		public DateTime LimitDate
		{
			get { return _limitDate;}
			set { _limitDate = value;}
		}                                    
		
		/// <summary>
		/// 是否结存
		/// </summary>
		public bool IsBalance
		{
			get { return _isBalance;}
			set { _isBalance = value;}
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
		/// 药库库存Id
		/// </summary>
		public string HuStoresId
		{
			get { return _huStoresId;}
			set { _huStoresId = value;}
		}                                    
		
	                                  
		    
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }   
        
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        } 
	}  
}           


