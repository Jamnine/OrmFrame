

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库盘点明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuCheckDtl:BaseModel
	{    
		private string _billId;  //单据ID
		
		private string _inBatchId;  //药品批次ID
		
		private string _itemId;  //项目ID
		
		private string _compId;  //医药公司ID
		
		private string _unitId;  //单位ID
		
		private double _balanceNum;  //结存数量
		
		private double _stcokNum;  //库存数量
		
		private double _instoreNum;  //进货数量
		
		private double _checkNum;  //盘点数量
		
		private double _stockPrice;  //进货(买入)价
		
		private double _retailPrice;  //零售价
		
		private string _compare;  //盘盈或盘亏
		
		private bool _isBalance;  //是否结存
		
		private bool _isAdjust;  //是否已记账
		
		private double _buyIn;  //自购入库
		
		private double _backIn;  //药房退药
		
		private double _otherIn;  //其他入库
		
		private double _deptOut;  //药库发药
		
		private double _saleOut;  //其他出库
		
		private double _backOut;  //退药出库
		
		private double _loseOut;  //报损出库
		
		private double _adjustAmouUp;  //调价报益
		
		private double _adjustAmouDn;  //调价报损
		
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
		/// 药品批次ID
		/// </summary>
		public string InBatchId
		{
			get { return _inBatchId;}
			set { _inBatchId = value;}
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
		/// 医药公司ID
		/// </summary>
		public string CompId
		{
			get { return _compId;}
			set { _compId = value;}
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
		/// 结存数量
		/// </summary>
		public double BalanceNum
		{
			get { return _balanceNum;}
			set { _balanceNum = value;}
		}                                    
		
		/// <summary>
		/// 库存数量
		/// </summary>
		public double StcokNum
		{
			get { return _stcokNum;}
			set { _stcokNum = value;}
		}                                    
		
		/// <summary>
		/// 进货数量
		/// </summary>
		public double InstoreNum
		{
			get { return _instoreNum;}
			set { _instoreNum = value;}
		}                                    
		
		/// <summary>
		/// 盘点数量
		/// </summary>
		public double CheckNum
		{
			get { return _checkNum;}
			set { _checkNum = value;}
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
		/// 盘盈或盘亏
		/// </summary>
		public string Compare
		{
			get { return _compare;}
			set { _compare = value;}
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
		/// 是否已记账
		/// </summary>
		public bool IsAdjust
		{
			get { return _isAdjust;}
			set { _isAdjust = value;}
		}                                    
		
		/// <summary>
		/// 自购入库
		/// </summary>
		public double BuyIn
		{
			get { return _buyIn;}
			set { _buyIn = value;}
		}                                    
		
		/// <summary>
		/// 药房退药
		/// </summary>
		public double BackIn
		{
			get { return _backIn;}
			set { _backIn = value;}
		}                                    
		
		/// <summary>
		/// 其他入库
		/// </summary>
		public double OtherIn
		{
			get { return _otherIn;}
			set { _otherIn = value;}
		}                                    
		
		/// <summary>
		/// 药库发药
		/// </summary>
		public double DeptOut
		{
			get { return _deptOut;}
			set { _deptOut = value;}
		}                                    
		
		/// <summary>
		/// 其他出库
		/// </summary>
		public double SaleOut
		{
			get { return _saleOut;}
			set { _saleOut = value;}
		}                                    
		
		/// <summary>
		/// 退药出库
		/// </summary>
		public double BackOut
		{
			get { return _backOut;}
			set { _backOut = value;}
		}                                    
		
		/// <summary>
		/// 报损出库
		/// </summary>
		public double LoseOut
		{
			get { return _loseOut;}
			set { _loseOut = value;}
		}                                    
		
		/// <summary>
		/// 调价报益
		/// </summary>
		public double AdjustAmouUp
		{
			get { return _adjustAmouUp;}
			set { _adjustAmouUp = value;}
		}                                    
		
		/// <summary>
		/// 调价报损
		/// </summary>
		public double AdjustAmouDn
		{
			get { return _adjustAmouDn;}
			set { _adjustAmouDn = value;}
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


