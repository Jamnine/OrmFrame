

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库其他入库明细表 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuOtherInDtl:BaseModel
	{    
		private string _billId;  //单据ID
		
		private string _inBatchNo;  //流水号
		
		private string _itemId;  //项目ID
		
		private string _pNo;  //批号
		
		private string _unitId;  //单位ID
		
		private string _compId;  //医药公司ID
		
		private double _drugNum;  //库存单位数(大单位)
		
		private double _stockPrice;  //进货(买入)价
		
		private double _retailPrice;  //零售价
		
		private DateTime _storeDate;  //入库日期
		
		private DateTime _produceDate;  //生产日期
		
		private DateTime _limitDate;  //失期日期
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 单据ID
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
		}                                    
		
		/// <summary>
		/// 流水号
		/// </summary>
		public string InBatchNo
		{
			get { return _inBatchNo;}
			set { _inBatchNo = value;}
		}                                    
		
		/// <summary>
		/// 项目ID
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
		/// 单位ID
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
		public double DrugNum
		{
			get { return _drugNum;}
			set { _drugNum = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                                
		        
	}  
}           


