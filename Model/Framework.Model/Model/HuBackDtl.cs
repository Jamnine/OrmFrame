

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库退库明细表 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuBackDtl:BaseModel
	{    
		private string _billId;  //单据ID
		
		private string _inBatchId;  //批号Id,HuStores.id
		
		private string _itemId;  //项目ID
		
		private string _unitId;  //单位ID
		
		private double _drugNum;  //药品数量
		
		private double _retailPrice;  //零售价
		
		private double _stockPrice;  //进货(买入)价
		
		private string _memo;  //备注
		
		private string _voucherNo;  //发票号
		
		private bool _isMargin;  //补差价退货
		
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
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
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
		/// 补差价退货
		/// </summary>
		public bool IsMargin
		{
			get { return _isMargin;}
			set { _isMargin = value;}
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


