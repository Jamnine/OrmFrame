

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房出入日志明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmStoreLog : BaseModel
    {   
		
		
		
		private DateTime _happenTime;  //发生时间
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _inBatchId;  //药房库存表Id，RmStores.id
		
		private double _beforeStockNum;  //操作前数量
		
		private double _happenNum;  //发生数量
		
		private double _stockPrice;  //药库买入价
		
		private double _retailPrice;  //零售价
		
		private string _unitId;  //单位
		
		private string _billNo;  //单据流水号
		
		private int _lsActType;  //1:其它入房2:调拨出房3:退药出房4:报损出房5:其它出房6:盘盈入房7:盘亏出房8:科室领药9:科室退药10:病区发药11:门诊发药12:病区退药13:门诊退药14:药品入房15:调拨入房
		
		private string _memo;  //备注
		
		private double _afterStockNum;  //操作后药品的库存数量
		
		private double _beforeStockTotalNum;  //操作前总库存
		
		private double _afterStockTotalNum;  //操作后总库存
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _inOuPatId;  //对应病人Id.Inhosinfo.id或者ouhosinfo.id如果不是临床发药则为
		
		private string _outDtlId;  //申请单据明细Id，药房所有业务操作表明细ID
		
		private double _price;  //单价
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
        public RmStoreLog() { }

                              
		
		/// <summary>
		/// 发生时间
		/// </summary>
		public DateTime HappenTime
		{
			get { return _happenTime;}
			set { _happenTime = value;}
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
		/// 药房库存表Id，RmStores.id
		/// </summary>
		public string InBatchId
		{
			get { return _inBatchId;}
			set { _inBatchId = value;}
		}                                    
		
		/// <summary>
		/// 操作前数量
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
		/// 单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 单据流水号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 1:其它入房2:调拨出房3:退药出房4:报损出房5:其它出房6:盘盈入房7:盘亏出房8:科室领药9:科室退药10:病区发药11:门诊发药12:病区退药13:门诊退药14:药品入房15:调拨入房
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
		/// 操作后药品的库存数量
		/// </summary>
		public double AfterStockNum
		{
			get { return _afterStockNum;}
			set { _afterStockNum = value;}
		}                                    
		
		/// <summary>
		/// 操作前总库存
		/// </summary>
		public double BeforeStockTotalNum
		{
			get { return _beforeStockTotalNum;}
			set { _beforeStockTotalNum = value;}
		}                                    
		
		/// <summary>
		/// 操作后总库存
		/// </summary>
		public double AfterStockTotalNum
		{
			get { return _afterStockTotalNum;}
			set { _afterStockTotalNum = value;}
		}                                    
		
		/// <summary>
		/// 科室ID,BsLocation.Id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 对应病人Id.Inhosinfo.id或者ouhosinfo.id如果不是临床发药则为
		/// </summary>
		public string InOuPatId
		{
			get { return _inOuPatId;}
			set { _inOuPatId = value;}
		}                                    
		
		/// <summary>
		/// 申请单据明细Id，药房所有业务操作表明细ID
		/// </summary>
		public string OutDtlId
		{
			get { return _outDtlId;}
			set { _outDtlId = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
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
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


