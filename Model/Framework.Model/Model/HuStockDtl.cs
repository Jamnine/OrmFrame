

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库入库单明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuStockDtl:BaseModel
	{    
		private string _billId;  //单据Id

        private string _itemId = "";  //项目ID对应Bsitem.id
		
		private string _inBatchNo;  //入库流水号
		
		private string _pNo;  //批号
		
		private string _unitId;  //使用单位（小单位）
		
		private double _drugNum;  //数量
		
		private double _stockPrice;  //实价
		
		private double _retailPrice;  //零售价
		
		private DateTime _produceDate;  //生产日期
		
		private DateTime _limitDate;  //过期时间
		
		private bool _isBid;  //是否招标
		
		private string _voucherNo;  //发票号
		
		private string _proAreaId;  //产地
		
		private string _manuId;  //生产商
		
		private string _passNo;  //批准文号
		
		private double _priceHighLine;  //单价HighLine
		
		private string _qcMemo;  //质量情况
		
		private bool _isAuthed;  //已经封存，不可改删
		  
		/// <summary>
		/// 单据Id
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
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
		/// 入库流水号
		/// </summary>
		public string InBatchNo
		{
			get { return _inBatchNo;}
			set { _inBatchNo = value;}
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
		/// 使用单位（小单位）
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double DrugNum
		{
			get { return _drugNum;}
			set { _drugNum = value;}
		}                                    
		
		/// <summary>
		/// 实价
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
		/// 是否招标
		/// </summary>
		public bool IsBid
		{
			get { return _isBid;}
			set { _isBid = value;}
		}                                    
		
		/// <summary>
		/// 发票号
		/// </summary>
		public string VoucherNo
		{
			get { return _voucherNo;}
			set { _voucherNo = value;}
		}                                    
		
		/// <summary>
		/// 产地
		/// </summary>
		public string ProAreaId
		{
			get { return _proAreaId;}
			set { _proAreaId = value;}
		}                                    
		
		/// <summary>
		/// 生产商
		/// </summary>
		public string ManuId
		{
			get { return _manuId;}
			set { _manuId = value;}
		}                                    
		
		/// <summary>
		/// 批准文号
		/// </summary>
		public string PassNo
		{
			get { return _passNo;}
			set { _passNo = value;}
		}                                    
		
		/// <summary>
		/// 单价HighLine
		/// </summary>
		public double PriceHighLine
		{
			get { return _priceHighLine;}
			set { _priceHighLine = value;}
		}                                    
		
		/// <summary>
		/// 质量情况
		/// </summary>
		public string QcMemo
		{
			get { return _qcMemo;}
			set { _qcMemo = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}

        private string _reportNo;
        /// <summary>
        /// 行心云:报告书号
        /// </summary>
        public string ReportNo
        {
            get { return _reportNo; }
            set { _reportNo = value; }
        }

        private string _barCode = "";
        /// <summary>
        /// 行心云:条形码
        /// </summary>
        public string BarCode
        {
            get { return _barCode; }
            set { _barCode = value; }
        }

        private string _importUnit;
        /// <summary>
        /// 行心云:进口检验单位
        /// </summary>
        public string ImportUnit
        {
            get { return _importUnit; }
            set { _importUnit = value; }
        }

        private string _regNo;
        /// <summary>
        /// 行心云:注册证号
        /// </summary>
        public string RegNo
        {
            get { return _regNo; }
            set { _regNo = value; }
        }

        private string _makeiNarea;
        /// <summary>
        /// 行心云:生产地
        /// </summary>
        public string MakeiNarea
        {
            get { return _makeiNarea; }
            set { _makeiNarea = value; }
        }

        private int _HospitalID;
        /// <summary>
        /// 
        /// </summary>
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }
    }  
}           


