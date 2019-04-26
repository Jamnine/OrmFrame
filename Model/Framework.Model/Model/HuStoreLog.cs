

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库进出库日志 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuStoreLog:BaseModel
	{    
		private DateTime _happenTime;  //发生时间
		
		private string _houseId;  //药库ID
		
		private string _itemId;  //项目ID
		
		private string _inBatchId;  //药品批次ID
		
		private double _beforeStockNum;  //操作前该批次的库存数量
		
		private double _happenNum;  //发生数量
		
		private double _afterStockNum;  //操作后药品的库存数量
		
		private double _retailPrice;  //零售价
		
		private double _stockPrice;  //进货(买入)价
		
		private string _unitId;  //单位ID
		
		private string _billNo;  //单据号
		
		private int _lsActType;  //出入库类型
		
		private string _memo;  //备注
		
		private double _beforeStockNumSum;  //操作前库存总数
		
		private double _afterStockNumSum;  //操作后库存总数
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _barCode;  //行心云:条形码
		
		private int _HospitalID;  //

        private int _hisType;

        private DateTime _insertTime;

        private bool _isInBatchId = false;
        public bool u_IsInBatchId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(InBatchId))
                {
                    _isInBatchId = true;
                }
                return _isInBatchId;
            }
            set { _isInBatchId = value; }
        }
        public HuStoreLog() { }
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }

        /// <summary>
        /// HisType 产品类型：0 共享 1 His 2 行心云 3养老1 2 3表示某种系统独有
        /// </summary>
        public int  HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }

        /// <summary>
        /// 发生时间
        /// </summary>
        public DateTime HappenTime
		{
			get { return _happenTime;}
			set { _happenTime = value;}
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
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
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
		/// 操作前该批次的库存数量
		/// </summary>
		public double BeforeStockNum
		{
			get { return _beforeStockNum;}
			set { _beforeStockNum = value;}
		}                                    
		
		/// <summary>
		/// 发生数量
		/// </summary>
		public double HappenNum
		{
			get { return _happenNum;}
			set { _happenNum = value;}
		}                                    
		
		/// <summary>
		/// 操作后药品的库存数量
		/// </summary>
		public double AfterStockNum
		{
			get { return _afterStockNum;}
			set { _afterStockNum = value;}
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
		/// 进货(买入)价
		/// </summary>
		public double StockPrice
		{
			get { return _stockPrice;}
			set { _stockPrice = value;}
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
		/// 单据号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 出入库类型
		/// </summary>
		public int LsActType
		{
			get { return _lsActType;}
			set { _lsActType = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 操作前库存总数
		/// </summary>
		public double BeforeStockNumSum
		{
			get { return _beforeStockNumSum;}
			set { _beforeStockNumSum = value;}
		}                                    
		
		/// <summary>
		/// 操作后库存总数
		/// </summary>
		public double AfterStockNumSum
		{
			get { return _afterStockNumSum;}
			set { _afterStockNumSum = value;}
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
		                                   
		        
	}  
}           


