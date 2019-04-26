

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库药品库存表 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuStores:BaseModel
	{   
		 
		private string _inBatchNo;  //流水号
		
		private string _houseId;  //药库ID
		
		private string _itemId;  //药品ID
		
		private string _pNo;  //批号
		
		private string _unitId;  //入库单位（大单位）
		
		private string _compId;  //医药公司ID
		
		private double _stockNum;  //库存单位数(大单位)
		
		private double _instoreNum;  //入库数量
		
		private double _stockPrice;  //进货(买入)价
		
		private double _retailPrice;  //零售价
		
		private DateTime _storeDate;  //入库日期
		
		private DateTime _produceDate;  //生产日期
		
		private DateTime _limitDate;  //失期日期
		
		private bool _isBalance;  //结存
		
		private bool _isNewin;  //是否新入库
		
		private bool _isBid;  //是否招标
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _barCode;  //行心云:条形码
		
		private string _proareaId;  //行心云:外键与项目库存预警表（BsitemDrug.ProAreaId产地关联）
		
		private string _manuId;  //行心云: 外键与制造商.BsManufacture.id关联
		
		private int _HospitalID;  //

        public HuStores() { }
         
		/// <summary>
		/// 流水号
		/// </summary>
		public string InBatchNo
		{
			get { return _inBatchNo;}
			set { _inBatchNo = value;}
		}                                    
		
		/// <summary>
		/// 药库ID
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 药品ID
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
		/// 入库单位（大单位）
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 医药公司ID
		/// </summary>
		public string CompId
		{
			get { return _compId;}
			set { _compId = value;}
		}                                    
		
		/// <summary>
		/// 库存单位数(大单位)
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
		/// 进货(买入)价
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
		/// 失期日期
		/// </summary>
		public DateTime LimitDate
		{
			get { return _limitDate;}
			set { _limitDate = value;}
		}                                    
		
		/// <summary>
		/// 结存
		/// </summary>
		public bool IsBalance
		{
			get { return _isBalance;}
			set { _isBalance = value;}
		}                                    
		
		/// <summary>
		/// 是否新入库
		/// </summary>
		public bool IsNewin
		{
			get { return _isNewin;}
			set { _isNewin = value;}
		}                                    
		
		/// <summary>
		/// 是否招标
		/// </summary>
		public bool IsBid
		{
			get { return _isBid;}
			set { _isBid = value;}
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
		/// 行心云:条形码
		/// </summary>
		public string BarCode
		{
			get { return _barCode;}
			set { _barCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:外键与项目库存预警表（BsitemDrug.ProAreaId产地关联）
		/// </summary>
		public string ProareaId
		{
			get { return _proareaId;}
			set { _proareaId = value;}
		}                                    
		
		/// <summary>
		/// 行心云: 外键与制造商.BsManufacture.id关联
		/// </summary>
		public string ManuId
		{
			get { return _manuId;}
			set { _manuId = value;}
		}                                    
		                                  
		        
	}  
}           


