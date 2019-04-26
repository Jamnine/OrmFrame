

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房住院发药明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmZyOutDtl:BaseModel
	{   
		 
		private string _billId;  //单据Id
		
		private string _inBatchId;  //药房库存表Id，RmStores.id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _unitId;  //单位
		
		private double _drugNum;  //数量
		
		private double _backNum;  //退药数量
		
		private double _retailPrice;  //零售价
		
		private double _stockPrice;  //实价
		
		private string _reqItemId;  //对应病区申请单明细
		
		private string _recipeItemId;  //对应中药处方明细
		
		private double _beforeStockNum;  //操作前库存
		
		private double _afterStockNum;  //操作后库存
		
		private DateTime _confirmDate;  //发药时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RmZyOutDtl() { }
 
		/// <summary>
		/// 单据Id
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
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
		/// 退药数量
		/// </summary>
		public double BackNum
		{
			get { return _backNum;}
			set { _backNum = value;}
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
		/// 实价
		/// </summary>
		public double StockPrice
		{
			get { return _stockPrice;}
			set { _stockPrice = value;}
		}                                    
		
		/// <summary>
		/// 对应病区申请单明细
		/// </summary>
		public string ReqItemId
		{
			get { return _reqItemId;}
			set { _reqItemId = value;}
		}                                    
		
		/// <summary>
		/// 对应中药处方明细
		/// </summary>
		public string RecipeItemId
		{
			get { return _recipeItemId;}
			set { _recipeItemId = value;}
		}                                    
		
		/// <summary>
		/// 操作前库存
		/// </summary>
		public double BeforeStockNum
		{
			get { return _beforeStockNum;}
			set { _beforeStockNum = value;}
		}                                    
		
		/// <summary>
		/// 操作后库存
		/// </summary>
		public double AfterStockNum
		{
			get { return _afterStockNum;}
			set { _afterStockNum = value;}
		}                                    
		
		/// <summary>
		/// 发药时间
		/// </summary>
		public DateTime ConfirmDate
		{
			get { return _confirmDate;}
			set { _confirmDate = value;}
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


