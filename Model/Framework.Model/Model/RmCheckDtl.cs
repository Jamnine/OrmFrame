

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房盘点明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmCheckDtl : BaseModel
    {   
		
		
		
		private string _checkId;  //检查ID
		
		private string _inBatchId;  //药房库存表Id，RmStores.id
		
		private string _itemId;  //项目ID
		
		private string _compId;  //供应公司
		
		private string _unitId;  //单位
		
		private double _balanceNum;  //上次数量
		
		private double _stockNum;  //库存数量
		
		private double _instoreNum;  //进货数量
		
		private double _checkNum;  //盘点数量
		
		private string _operId;  //操作人ID
		
		private double _stockPrice;  //进货(买入)价
		
		private double _retailPrice;  //零售价
		
		private string _compare;  //盘盈或盘亏
		
		private bool _balance;  //是否结存
		
		private bool _isAdjust;  //是否已记账
		
		private double _applyIn;  //申请入库
		
		private double _mzBackIn;  //门诊退回
		
		private double _zyBackIn;  //住院退回
		
		private double _moveIn;  //调拨入库
		
		private double _otherIn;  //其他入库
		
		private double _moveOut;  //调拨出库
		
		private double _mzOut;  //门诊发出
		
		private double _zyOut;  //住院发出
		
		private double _loseOut;  //报损出库
		
		private double _backOut;  //退药出库其他出库
		
		private double _otherOut;  //其他出库
		
		private double _adjustAmouUp;  //调价报益调价报损
		
		private double _adjustAmouDn;  //调价报损科室领药
		
		private double _recipeOut;  //科室领药
		
		private double _ksBackIn;  //科室退药
		
		private double _ksOut;  //科室出药
		
		private double _huStockNum;  //药库库存数量,转换药库单位后的数量
		
		private int _unitKc;  //药库单位
		
		private double _huCheckNum;  //盘点药库数量,转换药库单位后的数量
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RmCheckDtl() { }
                          
		
		/// <summary>
		/// 检查ID
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
		}                                    
		
		/// <summary>
		/// 药房库存表Id，RmStores.id
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
		/// 供应公司
		/// </summary>
		public string CompId
		{
			get { return _compId;}
			set { _compId = value;}
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
		/// 上次数量
		/// </summary>
		public double BalanceNum
		{
			get { return _balanceNum;}
			set { _balanceNum = value;}
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
		/// 操作人ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		public bool balance
		{
			get { return _balance;}
			set { _balance = value;}
		}                                    
		
		/// <summary>
		/// 是否已记账
		/// </summary>
		public bool isAdjust
		{
			get { return _isAdjust;}
			set { _isAdjust = value;}
		}                                    
		
		/// <summary>
		/// 申请入库
		/// </summary>
		public double ApplyIn
		{
			get { return _applyIn;}
			set { _applyIn = value;}
		}                                    
		
		/// <summary>
		/// 门诊退回
		/// </summary>
		public double MzBackIn
		{
			get { return _mzBackIn;}
			set { _mzBackIn = value;}
		}                                    
		
		/// <summary>
		/// 住院退回
		/// </summary>
		public double ZyBackIn
		{
			get { return _zyBackIn;}
			set { _zyBackIn = value;}
		}                                    
		
		/// <summary>
		/// 调拨入库
		/// </summary>
		public double MoveIn
		{
			get { return _moveIn;}
			set { _moveIn = value;}
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
		/// 调拨出库
		/// </summary>
		public double MoveOut
		{
			get { return _moveOut;}
			set { _moveOut = value;}
		}                                    
		
		/// <summary>
		/// 门诊发出
		/// </summary>
		public double MzOut
		{
			get { return _mzOut;}
			set { _mzOut = value;}
		}                                    
		
		/// <summary>
		/// 住院发出
		/// </summary>
		public double ZyOut
		{
			get { return _zyOut;}
			set { _zyOut = value;}
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
		/// 退药出库其他出库
		/// </summary>
		public double BackOut
		{
			get { return _backOut;}
			set { _backOut = value;}
		}                                    
		
		/// <summary>
		/// 其他出库
		/// </summary>
		public double OtherOut
		{
			get { return _otherOut;}
			set { _otherOut = value;}
		}                                    
		
		/// <summary>
		/// 调价报益调价报损
		/// </summary>
		public double AdjustAmouUp
		{
			get { return _adjustAmouUp;}
			set { _adjustAmouUp = value;}
		}                                    
		
		/// <summary>
		/// 调价报损科室领药
		/// </summary>
		public double AdjustAmouDn
		{
			get { return _adjustAmouDn;}
			set { _adjustAmouDn = value;}
		}                                    
		
		/// <summary>
		/// 科室领药
		/// </summary>
		public double RecipeOut
		{
			get { return _recipeOut;}
			set { _recipeOut = value;}
		}                                    
		
		/// <summary>
		/// 科室退药
		/// </summary>
		public double KsBackIn
		{
			get { return _ksBackIn;}
			set { _ksBackIn = value;}
		}                                    
		
		/// <summary>
		/// 科室出药
		/// </summary>
		public double KsOut
		{
			get { return _ksOut;}
			set { _ksOut = value;}
		}                                    
		
		/// <summary>
		/// 药库库存数量,转换药库单位后的数量
		/// </summary>
		public double HuStockNum
		{
			get { return _huStockNum;}
			set { _huStockNum = value;}
		}                                    
		
		/// <summary>
		/// 药库单位
		/// </summary>
		public int UnitKc
		{
			get { return _unitKc;}
			set { _unitKc = value;}
		}                                    
		
		/// <summary>
		/// 盘点药库数量,转换药库单位后的数量
		/// </summary>
		public double HuCheckNum
		{
			get { return _huCheckNum;}
			set { _huCheckNum = value;}
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
		/// 医院ID
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


