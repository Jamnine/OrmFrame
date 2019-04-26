

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库出库单明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuOutDtl:BaseModel
	{   
		 
		private string _billId;  //单据Id
		
		private string _inBatchId;  //批号Id,HuStores.id
		
		private string _itemId;  //项目ID
		
		private string _unitId;  //单位ID
		
		private double _drugNum;  //药品数量
		
		private double _retailPrice;  //零售价
		
		private double _stockPrice;  //进货(买入)价
		
		private double _outPrice;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private bool _isStockNum;  //行心云:区分从领药申请单调出是库存是否足够
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 单据Id
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
		}                                    
		
		/// <summary>
		/// 批号Id,HuStores.id
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
		/// 单位ID
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 药品数量
		/// </summary>
		public double DrugNum
		{
			get { return _drugNum;}
			set { _drugNum = value;}
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
		/// 
		/// </summary>
		public double OutPrice
		{
			get { return _outPrice;}
			set { _outPrice = value;}
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
		/// 行心云:区分从领药申请单调出是库存是否足够
		/// </summary>
		public bool IsStockNum
		{
			get { return _isStockNum;}
			set { _isStockNum = value;}
		}                                    
		                                  
		        
	}  
}           


